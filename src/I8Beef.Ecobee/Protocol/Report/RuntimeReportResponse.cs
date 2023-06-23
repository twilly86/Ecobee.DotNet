using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Report;

/// <summary>
/// Ecobee API runtime report response.
/// </summary>
public class RuntimeReportResponse : Response
{
    /// <summary>
    /// report UTC start date.
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// report start interval.
    /// </summary>
    [JsonPropertyName("startInterval")]
    public int? StartInterval { get; set; }

    /// <summary>
    /// report UTC end date.
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime EndDate { get; set; }

    /// <summary>
    /// report end interval.
    /// </summary>
    [JsonPropertyName("endInterval")]
    public int? EndInterval { get; set; }

    /// <summary>
    /// CSV list of column names from the request.
    /// </summary>
    [JsonPropertyName("columns")]
    public string Columns { get; set; }

    /// <summary>
    /// A list of runtime reports.
    /// </summary>
    [JsonPropertyName("reportList")]
    public IList<RuntimeReport> ReportList { get; set; }

    /// <summary>
    /// A list of runtime sensor reports. Will be empty unless requested.
    /// </summary>
    [JsonPropertyName("sensorList")]
    public IList<RuntimeSensorReport> SensorList { get; set; }
}