using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API page.
/// </summary>
public class Page
{
    /// <summary>
    /// The page retrieved or, in the case of a request parameter,
    /// the specific page requested.
    /// </summary>
    [JsonPropertyName("page")]
    public int? CurrentPage { get; set; }

    /// <summary>
    /// The total pages available.
    /// </summary>
    [JsonPropertyName("totalPages")]
    public int? TotalPages { get; set; }

    /// <summary>
    /// The number of objects on this page.
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// The total number of objects available.
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}