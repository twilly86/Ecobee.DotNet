using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API electricity tier.
    /// </summary>
    public class ElectricityTier
    {
        /// <summary>
        /// The tier name as defined by the Utility. May be an empty string if the tier is
        /// undefined or the usage falls outside the defined tiers.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The last daily consumption reading collected. The reading format and precision
        /// is to three decimal places in kWh.
        /// </summary>
        [JsonPropertyName("consumption")]
        public string Consumption { get; set; }

        /// <summary>
        /// The daily cumulative tier cost in dollars if defined by the Utility. May be an
        /// empty string if undefined.
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }
    }
}