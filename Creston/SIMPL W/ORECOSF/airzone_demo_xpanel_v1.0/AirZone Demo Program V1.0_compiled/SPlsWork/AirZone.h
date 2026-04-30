namespace AirZone.Communication.DataPackets.Commands;
        // class declarations
         class AirZoneCommand;
         class AirZoneCoolSetpointCommand;
         class AirZoneCoolStageCommand;
         class AirZoneFanSpeedCommand;
         class AirZoneHeatSetpointCommand;
         class AirZoneHeatStageCommand;
         class AirZoneIntegrationCommand;
         class AirZoneModeCommand;
         class AirZoneSetpointCommand;
         class AirzonePowerCommand;
         class RootAirZoneCommand;
           class CoolStages;
           class Speeds;
           class HeatStages;
           class Modes;
     class AirZoneCommand 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER AllZonesDefault;

        // class properties
        SIGNED_LONG_INTEGER SytemId;
        SIGNED_LONG_INTEGER ZoneId;
    };

     class RootAirZoneCommand 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace AirZone.Communication.DataPackets.Feedback;
        // class declarations
         class Data;
         class Error;
         class Response;
         class Warning;
           class Units;
     class Data 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER SystemId;
        INTEGER ZoneId;
        STRING Name[];
        Units Units;
    };

     class Error 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ZoneMessage[];
        STRING SystemMessage[];
    };

     class Response 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class Warning 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ZoneMessage[];
        STRING SystemMessage[];
    };

namespace AirZone.Helpers;
        // class declarations
         class Debouncer;
         class Ramp;
         class Modus;
    static class Modus // enum
    {
        static SIGNED_LONG_INTEGER Up;
        static SIGNED_LONG_INTEGER Down;
    };

namespace AirZone.Logic.Model.Enums;
        // class declarations
         class CoolStages;
         class HeatStages;
         class Modes;
         class SetpointMode;
         class Speeds;
         class Stages;
         class Units;
    static class CoolStages // enum
    {
        static SIGNED_LONG_INTEGER Air;
        static SIGNED_LONG_INTEGER Radiant;
        static SIGNED_LONG_INTEGER Combined;
    };

    static class HeatStages // enum
    {
        static SIGNED_LONG_INTEGER Air;
        static SIGNED_LONG_INTEGER Radiant;
        static SIGNED_LONG_INTEGER Combined;
    };

    static class Modes // enum
    {
        static SIGNED_LONG_INTEGER Stop;
        static SIGNED_LONG_INTEGER Cooling;
        static SIGNED_LONG_INTEGER Heating;
        static SIGNED_LONG_INTEGER Fan;
        static SIGNED_LONG_INTEGER Dry;
        static SIGNED_LONG_INTEGER AutoUSA;
    };

    static class SetpointMode // enum
    {
        static SIGNED_LONG_INTEGER Single;
        static SIGNED_LONG_INTEGER Dual;
    };

    static class Speeds // enum
    {
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER One;
        static SIGNED_LONG_INTEGER Two;
        static SIGNED_LONG_INTEGER Three;
        static SIGNED_LONG_INTEGER Four;
        static SIGNED_LONG_INTEGER Five;
        static SIGNED_LONG_INTEGER Six;
        static SIGNED_LONG_INTEGER Seven;
    };

    static class Stages // enum
    {
        static SIGNED_LONG_INTEGER Air;
        static SIGNED_LONG_INTEGER Radiant;
        static SIGNED_LONG_INTEGER Combined;
    };

    static class Units // enum
    {
        static SIGNED_LONG_INTEGER Celsius;
        static SIGNED_LONG_INTEGER Fahrenheit;
    };

