using System;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat;

/// <summary>
/// Ecobee API thermostat summary request.
/// </summary>
public class ThermostatSummaryRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/thermostatSummary";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.GET;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(ThermostatSummaryResponse);

    /// <summary>
    /// The selection criteria for update.
    /// </summary>
    [JsonPropertyName("selection")]
    public Selection Selection { get; set; }
}