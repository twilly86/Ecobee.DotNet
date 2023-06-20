using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API notification settings.
    /// </summary>
    public class NotificationSettings
    {
        /// <summary>
        /// The list of email addresses alerts and reminders will be sent to. The full
        /// list of email addresses must be sent in any update request. If any are missing
        /// from that list they will be deleted. If an empty list is sent, any email addresses
        /// will be deleted.
        /// </summary>
        [JsonPropertyName("emailAddresses")]
        public IList<string> EmailAddresses { get; set; }

        /// <summary>
        /// Boolean values representing whether or not alerts and reminders will be sent
        /// to the email addresses listed above when triggered.
        /// </summary>
        [JsonPropertyName("emailNotificationsEnabled")]
        public bool? EmailNotificationsEnabled { get; set; }

        /// <summary>
        /// The list of equipment specific alert and reminder settings.
        /// </summary>
        [JsonPropertyName("equipment")]
        public IList<EquipmentSetting> Equipment { get; set; }

        /// <summary>
        /// The list of general alert and reminder settings.
        /// </summary>
        [JsonPropertyName("general")]
        public IList<GeneralSetting> General { get; set; }

        /// <summary>
        /// The list of limit specific alert and reminder settings.
        /// </summary>
        [JsonPropertyName("limit")]
        public IList<LimitSetting> Limit { get; set; }
    }
}
