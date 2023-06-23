using System;
using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Report;

/// <summary>
/// Ecobee API meter report request.
/// </summary>
public class MeterReportRequest : RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public override string Uri => "/meterReport";

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public override RequestType RequestType => RequestType.GET;

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public override Type ResponseType => typeof(MeterReportResponse);

    /// <summary>
    /// The Selection Object. Must be selectionType = 'thermostats' and selectionMatch = a CSV of
    /// thermostat identifiers.
    /// </summary>
    [JsonPropertyName("selection")]
    public Selection Selection { get; set; }

    /// <summary>
    /// The UTC report start date.
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// The 5 minute interval to begin the report on. The interval can be determined by multiplying the
    /// interval by 5. Range: 0-287 Default: 0
    /// </summary>
    [JsonPropertyName("startInterval")]
    public int? StartInterval { get; set; }

    /// <summary>
    /// The UTC report end date.
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime EndDate { get; set; }

    /// <summary>
    /// The 5 minute interval to end the report on. The interval can be determined by multiplying the
    /// interval by 5. Range: 0-287 Default: 287
    /// </summary>
    [JsonPropertyName("endInterval")]
    public int? EndInterval { get; set; }

    /// <summary>
    /// A CSV string of meter types. See Meter Types
    /// </summary>
    [JsonPropertyName("meters")]
    public string Meters { get; set; }
}