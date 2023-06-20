using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API group.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// The unique reference Id for the Group. If not supplied in the POST call, and new
        /// groupRef will be generated.
        /// </summary>
        [JsonPropertyName("groupRef")]
        public string GroupRef { get; set; }

        /// <summary>
        /// The name for the Group.
        /// </summary>
        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Flag for whether to synchronize Thermostat Alerts with all other Thermostats in
        /// the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeAlerts")]
        public bool? SynchronizeAlerts { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat mode with all other Thermostats in
        /// the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeSystemMode")]
        public bool? SynchronizeSystemMode { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat schedule/Program details with all
        /// other Thermostats in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeSchedule")]
        public bool? SynchronizeSchedule { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat quick save settings with all other
        /// Thermostats in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeQuickSave")]
        public bool? SynchronizeQuickSave { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat reminders with all other Thermostats
        /// in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeReminders")]
        public bool? SynchronizeReminders { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat Technician/Contractor Information with
        /// all other Thermostats in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeContractorInfo")]
        public bool? SynchronizeContractorInfo { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat user preferences with all other Thermostats
        /// in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeUserPreferences")]
        public bool? SynchronizeUserPreferences { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat utility information with all other
        /// Thermostats in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeUtilityInfo")]
        public bool? SynchronizeUtilityInfo { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat Location with all other Thermostats in
        /// the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeLocation")]
        public bool? SynchronizeLocation { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat reset with all other Thermostats in the
        /// Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeReset")]
        public bool? SynchronizeReset { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat vacation Program with all other Thermostats
        /// in the Group. Default is false.
        /// </summary>
        [JsonPropertyName("synchronizeVacation")]
        public bool? SynchronizeVacation { get; set; }

        /// <summary>
        /// The list of Thermostat identifiers which belong to the group. If an empty list is sent the
        /// Group will be deleted.
        /// </summary>
        [JsonPropertyName("thermostats")]
        public IList<string> Thermostats { get; set; }
    }
}
