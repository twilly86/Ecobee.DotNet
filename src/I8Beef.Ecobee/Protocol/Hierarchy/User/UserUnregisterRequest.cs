using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User;

/// <summary>
/// Ecobee API user unregister request.
/// </summary>
public class UserUnregisterRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/hierarchy/user";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.POST;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(Response);

    /// <summary>
    /// The type of request. Always "unregister".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "unregister";

    /// <summary>
    /// The users whose privileges to unregister.
    /// </summary>
    [JsonPropertyName("users")]
    public IList<HierarchyUser> Users { get; set; }
}