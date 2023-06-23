using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API hierarchy user.
/// </summary>
public class HierarchyUser
{
    /// <summary>
    /// The user name and login ID. It must be a valid email address.
    /// </summary>
    [JsonPropertyName("userName")]
    public string UserName { get; set; }

    /// <summary>
    /// The first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The timestamp of the last user login into the web portal. Format: YYYY-MM-DD HH:MM:SS
    /// </summary>
    [JsonPropertyName("lastLogin")]
    public string LastLogin { get; set; }

    /// <summary>
    /// Whether the user is active and permitted to access to the system.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Whether the user will receive alerts in email.
    /// </summary>
    [JsonPropertyName("emailAlerts")]
    public bool? EmailAlerts { get; set; }
}