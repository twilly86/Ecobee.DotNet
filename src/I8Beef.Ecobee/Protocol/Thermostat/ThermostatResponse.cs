using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat;

/// <summary>
/// Ecobee API thermostat response.
/// </summary>
public class ThermostatResponse : PagedResponse
{
    /// <summary>
    /// The list of thermostats returned by the request.
    /// </summary>
    [JsonPropertyName("thermostatList")]
    public IList<Objects.Thermostat> ThermostatList { get; set; }
}