namespace AirZone.Logic.Model;
        // class declarations
         class System;
         class Zone;
     class System 
    {
        // class delegates

        // class events
        EventHandler OnPolling ( System sender, EventArgs e );

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class Zone 
    {
        // class delegates

        // class events
        EventHandler OnPolling ( Zone sender, EventArgs e );

        // class functions
        FUNCTION ParsePollResponse ( Data zoneData );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace AirZone.Simpl;
        // class declarations
         class AirzoneInstallationSimpl;
         class AirzoneSystemSimpl;
         class AirzoneTestSimpl;
         class AirzoneZoneSimpl;
         class SimplRoot;
           class SimplUShortEventArgs;
           class SimplLicensedChangedEventArgs;
           class SimplSystemLoadedEventArgs;
           class SimplModesEventArgs;
           class SimplModeActiveEventArgs;
           class SimplSpeedsEventArgs;
           class SimplSpeedActiveEventArgs;
           class SimplZoneLoadedEventArgs;
           class SimplZoneStatusEventArgs;
           class SimplHumidityEventArgs;
           class SimplSetpointLimitEventArgs;
           class SimplNameEventArgs;
           class SimplStagesEventArgs;
           class SimplUnitEventArgs;
           class SimplErrorsEventArgs;
           class SimplWarningsEventArgs;
           class SimplSetpointEventArgs;
           class SimplPowerStatusEventArgs;
           class SimplStageActiveEventArgs;
     class AirzoneInstallationSimpl 
    {
        // class delegates

        // class events
        EventHandler OnInitializedChanged ( AirzoneInstallationSimpl sender, SimplUShortEventArgs e );
        EventHandler OnDebugStateChanged ( AirzoneInstallationSimpl sender, SimplUShortEventArgs e );
        EventHandler OnLicensedChanged ( AirzoneInstallationSimpl sender, SimplLicensedChangedEventArgs e );

        // class functions
        FUNCTION Initialize ( STRING licenseKey , STRING webServerIpAddress , INTEGER pollingIntervalInSeconds , INTEGER autoPollingEnabled );
        FUNCTION License ();
        FUNCTION ToggleDebugMode ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class AirzoneSystemSimpl 
    {
        // class delegates

        // class events
        EventHandler OnInitializedChanged ( AirzoneSystemSimpl sender, SimplUShortEventArgs e );
        EventHandler OnPolling ( AirzoneSystemSimpl sender, EventArgs e );
        EventHandler OnLoaded ( AirzoneSystemSimpl sender, SimplSystemLoadedEventArgs e );
        EventHandler OnModesChanged ( AirzoneSystemSimpl sender, SimplModesEventArgs e );
        EventHandler OnModeActiveChanged ( AirzoneSystemSimpl sender, SimplModeActiveEventArgs e );
        EventHandler OnSpeedsChanged ( AirzoneSystemSimpl sender, SimplSpeedsEventArgs e );
        EventHandler OnSpeedActiveChanged ( AirzoneSystemSimpl sender, SimplSpeedActiveEventArgs e );

        // class functions
        FUNCTION Initialize ( INTEGER systemId , INTEGER setpointMode );
        FUNCTION ManualPoll ();
        FUNCTION SetFanspeed ( INTEGER value );
        FUNCTION SetModus ( INTEGER value );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class AirzoneTestSimpl 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( STRING ipAddress );
        FUNCTION Test ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class AirzoneZoneSimpl 
    {
        // class delegates

        // class events
        EventHandler OnInitializedChanged ( AirzoneZoneSimpl sender, SimplUShortEventArgs e );
        EventHandler OnPolling ( AirzoneZoneSimpl sender, EventArgs e );
        EventHandler OnLoaded ( AirzoneZoneSimpl sender, SimplZoneLoadedEventArgs e );
        EventHandler OnStatusChanged ( AirzoneZoneSimpl sender, SimplZoneStatusEventArgs e );
        EventHandler OnHumidityChanged ( AirzoneZoneSimpl sender, SimplHumidityEventArgs e );
        EventHandler OnSetpointLimitsChanged ( AirzoneZoneSimpl sender, SimplSetpointLimitEventArgs e );
        EventHandler OnNameChanged ( AirzoneZoneSimpl sender, SimplNameEventArgs e );
        EventHandler OnModesChanged ( AirzoneZoneSimpl sender, SimplModesEventArgs e );
        EventHandler OnStagesChanged ( AirzoneZoneSimpl sender, SimplStagesEventArgs e );
        EventHandler OnSpeedsChanged ( AirzoneZoneSimpl sender, SimplSpeedsEventArgs e );
        EventHandler OnUnitChanged ( AirzoneZoneSimpl sender, SimplUnitEventArgs e );
        EventHandler OnErrorsChanged ( AirzoneZoneSimpl sender, SimplErrorsEventArgs e );
        EventHandler OnWarningsChanged ( AirzoneZoneSimpl sender, SimplWarningsEventArgs e );
        EventHandler OnSetpointStatusChanged ( AirzoneZoneSimpl sender, SimplSetpointEventArgs e );
        EventHandler OnPowerStatusChanged ( AirzoneZoneSimpl sender, SimplPowerStatusEventArgs e );
        EventHandler OnStageActiveChanged ( AirzoneZoneSimpl sender, SimplStageActiveEventArgs e );
        EventHandler OnModeActiveChanged ( AirzoneZoneSimpl sender, SimplModeActiveEventArgs e );
        EventHandler OnSpeedActiveChanged ( AirzoneZoneSimpl sender, SimplSpeedActiveEventArgs e );

        // class functions
        FUNCTION Initialize ( INTEGER systemId , INTEGER zoneId , INTEGER airStageControlEnabled , INTEGER radiantControlStageEnabled , INTEGER modeControlEnabled , INTEGER fanspeedControlEnabled );
        FUNCTION ManualPoll ();
        FUNCTION PowerToggle ();
        FUNCTION PowerOn ();
        FUNCTION PowerOff ();
        FUNCTION SetSetpoint ( INTEGER setpointScaled );
        FUNCTION SetpointUp ( INTEGER state );
        FUNCTION SetpointDown ( INTEGER state );
        FUNCTION SetFanspeed ( INTEGER value );
        FUNCTION SetModus ( INTEGER value );
        FUNCTION SetStage ( INTEGER value );
        FUNCTION SetHeatSetpoint ( INTEGER setpointScaled );
        FUNCTION HeatSetpointUp ( INTEGER state );
        FUNCTION HeatSetpointDown ( INTEGER state );
        FUNCTION SetCoolSetpoint ( INTEGER setpointScaled );
        FUNCTION CoolSetpointUp ( INTEGER state );
        FUNCTION CoolSetpointDown ( INTEGER state );
        FUNCTION FanspeedUp ( INTEGER state );
        FUNCTION FanspeedDown ( INTEGER state );
        FUNCTION SetModusWithName ( STRING modus );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SimplRoot 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace AirZone.Simpl.EventArguments;
        // class declarations
         class SimplErrorsEventArgs;
         class SimplHumidityEventArgs;
         class SimplHumidityStatusEventArgs;
         class SimplInitializedChangedEventArgs;
         class SimplLicensedChangedEventArgs;
         class SimplModeActiveEventArgs;
         class SimplModesEventArgs;
         class SimplNameEventArgs;
         class SimplPowerStatusEventArgs;
         class SimplSetpointEventArgs;
         class SimplSetpointLimitEventArgs;
         class SimplSpeedActiveEventArgs;
         class SimplSpeedsEventArgs;
         class SimplStageActiveEventArgs;
         class SimplStagesEventArgs;
         class SimplSystemLoadedEventArgs;
         class SimplTemperatureEventArgs;
         class SimplUShortEventArgs;
         class SimplUnitEventArgs;
         class SimplWarningsEventArgs;
         class SimplZoneLoadedEventArgs;
         class SimplZoneStatusEventArgs;
     class SimplErrorsEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER HasErrors;
        STRING Messages[][];
        INTEGER Count;
    };

     class SimplHumidityEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Humidity[];
        INTEGER HumidityAnalog;
        INTEGER HumidityAvailable;
    };

     class SimplHumidityStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Humidity[];
        INTEGER HumidityAnalog;
    };

     class SimplInitializedChangedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Initialized;
    };

     class SimplLicensedChangedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Licensed;
        STRING Message[];
    };

     class SimplModeActiveEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ModeStopActive;
        INTEGER ModeCoolingActive;
        INTEGER ModeHeatingActive;
        INTEGER ModeFanActive;
        INTEGER ModeDryActive;
        INTEGER ModeAutoActive;
        INTEGER ActiveModeAnalog;
        STRING ActiveModeSerial[];
    };

     class SimplModesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ModesAvailable;
        INTEGER ModeControllable;
        INTEGER ModeStopAvailable;
        INTEGER ModeCoolingAvailable;
        INTEGER ModeHeatingAvailable;
        INTEGER ModeFanAvailable;
        INTEGER ModeDryAvailable;
        INTEGER ModeAutoAvailable;
        INTEGER ModeStopActive;
        INTEGER ModeCoolingActive;
        INTEGER ModeHeatingActive;
        INTEGER ModeFanActive;
        INTEGER ModeDryActive;
        INTEGER ModeAutoActive;
        INTEGER ActiveModeAnalog;
        STRING ActiveModeSerial[];
    };

     class SimplNameEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class SimplPowerStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER PowerStatus;
    };

     class SimplSetpointEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Setpoint[];
        INTEGER SetpointAnalog;
    };

     class SimplSetpointLimitEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING SetpointLowerLimit[];
        INTEGER SetpointLowerLimitAnalog;
        INTEGER SetpointLowerLimitAvailable;
        STRING SetpointUpperLimit[];
        INTEGER SetpointUpperLimitAnalog;
        INTEGER SetpointUpperLimitAvailable;
    };

     class SimplSpeedActiveEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER SpeedAutoActive;
        INTEGER SpeedOneActive;
        INTEGER SpeedTwoActive;
        INTEGER SpeedThreeActive;
        INTEGER SpeedFourActive;
        INTEGER SpeedFiveActive;
        INTEGER SpeedSixActive;
        INTEGER SpeedSevenActive;
        INTEGER ActiveSpeedAnalog;
        STRING ActiveSpeedSerial[];
    };

     class SimplSpeedsEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER SpeedsAvailable;
        INTEGER SpeedControllable;
        INTEGER SpeedAutoAvailable;
        INTEGER SpeedOneAvailable;
        INTEGER SpeedTwoAvailable;
        INTEGER SpeedThreeAvailable;
        INTEGER SpeedFourAvailable;
        INTEGER SpeedFiveAvailable;
        INTEGER SpeedSixAvailable;
        INTEGER SpeedSevenAvailable;
        INTEGER SpeedAutoActive;
        INTEGER SpeedOneActive;
        INTEGER SpeedTwoActive;
        INTEGER SpeedThreeActive;
        INTEGER SpeedFourActive;
        INTEGER SpeedFiveActive;
        INTEGER SpeedSixActive;
        INTEGER SpeedSevenActive;
        INTEGER ActiveSpeedAnalog;
        STRING ActiveSpeedSerial[];
    };

     class SimplStageActiveEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER StageAirActive;
        INTEGER StageRadiantActive;
        INTEGER StageCombinedActive;
        INTEGER ActiveStageAnalog;
        STRING ActiveStageSerial[];
    };

     class SimplStagesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER StagesAvailable;
        INTEGER StageControllable;
        INTEGER StageAirAvailable;
        INTEGER StageRadiantAvailable;
        INTEGER StageCombinedAvailable;
        INTEGER StageAirActive;
        INTEGER StageRadiantActive;
        INTEGER StageCombinedActive;
        INTEGER ActiveStageAnalog;
        STRING ActiveStageSerial[];
    };

     class SimplSystemLoadedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ModesAvailable;
        INTEGER ModeControllable;
        INTEGER SpeedsAvailable;
        INTEGER SpeedControllable;
        INTEGER ModeStopAvailable;
        INTEGER ModeCoolingAvailable;
        INTEGER ModeHeatingAvailable;
        INTEGER ModeFanAvailable;
        INTEGER ModeDryAvailable;
        INTEGER ModeAutoAvailable;
        INTEGER ModeStopActive;
        INTEGER ModeCoolingActive;
        INTEGER ModeHeatingActive;
        INTEGER ModeFanActive;
        INTEGER ModeDryActive;
        INTEGER ModeAutoActive;
        INTEGER ActiveModeAnalog;
        STRING ActiveModeSerial[];
        INTEGER SpeedAutoAvailable;
        INTEGER SpeedOneAvailable;
        INTEGER SpeedTwoAvailable;
        INTEGER SpeedThreeAvailable;
        INTEGER SpeedFourAvailable;
        INTEGER SpeedFiveAvailable;
        INTEGER SpeedSixAvailable;
        INTEGER SpeedSevenAvailable;
        INTEGER SpeedAutoActive;
        INTEGER SpeedOneActive;
        INTEGER SpeedTwoActive;
        INTEGER SpeedThreeActive;
        INTEGER SpeedFourActive;
        INTEGER SpeedFiveActive;
        INTEGER SpeedSixActive;
        INTEGER SpeedSevenActive;
        INTEGER ActiveSpeedAnalog;
        STRING ActiveSpeedSerial[];
    };

     class SimplTemperatureEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Temperature[];
        STRING TemperatureAnalog[];
    };

     class SimplUShortEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Value;
    };

     class SimplUnitEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Celsius;
        INTEGER Fahrenheit;
    };

     class SimplWarningsEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER HasWarnings;
        STRING Messages[][];
        INTEGER Count;
    };

     class SimplZoneLoadedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Temperature[];
        INTEGER TemperatureAnalog;
        STRING Humidity[];
        INTEGER HumidityAnalog;
        INTEGER HumidityAvailable;
        STRING Setpoint[];
        INTEGER SetpointAnalog;
        STRING SetpointLowerLimit[];
        INTEGER SetpointLowerLimitAnalog;
        INTEGER SetpointLowerLimitAvailable;
        STRING SetpointUpperLimit[];
        INTEGER SetpointUpperLimitAnalog;
        INTEGER SetpointUpperLimitAvailable;
        INTEGER PowerStatus;
        INTEGER StagesAvailable;
        INTEGER StageControllable;
        INTEGER StageAirAvailable;
        INTEGER StageRadiantAvailable;
        INTEGER StageCombinedAvailable;
        INTEGER StageAirActive;
        INTEGER StageRadiantActive;
        INTEGER StageCombinedActive;
        INTEGER ActiveStageAnalog;
        STRING ActiveStageSerial[];
        INTEGER ModesAvailable;
        INTEGER ModeControllable;
        INTEGER ModeStopAvailable;
        INTEGER ModeCoolingAvailable;
        INTEGER ModeHeatingAvailable;
        INTEGER ModeFanAvailable;
        INTEGER ModeDryAvailable;
        INTEGER ModeAutoAvailable;
        INTEGER ModeStopActive;
        INTEGER ModeCoolingActive;
        INTEGER ModeHeatingActive;
        INTEGER ModeFanActive;
        INTEGER ModeDryActive;
        INTEGER ModeAutoActive;
        INTEGER ActiveModeAnalog;
        STRING ActiveModeSerial[];
        INTEGER SpeedsAvailable;
        INTEGER SpeedControllable;
        INTEGER SpeedAutoAvailable;
        INTEGER SpeedOneAvailable;
        INTEGER SpeedTwoAvailable;
        INTEGER SpeedThreeAvailable;
        INTEGER SpeedFourAvailable;
        INTEGER SpeedFiveAvailable;
        INTEGER SpeedSixAvailable;
        INTEGER SpeedSevenAvailable;
        INTEGER SpeedAutoActive;
        INTEGER SpeedOneActive;
        INTEGER SpeedTwoActive;
        INTEGER SpeedThreeActive;
        INTEGER SpeedFourActive;
        INTEGER SpeedFiveActive;
        INTEGER SpeedSixActive;
        INTEGER SpeedSevenActive;
        INTEGER ActiveSpeedAnalog;
        STRING ActiveSpeedSerial[];
    };

     class SimplZoneStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER PowerStatus;
        STRING Temperature[];
        INTEGER TemperatureAnalog;
        STRING Humidity[];
        INTEGER HumidityAnalog;
        INTEGER StageAirActive;
        INTEGER StageRadiantActive;
        INTEGER StageCombinedActive;
        INTEGER ActiveStageAnalog;
        STRING ActiveStageSerial[];
        INTEGER ModeStopActive;
        INTEGER ModeCoolingActive;
        INTEGER ModeHeatingActive;
        INTEGER ModeFanActive;
        INTEGER ModeDryActive;
        INTEGER ModeAutoActive;
        INTEGER ActiveModeAnalog;
        STRING ActiveModeSerial[];
        INTEGER SpeedAutoActive;
        INTEGER SpeedOneActive;
        INTEGER SpeedTwoActive;
        INTEGER SpeedThreeActive;
        INTEGER SpeedFourActive;
        INTEGER SpeedFiveActive;
        INTEGER SpeedSixActive;
        INTEGER SpeedSevenActive;
        INTEGER ActiveSpeedAnalog;
        STRING ActiveSpeedSerial[];
        STRING Timestamp[];
    };

namespace AirZone.Ucmd;
        // class declarations
         class UcmdHandler;
    static class UcmdHandler 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION DistributeUcmdCommand ( STRING prefix , STRING command );
        static FUNCTION List ();
        static FUNCTION UcmdIn ( STRING uCommand );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

