using I8Beef.Ecobee.Protocol.Functions;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API function base class.
/// </summary>
[JsonDerivedType(typeof(AcknowledgeFunction))]
[JsonDerivedType(typeof(ControlPlugFunction))]
[JsonDerivedType(typeof(CreateVacationFunction))]
[JsonDerivedType(typeof(DeleteVacationFunction))]
[JsonDerivedType(typeof(ResetPreferencesFunction))]
[JsonDerivedType(typeof(ResumeProgramFunction))]
[JsonDerivedType(typeof(SendMessageFunction))]
[JsonDerivedType(typeof(SetHoldFunction))]
[JsonDerivedType(typeof(SetOccupiedFunction))]
[JsonDerivedType(typeof(UpdateSensorFunction))]
[JsonDerivedType(typeof(UnlinkVoiceEngineFunction))]

    
    
public abstract class Function
{
    /// <summary>
    /// The function type name. See the type name in the function documentation.
    /// </summary>
    [JsonPropertyName("type")]
    public abstract string Type { get; set; }

    /// <summary>
    /// A map of key=value pairs as the parameters to the function. See
    /// individual function documentation for the properties.
    /// </summary>
    [JsonPropertyName("params")]
    public abstract FunctionParams Params { get; set; }
}