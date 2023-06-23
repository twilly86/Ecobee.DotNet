using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Report;

/// <summary>
/// Ecobee API meter report response.
/// </summary>
public class MeterReportResponse : Response
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
    /// CSV list of meter types from the request.
    /// </summary>
    [JsonPropertyName("meters")]
    public string Meters { get; set; }

    /// <summary>
    /// A list of thermostat meter reports.
    /// </summary>
    [JsonPropertyName("reportList")]
    public IList<MeterReport> ReportList { get; set; }
}