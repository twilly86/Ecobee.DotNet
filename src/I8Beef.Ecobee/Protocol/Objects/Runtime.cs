using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
#pragma warning disable CS1591

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API runtime.
    /// </summary>
    public class Runtime
    {
        /// <summary>
        /// The current runtime revision. Equivalent in meaning to the runtime revision number
        /// in the thermostat summary call.
        /// </summary>
        [JsonPropertyName("runtimeRev")]
        public string RuntimeRev { get; set; }

        /// <summary>
        /// Whether the thermostat is currently connected to the server.
        /// </summary>
        [JsonPropertyName("connected")]
        public bool? Connected { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat first connected to the ecobee server.
        /// </summary>
        [JsonPropertyName("firstConnected")]
        public string FirstConnected { get; set; }

        /// <summary>
        /// The last recorded connection date and time.
        /// </summary>
        [JsonPropertyName("connectDateTime")]
        public string ConnectDateTime { get; set; }

        /// <summary>
        /// The last recorded disconnection date and time.
        /// </summary>
        [JsonPropertyName("disconnectDateTime")]
        public string DisconnectDateTime { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat was updated. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat last posted its runtime information.
        /// Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonPropertyName("lastStatusModified")]
        public string LastStatusModified { get; set; }

        /// <summary>
        /// The UTC date of the last runtime reading. Format: YYYY-MM-DD
        /// </summary>
        [JsonPropertyName("runtimeDate")]
        public string RuntimeDate { get; set; }

        /// <summary>
        /// The last 5 minute interval which was updated by the thermostat telemetry update. Subtract 2
        /// from this interval to obtain the beginning interval for the last 3 readings. Multiply by 5
        /// mins to obtain the minutes of the day. Range: 0-287
        /// </summary>
        [JsonPropertyName("runtimeInterval")]
        public int? RuntimeInterval { get; set; }

        /// <summary>
        /// The current temperature displayed on the thermostat.
        /// </summary>
        [JsonPropertyName("actualTemperature")]
        public int? ActualTemperature { get; set; }

        /// <summary>
        /// The current humidity % shown on the thermostat.
        /// </summary>
        [JsonPropertyName("actualHumidity")]
        public int? ActualHumidity { get; set; }

        /// <summary>
        /// The desired heat temperature as per the current running program or active event.
        /// </summary>
        [JsonPropertyName("desiredHeat")]
        public int? DesiredHeat { get; set; }

        /// <summary>
        /// The desired cool temperature as per the current running program or active event.
        /// </summary>
        [JsonPropertyName("desiredCool")]
        public int? DesiredCool { get; set; }

        /// <summary>
        /// The desired humidity set point.
        /// </summary>
        [JsonPropertyName("desiredHumidity")]
        public int? DesiredHumidity { get; set; }

        /// <summary>
        /// The desired dehumidification set point.
        /// </summary>
        [JsonPropertyName("desiredDehumidity")]
        public int? DesiredDehumidity { get; set; }

        /// <summary>
        /// The desired fan mode. Values: auto, on or null if the HVAC system is off and the thermostat
        /// is not controlling a fan independently.
        /// </summary>
        [JsonPropertyName("desiredFanMode")]
        public string DesiredFanMode { get; set; }

        /// <summary>
        /// This field provides the possible valid range for which a desiredHeat setpoint? can be set to.
        /// This value takes into account the thermostat heat temperature limits as well the running
        /// program or active events. Values are returned as an Integer array representing the canonical
        /// minimum and maximim, e.g. [450,790].
        /// </summary>
        [JsonPropertyName("desiredHeatRange")]
        public IList<int> DesiredHeatRange { get; set; }

        /// <summary>
        /// This field provides the possible valid range for which a desiredCool setpoint? can be set to.
        /// This value takes into account the thermostat cool temperature limits as well the running program
        /// or active events. Values are returned as an Integer array representing the canonical minimum and
        /// maximim, e.g. [650,920].
        /// </summary>
        [JsonPropertyName("desiredCoolRange")]
        public IList<int> DesiredCoolRange { get; set; }
         
        [JsonPropertyName("rawTemperature")]
        public long RawTemperature { get; set; }

        [JsonPropertyName("showIconMode")]
        public long ShowIconMode { get; set; }
         

        [JsonPropertyName("actualVOC")]
        public long ActualVoc { get; set; }

        [JsonPropertyName("actualCO2")]
        public long ActualCo2 { get; set; }

        [JsonPropertyName("actualAQAccuracy")]
        public long ActualAqAccuracy { get; set; }

        [JsonPropertyName("actualAQScore")]
        public long ActualAqScore { get; set; } 
    }
}
