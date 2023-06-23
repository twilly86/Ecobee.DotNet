

using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Messages;

/// <summary>
/// Ecobee API Error.
/// </summary>
public class ApiError
{
    /// <summary>
    /// Error code.
    /// </summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }

    /// <summary>
    /// Error description.
    /// </summary>
    [JsonPropertyName("error_description")]
    public string ErrorDescription { get; set; }

    /// <summary>
    /// Error URI.
    /// </summary>
    [JsonPropertyName("error_uri")]
    public string ErrorUri { get; set; }
}