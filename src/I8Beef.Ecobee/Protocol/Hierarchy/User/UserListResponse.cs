using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user list response.
    /// </summary>
    public class UserListResponse : Response
    {
        /// <summary>
        /// list of users in the company.
        /// </summary>
        [JsonPropertyName("users")]
        public IList<Objects.HierarchyUser> Users { get; set; }

        /// <summary>
        /// of hierarchy privileges if requested.
        /// </summary>
        [JsonPropertyName("privileges")]
        public IList<Objects.HierarchyPrivilege> Privileges { get; set; }
    }
}
