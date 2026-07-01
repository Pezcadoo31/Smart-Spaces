namespace Lutron.Leap.CommLib.ProtocolSupport;
        // class declarations
         class HvacOperatingStatus;
         class ShadeMode;
         class FanSpeedTypes;
         class AreaMode;
         class OccupiedStateTypes;
         class ContextType;
         class ButtonEventState;
         class ButtonEventFeedback;
         class HvacOperatingMode;
         class MessageBodyType;
         class TemperatureSensorMode;
         class CommandType;
         class LEDState;
         class CommuniqueType;
         class ButtonMode;
         class AvailabilityTypes;
         class EmergencyStateTypes;
         class ActiveState;
         class TemperatureScales;
         class LoadShedState;
         class HvacFanStatus;
         class ZoneMode;
         class SwitchedLevel;
         class SpectrumTuningLevelType;
         class CCOLevel;
         class BatteryStateTypes;
         class ZoneObjType;
         class ReceptacleLevel;
         class HvacFanMode;
         class EnabledTypes;
         class ControlType;
    static class HvacOperatingStatus // enum
    {
        static SIGNED_LONG_INTEGER HeatLast;
        static SIGNED_LONG_INTEGER HeatStageOne;
        static SIGNED_LONG_INTEGER HeatStageTwo;
        static SIGNED_LONG_INTEGER HeatStageThree;
        static SIGNED_LONG_INTEGER CoolLast;
        static SIGNED_LONG_INTEGER CoolStageOne;
        static SIGNED_LONG_INTEGER CoolStageTwo;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER EmergencyHeat;
        static SIGNED_LONG_INTEGER Dry;
    };

    static class ShadeMode // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Lift;
        static SIGNED_LONG_INTEGER LiftAndTilt;
        static SIGNED_LONG_INTEGER LiftAndTiltWhenClosed;
    };

    static class FanSpeedTypes // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Low;
        static SIGNED_LONG_INTEGER Medium;
        static SIGNED_LONG_INTEGER MediumHigh;
        static SIGNED_LONG_INTEGER High;
    };

    static class AreaMode // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER DimLevel;
        static SIGNED_LONG_INTEGER Switched;
    };

    static class OccupiedStateTypes // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Occupied;
        static SIGNED_LONG_INTEGER Unoccupied;
    };

    static class ContextType // enum
    {
        static SIGNED_LONG_INTEGER Uknown;
        static SIGNED_LONG_INTEGER Application;
    };

    static class ButtonEventState // enum
    {
        static SIGNED_LONG_INTEGER PressAndHold;
        static SIGNED_LONG_INTEGER Release;
        static SIGNED_LONG_INTEGER PressAndRelease;
        static SIGNED_LONG_INTEGER MultiTap;
    };

    static class ButtonEventFeedback // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Press;
        static SIGNED_LONG_INTEGER Release;
        static SIGNED_LONG_INTEGER MultiTap;
        static SIGNED_LONG_INTEGER LongHold;
    };

    static class HvacOperatingMode // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Heat;
        static SIGNED_LONG_INTEGER Cool;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER EmergencyHeat;
        static SIGNED_LONG_INTEGER Fan;
        static SIGNED_LONG_INTEGER Dry;
    };

    static class MessageBodyType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER AdvancedToggleProgrammingModel;
        static SIGNED_LONG_INTEGER DualActionProgrammingModel;
        static SIGNED_LONG_INTEGER ExceptionDetail;
        static SIGNED_LONG_INTEGER MultipleAreaDefinition;
        static SIGNED_LONG_INTEGER MultipleAreaStatus;
        static SIGNED_LONG_INTEGER MultipleAreaSummaryDefinition;
        static SIGNED_LONG_INTEGER MultipleButtonGroupDefinition;
        static SIGNED_LONG_INTEGER MultipleButtonStatusEvent;
        static SIGNED_LONG_INTEGER MultipleCCOLevelAssignmentDefinition;
        static SIGNED_LONG_INTEGER MultipleControlStationDefinition;
        static SIGNED_LONG_INTEGER MultipleDeviceDefinition;
        static SIGNED_LONG_INTEGER MultipleDeviceStatus;
        static SIGNED_LONG_INTEGER MultipleDimmedLevelAssignmentDefinition;
        static SIGNED_LONG_INTEGER MultipleFanSpeedAssignmentDefinition;
        static SIGNED_LONG_INTEGER MultipleEmergencyDefinition;
        static SIGNED_LONG_INTEGER MultipleEmergencyStatus;
        static SIGNED_LONG_INTEGER MultipleOccupancyGroupDefinition;
        static SIGNED_LONG_INTEGER MultipleOccupancyGroupStatus;
        static SIGNED_LONG_INTEGER MultipleOccupancySensorStatus;
        static SIGNED_LONG_INTEGER MultipleProgrammingModelDefinition;
        static SIGNED_LONG_INTEGER MultipleReceptacleLevelAssignmentDefinition;
        static SIGNED_LONG_INTEGER MultipleSpectrumTuningLevelAssignmentDefinition;
        static SIGNED_LONG_INTEGER MultipleSwitchedLevelAssignmentDefinition;
        static SIGNED_LONG_INTEGER MultipleVirtualButtonDefinition;
        static SIGNED_LONG_INTEGER MultipleVirtualButtonDefinitionSummary;
        static SIGNED_LONG_INTEGER MultipleZoneDefinition;
        static SIGNED_LONG_INTEGER MultipleZoneStatus;
        static SIGNED_LONG_INTEGER MultipleZoneTypeGroupStatus;
        static SIGNED_LONG_INTEGER OneAreaDefinition;
        static SIGNED_LONG_INTEGER OneAreaStatus;
        static SIGNED_LONG_INTEGER OneButtonDefinition;
        static SIGNED_LONG_INTEGER OneButtonGroupDefinition;
        static SIGNED_LONG_INTEGER OneButtonStatusEvent;
        static SIGNED_LONG_INTEGER OneClientSettingDefinition;
        static SIGNED_LONG_INTEGER OneDeviceStatus;
        static SIGNED_LONG_INTEGER OneLEDDefinition;
        static SIGNED_LONG_INTEGER OneLEDStatus;
        static SIGNED_LONG_INTEGER OneLoginDefinition;
        static SIGNED_LONG_INTEGER OneOccupancySensorDefinition;
        static SIGNED_LONG_INTEGER OneOccupancySensorStatus;
        static SIGNED_LONG_INTEGER OnePingResponse;
        static SIGNED_LONG_INTEGER OnePresetDefinition;
        static SIGNED_LONG_INTEGER OneProgrammingModelDefinition;
        static SIGNED_LONG_INTEGER OneProjectDefinition;
        static SIGNED_LONG_INTEGER OneSystemLoadSheddingStatus;
        static SIGNED_LONG_INTEGER OneVirtualButtonDefinition;
        static SIGNED_LONG_INTEGER OneZoneDefinition;
        static SIGNED_LONG_INTEGER OneZoneStatus;
        static SIGNED_LONG_INTEGER OneZoneTypeGroupStatus;
        static SIGNED_LONG_INTEGER OneEmergencyStatus;
        static SIGNED_LONG_INTEGER SingleActionProgrammingModel;
        static SIGNED_LONG_INTEGER SingleSceneRaiseProgrammingModel;
        static SIGNED_LONG_INTEGER MultipleTemperatureSensorDefinition;
        static SIGNED_LONG_INTEGER OneTemperatureSensorStatus;
        static SIGNED_LONG_INTEGER MultipleButtonGroupExpandedDefinition;
    };

    static class TemperatureSensorMode // enum
    {
        static SIGNED_LONG_INTEGER Enabled;
        static SIGNED_LONG_INTEGER Disabled;
    };

    static class CommandType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Raise;
        static SIGNED_LONG_INTEGER Lower;
        static SIGNED_LONG_INTEGER Stop;
        static SIGNED_LONG_INTEGER RaiseTilt;
        static SIGNED_LONG_INTEGER LowerTilt;
        static SIGNED_LONG_INTEGER StopTilt;
        static SIGNED_LONG_INTEGER GoToSwitchedLevel;
        static SIGNED_LONG_INTEGER GoToDimmedLevel;
        static SIGNED_LONG_INTEGER GoToShadeLevel;
        static SIGNED_LONG_INTEGER GoToShadeLevelWithTilt;
        static SIGNED_LONG_INTEGER GoToSpectrumTuningLevel;
        static SIGNED_LONG_INTEGER GoToReceptacleLevel;
        static SIGNED_LONG_INTEGER GoToCCOLevel;
        static SIGNED_LONG_INTEGER GoToFanSpeed;
        static SIGNED_LONG_INTEGER Activate;
        static SIGNED_LONG_INTEGER GoToGroupLightingLevel;
        static SIGNED_LONG_INTEGER GoToScene;
        static SIGNED_LONG_INTEGER GoToShadeLevelWithTiltWhenClosed;
        static SIGNED_LONG_INTEGER GoToWhiteTuningLevel;
        static SIGNED_LONG_INTEGER RaiseLift;
        static SIGNED_LONG_INTEGER LowerLift;
        static SIGNED_LONG_INTEGER StopLift;
        static SIGNED_LONG_INTEGER GoToWarmDim;
    };

    static class LEDState // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER NormalFlash;
        static SIGNED_LONG_INTEGER RapidFlash;
    };

    static class CommuniqueType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER CreateRequest;
        static SIGNED_LONG_INTEGER CreateResponse;
        static SIGNED_LONG_INTEGER UpdateRequest;
        static SIGNED_LONG_INTEGER UpdateResponse;
        static SIGNED_LONG_INTEGER ReadResponse;
        static SIGNED_LONG_INTEGER ReadRequest;
        static SIGNED_LONG_INTEGER SubscribeRequest;
        static SIGNED_LONG_INTEGER SubscribeResponse;
        static SIGNED_LONG_INTEGER ExceptionResponse;
    };

    static class ButtonMode // enum
    {
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER PressRelease;
        static SIGNED_LONG_INTEGER MultiTap;
        static SIGNED_LONG_INTEGER PressHold;
    };

    static class AvailabilityTypes // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Unavailable;
        static SIGNED_LONG_INTEGER Mixed;
        static SIGNED_LONG_INTEGER Available;
    };

    static class EmergencyStateTypes // enum
    {
        static SIGNED_LONG_INTEGER Inactive;
        static SIGNED_LONG_INTEGER Active;
    };

    static class ActiveState // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Active;
        static SIGNED_LONG_INTEGER Inactive;
    };

    static class TemperatureScales // enum
    {
        static SIGNED_LONG_INTEGER Fahrenheit;
        static SIGNED_LONG_INTEGER Celsius;
    };

    static class LoadShedState // enum
    {
        static SIGNED_LONG_INTEGER Disabled;
        static SIGNED_LONG_INTEGER Enabled;
    };

    static class HvacFanStatus // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER High;
        static SIGNED_LONG_INTEGER Medium;
        static SIGNED_LONG_INTEGER Low;
        static SIGNED_LONG_INTEGER Off;
    };

    static class ZoneMode // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER DimLevel;
        static SIGNED_LONG_INTEGER Switched;
        static SIGNED_LONG_INTEGER CCO;
        static SIGNED_LONG_INTEGER Receptacle;
        static SIGNED_LONG_INTEGER SingleSetPointHvac;
        static SIGNED_LONG_INTEGER DualSetPointHvac;
        static SIGNED_LONG_INTEGER WhiteTuning;
        static SIGNED_LONG_INTEGER WarmDim;
    };

    static class SwitchedLevel // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class SpectrumTuningLevelType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER HueAndSaturation;
        static SIGNED_LONG_INTEGER WhiteTuning;
        static SIGNED_LONG_INTEGER ColorXY;
        static SIGNED_LONG_INTEGER Vibrancy;
    };

    static class CCOLevel // enum
    {
        static SIGNED_LONG_INTEGER Closed;
        static SIGNED_LONG_INTEGER Open;
    };

    static class BatteryStateTypes // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Bad;
        static SIGNED_LONG_INTEGER Good;
    };

    static class ZoneObjType // enum
    {
        static SIGNED_LONG_INTEGER zone;
        static SIGNED_LONG_INTEGER zonetypegroup;
    };

    static class ReceptacleLevel // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER On;
    };

    static class HvacFanMode // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Cycle;
        static SIGNED_LONG_INTEGER NoFan;
        static SIGNED_LONG_INTEGER High;
        static SIGNED_LONG_INTEGER Medium;
        static SIGNED_LONG_INTEGER Low;
        static SIGNED_LONG_INTEGER Top;
        static SIGNED_LONG_INTEGER Off;
    };

    static class EnabledTypes // enum
    {
        static SIGNED_LONG_INTEGER Disabled;
        static SIGNED_LONG_INTEGER Enabled;
    };

    static class ControlType // enum
    {
        static SIGNED_LONG_INTEGER Dimmed;
        static SIGNED_LONG_INTEGER Switched;
        static SIGNED_LONG_INTEGER SpectrumTune;
        static SIGNED_LONG_INTEGER WhiteTune;
        static SIGNED_LONG_INTEGER Shade;
        static SIGNED_LONG_INTEGER ShadeWithTilt;
        static SIGNED_LONG_INTEGER ShadeWithTiltWhenClosed;
        static SIGNED_LONG_INTEGER Receptacle;
        static SIGNED_LONG_INTEGER CCO;
        static SIGNED_LONG_INTEGER FanSpeed;
        static SIGNED_LONG_INTEGER Tilt;
        static SIGNED_LONG_INTEGER OpenCloseStop;
        static SIGNED_LONG_INTEGER SingleSetPointHVAC;
        static SIGNED_LONG_INTEGER DualSetPointHVAC;
        static SIGNED_LONG_INTEGER WarmDim;
        static SIGNED_LONG_INTEGER ColorTune;
    };

