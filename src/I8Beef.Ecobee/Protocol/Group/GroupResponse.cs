using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Group;

/// <summary>
/// Ecobee API group response.
/// </summary>
public class GroupResponse : Response
{
    /// <summary>
    /// The list of Groups returned by the request.
    /// </summary>
    [JsonPropertyName("groups")]
    public IList<Objects.Group> Groups { get; set; }
}