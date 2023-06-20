using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API house details.
    /// </summary>
    public class HouseDetails
    {
        /// <summary>
        /// The style of house. Values: other, apartment, condominium, detached, loft,
        /// multiPlex, rowHouse, semiDetached, townhouse, and 0 for unknown.
        /// </summary>
        [JsonPropertyName("style")]
        public string Style { get; set; }

        /// <summary>
        /// The size of the house in square feet.
        /// </summary>
        [JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The number of floors or levels in the house.
        /// </summary>
        [JsonPropertyName("numberOfFloors")]
        public int? NumberOfFloors { get; set; }

        /// <summary>
        /// The number of rooms in the house.
        /// </summary>
        [JsonPropertyName("numberOfRooms")]
        public int? NumberOfRooms { get; set; }

        /// <summary>
        /// The number of occupants living in the house.
        /// </summary>
        [JsonPropertyName("numberOfOccupants")]
        public int? NumberOfOccupants { get; set; }

        /// <summary>
        /// The age of house in years.
        /// </summary>
        [JsonPropertyName("age")]
        public int? Age { get; set; }

        /// <summary>
        /// This field defines the window efficiency of the house. Valid values are in the range 1 - 7.
        /// Changing the value of this field alters the settings the thermostat uses for the humidifier
        /// when in 'frost Control' mode. See the NOTE above before updating this value.
        /// </summary>
        [JsonPropertyName("windowEfficiency")]
        public int? WindowEfficiency { get; set; }
    }
}
