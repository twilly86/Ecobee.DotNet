using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API selection.
    /// </summary>
    public class Selection
    {
        /// <summary>
        /// The type of match data supplied: Values: none, thermostats, user, managementSet.
        /// </summary>
        [JsonPropertyName("selectionType")]
        public string SelectionType { get; set; }

        /// <summary>
        /// The match data based on selectionType(e.g.a list of thermostat idendifiers in the case of a selectionType of thermostats)
        /// </summary>
        [JsonPropertyName("selectionMatch")]
        public string SelectionMatch { get; set; }

        /// <summary>
        /// Include the thermostat runtime object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeRuntime")]
        public bool? IncludeRuntime { get; set; }

        /// <summary>
        /// Include the extended thermostat runtime object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeExtendedRuntime")]
        public bool? IncludeExtendedRuntime { get; set; }

        /// <summary>
        /// Include the electricity readings object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeElectricity")]
        public bool? IncludeElectricity { get; set; }

        /// <summary>
        /// Include the thermostat settings object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeSettings")]
        public bool? IncludeSettings { get; set; }

        /// <summary>
        /// Include the thermostat location object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeLocation")]
        public bool? IncludeLocation { get; set; }

        /// <summary>
        /// Include the thermostat program object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeProgram")]
        public bool? IncludeProgram { get; set; }

        /// <summary>
        /// Include the thermostat calendar events objects.If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeEvents")]
        public bool? IncludeEvents { get; set; }

        /// <summary>
        /// Include the thermostat device configuration objects. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeDevice")]
        public bool? IncludeDevice { get; set; }

        /// <summary>
        /// Include the thermostat technician object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeTechnician")]
        public bool? IncludeTechnician { get; set; }

        /// <summary>
        /// Include the thermostat utility company object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeUtility")]
        public bool? IncludeUtility { get; set; }

        /// <summary>
        /// Include the thermostat management company object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeManagement")]
        public bool? IncludeManagement { get; set; }

        /// <summary>
        /// Include the thermostat's unacknowledged alert objects. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeAlerts")]
        public bool? IncludeAlerts { get; set; }

        /// <summary>
        /// Include the current thermostat weather forecast object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeWeather")]
        public bool? IncludeWeather { get; set; }

        /// <summary>
        /// Include the current thermostat house details object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeHouseDetails")]
        public bool? IncludeHouseDetails { get; set; }

        /// <summary>
        /// Include the current thermostat OemCfg object. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeOemCfg")]
        public bool? IncludeOemCfg { get; set; }

        /// <summary>
        /// Include the current thermostat equipment status information.If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeEquipmentStatus")]
        public bool? IncludeEquipmentStatus { get; set; }

        /// <summary>
        /// Include the current thermostat alert and reminders settings. If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeNotificationSettings")]
        public bool? IncludeNotificationSettings { get; set; }

        /// <summary>
        /// Include the current thermostat privacy settings. Note: access to this object is restricted to
        /// callers with implict authentication, setting this value to true without proper credentials will
        /// result in an authentication exception.
        /// </summary>
        [JsonPropertyName("includePrivacy")]
        public bool? IncludePrivacy { get; set; }

        /// <summary>
        /// Include the current firmware version the Thermostat is running.If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeVersion")]
        public bool? IncludeVersion { get; set; }

        /// <summary>
        /// Include the current securitySettings object for the selected Thermostat(s). If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeSecuritySettings")]
        public bool? IncludeSecuritySettings { get; set; }

        /// <summary>
        /// Include the list of current thermostatRemoteSensor objects for the selected Thermostat(s). If not specified,
        /// defaults to false.
        /// </summary>
        [JsonPropertyName("includeSensors")]
        public bool? IncludeSensors { get; set; }

        /// <summary>
        /// Include the audio configuration for the selected Thermostat(s). If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeAudio")]
        public bool? IncludeAudio { get; set; }

        /// <summary>
        /// Include the energy configuration for the selected Thermostat(s). If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeEnergy")]
        public bool? IncludeEnergy { get; set; }

        /// <summary>
        /// Include the capabilities for the selected Thermostat(s). If not specified, defaults to false.
        /// </summary>
        [JsonPropertyName("includeCapabilities")]
        public bool? IncludeCapabilities { get; set; }
    }
}
