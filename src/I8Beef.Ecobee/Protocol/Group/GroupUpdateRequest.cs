﻿using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Group
{
    /// <summary>
    /// Ecobee API group update request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GroupUpdateRequest : RequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateRequest"/> class.
        /// </summary>
        public GroupUpdateRequest()
        {
            Groups = new List<dynamic>();
        }

        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/group"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(GroupUpdateResponse); } }

        /// <summary>
        /// The selection criteria for the request.
        /// </summary>
        [JsonProperty(PropertyName = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// The list of Groups to update.
        /// </summary>
        [JsonProperty(PropertyName = "Groups")]
        public IList<dynamic> Groups { get; set; }
    }
}
