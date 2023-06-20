using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API control plug function.
    /// </summary>
    public sealed class ControlPlugFunction : Function
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlPlugFunction"/> class.
        /// </summary>
        public ControlPlugFunction()
        {
            Params = new ControlPlugParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonPropertyName("type")]
        public override string Type { get { return "controlPlug"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See
        /// individual function documentation for the properties.
        /// </summary>
        [JsonPropertyName("params")]
        public override FunctionParams Params { get; set; }
    }
}
