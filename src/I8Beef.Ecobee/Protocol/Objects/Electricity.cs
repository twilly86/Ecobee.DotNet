using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API electricity.
    /// </summary>
    public class Electricity
    {
        /// <summary>
        /// The list of ElectricityDevice objects associated with the thermostat, each
        /// representing a device such as an electric meter or remote load control.
        /// </summary>
        [JsonPropertyName("devices")]
        public IList<ElectricityDevice> Devices { get; set; }
    }
}
