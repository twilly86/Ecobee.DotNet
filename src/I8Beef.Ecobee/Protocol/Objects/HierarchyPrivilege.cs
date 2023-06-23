using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API hierarchy privilege.
/// </summary>
public class HierarchyPrivilege
{
    /// <summary>
    /// The path of the management set.
    /// </summary>
    [JsonPropertyName("setPath")]
    public string SetPath { get; set; }

    /// <summary>
    /// The name of the managment set.
    /// </summary>
    [JsonPropertyName("setName")]
    public string SetName { get; set; }

    /// <summary>
    /// The user name of the user associated with this privilege.
    /// </summary>
    [JsonPropertyName("userName")]
    public string UserName { get; set; }

    /// <summary>
    /// The user is permitted all privileges on the set.
    /// </summary>
    [JsonPropertyName("allowAll")]
    public bool? AllowAll { get; set; }

    /// <summary>
    /// The user is denied any privilege and may not view the set.
    /// </summary>
    [JsonPropertyName("allowNone")]
    public bool? AllowNone { get; set; }

    /// <summary>
    /// The user is only permitted to view the set and its contents.
    /// </summary>
    [JsonPropertyName("allowView")]
    public bool? AllowView { get; set; }

    /// <summary>
    /// The user is permitted to make program changes.
    /// </summary>
    [JsonPropertyName("allowProgram")]
    public bool? AllowProgram { get; set; }

    /// <summary>
    /// The user is permitted to create and edit vacation events.
    /// </summary>
    [JsonPropertyName("allowVacation")]
    public bool? AllowVacation { get; set; }

    /// <summary>
    /// The user is permitted to edit thermostat settings.
    /// </summary>
    [JsonPropertyName("allowSettings")]
    public bool? AllowSettings { get; set; }

    /// <summary>
    /// The user is permitted to access thermostat details such as desired temperature, HVAC mode and humidity settings.
    /// </summary>
    [JsonPropertyName("allowDetails")]
    public bool? AllowDetails { get; set; }

    /// <summary>
    /// The user is permitted to view thermostat reports.
    /// </summary>
    [JsonPropertyName("allowReport")]
    public bool? AllowReport { get; set; }

    /// <summary>
    /// The user is permitted to manage user security.
    /// </summary>
    [JsonPropertyName("allowSecurity")]
    public bool? AllowSecurity { get; set; }

    /// <summary>
    /// The user is permitted to manage management sets.
    /// </summary>
    [JsonPropertyName("allowHierarchy")]
    public bool? AllowHierarchy { get; set; }

    /// <summary>
    /// The user is permitted to manage alerts.
    /// </summary>
    [JsonPropertyName("allowAlerts")]
    public bool? AllowAlerts { get; set; }

    /// <summary>
    /// The user is permitted to manage account information and register/unregister new users.
    /// </summary>
    [JsonPropertyName("allowManageAccount")]
    public bool? AllowManageAccount { get; set; }
}