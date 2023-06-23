using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set;

/// <summary>
/// Ecobee API set add request.
/// </summary>
public class SetAddRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/hierarchy/set";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.POST;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(Response);

    /// <summary>
    /// The type of request. Always "add".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "add";

    /// <summary>
    /// The name of the new set.
    /// </summary>
    [JsonPropertyName("setName")]
    public string SetName { get; set; }

    /// <summary>
    /// The path to the parent for the new set.
    /// </summary>
    [JsonPropertyName("parentPath")]
    public string ParentPath { get; set; }
}