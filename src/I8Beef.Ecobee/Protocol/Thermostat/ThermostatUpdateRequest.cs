using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat;

/// <summary>
/// Ecobee API thermostat update request.
/// </summary>
public class ThermostatUpdateRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/thermostat";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.POST;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    [JsonIgnore]
    public override Type ResponseType => typeof(Response);

    /// <summary>
    /// The selection criteria for update.
    /// </summary>
    [JsonPropertyName("selection")]
    public Selection Selection { get; set; }

    /// <summary>
    /// The thermostat object with properties to update.
    /// </summary>
    [JsonPropertyName("thermostat")]
    public object Thermostat { get; set; }

    /// <summary>
    /// The list of functions to perform on all selected thermostats.
    /// </summary>
    [JsonPropertyName("functions")]
    public IList<Function> Functions { get; set; }
}