﻿using I8Beef.Ecobee.Protocol.Objects;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions;

/// <summary>
/// Ecobee API resume program params.
/// </summary>
public class ResumeProgramParams : FunctionParams
{
    /// <summary>
    /// Should the thermostat be resumed to next event (false) or to it's program (true).
    /// </summary>
    [JsonPropertyName("resumeAll")]
    public bool? ResumeAll { get; set; }
}