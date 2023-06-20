using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API set hold params.
    /// </summary>
    public class SetHoldParams : FunctionParams
    {
        /// <summary>
        /// The temperature to set the cool hold at.
        /// </summary>
        [JsonPropertyName("coolHoldTemp")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? CoolHoldTemp { get; set; }

        /// <summary>
        /// The temperature to set the heat hold at.
        /// </summary>
        [JsonPropertyName("heatHoldTemp")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? HeatHoldTemp { get; set; }

        /// <summary>
        /// The fan state.
        /// </summary>
        [JsonPropertyName("fan")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Fan { get; set; }

        /// <summary>
        /// The Climate to use as reference for setting the coolHoldTemp, heatHoldTemp and fan
        /// settings for this hold. If this value is passed the coolHoldTemp and heatHoldTemp
        /// are not required.
        /// </summary>
        [JsonPropertyName("holdClimateRef")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string HoldClimateRef { get; set; }

        /// <summary>
        /// The start date in thermostat time.
        /// </summary>
        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string EndDate { get; set; }

        /// <summary>
        /// The end time in thermostat time.
        /// </summary>
        [JsonPropertyName("endTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string EndTime { get; set; }

        /// <summary>
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite,
        /// holdHours.
        /// </summary>
        [JsonPropertyName("holdType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string HoldType { get; set; }

        /// <summary>
        /// The number of hours to hold for, used and required if holdType='holdHours'.
        /// </summary>
        [JsonPropertyName("holdHours")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? HoldHours { get; set; }
    }
}