namespace Lutron.Leap.CommLib.Models.Bodies;
        // class declarations
         class TemperatureSensorStatusBody;
         class TemperatureSensorDetails;
         class ButtonStatusBody;
         class ButtonStatus;
         class ButtonEvent;
         class LoginUpdateBody;
         class LoginBody;
         class VersionUpdateBody;
         class VersionBody;
         class LoadShedUpdateBody;
         class MultiZoneBody;
         class AreaBody;
         class ZoneStatus;
         class AreaStatus;
         class ZoneTypeGroupBody;
         class ZoneDefinition;
         class ButtonBody;
         class ButtonCommandType;
         class MultiEmergencyBody;
         class LoadShedBody;
         class SystemLoadSheddingStatus;
         class SystemLoadShedding;
         class MultiZoneTypeGroupBody;
         class ExceptionBody;
         class MultiAreaBody;
         class EmergencyUpdateBody;
         class EmergencyActiveState;
         class ZoneBody;
         class TemperatureSensorBody;
         class TemperatureSensorStatus;
         class MultiOccupancySensorBody;
         class EmergencyBody;
         class EmergencyStatus;
         class Category;
         class Emergency;
         class DeviceBody;
         class DeviceStatus;
         class BatteryStatus;
         class Transfers;
         class ButtonGroupsExpandedBody;
         class ButtonGroupsExpanded;
         class OccupancySensorBody;
         class OccupancySensorStatus;
         class LEDBody;
         class LEDStatus;
         class LED;
         class MultiTemperatureSensorBody;
         class MultiDeviceBody;
         class PingBody;
         class PingResponse;
         class CommandBody;
         class LeapCommand;
         class SwitchedLevelParameters;
         class DimmedLevelParameters;
         class ShadeLevelParameters;
         class ShadeWithTiltLevelParameters;
         class ShadeWithTiltWhenClosedLevelParameters;
         class SpectrumTuningLevelParameters;
         class CCOLevelParameters;
         class ReceptacleLevelParameters;
         class FanSpeedParameters;
         class GroupLightingLevelParameters;
         class GoToSceneParameters;
         class CurrentScene;
         class WhiteTuningLevelParameters;
         class WarmDimParameters;
         class ZoneDefinitionBody;
           class SetPoint;
           class ColorTuningStatus;
           class SingleSetPointHvacStatus;
           class DualSetPointHvacStatus;
           class DualSetPointHVACProperties;
           class SingleSetPointHVACProperties;
           class ColorTuningProperties;
           class Curve;
           class Parent;
           class VibrancyStatus;
           class WhiteTuningLevel;
           class CurveDimming;
     class TemperatureSensorStatusBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        TemperatureSensorDetails Temperaturesensor;
        SetPoint CurrentTemperature;
    };

     class TemperatureSensorDetails 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class ButtonStatusBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonStatus ButtonStatus;
    };

     class ButtonStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonEvent ButtonEvent;
    };

     class ButtonEvent 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonEventFeedback EventType;
    };

     class LoginUpdateBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LoginBody Login;
    };

     class LoginBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ContextType ContextType;
        STRING href[];
        STRING LoginId[];
        STRING Password[];
    };

     class VersionUpdateBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VersionBody ClientSetting;
    };

     class VersionBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        SIGNED_LONG_INTEGER ClientMajorVersion;
    };

     class LoadShedUpdateBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SystemLoadSheddingStatus SystemLoadSheddingStatus;
    };

     class MultiZoneBody 
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

     class AreaBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AreaStatus AreaStatus;
    };

     class ZoneStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        ColorTuningStatus ColorTuningStatus;
        SingleSetPointHvacStatus SingleSetPointHvacStatus;
        DualSetPointHvacStatus DualSetPointHvacStatus;
    };

     class AreaStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        ColorTuningStatus ColorTuningStatus;
        SingleSetPointHvacStatus SingleSetPointHvacStatus;
        DualSetPointHvacStatus DualSetPointHvacStatus;
    };

     class ZoneTypeGroupBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ZoneStatus ZoneTypeGroupStatus;
    };

     class ZoneDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        STRING Name[];
        ControlType ControlType;
        DualSetPointHVACProperties DualSetPointHVACProperties;
        SingleSetPointHVACProperties SingleSetPointHVACProperties;
        ColorTuningProperties ColorTuningProperties;
        Curve DefaultDimCurve;
    };

     class ButtonBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonCommandType Command;
    };

     class ButtonCommandType 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonEventState CommandType;
    };

     class MultiEmergencyBody 
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

     class LoadShedBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SystemLoadSheddingStatus SystemLoadSheddingStatus;
    };

     class SystemLoadSheddingStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SystemLoadShedding SystemLoadShedding;
        LoadShedState State;
    };

     class SystemLoadShedding 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class MultiZoneTypeGroupBody 
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

     class ExceptionBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Message[];
    };

     class MultiAreaBody 
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

     class EmergencyUpdateBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        EmergencyActiveState EmergencyStatus;
    };

     class EmergencyActiveState 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        EmergencyStateTypes ActiveState;
    };

     class ZoneBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ZoneStatus ZoneStatus;
    };

     class TemperatureSensorBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        TemperatureSensorStatusBody TemperatureSensorStatus;
    };

     class TemperatureSensorStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        Parent Parent;
    };

     class MultiOccupancySensorBody 
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

     class EmergencyBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        EmergencyStatus EmergencyStatus;
    };

     class EmergencyStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        Emergency Emergency;
    };

     class Category 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

     class Emergency 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class DeviceBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DeviceStatus DeviceStatus;
    };

     class DeviceStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        BatteryStatus BatteryStatus;
        Transfers FailedTransfers;
    };

     class BatteryStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        BatteryStateTypes LevelState;
    };

     class Transfers 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Count;
    };

     class ButtonGroupsExpandedBody 
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

     class ButtonGroupsExpanded 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        Parent Parent;
    };

     class OccupancySensorBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        OccupancySensorStatus OccupancySensorStatus;
    };

     class OccupancySensorStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        OccupiedStateTypes OccupancyStatus;
    };

     class LEDBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LEDStatus LEDStatus;
    };

     class LEDStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
        LED LED;
        LEDState State;
    };

     class LED 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class MultiTemperatureSensorBody 
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

     class MultiDeviceBody 
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

     class PingBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        PingResponse PingResponse;
    };

     class PingResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING LEAPVersion[];
    };

     class CommandBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LeapCommand Command;
    };

     class LeapCommand 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommandType CommandType;
        SwitchedLevelParameters SwitchedLevelParameters;
        DimmedLevelParameters DimmedLevelParameters;
        ShadeLevelParameters ShadeLevelParameters;
        ShadeWithTiltLevelParameters ShadeWithTiltLevelParameters;
        ShadeWithTiltWhenClosedLevelParameters ShadeWithTiltWhenClosedLevelParameters;
        SpectrumTuningLevelParameters SpectrumTuningLevelParameters;
        CCOLevelParameters CCOLevelParameters;
        ReceptacleLevelParameters ReceptacleLevelParameters;
        FanSpeedParameters FanSpeedParameters;
        GroupLightingLevelParameters GroupLightingLevelParameters;
        GoToSceneParameters GoToSceneParameters;
        WhiteTuningLevelParameters WhiteTuningLevelParameters;
        WarmDimParameters WarmDimParameters;
    };

     class SwitchedLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SwitchedLevel SwitchedLevel;
    };

     class DimmedLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Level;
        STRING FadeTime[];
    };

     class ShadeLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Level;
    };

     class ShadeWithTiltLevelParameters 
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

     class ShadeWithTiltWhenClosedLevelParameters 
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

     class SpectrumTuningLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING FadeTime[];
        ColorTuningStatus ColorTuningStatus;
    };

     class CCOLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CCOLevel CCOLevel;
    };

     class ReceptacleLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ReceptacleLevel ReceptacleLevel;
    };

     class FanSpeedParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        FanSpeedTypes FanSpeed;
    };

     class GroupLightingLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VibrancyStatus VibrancyStatus;
        STRING FadeTime[];
        ColorTuningStatus ColorTuningStatus;
    };

     class GoToSceneParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CurrentScene CurrentScene;
    };

     class CurrentScene 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class WhiteTuningLevelParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        WhiteTuningLevel WhiteTuningLevel;
        STRING FadeTime[];
    };

     class WarmDimParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CurveDimming CurveDimming;
        STRING FadeTime[];
    };

     class ZoneDefinitionBody 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ZoneDefinition Zone;
    };

