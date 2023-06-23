using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Group;

/// <summary>
/// Ecobee API group update request.
/// </summary>
public class GroupUpdateRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/group";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.POST;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(GroupUpdateResponse);

    /// <summary>
    /// The selection criteria for the request.
    /// </summary>
    [JsonPropertyName("selection")]
    public Selection Selection { get; set; }

    /// <summary>
    /// The list of Groups to update.
    /// </summary>
    [JsonPropertyName("Groups")]
    public IList<dynamic> Groups { get; set; }
}