using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Messages
{
    /// <summary>
    /// Ecobee authorization token.
    /// </summary>
    public class AuthToken
    {
        /// <summary>
        /// Access token.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Type of token.
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Time until expiration.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Refresh token.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Scope of token.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}
