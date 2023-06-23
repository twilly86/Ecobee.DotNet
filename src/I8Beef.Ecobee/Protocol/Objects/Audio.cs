using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API Audio.
/// </summary>
public class Audio
{
    /// <summary>
    /// The volume level for audio playback. This includes volume of the voice
    /// assistant. A value between 0 and 100.
    /// </summary>
    [JsonPropertyName("playbackVolume")]
    public int? PlaybackVolume { get; set; }

    /// <summary>
    /// Turn microphone (privacy mode) on and off.
    /// </summary>
    [JsonPropertyName("microphoneEnabled	")]
    public bool? MicrophoneEnabled { get; set; }

    /// <summary>
    /// The volume level for alerts on the thermostat. A value between 0 and 10, with 0
    /// meaning 'off' - the zero value may not be honored by all ecobee versions.
    /// </summary>
    [JsonPropertyName("soundAlertVolume")]
    public int? SoundAlertVolume { get; set; }

    /// <summary>
    /// The volume level for key presses on the thermostat. A value between 0 and 10,
    /// with 0 meaning 'off' - the zero value may not be honored by all ecobee versions.
    /// </summary>
    [JsonPropertyName("soundTickVolume")]
    public int? SoundTickVolume { get; set; }

    /// <summary>
    /// The list of voice engines compatible with the selected thermostat.
    /// </summary>
    [JsonPropertyName("voiceEngines")]
    public IList<VoiceEngine> VoiceEngines { get; set; }
}