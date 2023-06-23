using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API unlink voice engine params.
/// </summary>
public class UnlinkVoiceEngineParams : FunctionParams
{
    /// <summary>
    /// The name of the engine to unlink.
    /// </summary>
    [JsonPropertyName("engineName")]
    public string EngineName { get; set; }
}