#!/bin/bash

set -e  # Exit on error

# Function to check if a directory contains TSP files
has_tsp_files() {
    local dir=$1
    find "$dir" -name "*.tsp" -type f | grep -q .
}

# Function to build a TSP project
build_tsp_project() {
    local dir=$1
    local target=$2
    echo "Building TSP project in $dir with target $target"
    pushd "$dir"
    npm ci
    if ! tsp compile "$target"; then
        echo "Error: Failed to compile $target"
        popd
        return 1
    fi
    popd
}

# Make git diff more CI-friendly
CHANGED_FILES=$(git diff --name-only ${CI_PREVIOUS_COMMIT:-HEAD~1} ${CI_COMMIT_SHA:-HEAD})

# Check for changes in OpenAI base spec
OPENAI_CHANGES=false
AZURE_CHANGES=false

for file in $CHANGED_FILES; do
    if [[ "$file" == "openai-in-typespec/typespec/"* ]] || [[ "$file" == "openai-in-typespec/entrypoints/full.openai/"* ]]; then
        OPENAI_CHANGES=true
    elif [[ "$file" == "openai-in-typespec/typespec.azure/"* ]] || [[ "$file" == "openai-in-typespec/entrypoints/full.openai.azure/"* ]]; then
        AZURE_CHANGES=true
    fi
done

# Build projects based on detected changes
if [ "$OPENAI_CHANGES" = true ]; then
    echo "Changes detected in OpenAI base spec"
    build_tsp_project "openai-in-typespec" "entrypoints/full.openai"
else
    echo "No changes detected in OpenAI base spec - skipping build"
fi

if [ "$AZURE_CHANGES" = true ]; then
    echo "Changes detected in Azure spec"
    build_tsp_project "openai-in-typespec" "entrypoints/full.openai.azure"
else
    echo "No changes detected in Azure spec - skipping build"
fi