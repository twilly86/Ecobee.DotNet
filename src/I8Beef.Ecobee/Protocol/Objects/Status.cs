using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API Status.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// The status code for this status.
        /// </summary>
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// The detailed message for this status.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
