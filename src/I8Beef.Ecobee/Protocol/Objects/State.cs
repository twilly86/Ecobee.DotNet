using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API State.
    /// </summary>
    public class State
    {
        /// <summary>
        /// The maximum value the sensor can generate.
        /// </summary>
        [JsonPropertyName("maxValue")]
        public int? MaxValue { get; set; }

        /// <summary>
        /// The minimum value the sensor can generate.
        /// </summary>
        [JsonPropertyName("minValue")]
        public int? MinValue { get; set; }

        /// <summary>
        /// Values: coolHigh, coolLow, heatHigh, heatLow, high, low, transitionCount, normal.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The list of StateAction objects associated with the sensor.
        /// </summary>
        [JsonPropertyName("actions")]
        public IList<Action> Actions { get; set; }
    }
}