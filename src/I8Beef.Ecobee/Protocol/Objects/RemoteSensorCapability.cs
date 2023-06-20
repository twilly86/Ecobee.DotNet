﻿using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API remote sensor capability.
    /// </summary>
    public class RemoteSensorCapability
    {
        /// <summary>
        /// The unique sensor capability identifier. For example: 1
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of sensor capability. Values: adc, co2, dryContact, humidity, temperature,
        /// occupancy, unknown.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The data value for this capability, always a String. Temperature values are expressed
        /// as degrees Fahrenheit, multiplied by 10. For example, a temperature of 72F would be
        /// returned as the value "720". Occupancy values are "true" or "false". Humidity is
        /// expressed as a % value such as "45". Unknown values are returned as "unknown".
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
