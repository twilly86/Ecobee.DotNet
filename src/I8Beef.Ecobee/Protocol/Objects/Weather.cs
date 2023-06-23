using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API Weather.
/// </summary>
public class Weather
{
    /// <summary>
    /// The time stamp in UTC of the weather forecast.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// The weather station identifier.
    /// </summary>
    [JsonPropertyName("weatherStation")]
    public string WeatherStation { get; set; }

    /// <summary>
    /// The list of latest weather station forecasts.
    /// </summary>
    [JsonPropertyName("forecasts")]
    public IList<WeatherForecast> Forecasts { get; set; }
}