namespace Lutron.Leap.CommLib.Models.Bodies.SubClasses;
        // class declarations
         class SetPointHVACProperties;
         class SingleSetPointHVACProperties;
         class Parent;
         class EcoModeProperties;
         class KeypadButton;
         class Engraving;
         class AssociatedLED;
         class HvacOperatingStatuses;
         class ColorTuningStatus;
         class XYTuningLevel;
         class HSVTuningLevel;
         class WhiteTuningLevel;
         class CurveDimming;
         class Curve;
         class VibrancyStatus;
         class SingleSetPointHvacStatus;
         class DualSetPointHVACProperties;
         class DualSetPointHvacStatus;
         class ColorTuningProperties;
         class WhiteTuningLevelRange;
         class SetPoint;
         class SetPointRange;
         class TemperatureRange;
     class SetPointHVACProperties 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION SupportsTemperatureScale ( TemperatureScales scale );
        INTEGER_FUNCTION SupportsFanModes ( HvacFanMode fanMode );
        INTEGER_FUNCTION SupportsOperatingModes ( HvacOperatingMode operatingMode );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        EcoModeProperties EcoModeProperties;
        INTEGER EcoModeActiveState;
        INTEGER EcoModeEnabledState;
    };

     class SingleSetPointHVACProperties 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION SupportsTemperatureScale ( TemperatureScales scale );
        INTEGER_FUNCTION SupportsFanModes ( HvacFanMode fanMode );
        INTEGER_FUNCTION SupportsOperatingModes ( HvacOperatingMode operatingMode );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SetPointRange SetPointRange;
        EcoModeProperties EcoModeProperties;
        INTEGER EcoModeActiveState;
        INTEGER EcoModeEnabledState;
    };

     class Parent 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class EcoModeProperties 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ActiveState ActiveState;
        EnabledTypes EnabledState;
    };

     class KeypadButton 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ButtonHrefUrl[];
        INTEGER ButtonNumber;
        Engraving Engraving;
        AssociatedLED LedHrefUrl;
        LONG_INTEGER ButtonHref;
        LONG_INTEGER LedHref;
    };

     class Engraving 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Text[];
    };

     class AssociatedLED 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class HvacOperatingStatuses 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION ActiveOperatingStatus ( HvacOperatingStatus operatingStatus );
        FUNCTION set_Item ( SIGNED_LONG_INTEGER index , HvacOperatingStatus value );
        FUNCTION Add ( HvacOperatingStatus item );
        SIGNED_LONG_INTEGER_FUNCTION BinarySearch ( HvacOperatingStatus item );
        FUNCTION Clear ();
        FUNCTION CopyTo ( HvacOperatingStatus array[] );
        SIGNED_LONG_INTEGER_FUNCTION IndexOf ( HvacOperatingStatus item );
        FUNCTION Insert ( SIGNED_LONG_INTEGER index , HvacOperatingStatus item );
        SIGNED_LONG_INTEGER_FUNCTION LastIndexOf ( HvacOperatingStatus item );
        FUNCTION RemoveAt ( SIGNED_LONG_INTEGER index );
        FUNCTION RemoveRange ( SIGNED_LONG_INTEGER index , SIGNED_LONG_INTEGER count );
        FUNCTION Reverse ();
        FUNCTION Sort ();
        FUNCTION TrimExcess ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Capacity;
        SIGNED_LONG_INTEGER Count;
    };

     class ColorTuningStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        XYTuningLevel XYTuningLevel;
        HSVTuningLevel HSVTuningLevel;
        WhiteTuningLevel WhiteTuningLevel;
        CurveDimming CurveDimming;
    };

     class XYTuningLevel 
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

     class HSVTuningLevel 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Hue;
        INTEGER Saturation;
    };

     class WhiteTuningLevel 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Kelvin;
    };

     class CurveDimming 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        Curve Curve;
    };

     class Curve 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING href[];
    };

     class VibrancyStatus 
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

     class SingleSetPointHvacStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SetPoint SetPoint;
        SetPoint CurrentTemperature;
        HvacOperatingStatuses OperatingStatuses;
    };

     class DualSetPointHVACProperties 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION SupportsTemperatureScale ( TemperatureScales scale );
        INTEGER_FUNCTION SupportsFanModes ( HvacFanMode fanMode );
        INTEGER_FUNCTION SupportsOperatingModes ( HvacOperatingMode operatingMode );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SetPointRange HeatingSetPointRange;
        SetPointRange CoolingSetPointRange;
        SetPointRange HeatingCoolingDelta;
        EcoModeProperties EcoModeProperties;
        INTEGER EcoModeActiveState;
        INTEGER EcoModeEnabledState;
    };

     class DualSetPointHvacStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SetPoint CoolingSetPoint;
        SetPoint HeatingSetPoint;
        SetPoint CurrentTemperature;
        HvacOperatingStatuses OperatingStatuses;
    };

     class ColorTuningProperties 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        WhiteTuningLevelRange WhiteTuningLevelRange;
    };

     class WhiteTuningLevelRange 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Min;
        INTEGER Max;
    };

     class SetPoint 
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

     class SetPointRange 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        TemperatureRange Fahrenheit;
        TemperatureRange Celsius;
    };

     class TemperatureRange 
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

