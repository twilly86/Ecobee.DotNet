using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects;

/// <summary>
/// Ecobee API alert.
/// </summary>
public class Alert
{
    /// <summary>
    /// The acknowledge ref of the alert.
    /// </summary>
    [JsonPropertyName("acknowledgeRef")]
    public string AcknowledgeRef { get; set; }

    /// <summary>
    /// The date of the alert.
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; }

    /// <summary>
    /// The time of the alert.
    /// </summary>
    [JsonPropertyName("time")]
    public string Time { get; set; }

    /// <summary>
    /// The saverity of the alert.
    /// </summary>
    [JsonPropertyName("severity")]
    public string Severity { get; set; }

    /// <summary>
    /// The text of the alert.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// The number of the alert.
    /// </summary>
    [JsonPropertyName("alertNumber")]
    public int? AlertNumber { get; set; }

    /// <summary>
    /// The type of the alert.
    /// </summary>
    [JsonPropertyName("alertType")]
    public string AlertType { get; set; }

    /// <summary>
    /// Whether alert is an operator alert.
    /// </summary>
    [JsonPropertyName("isOperatorAlert")]
    public bool? IsOperatorAlert { get; set; }

    /// <summary>
    /// The reminder of the alert.
    /// </summary>
    [JsonPropertyName("reminder")]
    public string Reminder { get; set; }

    /// <summary>
    /// Whether to show the alert in Idt.
    /// </summary>
    [JsonPropertyName("showIdt")]
    public bool? ShowIdt { get; set; }

    /// <summary>
    /// Whether to show the alert on the web.
    /// </summary>
    [JsonPropertyName("showWeb")]
    public bool? ShowWeb { get; set; }

    /// <summary>
    /// Whether to send and email for the alert.
    /// </summary>
    [JsonPropertyName("sendEmail")]
    public bool? SendEmail { get; set; }

    /// <summary>
    /// Acknowledgement of the alert.
    /// </summary>
    [JsonPropertyName("acknowledgement")]
    public string Acknowledgement { get; set; }

    /// <summary>
    /// Whether to remind about the alert later.
    /// </summary>
    [JsonPropertyName("remindMeLater")]
    public bool? RemindMeLater { get; set; }

    /// <summary>
    /// The thermostat identifier.
    /// </summary>
    [JsonPropertyName("thermostatIdentifier")]
    public string ThermostatIdentifier { get; set; }

    /// <summary>
    /// The notification type of the alert.
    /// </summary>
    [JsonPropertyName("notificationType")]
    public string NotificationType { get; set; }
}