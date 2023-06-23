using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol;

/// <summary>
/// Paged Ecobee API response.
/// </summary>
public class PagedResponse : Response
{
    /// <summary>
    /// The Page object is optional and will only appear for responses which can be paged.
    /// It will not appear for responses which do not contain pageable content.
    /// </summary>
    [JsonPropertyName("page")]
    public Page Page { get; set; }
}