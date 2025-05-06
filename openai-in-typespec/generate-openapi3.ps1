
$entrypoints = @(
    "full.openai",
    "full.openai.azure",
    "responses",
    "responses.azure",
    "responses.azure.json"
)

foreach ($entrypoint in $entrypoints) {
    $entrypointPath = Join-Path $PSScriptRoot "entrypoints" $entrypoint
    Write-Host "Compiling OpenAPI spec for entrypoint: $entrypoint"
    & npx tsp compile $entrypointPath
}