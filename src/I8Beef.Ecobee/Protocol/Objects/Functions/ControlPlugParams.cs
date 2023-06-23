using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API control plug params.
/// </summary>
public class ControlPlugParams : FunctionParams
{
    /// <summary>
    /// The name of the plug. Ensure each plug has a unique name.
    /// </summary>
    [JsonPropertyName("plugName")]
    public string PlugName { get; set; }

    /// <summary>
    /// The state to put the plug into. Valid values: on, off, resume.
    /// </summary>
    [JsonPropertyName("plugState")]
    public string PlugState { get; set; }

    /// <summary>
    /// The start date in thermostat time.
    /// </summary>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }

    /// <summary>
    /// The start time in thermostat time.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// The end date in thermostat time.
    /// </summary>
    [JsonPropertyName("endDate")]
    public string EndDate { get; set; }

    /// <summary>
    /// The end time in thermostat time.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string EndTime { get; set; }

    /// <summary>
    /// The hold duration type. Valid values: dateTime, nextTransition, indefinite, holdHours.
    /// </summary>
    [JsonPropertyName("holdType")]
    public string HoldType { get; set; }

    /// <summary>
    /// The number of hours to hold for, used and required if holdType='holdHours'.
    /// </summary>
    [JsonPropertyName("holdHours")]
    public int? HoldHours { get; set; }
}