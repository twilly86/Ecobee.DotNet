using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API Utility.
/// </summary>
public class Utility
{
    /// <summary>
    /// The Utility company name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The Utility company contact phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The Utility company email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// The Utility company web site.
    /// </summary>
    [JsonPropertyName("web")]
    public string Web { get; set; }
}