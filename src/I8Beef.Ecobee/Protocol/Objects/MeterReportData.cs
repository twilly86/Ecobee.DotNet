using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API meter report data.
    /// </summary>
    public class MeterReportData
    {
        /// <summary>
        /// The type of meter the data is for.
        /// </summary>
        [JsonPropertyName("meterType")]
        public string MeterType { get; set; }

        /// <summary>
        /// The columns provided in the data.
        /// </summary>
        [JsonPropertyName("columns")]
        public string Columns { get; set; }

        /// <summary>
        /// A list of rows of CSV data matching the columns property.
        /// </summary>
        [JsonPropertyName("data")]
        public IList<string> Data { get; set; }
    }
}