namespace Lutron.Leap.CommLib.Event_Arguments;
        // class declarations
         class ButtonEventArgs;
         class KeypadLabelEventArgs;
         class CommunicatingEventArgs;
         class EmergencyEventArgs;
         class HvacOperatingStatusesEventArgs;
         class FloatEventArgs;
         class WhiteTuningRangeEventArgs;
         class CCOLevelEventArgs;
         class AvailabilityEventArgs;
         class DimLevelEventArgs;
         class FanSpeedEventArgs;
         class BatteryEventArgs;
         class OccupiedStatusEventArgs;
         class OccupancyStatus;
         class DebugEventArgs;
         class SwitchedLevelEventArgs;
         class SceneEventArgs;
         class OccupiedEventArgs;
         class LevelEventArgs;
         class LEDEventArgs;
         class InitializationEventArgs;
         class HvacPropertiesEventArgs;
         class CurveEventArgs;
         class KeypadButtonEventArgs;
         class ButtonFeedbackEventArgs;
         class ReceptacleLevelEventArgs;
         class LoadShedStatusEventArgs;
         class LEDStatusEventArgs;
         class LEDStatus;
     class KeypadLabelEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Id;
        STRING Payload[];
    };

     class CommunicatingEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

     class EmergencyEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        EmergencyStateTypes Payload;
    };

     class HvacOperatingStatusesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        HvacOperatingStatuses Payload;
    };

     class FloatEventArgs 
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

     class WhiteTuningRangeEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        WhiteTuningLevelRange Payload;
    };

     class CCOLevelEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CCOLevel Payload;
    };

     class AvailabilityEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AvailabilityTypes Payload;
    };

     class DimLevelEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

     class FanSpeedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        FanSpeedTypes Payload;
    };

     class BatteryEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        BatteryStateTypes Payload;
    };

     class OccupiedStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        OccupancyStatus Payload;
    };

     class OccupancyStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER Id;
        OccupiedStateTypes State;
        INTEGER Status;
    };

     class DebugEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Payload[];
    };

     class SwitchedLevelEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SwitchedLevel Payload;
    };

     class SceneEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER Payload;
    };

     class OccupiedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        OccupiedStateTypes Payload;
    };

     class LevelEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

     class InitializationEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

     class HvacPropertiesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SetPointHVACProperties Payload;
    };

     class CurveEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

     class KeypadButtonEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Id;
        INTEGER Payload;
    };

     class ButtonFeedbackEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER Id;
        ButtonEventFeedback Payload;
    };

     class ReceptacleLevelEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ReceptacleLevel Payload;
    };

     class LoadShedStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LoadShedState Payload;
    };

     class LEDStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LEDStatus Payload;
    };

     class LEDStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER Id;
        LEDState State;
        INTEGER Status;
    };

