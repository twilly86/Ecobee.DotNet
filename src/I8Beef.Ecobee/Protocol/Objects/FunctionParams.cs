using System.Text.Json.Serialization;
using I8Beef.Ecobee.Protocol.Functions;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API function params base class.
/// </summary>
[JsonDerivedType(typeof(UnlinkVoiceEngineParams))]
[JsonDerivedType(typeof(SetOccupiedParams))]
[JsonDerivedType(typeof(UpdateSensorParams))]
[JsonDerivedType(typeof(AcknowledgeParams))]
[JsonDerivedType(typeof(ControlPlugParams))]
[JsonDerivedType(typeof(CreateVacationParams))]
[JsonDerivedType(typeof(DeleteVacationParams))]
[JsonDerivedType(typeof(ResetPreferencesParams))]
[JsonDerivedType(typeof(ResumeProgramParams))]
[JsonDerivedType(typeof(SendMessageParams))]
[JsonDerivedType(typeof(SetHoldParams))]
public abstract class FunctionParams
{
}