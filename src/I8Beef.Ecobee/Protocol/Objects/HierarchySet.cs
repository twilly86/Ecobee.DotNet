﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API hierarchy set.
    /// </summary>
    public class HierarchySet
    {
        /// <summary>
        /// The name of the hierarchy set.
        /// </summary>
        [JsonPropertyName("setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The full path from the root to the hierarchy set.
        /// </summary>
        [JsonPropertyName("setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The list of child hierarchy sets.
        /// </summary>
        [JsonPropertyName("children")]
        public IList<HierarchySet> Children { get; set; }

        /// <summary>
        /// The list of hierarchy privileges assigned to this hierarchy set.
        /// </summary>
        [JsonPropertyName("privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }

        /// <summary>
        /// The list of thermostats assigned to this hierarchy set.
        /// </summary>
        [JsonPropertyName("thermostats")]
        public IList<string> Thermostats { get; set; }
    }
}