namespace Lutron.Leap.CommLib.ComponentStates;
        // class declarations
         class OccupiedComponentState;
         class LoadShedComponentState;
         class ButtonEventComponentState;
         class EmergencyComponentState;
         class SwitchedLevelComponentState;
         class HvacOperatingStatusesComponentState;
         class ReceptacleComponentState;
         class BatteryComponentState;
         class FloatComponentState;
         class LEDComponentState;
         class FanComponentState;
         class WhiteTuningRangeState;
         class CCOComponentState;
         class AvailabilityState;
     class OccupiedComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( OccupiedComponentState sender, OccupiedEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER Id;
    };

     class LoadShedComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( LoadShedComponentState sender, LoadShedStatusEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class EmergencyComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( EmergencyComponentState sender, EmergencyEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SwitchedLevelComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( SwitchedLevelComponentState sender, SwitchedLevelEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class HvacOperatingStatusesComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( HvacOperatingStatusesComponentState sender, HvacOperatingStatusesEventArgs args );

        // class functions
        FUNCTION UpdateState ( HvacOperatingStatuses statuses );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        HvacOperatingStatuses State;
        HvacOperatingStatuses InitialState;
    };

     class ReceptacleComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( ReceptacleComponentState sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class BatteryComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( BatteryComponentState sender, BatteryEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class FloatComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( FloatComponentState sender, FloatEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class FanComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( FanComponentState sender, FanSpeedEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class WhiteTuningRangeState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( WhiteTuningRangeState sender, WhiteTuningRangeEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        WhiteTuningLevelRange State;
        WhiteTuningLevelRange InitialState;
    };

     class CCOComponentState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( CCOComponentState sender, CCOLevelEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class AvailabilityState 
    {
        // class delegates

        // class events
        EventHandler OnProcessUpdate ( AvailabilityState sender, AvailabilityEventArgs args );

        // class functions
        FUNCTION UpdateState ( STRING value );
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Lutron.Leap.CommLib.Components;
        // class declarations
         class AreaComponent;
         class ViveAreaComponent;
         class PassthruComponent;
         class AreaControlComponent;
         class ShadeComponent;
         class LEDComponent;
         class LEDInputControl;
         class ButtonComponent;
         class ZoneComponent;
         class LumarisComponent;
         class KeypadComponent;
         class ViveSceneComponent;
         class HvacComponent;
         class FanComponent;
         class SpectrumComponent;
         class ThirdPartyHvacComponent;
         class ViveEmergencyStateComponent;
         class ViveOccupancySensorComponent;
         class RGBComponent;
         class ViveZoneTypeGroupComponent;
         class ViveLoadShedComponent;
         class DaliComponent;
         class ViveButtonComponent;
         class OpenCloseStopComponent;
         class ViveDeviceComponent;
           class LeapBaseMessage;
     class AreaComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( AreaComponent sender, InitializationEventArgs args );
        EventHandler OnOccupancyChange ( AreaComponent sender, OccupiedEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER AreaId );
        FUNCTION AddPreset ( INTEGER Key , LONG_INTEGER PresetId );
        FUNCTION RecallPreset ( INTEGER Key );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER AreaId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveAreaComponent 
    {
        // class delegates

        // class events
        EventHandler OnInstantaneousPowerChange ( ViveAreaComponent sender, LevelEventArgs args );
        EventHandler OnInstantaneousMaxPowerChange ( ViveAreaComponent sender, LevelEventArgs args );
        EventHandler OnBrightnessLevelChange ( ViveAreaComponent sender, LevelEventArgs args );
        EventHandler OnInitializationChange ( ViveAreaComponent sender, InitializationEventArgs args );
        EventHandler OnOccupancyChange ( ViveAreaComponent sender, OccupiedEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER AreaId );
        FUNCTION AddPreset ( INTEGER Key , LONG_INTEGER PresetId );
        FUNCTION RecallPreset ( INTEGER Key );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER AreaId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class PassthruComponent 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        FUNCTION Configure ( INTEGER CommandProcessorId );
        FUNCTION SendJson ( STRING msg );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class AreaControlComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( AreaControlComponent sender, InitializationEventArgs args );
        EventHandler OnDimLevelChange ( AreaControlComponent sender, DimLevelEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER AreaId );
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION SetVibrancyLevel ( INTEGER Level );
        FUNCTION SetHueSaturationLevel ( INTEGER Hue , INTEGER Saturation );
        FUNCTION SetWhiteTuningLevel ( INTEGER Kelvin );
        FUNCTION SetColorXYLevel ( INTEGER X , INTEGER Y );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        AreaMode AreaMode;
        LONG_INTEGER AreaId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ShadeComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ShadeComponent sender, InitializationEventArgs args );
        EventHandler OnLiftLevelChange ( ShadeComponent sender, DimLevelEventArgs args );
        EventHandler OnTiltLevelChange ( ShadeComponent sender, DimLevelEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ShadeMode , LONG_INTEGER ZoneId );
        FUNCTION RaiseLift ();
        FUNCTION LowerLift ();
        FUNCTION StopLift ();
        FUNCTION RaiseTilt ();
        FUNCTION LowerTilt ();
        FUNCTION StopTilt ();
        FUNCTION SetLiftLevel ( INTEGER Level );
        FUNCTION SetTiltLevel ( INTEGER Level );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ShadeMode ShadeMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class LEDComponent 
    {
        // class delegates

        // class events
        EventHandler OnLEDStatusChange ( LEDComponent sender, LEDStatusEventArgs args );
        EventHandler OnInitializationChange ( LEDComponent sender, InitializationEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId );
        FUNCTION AddLEDStatus ( LONG_INTEGER Id );
        FUNCTION SetLEDControl ( LONG_INTEGER Id , INTEGER State );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorId;
        INTEGER Id;
    };

     class ButtonComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ButtonComponent sender, InitializationEventArgs args );
        EventHandler OnButtonEventChange ( ButtonComponent sender, ButtonFeedbackEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER Mode , INTEGER MultiTapTime );
        FUNCTION AddButton ( LONG_INTEGER Id );
        FUNCTION Press ( LONG_INTEGER Id );
        FUNCTION Release ( LONG_INTEGER Id );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonMode Mode;
        INTEGER MultiTapTime;
        INTEGER SimulateButtonRelease;
        INTEGER CommandProcessorId;
        INTEGER Id;
    };

     class ZoneComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ZoneComponent sender, InitializationEventArgs args );
        EventHandler OnSwitchedLevelChange ( ZoneComponent sender, SwitchedLevelEventArgs args );
        EventHandler OnDimLevelChange ( ZoneComponent sender, DimLevelEventArgs args );
        EventHandler OnCCOLevelChange ( ZoneComponent sender, CCOLevelEventArgs args );
        EventHandler OnReceptacleLevelChange ( ZoneComponent sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SwitchOn ();
        FUNCTION SwitchOff ();
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION ReceptacleOn ();
        FUNCTION ReceptacleOff ();
        FUNCTION CCOLevelOpen ();
        FUNCTION CCOLevelClose ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class LumarisComponent 
    {
        // class delegates

        // class events
        EventHandler OnWhiteTuningLevelChange ( LumarisComponent sender, LevelEventArgs args );
        EventHandler OnWarmDimCurveChange ( LumarisComponent sender, CurveEventArgs args );
        EventHandler OnWhiteTuningRangeChange ( LumarisComponent sender, WhiteTuningRangeEventArgs args );
        EventHandler OnInitializationChange ( LumarisComponent sender, InitializationEventArgs args );
        EventHandler OnSwitchedLevelChange ( LumarisComponent sender, SwitchedLevelEventArgs args );
        EventHandler OnDimLevelChange ( LumarisComponent sender, DimLevelEventArgs args );
        EventHandler OnCCOLevelChange ( LumarisComponent sender, CCOLevelEventArgs args );
        EventHandler OnReceptacleLevelChange ( LumarisComponent sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId );
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION SetWhiteTuningLevel ( INTEGER Kelvin );
        FUNCTION SetWarmDimCurve ( INTEGER href );
        INTEGER_FUNCTION IsCurveSupported ( INTEGER href );
        FUNCTION GetInitialized ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SwitchOn ();
        FUNCTION SwitchOff ();
        FUNCTION ReceptacleOn ();
        FUNCTION ReceptacleOff ();
        FUNCTION CCOLevelOpen ();
        FUNCTION CCOLevelClose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class KeypadComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( KeypadComponent sender, InitializationEventArgs args );
        EventHandler OnKeypadButtonLabelChange ( KeypadComponent sender, KeypadLabelEventArgs args );
        EventHandler OnKeypadButtonFeedbackChange ( KeypadComponent sender, KeypadButtonEventArgs args );
        EventHandler OnKeypadButtonEnableChange ( KeypadComponent sender, KeypadButtonEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER KeypadId );
        FUNCTION ButtonPress ( INTEGER button );
        FUNCTION ButtonRelease ( INTEGER button );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER KeypadId;
        INTEGER CommandProcessorId;
        INTEGER Id;
    };

     class ViveSceneComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveSceneComponent sender, InitializationEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId );
        FUNCTION AddScene ( LONG_INTEGER Id );
        FUNCTION Press ( LONG_INTEGER Id );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorId;
        INTEGER Id;
    };

     class HvacComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( HvacComponent sender, InitializationEventArgs args );
        EventHandler OnCurrentTemperatureChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnSingleSetPointTemperatureChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnCoolSetPointTemperatureChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnHeatSetPointTemperatureChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnOperatingModeChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnFanModeChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnFanStatusChange ( HvacComponent sender, LevelEventArgs args );
        EventHandler OnHvacPropertiesChange ( HvacComponent sender, HvacPropertiesEventArgs args );
        EventHandler OnHvacOperatingStatusesChange ( HvacComponent sender, HvacOperatingStatusesEventArgs args );

        // class functions
        FUNCTION SetTemperature ( INTEGER temp );
        FUNCTION SetCoolTemperature ( INTEGER temp );
        FUNCTION SetHeatTemperature ( INTEGER temp );
        FUNCTION SetFanMode ( INTEGER mode );
        FUNCTION SetOperatingMode ( INTEGER mode );
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId , LONG_INTEGER TemperatureScale );
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class FanComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( FanComponent sender, InitializationEventArgs args );
        EventHandler OnFanSpeedChange ( FanComponent sender, FanSpeedEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER ZoneId );
        FUNCTION SetFanSpeed ( INTEGER speed );
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class SpectrumComponent 
    {
        // class delegates

        // class events
        EventHandler OnVibrancyLevelChange ( SpectrumComponent sender, LevelEventArgs args );
        EventHandler OnWhiteTuningLevelChange ( SpectrumComponent sender, LevelEventArgs args );
        EventHandler OnHueLevelChange ( SpectrumComponent sender, LevelEventArgs args );
        EventHandler OnSaturationLevelChange ( SpectrumComponent sender, LevelEventArgs args );
        EventHandler OnColorXChange ( SpectrumComponent sender, LevelEventArgs args );
        EventHandler OnColorYChange ( SpectrumComponent sender, LevelEventArgs args );
        EventHandler OnInitializationChange ( SpectrumComponent sender, InitializationEventArgs args );
        EventHandler OnSwitchedLevelChange ( SpectrumComponent sender, SwitchedLevelEventArgs args );
        EventHandler OnDimLevelChange ( SpectrumComponent sender, DimLevelEventArgs args );
        EventHandler OnCCOLevelChange ( SpectrumComponent sender, CCOLevelEventArgs args );
        EventHandler OnReceptacleLevelChange ( SpectrumComponent sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION SetVibrancyLevel ( INTEGER Level );
        FUNCTION SetHueSaturationLevel ( INTEGER Hue , INTEGER Saturation );
        FUNCTION SetWhiteTuningLevel ( INTEGER Kelvin );
        FUNCTION SetColorXYLevel ( INTEGER X , INTEGER Y );
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SwitchOn ();
        FUNCTION SwitchOff ();
        FUNCTION ReceptacleOn ();
        FUNCTION ReceptacleOff ();
        FUNCTION CCOLevelOpen ();
        FUNCTION CCOLevelClose ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ThirdPartyHvacComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ThirdPartyHvacComponent sender, InitializationEventArgs args );
        EventHandler OnCurrentTemperatureChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnSingleSetPointTemperatureChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnCoolSetPointTemperatureChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnHeatSetPointTemperatureChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnOperatingModeChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnFanModeChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnFanStatusChange ( ThirdPartyHvacComponent sender, LevelEventArgs args );
        EventHandler OnHvacPropertiesChange ( ThirdPartyHvacComponent sender, HvacPropertiesEventArgs args );
        EventHandler OnHvacOperatingStatusesChange ( ThirdPartyHvacComponent sender, HvacOperatingStatusesEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId , LONG_INTEGER TemperatureScale , INTEGER TemperatureSensorMode , LONG_INTEGER ThermostatDeviceId );
        FUNCTION SetCurrentTemperature ( INTEGER Temperature );
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION GetInitialized ();
        FUNCTION SetTemperature ( INTEGER temp );
        FUNCTION SetCoolTemperature ( INTEGER temp );
        FUNCTION SetHeatTemperature ( INTEGER temp );
        FUNCTION SetFanMode ( INTEGER mode );
        FUNCTION SetOperatingMode ( INTEGER mode );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER ThermostatDeviceId;
        LONG_INTEGER TemperatureSensorDeviceId;
        TemperatureSensorMode TemperatureSensorMode;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveEmergencyStateComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveEmergencyStateComponent sender, InitializationEventArgs args );
        EventHandler OnEmergencyStateChange ( ViveEmergencyStateComponent sender, EmergencyEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER EmergencyId );
        FUNCTION EmergencyStateEnable ();
        FUNCTION EmergencyStateDisable ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER EmergencyId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveOccupancySensorComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveOccupancySensorComponent sender, InitializationEventArgs args );
        EventHandler OnOccupancyStatusChange ( ViveOccupancySensorComponent sender, OccupiedStatusEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId );
        FUNCTION AddOccSensor ( LONG_INTEGER Id );
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER AreaId;
        INTEGER CommandProcessorId;
        INTEGER Id;
    };

     class RGBComponent 
    {
        // class delegates

        // class events
        EventHandler OnHueLevelChange ( RGBComponent sender, LevelEventArgs args );
        EventHandler OnSaturationLevelChange ( RGBComponent sender, LevelEventArgs args );
        EventHandler OnColorXChange ( RGBComponent sender, LevelEventArgs args );
        EventHandler OnColorYChange ( RGBComponent sender, LevelEventArgs args );
        EventHandler OnWhiteTuningLevelChange ( RGBComponent sender, LevelEventArgs args );
        EventHandler OnWarmDimCurveChange ( RGBComponent sender, CurveEventArgs args );
        EventHandler OnWhiteTuningRangeChange ( RGBComponent sender, WhiteTuningRangeEventArgs args );
        EventHandler OnInitializationChange ( RGBComponent sender, InitializationEventArgs args );
        EventHandler OnSwitchedLevelChange ( RGBComponent sender, SwitchedLevelEventArgs args );
        EventHandler OnDimLevelChange ( RGBComponent sender, DimLevelEventArgs args );
        EventHandler OnCCOLevelChange ( RGBComponent sender, CCOLevelEventArgs args );
        EventHandler OnReceptacleLevelChange ( RGBComponent sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION SetHueSaturationLevel ( INTEGER Hue , INTEGER Saturation );
        FUNCTION SetColorXYLevel ( INTEGER X , INTEGER Y );
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId );
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION SetWhiteTuningLevel ( INTEGER Kelvin );
        FUNCTION SetWarmDimCurve ( INTEGER href );
        INTEGER_FUNCTION IsCurveSupported ( INTEGER href );
        FUNCTION GetInitialized ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SwitchOn ();
        FUNCTION SwitchOff ();
        FUNCTION ReceptacleOn ();
        FUNCTION ReceptacleOff ();
        FUNCTION CCOLevelOpen ();
        FUNCTION CCOLevelClose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveZoneTypeGroupComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveZoneTypeGroupComponent sender, InitializationEventArgs args );
        EventHandler OnSwitchedLevelChange ( ViveZoneTypeGroupComponent sender, SwitchedLevelEventArgs args );
        EventHandler OnDimLevelChange ( ViveZoneTypeGroupComponent sender, DimLevelEventArgs args );
        EventHandler OnCCOLevelChange ( ViveZoneTypeGroupComponent sender, CCOLevelEventArgs args );
        EventHandler OnReceptacleLevelChange ( ViveZoneTypeGroupComponent sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SwitchOn ();
        FUNCTION SwitchOff ();
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION ReceptacleOn ();
        FUNCTION ReceptacleOff ();
        FUNCTION CCOLevelOpen ();
        FUNCTION CCOLevelClose ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneTypeGroupId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveLoadShedComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveLoadShedComponent sender, InitializationEventArgs args );
        EventHandler OnLoadShedStatusChange ( ViveLoadShedComponent sender, LoadShedStatusEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId );
        FUNCTION LoadShedEnable ();
        FUNCTION LoadShedDisable ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        FUNCTION StartPollTimer ();
        FUNCTION StopPollTimer ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class DaliComponent 
    {
        // class delegates

        // class events
        EventHandler OnWhiteTuningLevelChange ( DaliComponent sender, LevelEventArgs args );
        EventHandler OnInitializationChange ( DaliComponent sender, InitializationEventArgs args );
        EventHandler OnSwitchedLevelChange ( DaliComponent sender, SwitchedLevelEventArgs args );
        EventHandler OnDimLevelChange ( DaliComponent sender, DimLevelEventArgs args );
        EventHandler OnCCOLevelChange ( DaliComponent sender, CCOLevelEventArgs args );
        EventHandler OnReceptacleLevelChange ( DaliComponent sender, ReceptacleLevelEventArgs args );

        // class functions
        FUNCTION SetDimLevel ( INTEGER Level );
        FUNCTION SetWhiteTuningLevel ( INTEGER Kelvin );
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER ZoneMode , LONG_INTEGER ZoneId );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SwitchOn ();
        FUNCTION SwitchOff ();
        FUNCTION ReceptacleOn ();
        FUNCTION ReceptacleOff ();
        FUNCTION CCOLevelOpen ();
        FUNCTION CCOLevelClose ();
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER FadeTime;
        ZoneMode ZoneMode;
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveButtonComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveButtonComponent sender, InitializationEventArgs args );
        EventHandler OnButtonEventChange ( ViveButtonComponent sender, ButtonFeedbackEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , INTEGER Mode );
        FUNCTION AddButton ( LONG_INTEGER Id );
        FUNCTION Press ( LONG_INTEGER Id );
        FUNCTION Release ( LONG_INTEGER Id );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ButtonMode Mode;
        INTEGER MultiTapTime;
        INTEGER SimulateButtonRelease;
        INTEGER CommandProcessorId;
        INTEGER Id;
    };

     class OpenCloseStopComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( OpenCloseStopComponent sender, InitializationEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER ZoneId );
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER ZoneId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

     class ViveDeviceComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveDeviceComponent sender, InitializationEventArgs args );
        EventHandler OnBatteryChange ( ViveDeviceComponent sender, BatteryEventArgs args );
        EventHandler OnAvailabilityChange ( ViveDeviceComponent sender, AvailabilityEventArgs args );
        EventHandler OnFailedTransferChange ( ViveDeviceComponent sender, LevelEventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , LONG_INTEGER DeviceId );
        FUNCTION ProcessSubscription ( LeapBaseMessage response );
        FUNCTION ProcessResponse ( LeapBaseMessage response , LeapBaseMessage request );
        FUNCTION GetInitialized ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER DeviceId;
        INTEGER Id;
        INTEGER CommandProcessorId;
    };

