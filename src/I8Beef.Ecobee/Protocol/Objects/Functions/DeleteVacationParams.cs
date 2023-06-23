using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API delete vacation params.
/// </summary>
public class DeleteVacationParams : FunctionParams
{
    /// <summary>
    /// The vacation event name. It must be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}