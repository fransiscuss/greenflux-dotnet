def response_envelope($dataSchema):
  {
    "type": "object",
    "properties": {
      "data": $dataSchema,
      "status_code": {"$ref": "#/components/schemas/OcpiStatusCode"},
      "status_message": {"type": "string", "nullable": true},
      "timestamp": {"type": "string", "format": "date-time"}
    }
  };

($operationIds[0]) as $ids
| .paths |= with_entries(
    .key as $path
    | .value |= with_entries(
        if (.key == "get" or .key == "post" or .key == "put" or .key == "patch" or .key == "delete") then
          ((.key | ascii_upcase) + " " + $path) as $lookup
          | if $ids[$lookup] then .value.operationId = $ids[$lookup] else . end
        else
          .
        end
      )
  )
| if .info.title == "Charge Location Management APIs" then
    .components.schemas.GcpiChargeStationListResponse = response_envelope({"type": "array", "items": {"$ref": "#/components/schemas/GcpiChargeStation"}})
    | .components.schemas.GcpiChargeStationResponse = response_envelope({"$ref": "#/components/schemas/GcpiChargeStation"})
    # The official examples conflict: successful data is an object, while a
    # documented HTTP-200 business-error response uses an array. Keep the raw
    # union value so both valid wire shapes remain readable.
    | .components.schemas.GcpiChargeStationCreateResponse = response_envelope({})
    | .components.schemas.GcpiLocationListResponse = response_envelope({"type": "array", "items": {"$ref": "#/components/schemas/GcpiLocation"}})
    | .components.schemas.GcpiLocationResponse = response_envelope({"$ref": "#/components/schemas/GcpiLocation"})
    | .paths["/api/{versionNumber}/ChargeStations"].get.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiChargeStationListResponse"}
    | .paths["/api/{versionNumber}/ChargeStations"].post.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiChargeStationCreateResponse"}
    | .paths["/api/{versionNumber}/ChargeStations/{chargeStationId}"].get.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiChargeStationResponse"}
    | .paths["/api/{versionNumber}/ChargeStations/{chargeStationId}"].put.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiChargeStationResponse"}
    | .paths["/api/{versionNumber}/ChargeStations/{chargeStationId}"].patch.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiChargeStationResponse"}
    | .paths["/api/{versionNumber}/Locations"].get.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiLocationListResponse"}
    | .paths["/api/{versionNumber}/Locations"].post.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiLocationResponse"}
    | .paths["/api/{versionNumber}/Locations/{locationId}"].get.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiLocationResponse"}
    | .paths["/api/{versionNumber}/Locations/{locationId}"].put.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiLocationResponse"}
    | .paths["/api/{versionNumber}/Locations/{locationId}"].patch.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiLocationResponse"}
    | .paths["/api/{versionNumber}/CpoCustomers"].post.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiCpoCustomerResponse"}
    | .paths["/api/{versionNumber}/CpoCustomers/{cpoId}/{externalId}"].get.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiCpoCustomerResponse"}
    | .paths["/api/{versionNumber}/CpoCustomers/{cpoId}/{externalId}"].put.responses["200"].content["application/json"].schema = {"$ref": "#/components/schemas/GcpiCpoCustomerResponse"}
  elif .info.title == "RemoteCommandsAPi" then
    .paths |= with_entries(.value |= with_entries(if .key == "post" then .value.requestBody.required = true else . end))
    | .components.schemas.GcpiStartSession.required = ["token", "chargestation_id", "evse_uid", "location_id"]
    | .components.schemas.GcpiStartSession.properties.chargestation_id.nullable = false
    | .components.schemas.GcpiStartSession.properties.evse_uid.nullable = false
    | .components.schemas.GcpiStartSession.properties.location_id.nullable = false
    | .components.schemas.GcpiInstallCertificate.required = ["charge_station_id", "certificateType", "certificate"]
  elif .info.title == "Charge Assist" then
    .components.schemas.ChargeAssistSessionStatus = {
      "type": "string",
      "enum": ["REQUESTED", "REJECTED", "STARTING", "CHARGING", "STOPPING", "COMPLETED", "CDR_AVAILABLE", "PARKING", "TIMEOUT", "CANCELLED", "ERROR"]
    }
    | .components.schemas.ChargeAssistConnectorType = {
      "type": "string",
      "enum": ["CHADEMO", "DOMESTIC_A", "DOMESTIC_B", "DOMESTIC_C", "DOMESTIC_D", "DOMESTIC_E", "DOMESTIC_F", "DOMESTIC_G", "DOMESTIC_H", "DOMESTIC_I", "DOMESTIC_J", "DOMESTIC_K", "DOMESTIC_L", "IEC_60309_2_single_16", "IEC_60309_2_three_16", "IEC_60309_2_three_32", "IEC_60309_2_three_64", "IEC_62196_T1", "IEC_62196_T1_COMBO", "IEC_62196_T2", "IEC_62196_T2_COMBO", "IEC_62196_T3A", "IEC_62196_T3C", "TESLA_R", "TESLA_S", "PANTOGRAPH_BOTTOM_UP", "PANTOGRAPH_TOP_DOWN"]
    }
    | .components.schemas.ChargeAssistPowerType = {"type": "string", "enum": ["AC", "DC"]}
    | .components.schemas.ChargeAssistPaymentMethodType = {"type": "string", "enum": ["CHARGE_CARD", "OTHER"]}
    | .paths["/favorites/{appToken}/location/{id}"].post.responses["204"] |= del(.content)
    | .paths["/favorites/{appToken}/location/{id}"].delete.responses["204"] |= del(.content)
    | .paths["/v2.1/favorites/{appToken}/location/{id}"].post.responses["204"] |= del(.content)
    | .paths["/v2.1/favorites/{appToken}/location/{id}"].delete.responses["204"] |= del(.content)
    | .paths["/payment/{appToken}/{id}"].delete.responses["204"] |= del(.content)
    | walk(
        if type == "object" and .name? == "filter.sessionStatus" then
          .schema.items = {"$ref": "#/components/schemas/ChargeAssistSessionStatus"}
        elif type == "object" and .name? == "filter.connectorTypes" then
          .schema.items = {"$ref": "#/components/schemas/ChargeAssistConnectorType"}
        elif type == "object" and .name? == "filter.connectorType" then
          .schema = {"$ref": "#/components/schemas/ChargeAssistConnectorType"}
        elif type == "object" and .name? == "filter.powerType" then
          .schema = {"$ref": "#/components/schemas/ChargeAssistPowerType"}
        elif type == "object" and .name? == "filter.paymentMethodType" then
          .schema = {"$ref": "#/components/schemas/ChargeAssistPaymentMethodType"}
        else
          .
        end
      )
  else
    .
  end