namespace Lutron.Leap.CommLib;
        // class declarations
         class CommandProcessor;
         class ViveCommandProcessor;
     class CommandProcessor 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( CommandProcessor sender, InitializationEventArgs args );
        EventHandler OnCommunicationChange ( CommandProcessor sender, CommunicatingEventArgs args );
        EventHandler OnDebugMessage ( CommandProcessor sender, DebugEventArgs args );
        EventHandler OnReadyState ( CommandProcessor sender, EventArgs e );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , STRING IPAddress , STRING Username , STRING Password );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION SendMessage ( LeapBaseMessage msg );
        FUNCTION SendRawJson ( STRING str );
        FUNCTION FailedResponse ();
        SIGNED_LONG_INTEGER_FUNCTION GetHeartbeatTime ();
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetResponseTime ();
        FUNCTION Reconnect ();
        FUNCTION SendHeartbeat ();
        FUNCTION SendTrace ( STRING msg );
        FUNCTION Strikeout ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING IPAddress[];
        INTEGER Id;
    };

     class ViveCommandProcessor 
    {
        // class delegates

        // class events
        EventHandler OnInitializationChange ( ViveCommandProcessor sender, InitializationEventArgs args );
        EventHandler OnCommunicationChange ( ViveCommandProcessor sender, CommunicatingEventArgs args );
        EventHandler OnDebugMessage ( ViveCommandProcessor sender, DebugEventArgs args );
        EventHandler OnReadyState ( ViveCommandProcessor sender, EventArgs e );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorId , STRING IPAddress , STRING Username , STRING Password );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION SendMessage ( LeapBaseMessage msg );
        FUNCTION SendRawJson ( STRING str );
        FUNCTION FailedResponse ();
        SIGNED_LONG_INTEGER_FUNCTION GetHeartbeatTime ();
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetResponseTime ();
        FUNCTION Reconnect ();
        FUNCTION SendHeartbeat ();
        FUNCTION SendTrace ( STRING msg );
        FUNCTION Strikeout ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING IPAddress[];
        INTEGER Id;
    };

