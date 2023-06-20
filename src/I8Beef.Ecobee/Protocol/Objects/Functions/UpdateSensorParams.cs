using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API update sensor params.
    /// </summary>
    public class UpdateSensorParams : FunctionParams
    {
        /// <summary>
        /// The updated name to give the sensor. Has a max length of 32, but shorter is recommended.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The deviceId for the sensor, typically this indicates the enclosure and corresponds to the ThermostatRemoteSensor.id field. For example: rs:100
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// The idendifier for the sensor within the enclosure. Corresponds to the RemoteSensorCapability.id. For example: 1
        /// </summary>
        [JsonPropertyName("sensorId")]
        public string SensorId { get; set; }
    }
}
