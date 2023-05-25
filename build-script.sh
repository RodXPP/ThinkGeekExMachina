#!/bin/bash

# Exit as soon as any command fails
set -e

# Iterate over every subdirectory of every language directory
for project in */*; do
  echo "Building project $project..."

  # Determine the language based on the parent directory
  language=$(dirname "$project")

  # Build the project based on the language
  case "$language" in
    c)
      files=("$project/src/"*.c)
      [[ -e "${files[0]}" ]] && gcc -o "$project/out" "${files[@]}" ;;
    c++)
      files=("$project/src/"*.cpp)
      [[ -e "${files[0]}" ]] && g++ -o "$project/out" "${files[@]}" ;;
    c#)
      [[ -d "$project/src" ]] && dotnet build "$project/src" ;;
    python)
      files=("$project/src/"*.py)
      [[ -e "${files[0]}" ]] && for file in "${files[@]}"; do python -m py_compile "$file"; python "$file"; done ;;
    golang)
      files=("$project/src/"*.go)
      [[ -e "${files[0]}" ]] && go build -v -o "$project/out" "${files[@]}" ;;
    *)
      echo "Unknown language: $language"
      exit 1 ;;
  esac
done
