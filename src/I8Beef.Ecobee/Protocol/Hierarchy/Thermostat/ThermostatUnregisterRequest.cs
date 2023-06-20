﻿using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat unregister request.
    /// </summary>
    public class ThermostatUnregisterRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/thermostat"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "unregister".
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get { return "unregister"; } }

        /// <summary>
        /// Comma separated list of thermostat identifiers.
        /// </summary>
        [JsonPropertyName("thermostats")]
        public string Thermostats { get; set; }
    }
}
