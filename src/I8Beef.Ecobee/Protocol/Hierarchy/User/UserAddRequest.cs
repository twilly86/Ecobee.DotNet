using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user add request.
    /// </summary>
    public class UserAddRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/user"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "add".
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get { return "add"; } }

        /// <summary>
        /// The list of users to add.
        /// </summary>
        [JsonPropertyName("users")]
        public IList<HierarchyUser> Users { get; set; }

        /// <summary>
        /// The privileges to assign to the new users.
        /// </summary>
        [JsonPropertyName("privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }
    }
}
