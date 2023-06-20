using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat summary response.
    /// </summary>
    public class ThermostatSummaryResponse : Response
    {
        /// <summary>
        /// The list of CSV revision values.
        /// </summary>
        [JsonPropertyName("revisionList")]
        public IList<string> RevisionList { get; set; }

        /// <summary>
        /// Integer Number of thermostats listed in the Revision List.
        /// </summary>
        [JsonPropertyName("thermostatCount")]
        public int ThermostatCount { get; set; }

        /// <summary>
        /// CSV[] The list of CSV status values.
        /// </summary>
        [JsonPropertyName("statusList")]
        public IList<string> StatusList { get; set; }
    }
}
