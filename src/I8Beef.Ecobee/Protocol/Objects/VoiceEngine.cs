using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API VoiceEngine.
    /// </summary>
    public class VoiceEngine
    {
        /// <summary>
        /// The name of the voice engine.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// True if the voice engine is currently enabled (paired) for the ecobee account of
        /// selected thermostat. You can change the flag value by using UnlinkVoiceEngine
        /// thermostat function.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
