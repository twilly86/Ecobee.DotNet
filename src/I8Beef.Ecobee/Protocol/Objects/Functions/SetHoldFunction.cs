using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API set hold function.
/// </summary>
public sealed class SetHoldFunction : Function
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetHoldFunction"/> class.
    /// </summary>
    public SetHoldFunction()
    {
        Params = new SetHoldParams();
    }

    /// <summary>
    /// The function type name. See the type name in the function documentation.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get => "setHold";
        set { } }

    /// <summary>
    /// A map of key=value pairs as the parameters to the function. See
    /// individual function documentation for the properties.
    /// </summary>
    [JsonPropertyName("params")]
    public override FunctionParams Params { get; set; }
}