using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The User login userName. Usually a valid email address.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The User display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The User first name.
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The User last name.
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The User title such as Mr. or Mrs.
        /// </summary>
        [JsonPropertyName("honorific")]
        public string Honorific { get; set; }

        /// <summary>
        /// The User date of registration.
        /// </summary>
        [JsonPropertyName("registerDate")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// The User time of registration.
        /// </summary>
        [JsonPropertyName("registerTime")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// The Thermostat identifier this User is associated with.
        /// </summary>
        [JsonPropertyName("defaultThermostatIdentifier")]
        public string DefaultThermostatIdentifier { get; set; }

        /// <summary>
        /// The User management reference.
        /// </summary>
        [JsonPropertyName("managementRef")]
        public string ManagementRef { get; set; }

        /// <summary>
        /// The User utility reference.
        /// </summary>
        [JsonPropertyName("utilityRef")]
        public string UtilityRef { get; set; }

        /// <summary>
        /// The User support reference.
        /// </summary>
        [JsonPropertyName("supportRef")]
        public string SupportRef { get; set; }

        /// <summary>
        /// The User phone Number.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether this user has a residential role.
        /// </summary>
        [JsonPropertyName("isResidential")]
        public bool? IsResidential { get; set; }

        /// <summary>
        /// Whether this user has a developer role.
        /// </summary>
        [JsonPropertyName("isDeveloper")]
        public bool? IsDeveloper { get; set; }

        /// <summary>
        /// Whether this user has a management role.
        /// </summary>
        [JsonPropertyName("isManagement")]
        public bool? IsManagement { get; set; }

        /// <summary>
        /// Whether this user has a utility role.
        /// </summary>
        [JsonPropertyName("isUtility")]
        public bool? IsUtility { get; set; }

        /// <summary>
        /// Whether this user has a contractor role.
        /// </summary>
        [JsonPropertyName("isContractor")]
        public bool? IsContractor { get; set; }
    }
}
