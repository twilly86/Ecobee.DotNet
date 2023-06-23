using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API event.
/// </summary>
public class Event
{
    /// <summary>
    /// The type of event. Values: hold, demandResponse, sensor, switchOccupancy, vacation, quickSave, today, autoAway, autoHome
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// The unique event name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether the event is currently active or not.
    /// </summary>
    [JsonPropertyName("running")]
    public bool? Running { get; set; }

    /// <summary>
    /// The event start date in thermostat local time.
    /// </summary>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }

    /// <summary>
    /// The event start time in thermostat local time.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// The event end date in thermostat local time.
    /// </summary>
    [JsonPropertyName("endDate")]
    public string EndDate { get; set; }

    /// <summary>
    /// The event end time in thermostat local time.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string EndTime { get; set; }

    /// <summary>
    /// Whether there are persons occupying the property during the event.
    /// </summary>
    [JsonPropertyName("isOccupied")]
    public bool? IsOccupied { get; set; }

    /// <summary>
    /// Whether cooling will be turned off during the event.
    /// </summary>
    [JsonPropertyName("isCoolOff")]
    public bool? IsCoolOff { get; set; }

    /// <summary>
    /// Whether heating will be turned off during the event.
    /// </summary>
    [JsonPropertyName("isHeatOff")]
    public bool? IsHeatOff { get; set; }

    /// <summary>
    /// The cooling absolute temperature to set.
    /// </summary>
    [JsonPropertyName("coolHoldTemp")]
    public int? CoolHoldTemp { get; set; }

    /// <summary>
    /// The heating absolute temperature to set.
    /// </summary>
    [JsonPropertyName("heatHoldTemp")]
    public int? HeatHoldTemp { get; set; }

    /// <summary>
    /// The fan mode during the event. Values: auto, on Default: based on current climate and hvac mode.
    /// </summary>
    [JsonPropertyName("fan")]
    public string Fan { get; set; }

    /// <summary>
    /// The ventilator mode during the vent. Values: auto, minontime, on, off.
    /// </summary>
    [JsonPropertyName("vent")]
    public string Vent { get; set; }

    /// <summary>
    /// The minimum amount of time the ventilator equipment must stay on on each duty cycle.
    /// </summary>
    [JsonPropertyName("ventilatorMinOnTime")]
    public int? VentilatorMinOnTime { get; set; }

    /// <summary>
    /// Whether this event is mandatory or the end user can cancel it.
    /// </summary>
    [JsonPropertyName("isOptional")]
    public bool? IsOptional { get; set; }

    /// <summary>
    /// Whether the event is using a relative temperature setting to the currently active program climate.See the Note at the bottom of this page for more information.
    /// </summary>
    [JsonPropertyName("isTemperatureRelative")]
    public bool? IsTemperatureRelative { get; set; }

    /// <summary>
    /// The relative cool temperature adjustment.
    /// </summary>
    [JsonPropertyName("coolRelativeTemp")]
    public int? CoolRelativeTemp { get; set; }

    /// <summary>
    /// The relative heat temperature adjustment.
    /// </summary>
    [JsonPropertyName("heatRelativeTemp")]
    public int? HeatRelativeTemp { get; set; }

    /// <summary>
    /// Whether the event uses absolute temperatures to set the values.Default: true for DRs.See the Note at the bottom of this page for more information.
    /// </summary>
    [JsonPropertyName("isTemperatureAbsolute")]
    public bool? IsTemperatureAbsolute { get; set; }

    /// <summary>
    /// Indicates the % scheduled runtime during a Demand Response event. Valid range is 0 - 100%. Default = 100, indicates no change to schedule.
    /// </summary>
    [JsonPropertyName("dutyCyclePercentage")]
    public int? DutyCyclePercentage { get; set; }

    /// <summary>
    /// The minimum number of minutes to run the fan each hour.Range: 0-60, Default: 0
    /// </summary>
    [JsonPropertyName("fanMinOnTime")]
    public int? FanMinOnTime { get; set; }

    /// <summary>
    /// True if this calendar event was created because of the occupied sensor.
    /// </summary>
    [JsonPropertyName("occupiedSensorActive")]
    public bool? OccupiedSensorActive { get; set; }

    /// <summary>
    /// True if this calendar event was created because of the unoccupied sensor
    /// </summary>
    [JsonPropertyName("unoccupiedSensorActive")]
    public bool? UnoccupiedSensorActive { get; set; }

    /// <summary>
    /// Unsupported. Future feature.
    /// </summary>
    [JsonPropertyName("drRampUpTemp")]
    public int? DrRampUpTemp { get; set; }

    /// <summary>
    /// Unsupported.Future feature.
    /// </summary>
    [JsonPropertyName("drRampUpTime")]
    public int? DrRampUpTime { get; set; }

    /// <summary>
    /// Unique identifier set by the server to link one or more events and alerts together.
    /// </summary>
    [JsonPropertyName("linkRef")]
    public string LinkRef { get; set; }

    /// <summary>
    /// Used for display purposes to indicate what climate (if any) is being used for the hold.
    /// </summary>
    [JsonPropertyName("holdClimateRef")]
    public string HoldClimateRef { get; set; }
}