using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API security settings.
    /// </summary>
    public class SecuritySettings
    {
        /// <summary>
        /// The 4-digit user access code for the thermostat. The code must be set when
        /// enabling access control. See the callout above for more information.
        /// </summary>
        [JsonPropertyName("userAccessCode")]
        public string UserAccessCode { get; set; }

        /// <summary>
        /// The flag for determing whether there are any restrictions on the thermostat
        /// regarding access control. Default value is false. If all other values are
        /// true this value will default to true.
        /// </summary>
        [JsonPropertyName("allUserAccess")]
        public bool? AllUserAccess { get; set; }

        /// <summary>
        /// The flag for determing whether there are any restrictions on the thermostat
        /// regarding access control to the Thermostat.Program. Default value is false,
        /// unless allUserAccess is true.
        /// </summary>
        [JsonPropertyName("programAccess")]
        public bool? ProgramAccess { get; set; }

        /// <summary>
        /// The flag for determing whether there are any restrictions on the thermostat
        /// regarding access control to the Thermostat system and settings. Default value
        /// is false, unless allUserAccess is true.
        /// </summary>
        [JsonPropertyName("detailsAccess")]
        public bool? DetailsAccess { get; set; }

        /// <summary>
        /// The flag for determing whether there are any restrictions on the thermostat
        /// regarding access control to the Thermostat quick save functionality. Default
        /// value is false, unless allUserAccess is true.
        /// </summary>
        [JsonPropertyName("quickSaveAccess")]
        public bool? QuickSaveAccess { get; set; }

        /// <summary>
        /// The flag for determing whether there are any restrictions on the thermostat
        /// regarding access control to the Thermostat vacation functionality. Default
        /// value is false, unless allUserAccess is true.
        /// </summary>
        [JsonPropertyName("vacationAccess")]
        public bool? VacationAccess { get; set; }
    }
}