namespace Lutron.Leap.CommLib.Components.SubComponents;
        // class declarations
         class LeapScene;
         class LeapButton;

namespace Lutron.Leap.CommLib.LeapSupport;
        // class declarations
         class ScaleUtil;
         class ProtocolUtil;
     class ScaleUtil 
    {
        // class delegates

        // class events

        // class functions
        static INTEGER_FUNCTION Scale ( INTEGER inp , INTEGER inpMin , INTEGER inpMax , INTEGER outMin , INTEGER outMax );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ProtocolUtil 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GetCurve ( STRING href );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Lutron.Leap.CommLib.JsonSupport;
        // class declarations
         class LeapMessageJsonConverter;
     class LeapMessageJsonConverter 
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

namespace Lutron.Leap.CommLib.Models;
        // class declarations
         class LeapHeader;
         class LeapDirectives;
         class LeapBaseMessage;
     class LeapHeader 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING StatusCode[];
        STRING Url[];
        LeapDirectives Directives;
    };

     class LeapDirectives 
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

     class LeapBaseMessage 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommuniqueType CommuniqueType;
        LeapHeader Header;
    };

namespace Lutron.Leap.CommLib.Helper;
        // class declarations
         class CCITimer;

namespace Lutron.Leap.CommLib.CCI_Support;
        // class declarations

