using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User;

/// <summary>
/// Ecobee API user list request.
/// </summary>
public class UserListRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/hierarchy/user";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.GET;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(UserListResponse);

    /// <summary>
    /// The type of request. Always "list".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "list";

    /// <summary>
    /// The management set path.
    /// </summary>
    [JsonPropertyName("setPath")]
    public string SetPath { get; set; }

    /// <summary>
    /// Whether to include the user privileges.
    /// </summary>
    [JsonPropertyName("includePrivileges")]
    public bool? IncludePrivileges { get; set; }

    /// <summary>
    /// Whether to also return the children of the children, recursively. Default: false
    /// </summary>
    [JsonPropertyName("recursive")]
    public bool? Recursive { get; set; }
}