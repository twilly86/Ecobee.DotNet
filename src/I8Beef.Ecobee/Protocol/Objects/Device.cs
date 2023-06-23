using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API device.
/// </summary>
public class Device
{
    /// <summary>
    /// A unique ID for the device
    /// </summary>
    [JsonPropertyName("deviceId")]
    public int? DeviceId { get; set; }

    /// <summary>
    /// The user supplied device name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The list of Sensor Objects associated with the device.
    /// </summary>
    [JsonPropertyName("sensors")]
    public IList<Sensor> Sensors { get; set; }

    /// <summary>
    /// The list of Output Objects associated with the device
    /// </summary>
    [JsonPropertyName("outputs")]
    public IList<Output> Outputs { get; set; }
}