using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API meter report.
    /// </summary>
    public class MeterReport
    {
        /// <summary>
        /// The thermostat identifier this report is for.
        /// </summary>
        [JsonPropertyName("thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The list of meter data for the meters requested. If the thermostat has no
        /// meter, the object for that meter will not be included in the list. A
        /// thermostat with no meters will have this list empty.
        /// </summary>
        [JsonPropertyName("meterList")]
        public IList<MeterReportData> MeterList { get; set; }
    }
}
