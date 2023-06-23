using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API electricity device.
/// </summary>
public class ElectricityDevice
{
    /// <summary>
    /// The name of the device
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The list of Electricity Tiers containing the break down of daily
    /// electricity consumption of the device for the day, broken down per pricing tier.
    /// </summary>
    [JsonPropertyName("tiers")]
    public IList<ElectricityTier> Tiers { get; set; }

    /// <summary>
    /// The last date/time the reading was updated in UTC time.
    /// </summary>
    [JsonPropertyName("lastUpdate")]
    public string LastUpdate { get; set; }

    /// <summary>
    /// The last three daily electricity cost reads from the device in
    /// cents with a three decimal place precision.
    /// </summary>
    [JsonPropertyName("cost")]
    public string Cost { get; set; }

    /// <summary>
    /// The last three daily electricity consumption reads from the
    /// device in KWh with a three decimal place precision.
    /// </summary>
    [JsonPropertyName("consumption")]
    public string Consumption { get; set; }
}