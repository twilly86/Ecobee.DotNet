using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API remote sensor.
    /// </summary>
    public class RemoteSensor
    {
        /// <summary>
        /// The unique sensor identifier. It is composed of deviceName + deviceId separated
        /// by colons, for example: rs:100
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The user assigned sensor name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of sensor. Values: thermostat, ecobee3_remote_sensor, monitor_sensor,
        /// control_sensor.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The unique 4-digit alphanumeric sensor code. For ecobee3 remote sensors this
        /// corresponds to the code found on the back of the physical sensor.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// This flag indicates whether the remote sensor is currently in use by a comfort
        /// setting. See Climate for more information.
        /// </summary>
        [JsonPropertyName("inUse")]
        public bool? InUse { get; set; }

        /// <summary>
        /// The list of remoteSensorCapability objects for the remote sensor.
        /// </summary>
        [JsonPropertyName("capability")]
        public IList<RemoteSensorCapability> Capability { get; set; }
    }
}
