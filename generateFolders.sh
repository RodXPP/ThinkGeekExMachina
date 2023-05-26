#!/bin/bash

# Define the array of languages
languages=("c" "cpp" "c#" "python" "golang")

# Iterate over each language
for language in "${languages[@]}"; do
    mkdir -p "${language}"
done

