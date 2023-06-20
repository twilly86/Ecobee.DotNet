using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API runtime report.
    /// </summary>
    public class RuntimeReport
    {
        /// <summary>
        /// The thermostat identifier for the report.
        /// </summary>
        [JsonPropertyName("thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The number of report rows in this report
        /// </summary>
        [JsonPropertyName("rowCount")]
        public int? RowCount { get; set; }

        /// <summary>
        /// A list of CSV report strings based on the columns requested.
        /// </summary>
        [JsonPropertyName("rowList")]
        public IList<string> RowList { get; set; }
    }
}
