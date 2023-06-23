using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User;

/// <summary>
/// Ecobee API user update request.
/// </summary>
public class UserUpdateRequest : RequestBase
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
    /// The type of request. Always "update".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "update";

    /// <summary>
    /// The list of users to update.
    /// </summary>
    [JsonPropertyName("users")]
    public IList<HierarchyUser> Users { get; set; }

    /// <summary>
    /// The privileges to update or add.
    /// </summary>
    [JsonPropertyName("privileges")]
    public IList<HierarchyPrivilege> Privileges { get; set; }
}