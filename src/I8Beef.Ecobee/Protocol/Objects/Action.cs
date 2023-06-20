using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API action.
    /// </summary>
    public class Action
    {
        /// <summary>
        /// Values: activateRelay, adjustTemp, doNothing, shutdownAC, shutdownAuxHeat,
        /// shutdownSystem, shutdownCompression, switchToOccupied, switchToUnoccupied,
        /// turnOffDehumidifer, turnOffHumidifier, turnOnCool, turnOnDehumidifier,
        /// turnOnFan, turnOnHeat, turnOnHumidifier.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Flag to enable an alert to be generated when the state is triggered.
        /// </summary>
        [JsonPropertyName("sendAlert")]
        public bool? SendAlert { get; set; }

        /// <summary>
        /// Whether to send an update message.
        /// </summary>
        [JsonPropertyName("sendUpdate")]
        public bool? SendUpdate { get; set; }

        /// <summary>
        /// Delay in seconds before the action is triggered by the state change.
        /// </summary>
        [JsonPropertyName("activationDelay")]
        public int? ActivationDelay { get; set; }

        /// <summary>
        /// The amount of time to wait before deactivating this state after the state has been cleared.
        /// </summary>
        [JsonPropertyName("deactivationDelay")]
        public int? DeactivationDelay { get; set; }

        /// <summary>
        /// The minimum length of time to maintain action after sensor has been deactivated.
        /// </summary>
        [JsonPropertyName("minActionDuration")]
        public int? MinActionDuration { get; set; }

        /// <summary>
        /// The amount to increase/decrease current setpoint? if the type = adjustTemp.
        /// </summary>
        [JsonPropertyName("heatAdjustTemp")]
        public int? HeatAdjustTemp { get; set; }

        /// <summary>
        /// The amount to increase/decrease current setpoint? if the type = adjustTemp.
        /// </summary>
        [JsonPropertyName("coolAdjustTemp")]
        public int? CoolAdjustTemp { get; set; }

        /// <summary>
        /// The user defined relay to be activated, only used for type == activateRelay.
        /// </summary>
        [JsonPropertyName("activateRelay")]
        public string ActivateRelay { get; set; }

        /// <summary>
        /// Select if relay is to be open or closed when activated, only used for type == activateRelay.
        /// </summary>
        [JsonPropertyName("activateRelayOpen")]
        public bool? ActivateRelayOpen { get; set; }
    }
}
