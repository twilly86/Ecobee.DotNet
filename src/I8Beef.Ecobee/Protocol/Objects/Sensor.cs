using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API Sensor.
    /// </summary>
    public class Sensor
    {
        /// <summary>
        /// The sensor name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The sensor manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The sensor model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }

        /// <summary>
        /// The thermostat zone the sensor is associated with.
        /// </summary>
        [JsonPropertyName("zone")]
        public int? Zone { get; set; }

        /// <summary>
        /// The unique sensor identifier.
        /// </summary>
        [JsonPropertyName("sensorId")]
        public int? SensorId { get; set; }

        /// <summary>
        /// The type of sensor.Values: adc, co2, dryCOntact, humidity, temperature, unknown.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The sensor usage type. Values: dischargeAir, indoor, monitor, outdoor.
        /// </summary>
        [JsonPropertyName("usage")]
        public string Usage { get; set; }

        /// <summary>
        /// The number of bits the adc has been configured to use.
        /// </summary>
        [JsonPropertyName("numberOfBits")]
        public int? NumberOfBits { get; set; }

        /// <summary>
        /// Value of the bconstant value used in temperature sensors.
        /// </summary>
        [JsonPropertyName("bconstant")]
        public int? BConstant { get; set; }

        /// <summary>
        /// The sensor thermistor value, ie. 10K thermistor = 10000, 2.5K thermistor = 2500.
        /// </summary>
        [JsonPropertyName("thermistorSize")]
        public int? ThermistorSize { get; set; }

        /// <summary>
        /// The user adjustable temperature compensation applied to the temperature reading.
        /// </summary>
        [JsonPropertyName("tempCorrection")]
        public int? TempCorrection { get; set; }

        /// <summary>
        /// The sensor thermistor gain value.
        /// </summary>
        [JsonPropertyName("gain")]
        public int? Gain { get; set; }

        /// <summary>
        /// The sensor thermistor max voltage in Volts, 5=5V, 10=10V.
        /// </summary>
        [JsonPropertyName("maxVoltage")]
        public int? MaxVoltage { get; set; }

        /// <summary>
        /// The multiplier value used in sensors (1000x value).
        /// </summary>
        [JsonPropertyName("multiplier")]
        public int? Multiplier { get; set; }

        /// <summary>
        /// A list of SensorState objects.
        /// </summary>
        [JsonPropertyName("states")]
        public IList<State> States { get; set; }
    }
}