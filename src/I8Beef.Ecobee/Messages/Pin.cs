using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Messages;

/// <summary>
/// Ecobee authorization pin.
/// </summary>
public class Pin
{
    /// <summary>
    /// Ecobee pin.
    /// </summary>
    [JsonPropertyName("ecobeePin")]
    public string EcobeePin { get; set; }

    /// <summary>
    /// Pin code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// Scope of pin.
    /// </summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Time until expiration.
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    /// <summary>
    /// Pin interval.
    /// </summary>
    [JsonPropertyName("interval")]
    public int Interval { get; set; }
}