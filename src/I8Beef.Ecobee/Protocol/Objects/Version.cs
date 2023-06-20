using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API Version.
    /// </summary>
    public class Version
    {
        /// <summary>
        /// The thermostat firmware version number.
        /// </summary>
        [JsonPropertyName("thermostatFirmwareVersion")]
        public string ThermostatFirmwareVersion { get; set; }
    }
}
