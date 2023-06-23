using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API acknowledge params.
/// </summary>
public class AcknowledgeParams : FunctionParams
{
    /// <summary>
    /// The thermostat identifier to acknowledge the alert for.
    /// </summary>
    [JsonPropertyName("thermostatIdentifier")]
    public string ThermostatIdentifier { get; set; }

    /// <summary>
    /// The acknowledge ref of alert.
    /// </summary>
    [JsonPropertyName("ackRef")]
    public string AckRef { get; set; }

    /// <summary>
    /// The type of acknowledgement. Valid values: accept, decline, defer, unacknowledged.
    /// </summary>
    [JsonPropertyName("ackType")]
    public string AckType { get; set; }

    /// <summary>
    /// Whether to remind at a later date, if this is a defer acknowledgement.
    /// </summary>
    [JsonPropertyName("remindMeLater")]
    public bool? RemindMeLater { get; set; }
}