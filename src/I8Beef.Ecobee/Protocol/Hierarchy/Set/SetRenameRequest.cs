using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    /// <summary>
    /// Ecobee API set rename request.
    /// </summary>
    public class SetRenameRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/set"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "rename".
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get { return "rename"; } }

        /// <summary>
        /// The path of the set to rename.
        /// </summary>
        [JsonPropertyName("setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The new name to assign. Must be unique to that parent.
        /// </summary>
        [JsonPropertyName("newName")]
        public string NewName { get; set; }
    }
}
