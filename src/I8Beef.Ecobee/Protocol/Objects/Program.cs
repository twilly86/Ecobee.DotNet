using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API program.
/// </summary>
public class Program
{
    /// <summary>
    /// The Schedule object defining the program schedule.
    /// </summary>
    [JsonPropertyName("schedule")]
    public IList<string[]> Schedule { get; set; }

    /// <summary>
    /// The list of Climate objects defining all the climates in the program schedule.
    /// </summary>
    [JsonPropertyName("climates")]
    public IList<Climate> Climates { get; set; }

    /// <summary>
    /// The currently active climate, identified by its ClimateRef.
    /// </summary>
    [JsonPropertyName("currentClimateRef")]
    public string CurrentClimateRef { get; set; }
}