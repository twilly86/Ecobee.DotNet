using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API demand management.
    /// </summary>
    public class DemandManagement
    {
        /// <summary>
        /// The date(UTC) for the beginning of this day's demand management series.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// The hour in the day this series begins at.Range: 0-23
        /// </summary>
        [JsonPropertyName("hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// The series of 12, 5 minute interval temperature adjustments in the hour.
        /// Valid integer values are required for each interval. See Temperature values.
        /// </summary>
        [JsonPropertyName("tempOffsets")]
        public IList<int> TempOffsets { get; set; }
    }
}