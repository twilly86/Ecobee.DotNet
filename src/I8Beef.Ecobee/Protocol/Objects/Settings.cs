﻿using System.Text.Json.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API settings.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// The current HVAC mode the thermostat is in. Values: auto, auxHeatOnly, cool, heat, off.
        /// </summary>
        [JsonPropertyName("hvacMode")]
        public string HvacMode { get; set; }

        /// <summary>
        /// The last service date of the HVAC equipment.
        /// </summary>
        [JsonPropertyName("lastServiceDate")]
        public string LastServiceDate { get; set; }

        /// <summary>
        /// Whether to send an alert when service is required again.
        /// </summary>
        [JsonPropertyName("serviceRemindMe")]
        public bool? ServiceRemindMe { get; set; }

        /// <summary>
        /// The user configured monthly interval between HVAC service reminders
        /// </summary>
        [JsonPropertyName("monthsBetweenService")]
        public int? MonthsBetweenService { get; set; }

        /// <summary>
        /// Date to be reminded about the next HVAC service date.
        /// </summary>
        [JsonPropertyName("remindMeDate")]
        public string RemindMeDate { get; set; }

        /// <summary>
        /// The ventilator mode. Values: auto, minontime, on, off.
        /// </summary>
        [JsonPropertyName("vent")]
        public string Vent { get; set; }

        /// <summary>
        /// The minimum time in minutes the ventilator is configured to run. The thermostat will
        /// always guarantee that the ventilator runs for this minimum duration whenever engaged.
        /// </summary>
        [JsonPropertyName("ventilatorMinOnTime")]
        public int? VentilatorMinOnTime { get; set; }

        /// <summary>
        /// Whether the technician associated with this thermostat should receive the HVAC service
        /// reminders as well.
        /// </summary>
        [JsonPropertyName("serviceRemindTechnician")]
        public bool? ServiceRemindTechnician { get; set; }

        /// <summary>
        /// A note about the physical location where the SMART or EMS Equipment Interface module is
        /// located.
        /// </summary>
        [JsonPropertyName("eiLocation")]
        public string EiLocation { get; set; }

        /// <summary>
        /// The temperature at which a cold temp alert is triggered.
        /// </summary>
        [JsonPropertyName("coldTempAlert")]
        public int? ColdTempAlert { get; set; }

        /// <summary>
        /// Whether cold temperature alerts are enabled.
        /// </summary>
        [JsonPropertyName("coldTempAlertEnabled")]
        public bool? ColdTempAlertEnabled { get; set; }

        /// <summary>
        /// The temperature at which a hot temp alert is triggered.
        /// </summary>
        [JsonPropertyName("hotTempAlert")]
        public int? HotTempAlert { get; set; }

        /// <summary>
        /// Whether hot temperature alerts are enabled.
        /// </summary>
        [JsonPropertyName("hotTempAlertEnabled")]
        public bool? HotTempAlertEnabled { get; set; }

        /// <summary>
        /// The number of cool stages the connected HVAC equipment supports.
        /// </summary>
        [JsonPropertyName("coolStages")]
        public int? CoolStages { get; set; }

        /// <summary>
        /// The number of heat stages the connected HVAC equipment supports.
        /// </summary>
        [JsonPropertyName("heatStages")]
        public int? HeatStages { get; set; }

        /// <summary>
        /// The maximum automated set point? Set back offset allowed in degrees.
        /// </summary>
        [JsonPropertyName("maxSetBack")]
        public int? MaxSetBack { get; set; }

        /// <summary>
        /// The maximum automated set point? Set forward offset allowed in degrees.
        /// </summary>
        [JsonPropertyName("maxSetForward")]
        public int? MaxSetForward { get; set; }

        /// <summary>
        /// The set point? Set back offset, in degrees, configured for a quick save event.
        /// </summary>
        [JsonPropertyName("quickSaveSetBack")]
        public int? QuickSaveSetBack { get; set; }

        /// <summary>
        /// The set point? Set forward offset, in degrees, configured for a quick save event.
        /// </summary>
        [JsonPropertyName("quickSaveSetForward")]
        public int? QuickSaveSetForward { get; set; }

        /// <summary>
        /// Whether the thermostat is controlling a heat pump.
        /// </summary>
        [JsonPropertyName("hasHeatPump")]
        public bool? HasHeatPump { get; set; }

        /// <summary>
        /// Whether the thermostat is controlling a forced air furnace.
        /// </summary>
        [JsonPropertyName("hasForcedAir")]
        public bool? HasForcedAir { get; set; }

        /// <summary>
        /// Whether the thermostat is controlling a boiler.
        /// </summary>
        [JsonPropertyName("hasBoiler")]
        public bool? HasBoiler { get; set; }

        /// <summary>
        /// Whether the thermostat is controlling a humidifier.
        /// </summary>
        [JsonPropertyName("hasHumidifier")]
        public bool? HasHumidifier { get; set; }

        /// <summary>
        /// Whether the thermostat is controlling an energy recovery ventilator.
        /// </summary>
        [JsonPropertyName("hasErv")]
        public bool? HasErv { get; set; }

        /// <summary>
        /// Whether the thermostat is controlling a heat recovery ventilator.
        /// </summary>
        [JsonPropertyName("hasHrv")]
        public bool? HasHrv { get; set; }

        /// <summary>
        /// Whether the thermostat is in frost control mode.
        /// </summary>
        [JsonPropertyName("condensationAvoid")]
        public bool? CondensationAvoid { get; set; }

        /// <summary>
        /// Whether the thermostat is configured to report in degrees Celcius.
        /// </summary>
        [JsonPropertyName("useCelsius")]
        public bool? UseCelsius { get; set; }

        /// <summary>
        /// Whether the thermostat is using 12hr time format.
        /// </summary>
        [JsonPropertyName("useTimeFormat12")]
        public bool? UseTimeFormat12 { get; set; }

        /// <summary>
        /// Multilanguage support, currently only "en" - english is supported. In future others
        /// locales can be supported.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The minimum humidity level (in percent) set point? For the humidifier
        /// </summary>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// The humidifier mode. Values: auto, manual, off.
        /// </summary>
        [JsonPropertyName("humidifierMode")]
        public string HumidifierMode { get; set; }

        /// <summary>
        /// The thermostat backlight intensity when on. A value between 0 and 10, with 0 meaning
        /// 'off' - the zero value may not be honored by all ecobee versions.
        /// </summary>
        [JsonPropertyName("backlightOnIntensity")]
        public int? BacklightOnIntensity { get; set; }

        /// <summary>
        /// The thermostat backlight intensity when asleep. A value between 0 and 10, with 0 meaning
        /// 'off' - the zero value may not be honored by all ecobee versions.
        /// </summary>
        [JsonPropertyName("backlightSleepIntensity")]
        public int? BacklightSleepIntensity { get; set; }

        /// <summary>
        /// The time in seconds before the thermostat screen goes into sleep mode.
        /// </summary>
        [JsonPropertyName("backlightOffTime")]
        public int? BacklightOffTime { get; set; }

        /// <summary>
        /// The volume level for key presses on the thermostat. A value between 0 and 10, with 0 meaning
        /// 'off' - the zero value may not be honored by all ecobee versions.
        /// </summary>
        [JsonPropertyName("soundTickVolume")]
        public int? SoundTickVolume { get; set; }

        /// <summary>
        /// The volume level for alerts on the thermostat. A value between 0 and 10, with 0 meaning
        /// 'off' - the zero value may not be honored by all ecobee versions.
        /// </summary>
        [JsonPropertyName("soundAlertVolume")]
        public int? SoundAlertVolume { get; set; }

        /// <summary>
        /// The minimum time the compressor must be off for in order to prevent short-cycling.
        /// </summary>
        [JsonPropertyName("compressorProtectionMinTime")]
        public int? CompressorProtectionMinTime { get; set; }

        /// <summary>
        /// The minimum outdoor temperature that the compressor can operate at - applies more to air
        /// source heat pumps than geothermal.
        /// </summary>
        [JsonPropertyName("compressorProtectionMinTemp")]
        public int? CompressorProtectionMinTemp { get; set; }

        /// <summary>
        /// The difference between current temperature and set-point? That will trigger stage 2 heating.
        /// </summary>
        [JsonPropertyName("stage1HeatingDifferentialTemp")]
        public int? Stage1HeatingDifferentialTemp { get; set; }

        /// <summary>
        /// The difference between current temperature and set-point? That will trigger stage 2 cooling.
        /// </summary>
        [JsonPropertyName("stage1CoolingDifferentialTemp")]
        public int? Stage1CoolingDifferentialTemp { get; set; }

        /// <summary>
        /// The time after a heating cycle that the fan will run for to extract any heating left in
        /// the system - 30 second default.
        /// </summary>
        [JsonPropertyName("stage1HeatingDissipationTime")]
        public int? Stage1HeatingDissipationTime { get; set; }

        /// <summary>
        /// The time after a cooling cycle that the fan will run for to extract any cooling left in the
        /// system - 30 second default (for not)
        /// </summary>
        [JsonPropertyName("stage1CoolingDissipationTime")]
        public int? Stage1CoolingDissipationTime { get; set; }

        /// <summary>
        /// The flag to tell if the heat pump is in heating mode or in cooling when the relay is engaged.
        /// If set to zero it's heating when the reversing valve is open, cooling when closed and if it's
        /// one - it's the opposite.
        /// </summary>
        [JsonPropertyName("heatPumpReversalOnCool")]
        public bool? HeatPumpReversalOnCool { get; set; }

        /// <summary>
        /// Whether fan control by the Thermostat is required in auxiliary heating (gas/electric/boiler),
        /// otherwise controlled by furnace.
        /// </summary>
        [JsonPropertyName("fanControlRequired")]
        public bool? FanControlRequired { get; set; }

        /// <summary>
        /// The minimum time, in minutes, to run the fan each hour. Value from 1 to 60.
        /// </summary>
        [JsonPropertyName("fanMinOnTime")]
        public int? FanMinOnTime { get; set; }

        /// <summary>
        /// The minimum temperature difference between the heat and cool values. Used to ensure that
        /// when thermostat is in auto mode, the heat and cool values are separated by at least this value.
        /// </summary>
        [JsonPropertyName("heatCoolMinDelta")]
        public int? HeatCoolMinDelta { get; set; }

        /// <summary>
        /// The amount to adjust the temperature reading in degrees F - this value is subtracted from
        /// the temperature read from the sensor.
        /// </summary>
        [JsonPropertyName("tempCorrection")]
        public int? TempCorrection { get; set; }

        /// <summary>
        /// The default end time setting the thermostat applies to user temperature holds. Values
        /// useEndTime4hour, useEndTime2hour (EMS Only), nextPeriod, indefinite, askMe
        /// </summary>
        [JsonPropertyName("holdAction")]
        public string HoldAction { get; set; }

        /// <summary>
        /// Whether the Thermostat uses a geothermal / ground source heat pump.
        /// </summary>
        [JsonPropertyName("heatPumpGroundWater")]
        public bool? HeatPumpGroundWater { get; set; }

        /// <summary>
        /// Whether the thermostat is connected to an electric HVAC system.
        /// </summary>
        [JsonPropertyName("hasElectric")]
        public bool? HasElectric { get; set; }

        /// <summary>
        /// Whether the thermostat is connected to a dehumidifier. If true or dehumidifyOvercoolOffset > 0
        /// then allow setting dehumidifierMode and dehumidifierLevel.
        /// </summary>
        [JsonPropertyName("hasDehumidifier")]
        public bool? HasDehumidifier { get; set; }

        /// <summary>
        /// The dehumidifier mode. Values: on, off. If set to off then the dehumidifier will not run,
        /// nor will the AC overcool run.
        /// </summary>
        [JsonPropertyName("dehumidifierMode")]
        public string DehumidifierMode { get; set; }

        /// <summary>
        /// The dehumidification set point? in percentage.
        /// </summary>
        [JsonPropertyName("dehumidifierLevel")]
        public int? DehumidifierLevel { get; set; }

        /// <summary>
        /// Whether the thermostat should use AC overcool to dehumidify. When set to true a postive
        /// integer value must be supplied for dehumidifyOvercoolOffset otherwise an API validation
        /// exception will be thrown.
        /// </summary>
        [JsonPropertyName("dehumidifyWithAC")]
        public bool? DehumidifyWithAC { get; set; }

        /// <summary>
        /// Whether the thermostat should use AC overcool to dehumidify and what that temperature
        /// offset should be. A value of 0 means this feature is disabled and dehumidifyWithAC will
        /// be set to false. Value represents the value in F to subract from the current set point.
        /// Values should be in the range 0 - 50 and be divisible by 5.
        /// </summary>
        [JsonPropertyName("dehumidifyOvercoolOffset")]
        public int? DehumidifyOvercoolOffset { get; set; }

        /// <summary>
        /// If enabled, allows the Thermostat to be put in HVACAuto mode.
        /// </summary>
        [JsonPropertyName("autoHeatCoolFeatureEnabled")]
        public bool? AutoHeatCoolFeatureEnabled { get; set; }

        /// <summary>
        /// Whether the alert for when wifi is offline is enabled.
        /// </summary>
        [JsonPropertyName("wifiOfflineAlert")]
        public bool? WifiOfflineAlert { get; set; }

        /// <summary>
        /// The minimum heat set point? Allowed by the thermostat firmware.
        /// </summary>
        [JsonPropertyName("heatMinTemp")]
        public int? HeatMinTemp { get; set; }

        /// <summary>
        /// The maximum heat set point? Allowed by the thermostat firmware.
        /// </summary>
        [JsonPropertyName("heatMaxTemp")]
        public int? HeatMaxTemp { get; set; }

        /// <summary>
        /// The minimum cool set point? Allowed by the thermostat firmware.
        /// </summary>
        [JsonPropertyName("coolMinTemp")]
        public int? CoolMinTemp { get; set; }

        /// <summary>
        /// The maximum cool set point? Allowed by the thermostat firmware.
        /// </summary>
        [JsonPropertyName("coolMaxTemp")]
        public int? CoolMaxTemp { get; set; }

        /// <summary>
        /// The maximum heat set point? Configured by the user's preferences.
        /// </summary>
        [JsonPropertyName("heatRangeHigh")]
        public int? HeatRangeHigh { get; set; }

        /// <summary>
        /// The minimum heat set point? Configured by the user's preferences.
        /// </summary>
        [JsonPropertyName("heatRangeLow")]
        public int? HeatRangeLow { get; set; }

        /// <summary>
        /// The maximum cool set point? Configured by the user's preferences.
        /// </summary>
        [JsonPropertyName("coolRangeHigh")]
        public int? CoolRangeHigh { get; set; }

        /// <summary>
        /// The minimum heat set point? Configured by the user's preferences.
        /// </summary>
        [JsonPropertyName("coolRangeLow")]
        public int? CoolRangeLow { get; set; }

        /// <summary>
        /// The user access code value for this thermostat. See the SecuritySettings object for
        /// more information.
        /// </summary>
        [JsonPropertyName("userAccessCode")]
        public string UserAccessCode { get; set; }

        /// <summary>
        /// The integer representation of the user access settings. See the SecuritySettings object
        /// for more information.
        /// </summary>
        [JsonPropertyName("userAccessSetting")]
        public int? UserAccessSetting { get; set; }

        /// <summary>
        /// The temperature at which an auxHeat temperature alert is triggered.
        /// </summary>
        [JsonPropertyName("auxRuntimeAlert")]
        public int? AuxRuntimeAlert { get; set; }

        /// <summary>
        /// The temperature at which an auxOutdoor temperature alert is triggered.
        /// </summary>
        [JsonPropertyName("auxOutdoorTempAlert")]
        public int? AuxOutdoorTempAlert { get; set; }

        /// <summary>
        /// The maximum outdoor temperature above which aux heat will not run.
        /// </summary>
        [JsonPropertyName("auxMaxOutdoorTemp")]
        public int? AuxMaxOutdoorTemp { get; set; }

        /// <summary>
        /// Whether the auxHeat temperature alerts are enabled.
        /// </summary>
        [JsonPropertyName("auxRuntimeAlertNotify")]
        public bool? AuxRuntimeAlertNotify { get; set; }

        /// <summary>
        /// Whether the auxOutdoor temperature alerts are enabled.
        /// </summary>
        [JsonPropertyName("auxOutdoorTempAlertNotify")]
        public bool? AuxOutdoorTempAlertNotify { get; set; }

        /// <summary>
        /// Whether the auxHeat temperature alerts for the technician are enabled.
        /// </summary>
        [JsonPropertyName("auxRuntimeAlertNotifyTechnician")]
        public bool? AuxRuntimeAlertNotifyTechnician { get; set; }

        /// <summary>
        /// Whether the auxOutdoor temperature alerts for the technician are enabled.
        /// </summary>
        [JsonPropertyName("auxOutdoorTempAlertNotifyTechnician")]
        public bool? AuxOutdoorTempAlertNotifyTechnician { get; set; }

        /// <summary>
        /// Whether the thermostat should use pre heating to reach the set point? on time.
        /// </summary>
        [JsonPropertyName("disablePreHeating")]
        public bool? DisablePreHeating { get; set; }

        /// <summary>
        /// Whether the thermostat should use pre cooling to reach the set point? on time.
        /// </summary>
        [JsonPropertyName("disablePreCooling")]
        public bool? DisablePreCooling { get; set; }

        /// <summary>
        /// Whether an installer code is required.
        /// </summary>
        [JsonPropertyName("installerCodeRequired")]
        public bool? InstallerCodeRequired { get; set; }

        /// <summary>
        /// Whether Demand Response requests are accepted by this thermostat. Possible values are:
        /// always, askMe, customerSelect, defaultAccept, defaultDecline, never.
        /// </summary>
        [JsonPropertyName("drAccept")]
        public string DrAccept { get; set; }

        /// <summary>
        /// Whether the property is a rental, or not.
        /// </summary>
        [JsonPropertyName("isRentalProperty")]
        public bool? IsRentalProperty { get; set; }

        /// <summary>
        /// Whether to use a zone controller or not.
        /// </summary>
        [JsonPropertyName("useZoneController")]
        public bool? UseZoneController { get; set; }

        /// <summary>
        /// Whether random start delay is enabled for cooling.
        /// </summary>
        [JsonPropertyName("randomStartDelayCool")]
        public int? RandomStartDelayCool { get; set; }

        /// <summary>
        /// Whether random start delay is enabled for heating.
        /// </summary>
        [JsonPropertyName("randomStartDelayHeat")]
        public int? RandomStartDelayHeat { get; set; }

        /// <summary>
        /// The humidity level to trigger a high humidity alert.
        /// </summary>
        [JsonPropertyName("humidityHighAlert")]
        public int? HumidityHighAlert { get; set; }

        /// <summary>
        /// The humidity level to trigger a low humidity alert.
        /// </summary>
        [JsonPropertyName("humidityLowAlert")]
        public int? HumidityLowAlert { get; set; }

        /// <summary>
        /// Whether heat pump alerts are disabled.
        /// </summary>
        [JsonPropertyName("disableHeatPumpAlerts")]
        public bool? DisableHeatPumpAlerts { get; set; }

        /// <summary>
        /// Whether alerts are disabled from showing on the thermostat.
        /// </summary>
        [JsonPropertyName("disableAlertsOnIdt")]
        public bool? DisableAlertsOnIdt { get; set; }

        /// <summary>
        /// Whether humidification alerts are enabled to the thermsotat owner.
        /// </summary>
        [JsonPropertyName("humidityAlertNotify")]
        public bool? HumidityAlertNotify { get; set; }

        /// <summary>
        /// Whether humidification alerts are enabled to the technician associated with the thermsotat.
        /// </summary>
        [JsonPropertyName("humidityAlertNotifyTechnician")]
        public bool? HumidityAlertNotifyTechnician { get; set; }

        /// <summary>
        /// Whether temperature alerts are enabled to the thermsotat owner.
        /// </summary>
        [JsonPropertyName("tempAlertNotify")]
        public bool? TempAlertNotify { get; set; }

        /// <summary>
        /// Whether temperature alerts are enabled to the technician associated with the thermostat.
        /// </summary>
        [JsonPropertyName("tempAlertNotifyTechnician")]
        public bool? TempAlertNotifyTechnician { get; set; }

        /// <summary>
        /// The dollar amount the owner specifies for their desired maximum electricy bill.
        /// </summary>
        [JsonPropertyName("monthlyElectricityBillLimit")]
        public int? MonthlyElectricityBillLimit { get; set; }

        /// <summary>
        /// Whether electricity bill alerts are enabled.
        /// </summary>
        [JsonPropertyName("enableElectricityBillAlert")]
        public bool? EnableElectricityBillAlert { get; set; }

        /// <summary>
        /// Whether electricity bill projection alerts are enabled
        /// </summary>
        [JsonPropertyName("enableProjectedElectricityBillAlert")]
        public bool? EnableProjectedElectricityBillAlert { get; set; }

        /// <summary>
        /// The day of the month the owner's electricty usage is billed.
        /// </summary>
        [JsonPropertyName("electricityBillingDayOfMonth")]
        public int? ElectricityBillingDayOfMonth { get; set; }

        /// <summary>
        /// The owners billing cycle duration in months.
        /// </summary>
        [JsonPropertyName("electricityBillCycleMonths")]
        public int? ElectricityBillCycleMonths { get; set; }

        /// <summary>
        /// The annual start month of the owners billing cycle.
        /// </summary>
        [JsonPropertyName("electricityBillStartMonth")]
        public int? ElectricityBillStartMonth { get; set; }

        /// <summary>
        /// The number of minutes to run ventilator per hour when home.
        /// </summary>
        [JsonPropertyName("ventilatorMinOnTimeHome")]
        public int? VentilatorMinOnTimeHome { get; set; }

        /// <summary>
        /// The number of minutes to run ventilator per hour when away.
        /// </summary>
        [JsonPropertyName("ventilatorMinOnTimeAway")]
        public int? VentilatorMinOnTimeAway { get; set; }

        /// <summary>
        /// Determines whether or not to turn the backlight off during sleep.
        /// </summary>
        [JsonPropertyName("backlightOffDuringSleep")]
        public bool? BacklightOffDuringSleep { get; set; }

        /// <summary>
        /// When set to true if no occupancy motion detected thermostat will go into indefinite
        /// away hold, until either the user presses resume schedule or motion is detected.
        /// </summary>
        [JsonPropertyName("autoAway")]
        public bool? AutoAway { get; set; }

        /// <summary>
        /// When set to true if a larger than normal delta is found between sensors the fan will be
        /// engaged for 15min/hour.
        /// </summary>
        [JsonPropertyName("smartCirculation")]
        public bool? SmartCirculation { get; set; }

        /// <summary>
        /// When set to true if a sensor has detected presense for more than 10 minutes then include that
        /// sensor in temp average. If no activity has been seen on a sensor for more than 1 hour then
        /// remove this sensor from temperature average.
        /// </summary>
        [JsonPropertyName("followMeComfort")]
        public bool? FollowMeComfort { get; set; }

        /// <summary>
        /// This read-only field represents the type of ventilator present for the Thermostat. The
        /// possible values are none, ventilator, hrv, and erv.
        /// </summary>
        [JsonPropertyName("ventilatorType")]
        public string VentilatorType { get; set; }

        /// <summary>
        /// This Boolean field represents whether the ventilator timer is on or off. The default value is
        /// false. If set to true the ventilatorOffDateTime is set to now() + 20 minutes. If set to false
        /// the ventilatorOffDateTime is set to it's default value.
        /// </summary>
        [JsonPropertyName("isVentilatorTimerOn")]
        public bool? IsVentilatorTimerOn { get; set; }

        /// <summary>
        /// This read-only field represents the Date and Time the ventilator will run until. The default
        /// value is 2014-01-01 00:00:00.
        /// </summary>
        [JsonPropertyName("ventilatorOffDateTime")]
        public string VentilatorOffDateTime { get; set; }

        /// <summary>
        /// This Boolean field represents whether the HVAC system has a UV filter. The default value is true.
        /// </summary>
        [JsonPropertyName("hasUVFilter")]
        public bool? HasUVFilter { get; set; }

        /// <summary>
        /// This field represents whether to permit the cooling to operate when the Outdoor temeperature is
        /// under a specific threshold, currently 55F. The default value is false.
        /// </summary>
        [JsonPropertyName("coolingLockout")]
        public bool? CoolingLockout { get; set; }

        /// <summary>
        /// Whether to use the ventilator to dehumidify when climate or calendar event indicates the owner is
        /// home. The default value is false.
        /// </summary>
        [JsonPropertyName("ventilatorFreeCooling")]
        public bool? VentilatorFreeCooling { get; set; }

        /// <summary>
        /// This field represents whether to permit dehumidifer to operate when the heating is running.
        /// The default value is false.
        /// </summary>
        [JsonPropertyName("dehumidifyWhenHeating")]
        public bool? DehumidifyWhenHeating { get; set; }

        /// <summary>
        /// This field represents whether or not to allow dehumification when cooling. The default value
        /// is true.
        /// </summary>
        [JsonPropertyName("ventilatorDehumidify")]
        public bool? VentilatorDehumidify { get; set; }

        /// <summary>
        /// The unique reference to the group this thermostat belongs to, if any. See GET Group request and
        /// POST Group request for more information.
        /// </summary>
        [JsonPropertyName("groupRef")]
        public string GroupRef { get; set; }

        /// <summary>
        /// The name of the the group this thermostat belongs to, if any. See GET Group request and POST
        /// Group request for more information.
        /// </summary>
        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// The setting value for the group this thermostat belongs to, if any. See GET Group request and
        /// POST Group request for more information.
        /// </summary>
        [JsonPropertyName("groupSetting")]
        public int? GroupSetting { get; set; }
    }
}
