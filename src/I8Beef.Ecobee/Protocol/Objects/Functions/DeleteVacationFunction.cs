using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API delete vacation function.
/// </summary>
public sealed class DeleteVacationFunction : Function
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteVacationFunction"/> class.
    /// </summary>
    public DeleteVacationFunction()
    {
        Params = new DeleteVacationParams();
    }

    /// <summary>
    /// The function type name. See the type name in the function documentation.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get => "deleteVacation";
        set { } }

    /// <summary>
    /// A map of key=value pairs as the parameters to the function. See
    /// individual function documentation for the properties.
    /// </summary>
    [JsonPropertyName("params")]
    public override FunctionParams Params { get; set; }
}