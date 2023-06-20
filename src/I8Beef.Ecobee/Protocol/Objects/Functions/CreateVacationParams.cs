using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API create vacation params.
    /// </summary>
    public class CreateVacationParams : FunctionParams
    {
        /// <summary>
        /// The vacation event name. It must be unique.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The temperature to set the cool vacation hold at.
        /// </summary>
        [JsonPropertyName("coolHoldTemp")]
        public int? CoolHoldTemp { get; set; }

        /// <summary>
        /// The temperature to set the heat vacation hold at.
        /// </summary>
        [JsonPropertyName("heatHoldTemp")]
        public int? HeatHoldTemp { get; set; }

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
        /// The fan mode during the vacation. Values: auto, on Default: auto
        /// </summary>
        [JsonPropertyName("fan")]
        public string Fan { get; set; }

        /// <summary>
        /// The minimum number of minutes to run the fan each hour. Range: 0-60, Default: 0
        /// </summary>
        [JsonPropertyName("fanMinOnTime")]
        public string FanMinOnTime { get; set; }
    }
}
