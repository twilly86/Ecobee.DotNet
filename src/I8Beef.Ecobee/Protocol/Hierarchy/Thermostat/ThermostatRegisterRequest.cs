using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat register request.
    /// </summary>
    public class ThermostatRegisterRequest : RequestBase
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
        /// The type of request. Always "register".
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get { return "register"; } }

        /// <summary>
        /// Comma separated list of thermostat identifiers.
        /// </summary>
        [JsonPropertyName("thermostats")]
        public string Thermostats { get; set; }

        /// <summary>
        /// The set path to assign thermostat to.
        /// </summary>
        [JsonPropertyName("setPath")]
        public string SetPath { get; set; }
    }
}
