using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using I8Beef.Ecobee.Messages;
using I8Beef.Ecobee.Protocol;
using I8Beef.Ecobee.Protocol.Functions;
using I8Beef.Ecobee.Protocol.Objects;
using I8Beef.Ecobee.Protocol.Thermostat;

namespace I8Beef.Ecobee.Serializers;

/// <summary>
/// 
/// </summary>
// [JsonSourceGenerationOptions(
//     WriteIndented = false,
//     PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
//     GenerationMode = JsonSourceGenerationMode.Serialization)]
[JsonSerializable(typeof(Response))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(DateTime))]

[JsonSerializable(typeof(ApiError))]
[JsonSerializable(typeof(ThermostatRequest))]
[JsonSerializable(typeof(ThermostatResponse))]
[JsonSerializable(typeof(ThermostatSummaryRequest))]
[JsonSerializable(typeof(ThermostatSummaryResponse))]
[JsonSerializable(typeof(AuthToken))]
[JsonSerializable(typeof(ThermostatUpdateRequest))]
[JsonSerializable(typeof(Pin))]
[JsonSerializable(typeof(Type))]
[JsonSerializable(typeof(RequestBase))]
[JsonSerializable(typeof(PagedRequestBase))]
[JsonSerializable(typeof(PagedResponse))]
[JsonSerializable(typeof(Function))]
[JsonSerializable(typeof(SetHoldFunction))]
[JsonSerializable(typeof(SetHoldParams))]
[JsonSerializable(typeof(FunctionParams))]
public partial class SourceGenerationContext : JsonSerializerContext
{
    
}