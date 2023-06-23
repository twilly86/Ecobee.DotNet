using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API send message params.
/// </summary>
public class SendMessageParams : FunctionParams
{
    /// <summary>
    /// The message text to send. Text will be truncated to 500 characters if longer.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }
}