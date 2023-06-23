using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set;

/// <summary>
/// Ecobee API set list response.
/// </summary>
public class SetListResponse : Response
{
    /// <summary>
    /// list of hierarchy management sets.
    /// </summary>
    [JsonPropertyName("sets")]
    public IList<Objects.HierarchySet> Sets { get; set; }
}