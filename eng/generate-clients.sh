#!/usr/bin/env bash
set -euo pipefail

repo_dir=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
generated_dir="$repo_dir/src/Greenflux.Sdk/Generated"
working_dir=$(mktemp -d)
trap 'rm -rf -- "$working_dir"' EXIT

normalize() {
  local input=$1
  local output=$2
  jq --slurpfile operationIds "$repo_dir/eng/operation-ids.json" \
    -f "$repo_dir/eng/normalize-openapi.jq" "$input" > "$output"
}

generate() {
  local input=$1
  local output=$2
  local namespace=$3
  local class_name=$4
  local exception_name=$5

  dotnet nswag openapi2csclient \
    "/input:$input" \
    "/output:$output" \
    "/namespace:$namespace" \
    "/classname:$class_name" \
    "/ExceptionClass:$exception_name" \
    /GenerateClientInterfaces:true \
    /InjectHttpClient:true \
    /DisposeHttpClient:false \
    /UseBaseUrl:false \
    /GenerateOptionalParameters:true \
    /GenerateNullableReferenceTypes:true \
    /GenerateOptionalPropertiesAsNullable:true \
    /UseRequiredKeyword:false \
    /JsonLibrary:NewtonsoftJson \
    /GenerateJsonMethods:false \
    /GenerateDataAnnotations:false \
    /OperationGenerationMode:SingleClientFromOperationId \
    /NewLineBehavior:LF
}

mkdir -p "$generated_dir"
normalize "$repo_dir/openapi/greenflux-service.json" "$working_dir/greenflux-service.json"
normalize "$repo_dir/openapi/charge-location-management.json" "$working_dir/charge-location-management.json"
normalize "$repo_dir/openapi/remote-commands.json" "$working_dir/remote-commands.json"
normalize "$repo_dir/openapi/charge-assist.json" "$working_dir/charge-assist.json"

generate "$working_dir/greenflux-service.json" "$generated_dir/GreenfluxPlatformClient.g.cs" Greenflux.Platform GreenfluxPlatformClient GreenfluxPlatformApiException
generate "$working_dir/charge-location-management.json" "$generated_dir/ChargeLocationManagementClient.g.cs" Greenflux.ChargeLocations ChargeLocationManagementClient ChargeLocationManagementApiException
generate "$working_dir/remote-commands.json" "$generated_dir/RemoteCommandsClient.g.cs" Greenflux.RemoteCommands RemoteCommandsClient RemoteCommandsApiException
generate "$working_dir/charge-assist.json" "$generated_dir/ChargeAssistClient.g.cs" Greenflux.ChargeAssist ChargeAssistClient ChargeAssistApiException
