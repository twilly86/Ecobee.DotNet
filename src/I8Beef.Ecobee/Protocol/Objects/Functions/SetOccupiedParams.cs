using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API set occupied params.
    /// </summary>
    public class SetOccupiedParams : FunctionParams
    {
        /// <summary>
        /// The climate to use for the temperature, occupied (true) or unoccupied (false).
        /// </summary>
        [JsonPropertyName("occupied")]
        public bool? Occupied { get; set; }

        /// <summary>
        /// The start date in thermostat time.
        /// </summary>
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// The start time in thermostat time.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The end date in thermostat time.
        /// </summary>
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The end time in thermostat time.
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite, holdHours.
        /// </summary>
        [JsonPropertyName("holdType")]
        public string HoldType { get; set; }

        /// <summary>
        /// The number of hours to hold for, used and required if holdType='holdHours'.
        /// </summary>
        [JsonPropertyName("holdHours")]
        public int? HoldHours { get; set; }
    }
}
