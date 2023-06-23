using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API Technician.
/// </summary>
public class Technician
{
    /// <summary>
    /// The internal ecobee unique identifier for this contractor.
    /// </summary>
    [JsonPropertyName("contractorRef")]
    public string ContractorRef { get; set; }

    /// <summary>
    /// The company name of the technician.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The technician's contact phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The technician's street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string StreetAddress { get; set; }

    /// <summary>
    /// The technician's city.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// The technician's State or Province.
    /// </summary>
    [JsonPropertyName("provinceState")]
    public string ProvinceState { get; set; }

    /// <summary>
    /// The technician's country.
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// The technician's ZIP or Postal Code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// The technician's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// The technician's web site.
    /// </summary>
    [JsonPropertyName("web")]
    public string Web { get; set; }
}