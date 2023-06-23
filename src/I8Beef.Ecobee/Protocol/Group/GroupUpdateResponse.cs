using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Group;

/// <summary>
/// Ecobee API group update response.
/// </summary>
public class GroupUpdateResponse : Response
{
    /// <summary>
    /// The list of Groups updated by the request.
    /// </summary>
    [JsonPropertyName("groups")]
    public IList<Objects.Group> Groups { get; set; }
}