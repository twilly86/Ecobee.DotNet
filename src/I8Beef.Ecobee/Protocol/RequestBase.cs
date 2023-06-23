using I8Beef.Ecobee.Protocol.Report;
using System;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol;

/// <summary>
/// Base class for Ecobee API requests.
/// </summary>
[JsonDerivedType(typeof(MeterReportRequest))]
public abstract class RequestBase
{
    /// <summary>
    /// Request URI.
    /// </summary>
    public abstract string Uri { get; }

    /// <summary>
    /// Request type (GET or POST).
    /// </summary>
    public abstract RequestType RequestType { get; }

    /// <summary>
    /// Type to deserialize the response to.
    /// </summary>
    public abstract Type ResponseType { get; }
}