using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand;

/// <summary>
/// Ecobee API list deman request.
/// </summary>
public class ListDemandRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/demandResponse";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.GET;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(ListDemandResponse);

    /// <summary>
    /// The type of request. Always "list".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation => "list";
}