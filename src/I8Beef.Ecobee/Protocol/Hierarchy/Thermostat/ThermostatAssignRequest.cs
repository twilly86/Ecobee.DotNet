using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat;

/// <summary>
/// Ecobee API thermostat assign request.
/// </summary>
public class ThermostatAssignRequest : RequestBase
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
    /// The type of request. Always "assign".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "assign";

    /// <summary>
    /// The set path the thermostats are being moved to.
    /// </summary>
    [JsonPropertyName("setPath")]
    public string SetPath { get; set; }

    /// <summary>
    /// Comma separated list of thermostat identifiers.
    /// </summary>
    [JsonPropertyName("thermostats")]
    public string Thermostats { get; set; }
}