using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API general setting.
    /// </summary>
    public class GeneralSetting
    {
        /// <summary>
        /// Boolean value representing whether or not alerts/reminders are enabled for
        /// this notification type or not.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The type of notification. Possible values are: temp
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Boolean value representing whether or not alerts/reminders should be sent
        /// to the technician/contractor assoicated with the thermostat.
        /// </summary>
        [JsonPropertyName("remindTechnician")]
        public bool? RemindTechnician { get; set; }
    }
}
