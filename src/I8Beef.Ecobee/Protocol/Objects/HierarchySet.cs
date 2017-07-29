﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API hierarchy set.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HierarchySet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchySet"/> class.
        /// </summary>
        public HierarchySet()
        {
            Children = new List<HierarchySet>();
            Privileges = new List<HierarchyPrivilege>();
            Thermostats = new List<string>();
        }

        /// <summary>
        /// The name of the hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The full path from the root to the hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The list of child hierarchy sets.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<HierarchySet> Children { get; set; }

        /// <summary>
        /// The list of hierarchy privileges assigned to this hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }

        /// <summary>
        /// The list of thermostats assigned to this hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "thermostats")]
        public IList<string> Thermostats { get; set; }
    }
}
