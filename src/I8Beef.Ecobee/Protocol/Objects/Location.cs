using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API location.
/// </summary>
public class Location
{
    /// <summary>
    /// The timezone offset in minutes from UTC.
    /// </summary>
    [JsonPropertyName("timeZoneOffsetMinutes")]
    public int? TimeZoneOffsetMinutes { get; set; }

    /// <summary>
    /// The Olson timezone the thermostat resides in (e.g America/Toronto).
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }

    /// <summary>
    /// Whether the thermostat should factor in daylight savings when displaying the date and time.
    /// </summary>
    [JsonPropertyName("isDaylightSaving")]
    public bool? IsDaylightSaving { get; set; }

    /// <summary>
    /// The thermostat location street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string StreetAddress { get; set; }

    /// <summary>
    /// The thermostat location city.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// The thermostat location State or Province.
    /// </summary>
    [JsonPropertyName("provinceState")]
    public string ProvinceState { get; set; }

    /// <summary>
    /// The thermostat location country.
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// The thermostat location ZIP or Postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// The thermostat owner's phone number
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The lat/long geographic coordinates of the thermostat location.
    /// </summary>
    [JsonPropertyName("mapCoordinates")]
    public string MapCoordinates { get; set; }
}