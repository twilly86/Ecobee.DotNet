using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand;

/// <summary>
/// Ecobee API issue demand response.
/// </summary>
public class IssueDemandResponse : Response
{
    /// <summary>
    /// unique demand response reference ID.
    /// </summary>
    [JsonPropertyName("demandResponseRef")]
    public string DemandResponseRef { get; set; }
}