using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API management.
/// </summary>
public class Management
{
    /// <summary>
    /// The administrative contact name.
    /// </summary>
    [JsonPropertyName("administrativeContact")]
    public string AdministrativeContact { get; set; }

    /// <summary>
    /// The billing contact name.
    /// </summary>
    [JsonPropertyName("billingContact")]
    public string BillingContact { get; set; }

    /// <summary>
    /// The company name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The contact email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// The company web site.
    /// </summary>
    [JsonPropertyName("web")]
    public string Web { get; set; }

    /// <summary>
    /// Whether to show management alerts on the thermostat.
    /// </summary>
    [JsonPropertyName("showAlertIdt")]
    public bool? ShowAlertIdt { get; set; }

    /// <summary>
    /// Whether to show management alerts in the web portal.
    /// </summary>
    [JsonPropertyName("showAlertWeb")]
    public bool? ShowAlertWeb { get; set; }
}