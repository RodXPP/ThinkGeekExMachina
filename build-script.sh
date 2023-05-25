#!/bin/bash

# Exit if any command fails
set -e

# Iterate over every subdirectory of every language directory
for project in */*; do
  echo "Building project $project..."

  # Determine the language based on the parent directory
  language=$(dirname "$project")

  # Build the project based on the language
  case "$language" in
    c) gcc -o "$project/out" "$project/src/"*.c ;;
    cpp) g++ -o "$project/out" "$project/src/"*.cpp ;;
    c#) dotnet build "$project/src" ;;
    python) 
      for file in "$project/src/"*.py
      	do
	  python -m py_compile $file
	  python $file
	done
      ;;
    golang) go build -v -o "$project/out" "$project/src/"*.go ;;
    *) echo "Unknown language: $language" ; exit 1 ;;
  esac
done

