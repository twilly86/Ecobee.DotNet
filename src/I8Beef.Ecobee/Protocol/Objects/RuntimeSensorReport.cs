﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API runtime sensor report.
/// </summary>
public class RuntimeSensorReport
{
    /// <summary>
    /// The thermostat identifier for the report.
    /// </summary>
    [JsonPropertyName("thermostatIdentifier")]
    public string ThermostatIdentifier { get; set; }

    /// <summary>
    /// The list of sensor metadata configured in the thermostat.
    /// </summary>
    [JsonPropertyName("sensors")]
    public IList<RuntimeSensorMetadata> Sensors { get; set; }

    /// <summary>
    /// The list of column names returned in the data property. The sensor data column names
    /// match the sensorId within the sensor metadata. The first two columns are the date and
    /// time, the following are the defined sensorIds.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<string> Columns { get; set; }

    /// <summary>
    /// The list of CSV rows containing the column data as defined in the columns property.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<string> Data { get; set; }
}