using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    /// <summary>
    /// Ecobee API set add request.
    /// </summary>
    public class SetAddRequest : RequestBase
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
        /// The type of request. Always "add".
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get { return "add"; } }

        /// <summary>
        /// The name of the new set.
        /// </summary>
        [JsonPropertyName("setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The path to the parent for the new set.
        /// </summary>
        [JsonPropertyName("parentPath")]
        public string ParentPath { get; set; }
    }
}
