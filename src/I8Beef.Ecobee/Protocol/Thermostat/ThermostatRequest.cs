using System;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat;

/// <summary>
/// Ecobee API thermostat request.
/// </summary>
public class ThermostatRequest : PagedRequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/thermostat";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.GET;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    [JsonIgnore]
    public override Type ResponseType => typeof(ThermostatResponse);

    /// <summary>
    /// The selection criteria for update.
    /// </summary>
    [JsonPropertyName("selection")]
    public Selection Selection { get; set; }
}