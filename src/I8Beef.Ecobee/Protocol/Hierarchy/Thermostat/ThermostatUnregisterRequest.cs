using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat;

/// <summary>
/// Ecobee API thermostat unregister request.
/// </summary>
public class ThermostatUnregisterRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/hierarchy/thermostat";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.POST;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(Response);

    /// <summary>
    /// The type of request. Always "unregister".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "unregister";

    /// <summary>
    /// Comma separated list of thermostat identifiers.
    /// </summary>
    [JsonPropertyName("thermostats")]
    public string Thermostats { get; set; }
}