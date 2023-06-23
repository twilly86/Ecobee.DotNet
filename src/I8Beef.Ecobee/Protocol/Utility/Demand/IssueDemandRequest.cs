using System;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand;

/// <summary>
/// Ecobee API issue demand request.
/// </summary>
public class IssueDemandRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/demandResponse";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.POST;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(IssueDemandResponse);

    /// <summary>
    /// The selection criteria for update.
    /// </summary>
    [JsonPropertyName("selection")]
    public Selection Selection { get; set; }

    /// <summary>
    /// The type of request. Always "create".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation { get; set; }

    /// <summary>
    /// The demand response object to create.
    /// </summary>
    [JsonPropertyName("demandResponse")]
    public DemandResponse DemandResponse { get; set; }
}