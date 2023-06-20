using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API weather forcast.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// The Integer value used to map to a weatherSymbol. See list of mappings above.
        /// </summary>
        [JsonPropertyName("weatherSymbol")]
        public WeatherSymbol? WeatherSymbol { get; set; }

        /// <summary>
        /// The time stamp of the weather forecast.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// A text value representing the current weather condition.
        /// </summary>
        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// The current temperature.
        /// </summary>
        [JsonPropertyName("temperature")]
        public int? Temperature { get; set; }

        /// <summary>
        /// The current barometric pressure.
        /// </summary>
        [JsonPropertyName("pressure")]
        public int? Pressure { get; set; }

        /// <summary>
        /// The current humidity.
        /// </summary>
        [JsonPropertyName("relativeHumidity")]
        public int? RelativeHumidity { get; set; }

        /// <summary>
        /// The dewpoint.
        /// </summary>
        [JsonPropertyName("dewpoint")]
        public int? Dewpoint { get; set; }

        /// <summary>
        /// The visibility in meters; 0 - 70,000.
        /// </summary>
        [JsonPropertyName("visibility")]
        public int? Visibility { get; set; }

        /// <summary>
        /// The wind speed as an integer in mph * 1000.
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// The wind gust speed.
        /// </summary>
        [JsonPropertyName("windGust")]
        public int? WindGust { get; set; }

        /// <summary>
        /// The wind direction.
        /// </summary>
        [JsonPropertyName("windDirection")]
        public string WindDirection { get; set; }

        /// <summary>
        /// The wind bearing.
        /// </summary>
        [JsonPropertyName("windBearing")]
        public int? WindBearing { get; set; }

        /// <summary>
        /// Probability of precipitation.
        /// </summary>
        [JsonPropertyName("pop")]
        public int? Pop { get; set; }

        /// <summary>
        /// The predicted high temperature for the day.
        /// </summary>
        [JsonPropertyName("tempHigh")]
        public int? TempHigh { get; set; }

        /// <summary>
        /// The predicted low temperature for the day.
        /// </summary>
        [JsonPropertyName("tempLow")]
        public int? TempLow { get; set; }

        /// <summary>
        /// The cloud cover condition.
        /// </summary>
        [JsonPropertyName("sky")]
        public WeatherSky? Sky { get; set; }
    }
}
