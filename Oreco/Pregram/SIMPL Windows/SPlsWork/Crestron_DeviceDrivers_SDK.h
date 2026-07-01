namespace Crestron.DeviceDrivers.SDK;
        // class declarations
         class CommandBuilderArgs;
         class CommandComponentArgs;
         class ComponentArgs;
         class CommandData;
         class CommandDefinition;
         class ImplementationInfo;
         class CommandIdDefinition;
         class CommandRequest;
         class CommandTransportInfoTypeResolver;
         class CommandWithValueLookup;
         class CommandWithValues;
         class CustomCommandBuilder;
         class DelegateCommandFactory;
         class CommandIdRolloverBehavior;
         class CommandResponseExpectation;
         class IntegerCommandId;
         class IntegerCommandIdFactory;
         class SingleCommandBuilder;
         class TransportInfoCommand;
         class ConditionComponentArgs;
         class ConditionDefinition;
         class CommandRepeatTiming;
         class ControllerAdditionalState;
         class ControllerCommandSet;
         class ControllerComponentArgs;
         class ControllerComponentDependencies;
         class ControllerDefinition;
         class ControllerProperty;
         class DelegateDeviceState;
         class DelegateDeviceStateCommandHandler;
         class DelegateDeviceStateCommandSource;
         class DeviceStateBase;
         class StateCommand;
         class PollingConfiguration;
         class PollingDeviceStateBase;
         class StateCommandRepeatTiming;
         class StateController;
         class StateWithDeviceUnits;
         class AResponseProcessingNode;
         class CommandDecodeResponseProcessor;
         class CommandDecodeResponseProcessorFactory;
         class CommandResponse;
         class DelimitingResponseProcessingNode;
         class ResponseProcessingNode;
         class ProcessingBehavior;
         class SelectType;
         class ConditionType;
         class ResponseProcessingNodeResult;
         class ResponseProcessingStepStatus;
         class ResponseComponentArgs;
         class ResponseProcessingContext;
         class ResponseProcessingDefinition;
         class ResponseProcessingNodeInfo;
         class ResponseProcessorData;
         class ResponseStreamReader;
         class ResponseReaderWrapper;
         class ControlCommandRuleExecution;
         class DidSendRuleExecution;
         class FeedbackRuleExecution;
         class RuleComponentArgs;
         class RuleConditionChecker;
         class RuleDefinition;
         class RuleTriggerTypes;
         class StateChangeRuleExecution;
         class WillSendRuleExecution;
         class DelegateTransformation;
         class DelegateTransformationFactory;
         class TransformationCall;
         class TransformationComponentArgs;
         class TransformationException;
         class TransformCallDefinition;
         class TransformDefinition;
         class CommandResponseTransportProcessor;
         class EmptyCommandTransportInfoDefinition;
         class EmptyResponseData;
         class EmptyTransportInfoBuilder;
         class TransportType;
         class GenericStreamTransport;
         class TransportBase;
         class IpTransportConfigurationItemFactory;
         class ConfigurationItemDefinition;
         class ResponseNodeProcessor;
         class StandaloneCommandCoordinator;
         class TransportComponentArgs;
         class TransportCoordinator;
         class TransportCoordinatorArgs;
         class TransportDefinition;
         class TransportInfo;
         class TransportInfoComponentArgs;
         class TransportRxData;
         class TransportWatchDog;
         class InputUserAttributeInfo;
         class InputUserAttributeInfoInfoTypeFactory;
         class ConnectionRequirement;
         class InputDataType;
         class UrlUserAttributeInfo;
         class UrlUserAttributeInfoInfoTypeFactory;
         class UserAttributeDefinition;
         class CommandSourceList;
         class ControlCommand;
         class DeviceStateAndConfigCollection;
         class DriverComponentContext;
         class DriverCoordinator;
         class DriverCoordinatorArgs;
         class DriverDefinitionInitialization;
         class DriverImplementationResources;
         class DriverInitializationArgs;
         class StateVariables;
         class SupportedFeatureDefinition;
         class BasicTemplateString;
         class ConstantTemplateString;
         class NoTemplateString;
         class ParameterReferenceTemplateString;
         class ValueLookupKey;
         class TemplateString;
         class ComponentLogger;
         class DriverLogger;
         class LoggingConstants;
         class ConditionalConfigurationStepDefinition;
         class ConfigurationDefinition;
         class ConfigurationItemValidationDefinition;
         class ConfigurationStepDefinition;
         class ConfigurationStepsDefinition;
         class ConfigurationStepValidationDefinition;
         class DeveloperInformationDefinition;
         class DriverComponentFragment;
         class DriverConfig;
         class DriverConfigFile;
         class DriverControllerDefinition;
         class DriverDefinition;
         class BaseDefinitionType;
         class ParameterVisibility;
         class StringType;
         class ParameterUnit;
         class ProcessorPlatform;
         class DeviceType;
         class ExtensionDeviceDataDefinition;
         class GeneralInformationDefinition;
         class InputOutputDefinition;
         class NamedDefinition;
         class TypedDefinition;
         class Serialization;
         class ActionSchedule;
         class ActionScheduleExecutor;
         class MillisTickStopwatch;
         class PolledTimeout;
         class RepeatingScheduleAction;
         class ScheduleAction;
         class ScheduledTimeout;
         class Time;
         class ValueLookup;
         class ValueLookupIndex;
         class ValueLookupIndexType;
         class ValueLookupKeySpec;
         class ValueLookupWithDefaultKeyContext;
           class StateChangedEventArgs;
           class BooleanEventArgs;
           class TransportRxEventArgs;
           class FeedbackEventArgs;
           class StateChangeSetEventArgs;
           class LogEventArgs;
           class LogEntryLevelChangedArgs;
           class DriverEntityImplementation;
     class ComponentArgs 
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

     class CommandData 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Data[];
        CommandResponseExpectation ResponseExpectation;
        STRING Transport[];
        LONG_INTEGER PostCommandDelay;
        STRING StatesSetByCommand[][];
        STRING StatesPolledByCommand[][];
    };

     class CommandDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Transport[];
        STRING Type[];
        STRING Name[];
    };

     class ImplementationInfo 
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
        STRING Name[];
    };

     class CommandIdDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommandIdRolloverBehavior Rollover;
        STRING Type[];
        STRING Name[];
    };

     class CommandTransportInfoTypeResolver 
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

     class DelegateCommandFactory 
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

    static class CommandIdRolloverBehavior // enum
    {
        static SIGNED_LONG_INTEGER Default;
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Reconnect;
    };

    static class CommandResponseExpectation // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER HasResponse;
        static SIGNED_LONG_INTEGER HasNoResponse;
    };

     class IntegerCommandIdFactory 
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

     class ConditionDefinition 
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
        STRING Name[];
    };

     class CommandRepeatTiming 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER RepeatDelay;
        LONG_INTEGER RepeatHoldOff;
    };

     class ControllerDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Priority;
        LONG_INTEGER CommandRetryCount;
        LONG_INTEGER DeviceProcessingTime;
        LONG_INTEGER PollingHoldoffTime;
        LONG_INTEGER FeedbackHoldoffTime;
        LONG_INTEGER PollingInterval;
        PollingConfiguration PollingConfiguration;
        STRING InvalidationFeedback[];
        STRING ValuesWithoutFeedback[];
        STRING Type[];
        STRING Name[];
    };

     class DeviceStateBase 
    {
        // class delegates

        // class events
        EventHandler Changed ( DeviceStateBase sender, StateChangedEventArgs e );

        // class functions
        FUNCTION ProcessFeedback ( ValueLookup feedback );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StateWithDeviceUnits PresentState;
        StateWithDeviceUnits TargetState;
        DriverComponentContext Context;
        STRING Name[];
    };

    static class StateCommand // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Set;
        static SIGNED_LONG_INTEGER Toggle;
        static SIGNED_LONG_INTEGER Increment;
        static SIGNED_LONG_INTEGER Decrement;
        static SIGNED_LONG_INTEGER PressAndHold;
        static SIGNED_LONG_INTEGER HoldIncrement;
        static SIGNED_LONG_INTEGER HoldDecrement;
        static SIGNED_LONG_INTEGER CycleUp;
        static SIGNED_LONG_INTEGER CycleDown;
        static SIGNED_LONG_INTEGER HoldCycleUp;
        static SIGNED_LONG_INTEGER HoldCycleDown;
        static SIGNED_LONG_INTEGER Release;
        static SIGNED_LONG_INTEGER SetToDefault;
        static SIGNED_LONG_INTEGER SetTimeout;
        static SIGNED_LONG_INTEGER PresetCycleUp;
        static SIGNED_LONG_INTEGER PresetCycleDown;
        static SIGNED_LONG_INTEGER PresetHoldCycleUp;
        static SIGNED_LONG_INTEGER PresetHoldCycleDown;
        static SIGNED_LONG_INTEGER PresetStore;
        static SIGNED_LONG_INTEGER PresetRecall;
        static SIGNED_LONG_INTEGER SendCommand;
        static SIGNED_LONG_INTEGER SendCustomCommand;
        static SIGNED_LONG_INTEGER Connect;
        static SIGNED_LONG_INTEGER Disconnect;
        static SIGNED_LONG_INTEGER ProvideGenericStreamTransport;
        static SIGNED_LONG_INTEGER SetBand;
        static SIGNED_LONG_INTEGER ProvideCustomTransport;
        static SIGNED_LONG_INTEGER Push;
        static SIGNED_LONG_INTEGER CycleOffOn;
        static SIGNED_LONG_INTEGER Get;
        static SIGNED_LONG_INTEGER Begin;
        static SIGNED_LONG_INTEGER End;
        static SIGNED_LONG_INTEGER SetPollingInterval;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Cancel;
        static SIGNED_LONG_INTEGER CustomCommandBase;
    };

    static class PollingConfiguration // enum
    {
        static SIGNED_LONG_INTEGER Always;
        static SIGNED_LONG_INTEGER Never;
        static SIGNED_LONG_INTEGER IfUnknown;
    };

     class PollingDeviceStateBase 
    {
        // class delegates

        // class events
        EventHandler Changed ( PollingDeviceStateBase sender, StateChangedEventArgs e );

        // class functions
        FUNCTION OnCommandWillSend ( CommandData command );
        FUNCTION OnPollingCommandWillSend ( CommandData command );
        FUNCTION ProcessCommand ( ControlCommand command );
        FUNCTION ProcessFeedback ( ValueLookup feedback );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Priority;
        StateWithDeviceUnits PresentState;
        StateWithDeviceUnits TargetState;
        DriverComponentContext Context;
        STRING Name[];
    };

     class StateCommandRepeatTiming 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StateCommand Command;
        LONG_INTEGER RepeatDelay;
        LONG_INTEGER RepeatHoldOff;
    };

     class StateController 
    {
        // class delegates

        // class events
        EventHandler Changed ( StateController sender, StateChangedEventArgs e );

        // class functions
        FUNCTION Dispose ();
        FUNCTION OnCommandWillSend ( CommandData command );
        FUNCTION OnPollingCommandWillSend ( CommandData command );
        FUNCTION ProcessCommand ( ControlCommand command );
        FUNCTION ProcessFeedback ( ValueLookup feedback );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Priority;
        StateWithDeviceUnits PresentState;
        StateWithDeviceUnits TargetState;
        DriverComponentContext Context;
        STRING Name[];
    };

     class AResponseProcessingNode 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ResponseComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class CommandDecodeResponseProcessorFactory 
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

     class DelimitingResponseProcessingNode 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ResponseComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

    static class ProcessingBehavior // enum
    {
        static SIGNED_LONG_INTEGER UntilMatch;
        static SIGNED_LONG_INTEGER Continue;
        static SIGNED_LONG_INTEGER Stop;
    };

    static class SelectType // enum
    {
        static SIGNED_LONG_INTEGER All;
        static SIGNED_LONG_INTEGER Any;
        static SIGNED_LONG_INTEGER IfPresent;
    };

    static class ConditionType // enum
    {
        static SIGNED_LONG_INTEGER Match;
        static SIGNED_LONG_INTEGER Ack;
    };

    static class ResponseProcessingNodeResult // enum
    {
        static SIGNED_LONG_INTEGER Incomplete;
        static SIGNED_LONG_INTEGER Match;
        static SIGNED_LONG_INTEGER ContinueMatch;
        static SIGNED_LONG_INTEGER NoMatch;
        static SIGNED_LONG_INTEGER StopNoMatch;
    };

    static class ResponseProcessingStepStatus // enum
    {
        static SIGNED_LONG_INTEGER Incomplete;
        static SIGNED_LONG_INTEGER Match;
        static SIGNED_LONG_INTEGER NoMatch;
    };

     class ResponseProcessingDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Condition[];
        ConditionType ConditionType;
        STRING Match[];
        STRING Output[];
        ProcessingBehavior Processing;
        SelectType SelectType;
        STRING Type[];
        STRING Name[];
    };

     class ResponseProcessingNodeInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ResponseProcessorData ProcessorData;
        ProcessingBehavior Processing;
        STRING MatchOutput[];
        SelectType SelectType;
        ConditionType ConditionType;
    };

     class ControlCommandRuleExecution 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddCommand ( ControlCommand command );
        FUNCTION Block ();
        FUNCTION RemoveOriginalCommandWithoutBlocking ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ControlCommand OriginalCommand;
        DriverComponentContext Context;
    };

     class DidSendRuleExecution 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddControlCommand ( ControlCommand command );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING OriginalCommandName[];
        ValueLookup States;
    };

     class FeedbackRuleExecution 
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

     class RuleDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AppliesTo[];
        STRING Condition[];
        STRING Except[];
        STRING Type[];
        STRING Name[];
    };

    static class RuleTriggerTypes // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER ControlCommand;
        static SIGNED_LONG_INTEGER Feedback;
        static SIGNED_LONG_INTEGER StateChange;
        static SIGNED_LONG_INTEGER WillSend;
        static SIGNED_LONG_INTEGER DidSend;
    };

     class StateChangeRuleExecution 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddControlCommand ( ControlCommand command );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StateChangedEventArgs ChangeEvent;
        ValueLookup States;
    };

     class WillSendRuleExecution 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Block ();
        FUNCTION ReplaceCommandsWith ( CommandRequest newCommands[] );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommandRequest OriginalCommand;
        ValueLookup States;
    };

     class DelegateTransformationFactory 
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

     class TransformCallDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Output[];
        STRING Transformation[];
    };

     class TransformDefinition 
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
        STRING Name[];
    };

     class EmptyCommandTransportInfoDefinition 
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

     class EmptyResponseData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static Crestron.DeviceDrivers.SDK.EmptyResponseData Instance;

        // class properties
    };

     class EmptyTransportInfoBuilder 
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

    static class TransportType // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER CecDevice;
        static SIGNED_LONG_INTEGER CrestronConnected;
        static SIGNED_LONG_INTEGER Http;
        static SIGNED_LONG_INTEGER Ir;
        static SIGNED_LONG_INTEGER SerialComport;
        static SIGNED_LONG_INTEGER Simpl;
        static SIGNED_LONG_INTEGER Tcp;
        static SIGNED_LONG_INTEGER Telnet;
        static SIGNED_LONG_INTEGER Udp;
    };

     class TransportBase 
    {
        // class delegates

        // class events
        EventHandler OnDeviceConnectionChanged ( TransportBase sender, BooleanEventArgs e );
        EventHandler OnUserConnectionChanged ( TransportBase sender, BooleanEventArgs e );
        EventHandler OnDataReceived ( TransportBase sender, TransportRxEventArgs e );
        EventHandler OnReadyToSend ( TransportBase sender, EventArgs e );
        EventHandler OnWatchDogHeartbeat ( TransportBase sender, EventArgs e );

        // class functions
        FUNCTION Dispose ();
        FUNCTION Send ( CommandData data );
        FUNCTION Disconnect ();
        FUNCTION Cancel ();
        FUNCTION Reinitialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        LONG_INTEGER WaitForResponseTimeout;
        LONG_INTEGER WatchDogTimerInterval;
    };

    static class IpTransportConfigurationItemFactory 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING DatFileConfigurationType[];
        static STRING DriverTransportPostfix[];

        // class properties
    };

     class ConfigurationItemDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Availability[];
        STRING AvailableValues[][];
        STRING CurrentValue[];
        STRING CurrentValueDisplayOverride[];
        STRING DefaultValue[];
        STRING Description[];
        STRING DescriptionLocalizationKey[];
        STRING Id[];
        STRING Units[];
        STRING NonInteractiveDescription[];
        STRING NonInteractiveDescriptionLocalizationKey[];
        STRING NonInteractiveTitle[];
        STRING NonInteractiveTitleLocalizationKey[];
        STRING Title[];
        STRING TitleLocalizationKey[];
        STRING TransportIdForChannelId[];
        STRING UsageContext[];
        STRING UsageContextGroupId[];
        STRING ValueType[];
        STRING RenderHint[];
    };

     class TransportDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER TimeBetweenCommands;
        STRING ResponseProcessor[];
        STRING ResponseDelimiter[];
        STRING CommandResponseAfterPreprocessor[];
        STRING CommandResponseAfterPostprocessor[];
        LONG_INTEGER WaitForResponseTimeout;
        STRING Coordinator[];
        STRING Type[];
        STRING Name[];
    };

    static class TransportInfo 
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

     class InputUserAttributeInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING UserAttributeTypeOnScreen[];
        static STRING UserAttributeTypeDeviceId[];
        static STRING UserAttributeTypeCustom[];
        static STRING UserAttributeTypeUrl[];

        // class properties
        InputDataType DataType;
        STRING DefaultValue[];
        ConnectionRequirement RequiredForConnection;
    };

     class InputUserAttributeInfoInfoTypeFactory 
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

    static class ConnectionRequirement // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Before;
        static SIGNED_LONG_INTEGER After;
    };

    static class InputDataType // enum
    {
        static SIGNED_LONG_INTEGER String;
        static SIGNED_LONG_INTEGER Number;
        static SIGNED_LONG_INTEGER Boolean;
        static SIGNED_LONG_INTEGER Hex;
    };

     class UrlUserAttributeInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING UserAttributeTypeOnScreen[];
        static STRING UserAttributeTypeDeviceId[];
        static STRING UserAttributeTypeCustom[];
        static STRING UserAttributeTypeUrl[];

        // class properties
        STRING DefaultValueLabel[];
        InputDataType DataType;
        STRING DefaultValue[];
        ConnectionRequirement RequiredForConnection;
    };

     class UrlUserAttributeInfoInfoTypeFactory 
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

     class UserAttributeDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Description[];
        STRING Label[];
        STRING Type[];
        STRING Name[];
    };

    static class DriverDefinitionInitialization 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION LoadDependencies ( DriverInitializationArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DriverImplementationResources 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DriverDefinition DriverDefinition;
        DeviceStateAndConfigCollection StatesAndConfig;
        DriverCoordinator Coordinator;
    };

    static class StateVariables 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION BuildConfigParameter ( STRING parameterId );
        static STRING_FUNCTION RemoveConfigParameterPrefix ( STRING parameterId );
        static STRING_FUNCTION Prefix ( STRING optionalPrefix , STRING parameterId );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING True[];
        static STRING False[];
        static STRING DriverDataStore[];
        static STRING IdByte[];
        static STRING Ack[];
        static STRING Packet[];
        static STRING CommandName[];
        static STRING CommandId[];
        static STRING Connection[];
        static STRING UserConnection[];
        static STRING Model[];
        static STRING Username[];
        static STRING Password[];
        static STRING Host[];
        static STRING Port[];
        static STRING Context[];
        static STRING ParentGateway[];
        static STRING ControlSystem[];
        static STRING CresnetId[];
        static STRING InfinetExId[];
        static STRING IpId[];

        // class properties
    };

     class SupportedFeatureDefinition 
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
        STRING Name[];
    };

    static class LoggingConstants 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GenerateReceiveTag ( STRING transportName );
        static STRING_FUNCTION GenerateSendTag ( STRING transportName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Receive[];
        static STRING Send[];
        static STRING SendReceiveLoggingFormatString[];
        static STRING ComponentTypeSeparator[];
        static STRING ComponentTypeOther[];
        static STRING ComponentTypeTransformation[];
        static STRING ComponentTypeCondition[];
        static STRING ComponentTypeRule[];
        static STRING ComponentTypeResponse[];
        static STRING ComponentTypeCommand[];
        static STRING ComponentTypeTransport[];
        static STRING ComponentTypeController[];
        static STRING ComponentTypeCoordinator[];
        static STRING ComponentTypeCapability[];

        // class properties
    };

     class ConditionalConfigurationStepDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Condition[];
        STRING Step[];
    };

     class ConfigurationDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DriverInstanceIdentifier[];
        LONG_INTEGER MinTimeBetweenCommands;
    };

     class ConfigurationItemValidationDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ErrorCondition[];
        STRING ErrorMessage[];
    };

     class ConfigurationStepDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING NextStep[];
        STRING StepId[];
    };

     class ConfigurationStepsDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING FirstStep[];
    };

     class ConfigurationStepValidationDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AssociatedItem[];
        STRING ErrorCondition[];
        STRING ErrorMessage[];
    };

     class DeveloperInformationDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Company[];
        STRING Contact[];
        STRING Email[];
        STRING Website[];
        STRING PhoneNumber[];
    };

     class DriverComponentFragment 
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
        STRING Condition[];
        DriverEntityImplementation EntityModel;
    };

     class DriverConfig 
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

     class DriverConfigFile 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FileName[];

        // class properties
    };

     class DriverControllerDefinition 
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

     class DriverDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CurrentSchemaVersion[];

        // class properties
        GeneralInformationDefinition GeneralInformation;
        STRING SchemaVersion[];
        ConfigurationStepsDefinition ConfigurationSteps;
        ConfigurationDefinition Configuration;
        DriverControllerDefinition DriverController;
    };

     class BaseDefinitionType 
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

    static class ParameterVisibility // enum
    {
        static SIGNED_LONG_INTEGER Default;
        static SIGNED_LONG_INTEGER Advanced;
        static SIGNED_LONG_INTEGER Hidden;
    };

    static class StringType // enum
    {
        static SIGNED_LONG_INTEGER Text;
        static SIGNED_LONG_INTEGER LongText;
        static SIGNED_LONG_INTEGER TemplateString;
        static SIGNED_LONG_INTEGER LongTemplateString;
        static SIGNED_LONG_INTEGER ExistingParameter;
        static SIGNED_LONG_INTEGER NewParameter;
        static SIGNED_LONG_INTEGER NewOrExistingParameter;
    };

    static class ParameterUnit 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Milliseconds[];

        // class properties
    };

    static class ProcessorPlatform 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Series3[];
        static STRING Series4[];

        // class properties
    };

    static class DeviceType 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING AvReceiver[];
        static STRING FlatPanelDisplay[];
        static STRING Projector[];
        static STRING Speaker[];
        static STRING NetworkSwitch[];
        static STRING CableBox[];
        static STRING Platform[];
        static STRING Lights[];
        static STRING VideoServer[];

        // class properties
    };

     class ExtensionDeviceDataDefinition 
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

     class GeneralInformationDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING BaseModel[];
        STRING Description[];
        STRING DriverVersion[];
        STRING Manufacturer[];
        STRING MinCresDbVersion[];
        STRING MinSdkVersion[];
        STRING MinToolboxVersion[];
        STRING DeviceIcon[];
        STRING DeviceType[];
        DeveloperInformationDefinition Developer;
        STRING DependencyGroup[];
        ExtensionDeviceDataDefinition ExtensionDeviceData;
    };

     class InputOutputDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING FriendlyName[];
        STRING Type[];
        STRING Name[];
    };

     class NamedDefinition 
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

     class TypedDefinition 
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
        STRING Name[];
    };

    static class Serialization 
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

     class MillisTickStopwatch 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static LONG_INTEGER Stopped;

        // class properties
        LONG_INTEGER ElapsedMilliseconds;
    };

     class ScheduleAction 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION DoAction ();
        FUNCTION Reschedule ( LONG_INTEGER delay );
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER ScheduledTimeMillis;
    };

    static class Time 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static LONG_INTEGER Millisecond;
        static LONG_INTEGER MillisecondsInSecond;
        static LONG_INTEGER Second;
        static LONG_INTEGER SecondsInMinute;
        static LONG_INTEGER MinutesInHour;
        static LONG_INTEGER HoursInDay;
        static LONG_INTEGER SecondsInHour;
        static LONG_INTEGER SecondsInDay;
        static LONG_INTEGER MillisecondsInDay;
        static LONG_INTEGER Minute;
        static LONG_INTEGER Hour;
        static LONG_INTEGER Day;
        static LONG_INTEGER DefaultMaxMillisTimeout;

        // class properties
        LONG_INTEGER Millis;
    };

    static class ValueLookupIndexType // enum
    {
        static SIGNED_LONG_INTEGER Invalid;
        static SIGNED_LONG_INTEGER Any;
        static SIGNED_LONG_INTEGER TargetState;
        static SIGNED_LONG_INTEGER TargetDevice;
        static SIGNED_LONG_INTEGER TargetPending;
        static SIGNED_LONG_INTEGER PresentState;
        static SIGNED_LONG_INTEGER PresentPending;
    };

    static class ValueLookupKeySpec // enum
    {
        static SIGNED_LONG_INTEGER Invalid;
        static SIGNED_LONG_INTEGER DefaultForContext;
        static SIGNED_LONG_INTEGER DefaultTargetState;
        static SIGNED_LONG_INTEGER DefaultPresentState;
        static SIGNED_LONG_INTEGER TargetEffective;
        static SIGNED_LONG_INTEGER TargetState;
        static SIGNED_LONG_INTEGER TargetDevice;
        static SIGNED_LONG_INTEGER TargetPending;
        static SIGNED_LONG_INTEGER PresentEffective;
        static SIGNED_LONG_INTEGER PresentState;
        static SIGNED_LONG_INTEGER PresentPending;
    };

namespace Crestron.DeviceDrivers.SDK.Plugins;
        // class declarations
         class DriverFrameworkPlugin;
     class DriverFrameworkPlugin 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.Util;
        // class declarations
         class AllowedException;
         class ByteMath;
         class ObjectPool;
         class DefaultEncoding;
         class ImplementationMissingException;
         class HasImplementationProviderAttribute;
         class ImplementationProviderAttribute;
         class NamedImplementationProvider;
         class LoggingCast;
         class HistoricalAllocStringBuilder;
         class HistoricalLengthStringBuilder;
         class UnoptimizedStringBuilder;
         class ReflectionFunc;
         class ConsoleWrapper;
         class CriticalSection;
         class DelegateWrapperBase;
         class DriverDataStore;
         class EventWrapper;
         class FileSystem;
         class InitialParameters;
         class PersistentValue;
         class Resources;
         class ResourcesFromTypeAssembly;
         class ThreadEventWrapper;
         class ThreadWrapper;
         class BufferedStream;
         class BufferedStreamReader;
         class EmptyBufferedStreamReader;
         class StringUtils;
    static class ByteMath 
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

    static class ObjectPool 
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

    static class DefaultEncoding 
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

     class ImplementationMissingException 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Message[];
        STRING StackTrace[];
        STRING HelpLink[];
        STRING Source[];
        SIGNED_LONG_INTEGER HResult;
    };

     class HasImplementationProviderAttribute 
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

     class NamedImplementationProvider 
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

    static class LoggingCast 
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

     class HistoricalAllocStringBuilder 
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

     class HistoricalLengthStringBuilder 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER MaxLength;
    };

     class UnoptimizedStringBuilder 
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

    static class ReflectionFunc 
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

    static class ConsoleWrapper 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION WriteLine ( STRING message );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CriticalSection 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION DisposeLock ();
        FUNCTION Leave ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DelegateWrapperBase 
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

     class EventWrapper 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Dispose ();
        FUNCTION ClearSubscribers ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class FileSystem 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION CombinePath ( STRING part1 , STRING part2 );
        static STRING_FUNCTION NormalizePath ( STRING path );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING DefaultBackupExtension[];

        // class properties
        STRING DriverSdkPath[];
        STRING AppRootDirectory[];
    };

    static class InitialParameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER ApplicationNumber;
    };

    static class Resources 
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

    static class ResourcesFromTypeAssembly 
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

     class BufferedStream 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Dispose ();
        FUNCTION Clear ();
        FUNCTION Consume ( SIGNED_LONG_INTEGER numBytes );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class StringUtils 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION BytesToHex ( STRING input , STRING separator );
        static STRING_FUNCTION ToCamelCase ( STRING s );
        static STRING_FUNCTION JsonEscapeNonAsciiCharacters ( STRING s );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.Util.Tools;
        // class declarations
         class ConsoleDriverControllerLogger;
     class ConsoleDriverControllerLogger 
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

namespace Crestron.DeviceDrivers.SDK.Util.TestHooks;
        // class declarations
         class TestHarness;
     class TestHarness 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        TestHarness ActiveHooks;
        LONG_INTEGER Millis;
    };

namespace Crestron.DeviceDrivers.SDK.Util.SimplSharp;
        // class declarations
         class HashCalculation;
     class HashCalculation 
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

namespace Crestron.DeviceDrivers.SDK.Util.WebSocket;
        // class declarations
         class WebSocket;
         class WebSocketClientConnectionEventArgs;
         class WebSocketFrame;
         class FrameControlBits;
         class WebSocketPacketEventArgs;
         class WebSocketServer;
    static class WebSocket 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GenerateHandshakeRequest ( STRING endpoint , STRING hostHeader , BYREF STRING expectedHash );
        static STRING_FUNCTION GenerateHandshakeResponse ( STRING requestData );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class FrameControlBits // enum
    {
        static SIGNED_LONG_INTEGER OpContinuation;
        static SIGNED_LONG_INTEGER OpText;
        static SIGNED_LONG_INTEGER OpBinary;
        static SIGNED_LONG_INTEGER OpClose;
        static SIGNED_LONG_INTEGER OpPing;
        static SIGNED_LONG_INTEGER OpPong;
        static SIGNED_LONG_INTEGER OpCode;
        static SIGNED_LONG_INTEGER Fin;
    };

namespace Crestron.DeviceDrivers.SDK.Util.Extensions;
        // class declarations
         class AttributeExtensions;
         class CollectionExtensions;
         class CopyExtensions;
         class DebugExtensions;
         class DriverCoordinatorExtensions;
         class EnumExtensions;
         class LoggingExtensions;
         class LookupExtensions;
         class ImplementationProviderAttributeExtensions;
         class ImplementationProviderExtensions;
    static class AttributeExtensions 
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

    static class CollectionExtensions 
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

    static class CopyExtensions 
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

    static class DebugExtensions 
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

    static class DriverCoordinatorExtensions 
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

    static class EnumExtensions 
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

    static class LoggingExtensions 
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

    static class LookupExtensions 
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

    static class ImplementationProviderAttributeExtensions 
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

    static class ImplementationProviderExtensions 
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

namespace Crestron.DeviceDrivers.SDK.Schema.Attributes;
        // class declarations
         class ProviderTypeAttribute;

namespace Crestron.DeviceDrivers.SDK.Attributes;
        // class declarations
         class DefaultValueAttribute;
         class DriverParameterAttribute;
         class ResolveTypeCallbackAttribute;
     class DriverParameterAttribute 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GetDefaultFriendlyName ( STRING propertyName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Description[];
        ParameterVisibility Visibility;
        LONG_INTEGER ParameterIndex;
        STRING TableColumnNames[][];
        STRING TableColumnDescriptions[][];
        StringType StringType;
        StringType DictKeyStringType;
        SIGNED_LONG_INTEGER ValueDisplayPrecision;
        STRING Unit[];
    };

namespace Crestron.DeviceDrivers.SDK.Events;
        // class declarations
         class BooleanEventArgs;
         class ConfigChangeSetEventArgs;
         class FeedbackEventArgs;
         class LogEntryLevelChangedArgs;
         class LogEventArgs;
         class StateChangedEventArgs;
         class ValueChange;
         class StateChangedEventArgsFactory;
         class StateChangeSetEventArgs;
         class TransportRxEventArgs;
     class BooleanEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        BooleanEventArgs True;
        BooleanEventArgs False;
    };

     class ValueChange 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        FUNCTION Update ( ValueChange newChange );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class TransportRxEventArgs 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION Return ( TransportRxEventArgs instance );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.EntityModel;
        // class declarations
         class BaseDriverEntity;
         class BatchPropertyChangeTracker;
         class CachedPropertyInstance;
         class PropertyInstance;
         class CommandInstance;
         class ConfigurableDriverEntity;
         class ConfigurationItemErrors;
         class CoordinatorConfigurationController;
         class DataDrivenConfigurationController;
         class ApplyConfigurationAction;
         class CoordinatorDriverEntity;
         class ManuallyRaisedEventInstance;
         class CoordinatorDriverEntityArgs;
         class CoordinatorDriverEntityCreationDependencies;
         class DataDirectoryLocalization;
         class DataDrivenConfigurationControllerArgs;
         class DelegateCommandInstance;
         class DelegateDataDrivenConfigurationController;
         class DelegatePropertyInstance;
         class DispatchingDeviceController;
         class DriverControllerChannelGenericStreamTransport;
         class DriverEntityTransportTxChannel;
         class DriverEntityValueJsonConverter;
         class EntityTypeInstance;
         class EventInstance;
         class ExtensionDoCommandExecutor;
         class ExtensionObject;
         class ExtensionOperationResult;
         class ExtensionOperationResultCode;
         class ExtensionSetPropertyValueExecutor;
         class UiDefinitionProperty;
         class FragmentedDriverEntity;
         class JsonDriverEntryPoint;
         class ModelSerialization;
         class NestedDriverControllerLogger;
         class NoConfigurationController;
         class NoLocalization;
         class ReflectedAttributeDriverEntity;
         class ReflectionEventInstance;
     class PropertyInstance 
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

     class CommandInstance 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Id[];
    };

     class DataDrivenConfigurationController 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION UnsetTransportImplementation ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class ApplyConfigurationAction // enum
    {
        static SIGNED_LONG_INTEGER ApplyAll;
        static SIGNED_LONG_INTEGER ApplyStep;
        static SIGNED_LONG_INTEGER ClearValues;
    };

     class DataDirectoryLocalization 
    {
        // class delegates

        // class events
        EventHandler SupportedCulturesChanged ( DataDirectoryLocalization sender, EventArgs e );
        EventHandler LanguageTranslationsChanged ( DataDirectoryLocalization sender, EventArgs e );

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DriverEntityTransportTxChannel 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Dispose ();
        FUNCTION Send ( STRING data );
        FUNCTION SetChannelId ( STRING channelId );
        FUNCTION UnsetTransportImplementation ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DriverEntityValueJsonConverter 
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

     class EntityTypeInstance 
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

     class EventInstance 
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

     class ExtensionObject 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ExtensionObjectId[];
    };

    static class ExtensionOperationResultCode // enum
    {
        static SIGNED_LONG_INTEGER Uninitialized;
        static SIGNED_LONG_INTEGER Success;
        static SIGNED_LONG_INTEGER Error;
    };

     class JsonDriverEntryPoint 
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

     class ModelSerialization 
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

     class NoConfigurationController 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION UnsetTransportImplementation ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        NoConfigurationController Instance;
    };

     class NoLocalization 
    {
        // class delegates

        // class events
        EventHandler SupportedCulturesChanged ( NoLocalization sender, EventArgs e );
        EventHandler LanguageTranslationsChanged ( NoLocalization sender, EventArgs e );

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static Crestron.DeviceDrivers.SDK.EntityModel.NoLocalization Instance;

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.EntityModel.Util;
        // class declarations
         class DriverEntityValueExtensions;
         class EntityModelUtils;
    static class DriverEntityValueExtensions 
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

    static class EntityModelUtils 
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

namespace Crestron.DeviceDrivers.SDK.EntityModel.Data;
        // class declarations
         class ConfigurationItemContext;
         class Generic;
         class Com;
         class Network;
         class Authentication;
         class Cec;
         class ResourceObject;
         class ConfigurationItemRenderHint;
         class CoordinatorCommandInstance;
         class DriverEntityCommandImplementation;
         class DriverEntityEventImplementation;
         class DriverEntityImplementation;
         class DriverEntityPropertyImplementation;
         class OrderedDriverEntityCommandDefinition;
    static class ConfigurationItemContext 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Data[];

        // class properties
    };

    static class Generic 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Prompt[];
        static STRING Url[];

        // class properties
    };

    static class Com 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ChannelId[];
        static STRING Protocol[];
        static STRING BaudRate[];
        static STRING DataBits[];
        static STRING Parity[];
        static STRING StopBits[];
        static STRING HardwareHandshake[];
        static STRING SoftwareHandshake[];

        // class properties
    };

    static class Network 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Address[];
        static STRING Port[];
        static STRING IpId[];
        static STRING CresnetId[];
        static STRING RfId[];

        // class properties
    };

    static class Authentication 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Username[];
        static STRING Password[];

        // class properties
    };

    static class Cec 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ChannelId[];

        // class properties
    };

    static class ResourceObject 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ControlSystem[];
        static STRING ParentGateway[];

        // class properties
    };

    static class ConfigurationItemRenderHint 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING OnOff[];
        static STRING Slider[];

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.EntityModel.Attributes;
        // class declarations
         class EntityAvailableValueAttribute;
         class EntityCommandAttribute;
         class EntityValueAttribute;
         class EntityCommandMetadataAttribute;
         class EntityDataTypeAttribute;
         class EntityEventAttribute;
         class EntityEventMetadataAttribute;
         class EntityParameterAttribute;
         class EntityPropertyAttribute;
         class EntityPropertyMetadataAttribute;
     class EntityCommandAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AvailableValues[][];
        STRING AvailableValuesLabels[][];
        STRING AvailableValuesLocalizationKeys[][];
        STRING AvailableValuesProperty[];
        STRING Id[];
        STRING FriendlyName[];
        STRING NameLocalizationKey[];
        STRING ItemTypeRef[];
        STRING RangeProperty[];
        STRING RelativeRangeProperty[];
        STRING TypeRef[];
        STRING Units[];
        STRING UnitsProperty[];
    };

     class EntityValueAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AvailableValues[][];
        STRING AvailableValuesLabels[][];
        STRING AvailableValuesLocalizationKeys[][];
        STRING AvailableValuesProperty[];
        STRING Id[];
        STRING FriendlyName[];
        STRING NameLocalizationKey[];
        STRING ItemTypeRef[];
        STRING RangeProperty[];
        STRING RelativeRangeProperty[];
        STRING TypeRef[];
        STRING Units[];
        STRING UnitsProperty[];
    };

     class EntityCommandMetadataAttribute 
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

     class EntityDataTypeAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Id[];
    };

     class EntityEventAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING FriendlyName[];
        STRING Id[];
        STRING NameLocalizationKey[];
    };

     class EntityEventMetadataAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING TriggeredByCommands[][];
    };

     class EntityParameterAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AvailableValues[][];
        STRING AvailableValuesLabels[][];
        STRING AvailableValuesLocalizationKeys[][];
        STRING AvailableValuesProperty[];
        STRING Id[];
        STRING FriendlyName[];
        STRING NameLocalizationKey[];
        STRING ItemTypeRef[];
        STRING RangeProperty[];
        STRING RelativeRangeProperty[];
        STRING TypeRef[];
        STRING Units[];
        STRING UnitsProperty[];
    };

     class EntityPropertyAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AvailableValues[][];
        STRING AvailableValuesLabels[][];
        STRING AvailableValuesLocalizationKeys[][];
        STRING AvailableValuesProperty[];
        STRING Id[];
        STRING FriendlyName[];
        STRING NameLocalizationKey[];
        STRING ItemTypeRef[];
        STRING RangeProperty[];
        STRING RelativeRangeProperty[];
        STRING TypeRef[];
        STRING Units[];
        STRING UnitsProperty[];
    };

     class EntityPropertyMetadataAttribute 
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

namespace Crestron.DeviceDrivers.SDK.Extensions;
        // class declarations
         class Extensions;
         class DriverDefinitionExtensions;
    static class Extensions 
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

    static class DriverDefinitionExtensions 
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

namespace Crestron.DeviceDrivers.SDK.Transports.WebSocket;
        // class declarations
         class DedicatedThreadWebSocket;
         class WebSocketClientData;
         class WebSocketPacketType;
         class SimplWebSocketTransport;
         class SimplWebSocketTransportFactory;
         class WebSocketCommandTransportInfo;
         class CommandInfoTypeFactory;
         class WebSocketTransportFrame;
         class WebSocketTransportInfo;
         class WebSocketTransportInfoTypeFactory;
         class WebSocketTransportInfoBuilder;
         class WebSocketTransportInfoBuilderFactory;
     class WebSocketClientData 
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

    static class WebSocketPacketType // enum
    {
        static SIGNED_LONG_INTEGER Continuation;
        static SIGNED_LONG_INTEGER Text;
        static SIGNED_LONG_INTEGER Binary;
        static SIGNED_LONG_INTEGER Close;
        static SIGNED_LONG_INTEGER Ping;
        static SIGNED_LONG_INTEGER Pong;
    };

     class SimplWebSocketTransportFactory 
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

     class WebSocketCommandTransportInfo 
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

     class CommandInfoTypeFactory 
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

     class WebSocketTransportFrame 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        WebSocketCommandTransportInfo Info;
    };

     class WebSocketTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
        STRING Protocol[];
        STRING Url[];
        STRING ProxyHost[];
        LONG_INTEGER ProxyPort;
        STRING ProxyUsername[];
        STRING ProxyPassword[];
        LONG_INTEGER ReconnectInterval;
        LONG_INTEGER PingInterval;
    };

     class WebSocketTransportInfoTypeFactory 
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

     class WebSocketTransportInfoBuilderFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transports.Udp;
        // class declarations
         class UdpCommandTransportInfo;
         class UdpCommandTransportInfoDefinition;
         class CommandInfoTypeFactory;
         class UdpTransport;
         class UdpTransportFactory;
         class UdpTransportInfo;
         class UdpTransportInfoTypeFactory;
         class UdpTransportInfoBuilder;
         class UdpTransportInfoBuilderFactory;
         class UdpTransportMode;
     class UdpCommandTransportInfo 
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

     class UdpCommandTransportInfoDefinition 
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

     class CommandInfoTypeFactory 
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

     class UdpTransportFactory 
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

     class UdpTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
        SIGNED_LONG_INTEGER ReceiveBufferSize;
        UdpTransportMode Mode;
    };

     class UdpTransportInfoTypeFactory 
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

     class UdpTransportInfoBuilder 
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

     class UdpTransportInfoBuilderFactory 
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

    static class UdpTransportMode // enum
    {
        static SIGNED_LONG_INTEGER Bidirectional;
        static SIGNED_LONG_INTEGER SendOnly;
    };

namespace Crestron.DeviceDrivers.SDK.Transports.Tcp;
        // class declarations
         class TcpTransport;
         class TcpTransportFactory;
         class TcpTransportInfo;
         class TcpTransportInfoTypeFactory;
         class TcpTransportCommandInfoTypeFactory;
         class TcpTransportInfoBuilder;
         class TcpTransportInfoBuilderFactory;
     class TcpTransportFactory 
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

     class TcpTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
        LONG_INTEGER ReconnectInterval;
        STRING Encoding[];
    };

     class TcpTransportInfoTypeFactory 
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

     class TcpTransportCommandInfoTypeFactory 
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

     class TcpTransportInfoBuilder 
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

     class TcpTransportInfoBuilderFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transports.Serial;
        // class declarations
         class SerialTransportFactory;
         class SerialTransportInfo;
         class SerialTransportInfoTypeFactory;
         class SerialTransportCommandInfoTypeFactory;
         class SerialTransportInfoBuilder;
         class Factory;
     class SerialTransportFactory 
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

     class SerialTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];
        static STRING DefaultProtocol[];
        static STRING DefaultParity[];
        static STRING DefaultHardwareHandshake[];
        static STRING DefaultSoftwareHandshake[];
        static LONG_INTEGER DefaultBaudRate;
        static LONG_INTEGER DefaultDataBits;
        static LONG_INTEGER DefaultStopBits;

        // class properties
        STRING HardwareHandshake[];
        STRING Parity[];
        STRING Protocol[];
        STRING SoftwareHandshake[];
    };

     class SerialTransportInfoTypeFactory 
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

     class SerialTransportCommandInfoTypeFactory 
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

     class SerialTransportInfoBuilder 
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

     class Factory 
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

namespace Crestron.DeviceDrivers.SDK.Transports.Loopback;
        // class declarations
         class LoopbackTransport;
         class TcpTransportFactory;
         class LoopbackTransportInfo;
         class LoopbackTransportInfoTypeFactory;
         class LoopbackTransportCommandInfoTypeFactory;
         class LoopbackTransportInfoBuilder;
         class LoopbackTransportInfoBuilderFactory;
     class TcpTransportFactory 
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

     class LoopbackTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
        STRING ResponseEncoding[];
        LONG_INTEGER ResponseChunkSize;
        LONG_INTEGER TimeBetweenResponseChunks;
    };

     class LoopbackTransportInfoTypeFactory 
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

     class LoopbackTransportCommandInfoTypeFactory 
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

     class LoopbackTransportInfoBuilderFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transports.Http;
        // class declarations
         class HttpRequestType;
         class AuthenticationMethod;
         class HttpClientKeepAliveWrapper;
         class HttpCommandTransportInfo;
         class HttpCommandTransportInfoDefinition;
         class CommandInfoTypeFactory;
         class HttpResponseData;
         class HttpResponseHeaderMode;
         class HttpsClientKeepAliveWrapper;
         class HttpSendFailureRecoveryStrategy;
         class HttpTransportInfo;
         class HttpTransportInfoTypeFactory;
         class HttpTransportInfoBuilder;
         class HttpTransportInfoBuilderFactory;
         class SimplHttpTransport;
         class SimplHttpTransportFactory;
    static class HttpRequestType // enum
    {
        static SIGNED_LONG_INTEGER Get;
        static SIGNED_LONG_INTEGER Put;
        static SIGNED_LONG_INTEGER Post;
        static SIGNED_LONG_INTEGER Delete;
        static SIGNED_LONG_INTEGER Head;
        static SIGNED_LONG_INTEGER Patch;
    };

    static class AuthenticationMethod // enum
    {
        static LONG_INTEGER None;
        static LONG_INTEGER Basic;
        static LONG_INTEGER Digest;
        static LONG_INTEGER Negotiate;
        static LONG_INTEGER NTLM;
        static LONG_INTEGER Digest_IE;
        static LONG_INTEGER NTLM_WB;
        static LONG_INTEGER Only;
        static LONG_INTEGER Anysafe;
        static LONG_INTEGER Any;
    };

     class HttpCommandTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ContentType[];
        STRING Encoding[];
        STRING Password[];
        HttpRequestType RequestType;
        SIGNED_LONG_INTEGER Timeout;
        STRING Url[];
        STRING UserName[];
        AuthenticationMethod AuthenticationMethod;
    };

     class HttpCommandTransportInfoDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ContentType[];
        STRING Encoding[];
        STRING Endpoint[];
        STRING Password[];
        STRING Url[];
        STRING UserName[];
    };

     class CommandInfoTypeFactory 
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

     class HttpResponseData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING HttpStatusCode[];
        static STRING HttpHeaderDictionary[];
        static STRING HttpHeaderPrefix[];

        // class properties
    };

    static class HttpResponseHeaderMode // enum
    {
        static SIGNED_LONG_INTEGER Ignore;
        static SIGNED_LONG_INTEGER Items;
        static SIGNED_LONG_INTEGER Dictionary;
    };

     class HttpTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
        LONG_INTEGER RetryDelayMilliseconds;
        HttpResponseHeaderMode ResponseHeaderMode;
        STRING ClientCertificate[];
        STRING ClientPrivateKey[];
        STRING ContentType[];
        STRING Encoding[];
        STRING Password[];
        HttpRequestType RequestType;
        SIGNED_LONG_INTEGER Timeout;
        STRING Url[];
        STRING UserName[];
        AuthenticationMethod AuthenticationMethod;
    };

     class HttpTransportInfoTypeFactory 
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

     class HttpTransportInfoBuilderFactory 
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

     class SimplHttpTransportFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transports.Cip;
        // class declarations
         class CipCommand;
         class CipCommandBuilder;
         class CipDigitalCommandBuilderFactory;
         class CipAnalogCommandBuilderFactory;
         class CipSerialCommandBuilderFactory;
         class CipCommandInfo;
         class CipCommandInfoDefinition;
         class CipCommandInfoDefinitionTypeFactory;
         class CipInterlockCommandInfoDefinition;
         class CipDeInterlockCommandInfoTypeFactory;
         class CipInterlockCommand;
         class CipInterlockCommandBuilder;
         class CipInterlockCommandBuilderFactory;
         class CipResponseData;
         class CipTransportInfo;
         class CipTransportInfoTypeFactory;
         class CipTransportCommandInfoTypeFactory;
         class CipTransportInfoBuilder;
         class CipTransportInfoBuilderFactory;
           class JoinType;
     class CipDigitalCommandBuilderFactory 
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

     class CipAnalogCommandBuilderFactory 
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

     class CipSerialCommandBuilderFactory 
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

     class CipCommandInfoDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING DigitalCommandDefinitionType[];
        static STRING AnalogCommandDefinitionType[];
        static STRING SerialCommandDefinitionType[];

        // class properties
        SIGNED_LONG_INTEGER Join;
        SIGNED_LONG_INTEGER MethodName;
        STRING Value[];
    };

     class CipCommandInfoDefinitionTypeFactory 
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

     class CipInterlockCommandInfoDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandDefinitionType[];

        // class properties
        STRING Value[];
    };

     class CipDeInterlockCommandInfoTypeFactory 
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

     class CipInterlockCommandBuilderFactory 
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

     class CipTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
        LONG_INTEGER ReconnectInterval;
    };

     class CipTransportInfoTypeFactory 
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

     class CipTransportCommandInfoTypeFactory 
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

     class CipTransportInfoBuilder 
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

     class CipTransportInfoBuilderFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transports.Cec;
        // class declarations
         class CecTransportFactory;
         class CecTransportInfo;
         class InfoTypeFactory;
         class CecTransportCommandInfoTypeFactory;
         class CecTransportInfoBuilder;
         class Factory;
     class CecTransportFactory 
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

     class CecTransportInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetDriverTransportPostfix ();
        STRING_FUNCTION DatFileCommunicationType ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransportDefinitionType[];

        // class properties
    };

     class InfoTypeFactory 
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

     class CecTransportCommandInfoTypeFactory 
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

     class CecTransportInfoBuilder 
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

     class Factory 
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

namespace Crestron.DeviceDrivers.SDK.Components.Transformations.Random;
        // class declarations
         class RandomTransformation;
         class RandomTransformationFactory;
         class RandomTransformationInfo;
         class RandomTransformationTypeFactory;
         class RandomType;
     class RandomTransformationFactory 
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

     class RandomTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class RandomTransformationTypeFactory 
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

    static class RandomType // enum
    {
        static SIGNED_LONG_INTEGER Integer;
        static SIGNED_LONG_INTEGER Double;
    };

namespace Crestron.DeviceDrivers.SDK.Components.Transformations.Guid;
        // class declarations
         class GuidTransformation;
         class GuidTransformationFactory;
     class GuidTransformationFactory 
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

namespace Crestron.DeviceDrivers.SDK.Components.Transformations.Bitwise;
        // class declarations
         class BitwiseAndTransformation;
         class BitwiseAndTransformationFactory;
         class BitwiseAndTransformationInfo;
         class BitwiseAndTransformationTypeFactory;
         class BitwiseComplementTransformation;
         class BitwiseComplementTransformationFactory;
         class BitwiseComplementTransformationInfo;
         class BitwiseComplementTransformationTypeFactory;
         class BitwiseOrTransformation;
         class BitwiseOrTransformationFactory;
         class BitwiseOrTransformationInfo;
         class BitwiseOrTransformationTypeFactory;
         class BitwiseXorTransformation;
         class BitwiseXorTransformationFactory;
         class BitwiseXorTransformationInfo;
         class BitwiseXorTransformationTypeFactory;
         class LeftShiftTransformation;
         class LeftShiftTransformationFactory;
         class LeftShiftTransformationInfo;
         class LeftShiftTransformationTypeFactory;
         class RightShiftTransformation;
         class RightShiftTransformationFactory;
         class RightShiftTransformationInfo;
         class RightShiftTransformationTypeFactory;
     class BitwiseAndTransformationFactory 
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

     class BitwiseAndTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class BitwiseAndTransformationTypeFactory 
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

     class BitwiseComplementTransformationFactory 
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

     class BitwiseComplementTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class BitwiseComplementTransformationTypeFactory 
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

     class BitwiseOrTransformationFactory 
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

     class BitwiseOrTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class BitwiseOrTransformationTypeFactory 
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

     class BitwiseXorTransformationFactory 
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

     class BitwiseXorTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class BitwiseXorTransformationTypeFactory 
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

     class LeftShiftTransformationFactory 
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

     class LeftShiftTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class LeftShiftTransformationTypeFactory 
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

     class RightShiftTransformationFactory 
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

     class RightShiftTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class RightShiftTransformationTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.UrlEncode;
        // class declarations
         class UrlEncodeTransformation;
         class UrlEncodeTransformationFactory;
         class UrlEncodeTransformationInfo;
         class UrlEncodeTransformationInfoTypeFactory;
     class UrlEncodeTransformationFactory 
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

     class UrlEncodeTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class UrlEncodeTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Substring;
        // class declarations
         class SubstringTransformation;
         class SubstringTransformationFactory;
         class SubstringTransformationInfo;
         class SubstringTransformationInfoTypeFactory;
     class SubstringTransformationFactory 
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

     class SubstringTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        SIGNED_LONG_INTEGER Length;
        SIGNED_LONG_INTEGER StartIndex;
    };

     class SubstringTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.StringToUpper;
        // class declarations
         class StringToUpperTransformation;
         class StringToUpperTransformationFactory;
         class StringToUpperTransformationInfo;
         class StringToUpperTransformationInfoTypeFactory;
     class StringToUpperTransformationFactory 
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

     class StringToUpperTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class StringToUpperTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.StringToLower;
        // class declarations
         class StringToLowerTransformation;
         class StringToLowerTransformationFactory;
         class StringToLowerTransformationInfo;
         class StringToLowerTransformationInfoTypeFactory;
     class StringToLowerTransformationFactory 
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

     class StringToLowerTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class StringToLowerTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.StringReplace;
        // class declarations
         class StringReplaceTransformation;
         class StringReplaceTransformationFactory;
         class StringReplaceTransformationInfo;
         class StringReplaceTransformationInfoTypeFactory;
     class StringReplaceTransformationFactory 
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

     class StringReplaceTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING Pattern[];
        STRING Replacement[];
    };

     class StringReplaceTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.StringPadding;
        // class declarations
         class StringPaddingTransformation;
         class StringPaddingTransformationFactory;
         class PaddingDirection;
         class PaddingMode;
         class StringPaddingTransformationInfo;
         class StringPaddingTransformationInfoTypeFactory;
     class StringPaddingTransformationFactory 
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

    static class PaddingDirection // enum
    {
        static SIGNED_LONG_INTEGER Left;
        static SIGNED_LONG_INTEGER Right;
    };

    static class PaddingMode // enum
    {
        static SIGNED_LONG_INTEGER SpecifiedCharacter;
        static SIGNED_LONG_INTEGER PKCS7;
    };

     class StringPaddingTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        PaddingDirection PaddingDirection;
        PaddingMode PaddingMode;
        SIGNED_LONG_INTEGER TotalLength;
    };

     class StringPaddingTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.StringFormat;
        // class declarations
         class StringFormatTransformation;
         class StringFormatTransformationFactory;
         class StringFormatTransformationInfo;
         class StringFormatTransformationInfoTypeFactory;
     class StringFormatTransformationFactory 
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

     class StringFormatTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING DataType[];
        STRING FormatString[];
        STRING SplitInput[];
    };

     class StringFormatTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Slice;
        // class declarations
         class SliceTransformation;
         class SliceTransformationFactory;
         class SliceTransformationInfo;
         class SliceTransformationInfoTypeFactory;
     class SliceTransformationFactory 
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

     class SliceTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        SIGNED_LONG_INTEGER StartIndex;
    };

     class SliceTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.SimplByteConverter;
        // class declarations
         class SimplByteConverterTransformation;
         class SimplByteConverterTransformationFactory;
         class SimplByteConverterTransformationInfo;
         class SimplByteConverterTransformationInfoTypeFactory;
     class SimplByteConverterTransformationFactory 
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

     class SimplByteConverterTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class SimplByteConverterTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.RijndaelEncryptor;
        // class declarations
         class RijndaelEncryptorTransformation;
         class RijndaelEncryptorTransformationFactory;
         class RijndaelEncryptorTransformationInfo;
         class RijndaelEncryptorTransformationInfoTypeFactory;
     class RijndaelEncryptorTransformationFactory 
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

     class RijndaelEncryptorTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING Key[];
        STRING IV[];
    };

     class RijndaelEncryptorTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.RijndaelDecryptor;
        // class declarations
         class RijndaelDecryptorTransformation;
         class RijndaelDecryptorTransformationFactory;
         class RijndaelDecryptorTransformationInfo;
         class RijndaelDecryptorTransformationInfoTypeFactory;
     class RijndaelDecryptorTransformationFactory 
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

     class RijndaelDecryptorTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING Key[];
        STRING IV[];
    };

     class RijndaelDecryptorTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Polynomial;
        // class declarations
         class PolynomialTransformation;
         class PolynomialTransformationFactory;
         class PolynomialTransformationInfo;
         class PolynomialTransformationInfoTypeFactory;
     class PolynomialTransformationFactory 
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

     class PolynomialTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class PolynomialTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.PBKDF2;
        // class declarations
         class PBKDF2SHA256Transformation;
         class PBKDF2SHA256TransformationFactory;
         class HashAlgorithm;
         class PBKDF2TransformationInfo;
         class PBKDF2TransformationInfoTypeFactory;
     class PBKDF2SHA256TransformationFactory 
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

    static class HashAlgorithm // enum
    {
        static SIGNED_LONG_INTEGER SHA256;
    };

     class PBKDF2TransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING Salt[];
        SIGNED_LONG_INTEGER Iterations;
        SIGNED_LONG_INTEGER LengthOfKey;
        HashAlgorithm Algorithm;
    };

     class PBKDF2TransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.MultipleMath;
        // class declarations
         class SumTransformationFactory;
         class SubtractTransformationFactory;
         class ProductTransformationFactory;
         class DivideTransformationFactory;
         class MultipleMathTransformation;
         class MultipleMathTransformationInfo;
         class MultipleMathTransformationInfoTypeFactory;
     class SumTransformationFactory 
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

     class SubtractTransformationFactory 
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

     class ProductTransformationFactory 
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

     class DivideTransformationFactory 
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

     class MultipleMathTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING SumType[];
        static STRING SubtractType[];
        static STRING ProductType[];
        static STRING DivideType[];

        // class properties
    };

     class MultipleMathTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Math;
        // class declarations
         class MathTransformation;
         class MathTransformationFactory;
         class MathTransformationInfo;
         class MathTransformationInfoTypeFactory;
         class OperationType;
     class MathTransformationFactory 
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

     class MathTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        OperationType OpType;
    };

     class MathTransformationInfoTypeFactory 
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

    static class OperationType // enum
    {
        static SIGNED_LONG_INTEGER LittleEndianBytesToInt;
        static SIGNED_LONG_INTEGER LittleEndianBytesToUint;
        static SIGNED_LONG_INTEGER IntToLittleEndianBytes;
        static SIGNED_LONG_INTEGER UIntToLittleEndianBytes;
        static SIGNED_LONG_INTEGER BigEndianBytesToInt;
        static SIGNED_LONG_INTEGER BigEndianBytesToUint;
        static SIGNED_LONG_INTEGER IntToBigEndianBytes;
        static SIGNED_LONG_INTEGER UIntToBigEndianBytes;
        static SIGNED_LONG_INTEGER Add;
        static SIGNED_LONG_INTEGER Multiply;
        static SIGNED_LONG_INTEGER Round;
        static SIGNED_LONG_INTEGER Abs;
        static SIGNED_LONG_INTEGER Sign;
        static SIGNED_LONG_INTEGER Floor;
        static SIGNED_LONG_INTEGER Ceiling;
        static SIGNED_LONG_INTEGER MultiplyAndInvert;
        static SIGNED_LONG_INTEGER Divide;
        static SIGNED_LONG_INTEGER IntegerDivide;
    };

namespace Crestron.DeviceDrivers.SDK.Transformations.Map;
        // class declarations
         class MapTransformation;
         class MapTransformationFactory;
         class MapTransformationInfo;
         class MapTransformationInfoTypeFactory;
     class MapTransformationFactory 
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

     class MapTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING InversePrefix[];
    };

     class MapTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Length;
        // class declarations
         class LengthTransformation;
         class LengthTransformationFactory;
         class LengthTransformationInfo;
         class LengthTransformationInfoTypeFactory;
     class LengthTransformationFactory 
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

     class LengthTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        SIGNED_LONG_INTEGER Offset;
    };

     class LengthTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.JsonSerialize;
        // class declarations
         class JsonSerializeTransformation;
         class JsonSerializeTransformationFactory;
         class JsonSerializeTransformationInfo;
         class JsonSerializeTransformationInfoTypeFactory;
     class JsonSerializeTransformationFactory 
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

     class JsonSerializeTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class JsonSerializeTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Identity;
        // class declarations
         class IdentityTransformation;
         class IdentityTransformationFactory;
         class IdentityTransformationInfo;
         class IdentityTransformationInfoTypeFactory;
     class IdentityTransformationFactory 
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

     class IdentityTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class IdentityTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Hash;
        // class declarations
         class HashTransformation;
         class HashTransformationFactory;
         class Sha256Hash;
         class HashTransformationInfo;
         class EncodeTransformationInfoTypeFactory;
         class HashType;
     class HashTransformationFactory 
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

     class Sha256Hash 
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

     class HashTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        HashType Algorithm;
    };

     class EncodeTransformationInfoTypeFactory 
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

    static class HashType // enum
    {
        static SIGNED_LONG_INTEGER Sha256;
        static SIGNED_LONG_INTEGER Md5;
    };

namespace Crestron.DeviceDrivers.SDK.Transformations.Guid;
        // class declarations
         class GuidTransformationInfo;
         class GuidTransformationTypeFactory;
     class GuidTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class GuidTransformationTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Encode;
        // class declarations
         class EncodeTransformation;
         class EncodeTransformationFactory;
         class EncodeTransformationInfo;
         class EncodeTransformationInfoTypeFactory;
         class EncodingType;
     class EncodeTransformationFactory 
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

     class EncodeTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        EncodingType Encoding;
    };

     class EncodeTransformationInfoTypeFactory 
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

    static class EncodingType // enum
    {
        static SIGNED_LONG_INTEGER Base64;
    };

namespace Crestron.DeviceDrivers.SDK.Transformations.CresNext;
        // class declarations
         class FormatCresNextWriteTransformation;
         class FormatCresNextWriteTransformationFactory;
         class FormatCresNextWriteTransformationInfo;
         class FormatCresNextWriteTransformationInfoTypeFactory;
     class FormatCresNextWriteTransformationFactory 
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

     class FormatCresNextWriteTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class FormatCresNextWriteTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Color;
        // class declarations
         class ColorTransformation;
         class ColorTransformationFactory;
         class ColorTransformationInfo;
         class ColorTransformationInfoTypeFactory;
         class XyDefinition;
         class ColorGamutDefinition;
         class OperationType;
     class ColorTransformationFactory 
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

     class ColorTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        OperationType OpType;
        ColorGamutDefinition Rgb;
        XyDefinition White;
    };

     class ColorTransformationInfoTypeFactory 
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

     class XyDefinition 
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

     class ColorGamutDefinition 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        XyDefinition Red;
        XyDefinition Green;
        XyDefinition Blue;
    };

    static class OperationType // enum
    {
        static SIGNED_LONG_INTEGER XyvToRgb;
        static SIGNED_LONG_INTEGER RgbToXyv;
        static SIGNED_LONG_INTEGER HsvToRgb;
        static SIGNED_LONG_INTEGER RgbToHsv;
    };

namespace Crestron.DeviceDrivers.SDK.Transformations.Clamp;
        // class declarations
         class ClampTransformation;
         class ClampTransformationFactory;
         class ClampTransformationInfo;
         class ClampTransformationInfoTypeFactory;
     class ClampTransformationFactory 
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

     class ClampTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class ClampTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Checksum;
        // class declarations
         class ChecksumTransformation;
         class ChecksumTransformationFactory;
         class ChecksumTransformationInfo;
         class ChecksumTransformationInfoTypeFactory;
         class ComplementType;
     class ChecksumTransformationFactory 
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

     class ChecksumTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        SIGNED_LONG_INTEGER WordSize;
        ComplementType Complement;
    };

     class ChecksumTransformationInfoTypeFactory 
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

    static class ComplementType // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Ones;
        static SIGNED_LONG_INTEGER Twos;
    };

namespace Crestron.DeviceDrivers.SDK.Transformations.CharMap;
        // class declarations
         class CharMapTransformation;
         class CharMapTransformationFactory;
         class CharMapTransformationInfo;
         class CharMapTransformationInfoTypeFactory;
     class CharMapTransformationFactory 
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

     class CharMapTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class CharMapTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Bitwise;
        // class declarations
         class ViscaAssemble4LowerNibblesTransformationFactory;
         class ViscaAssemble4LowerNibblesTransformation;
         class ViscaAssemble4LowerNibblesTransformationInfo;
         class ViscaAssemble4LowerNibblesTransformationInfoTypeFactory;
         class ViscaAssembleLowerNibblesTransformationFactory;
         class ViscaAssembleLowerNibblesTransformation;
         class ViscaAssembleLowerNibblesTransformationInfo;
         class ViscaAssembleLowerNibblesTransformationInfoTypeFactory;
         class ViscaExtractNibblesTransformationFactory;
         class ViscaExtractNibblesTransformation;
         class ViscaExtractNibblesTransformationInfo;
         class ViscaExtractNibblesTransformationInfoTypeFactory;
     class ViscaAssemble4LowerNibblesTransformationFactory 
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

     class ViscaAssemble4LowerNibblesTransformation 
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

     class ViscaAssemble4LowerNibblesTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class ViscaAssemble4LowerNibblesTransformationInfoTypeFactory 
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

     class ViscaAssembleLowerNibblesTransformationFactory 
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

     class ViscaAssembleLowerNibblesTransformation 
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

     class ViscaAssembleLowerNibblesTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class ViscaAssembleLowerNibblesTransformationInfoTypeFactory 
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

     class ViscaExtractNibblesTransformationFactory 
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

     class ViscaExtractNibblesTransformation 
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

     class ViscaExtractNibblesTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
    };

     class ViscaExtractNibblesTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Transformations.Aggregate;
        // class declarations
         class GroupByTransformation;
         class GroupByTransformationFactory;
         class GroupByTransformationInfo;
         class GroupByTransformationInfoTypeFactory;
         class InnerJoinTransformation;
         class InnerJoinTransformationFactory;
         class InnerJoinTransformationInfo;
         class InnerJoinTransformationInfoTypeFactory;
     class GroupByTransformationFactory 
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

     class GroupByTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING Key[];
    };

     class GroupByTransformationInfoTypeFactory 
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

     class InnerJoinTransformationFactory 
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

     class InnerJoinTransformationInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TransformationType[];

        // class properties
        STRING Key[];
    };

     class InnerJoinTransformationInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.SubDevices;
        // class declarations
         class SubDeviceDefinition;
     class SubDeviceDefinition 
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
        STRING Name[];
    };

namespace Crestron.DeviceDrivers.SDK.SubDevices.Device;
        // class declarations
         class SubDeviceInfo;
         class SubDeviceWithCapabilitiesInfoTypeFactory;
     class SubDeviceInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        STRING Condition[];
        DriverControllerDefinition DriverController;
    };

     class SubDeviceWithCapabilitiesInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Rules.SetOther;
        // class declarations
         class ParameterizedControlCommand;
         class ParameterizedControlCommandDefinition;
         class SetOtherFeedbackRule;
         class SetOtherFeedbackRuleFactory;
         class SetOtherOnSendRule;
         class SetOtherOnSendRuleFactory;
         class SetOtherRuleInfo;
         class SetOtherRuleInfoTypeFactory;
         class SetOtherStateRule;
         class SetOtherStateRuleFactory;
         class SetOtherStateRuleInfo;
         class SetOtherStateRuleInfoTypeFactory;
     class ParameterizedControlCommandDefinition 
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
        STRING StateCommand[];
    };

     class SetOtherFeedbackRuleFactory 
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

     class SetOtherOnSendRuleFactory 
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

     class SetOtherRuleInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeNameFeedback[];
        static STRING TypeNameOnSend[];

        // class properties
    };

     class SetOtherRuleInfoTypeFactory 
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

     class SetOtherStateRuleFactory 
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

     class SetOtherStateRuleInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class SetOtherStateRuleInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Rules.SequencedEntryRule;
        // class declarations
         class SequencedEntryRule;
         class SequencedEntryRuleFactory;
         class SequencedEntryRuleInfo;
         class SequencedEntryRuleInfoTypeFactory;
     class SequencedEntryRuleFactory 
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

     class SequencedEntryRuleInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        STRING Content[];
    };

     class SequencedEntryRuleInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Rules.CommandSequence;
        // class declarations
         class CommandSequenceRule;
         class CommandSequenceRuleFactory;
         class CommandSequenceRuleInfo;
         class CommandSequenceRuleInfoTypeFactory;
     class CommandSequenceRuleFactory 
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

     class CommandSequenceRuleInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class CommandSequenceRuleInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Rules.Block;
        // class declarations
         class BlockRule;
         class BlockRuleFactory;
         class BlockRuleInfo;
         class BlockRuleInfoTypeFactory;
     class BlockRuleFactory 
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

     class BlockRuleInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class BlockRuleInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Responses;
        // class declarations
         class AlwaysMatchProcessor;
         class AlwaysMatchProcessorFactory;
         class AlwaysMatchResponseProcessorInfo;
         class AlwaysMatchResponseInfoTypeFactory;
         class CaptureAllProcessor;
         class CaptureAllProcessorFactory;
         class ForEachResponseMatchBehavior;
         class ForEachResponseProcessor;
         class ForEachResponseProcessorFactory;
         class ForEachResponseProcessorInfo;
         class ForEachResponseInfoTypeFactory;
         class NameMatchProcessor;
         class NameMatchProcessorFactory;
         class RegexResponseProcessor;
         class RegexResponseProcessorFactory;
         class RegexResponseProcessorInfo;
         class RegexResponseInfoTypeFactory;
     class AlwaysMatchProcessorFactory 
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

     class AlwaysMatchResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ResponseType[];

        // class properties
        STRING KeyVariable[];
    };

     class AlwaysMatchResponseInfoTypeFactory 
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

     class CaptureAllProcessorFactory 
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

    static class ForEachResponseMatchBehavior // enum
    {
        static SIGNED_LONG_INTEGER MatchIfAny;
        static SIGNED_LONG_INTEGER MatchIfAll;
        static SIGNED_LONG_INTEGER StopOnFirstMatch;
    };

     class ForEachResponseProcessor 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ResponseComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class ForEachResponseProcessorFactory 
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

     class ForEachResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ResponseType[];

        // class properties
        STRING Count[];
        STRING Index[];
        STRING Key[];
        ForEachResponseMatchBehavior MatchBehavior;
        STRING ValuePrefix[];
        STRING OutputDictionaryKey[];
    };

     class ForEachResponseInfoTypeFactory 
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

     class NameMatchProcessorFactory 
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

     class RegexResponseProcessorFactory 
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

     class RegexResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ResponseType[];
        static STRING MultiResponseType[];

        // class properties
        STRING Encoding[];
    };

     class RegexResponseInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Responses.Join;
        // class declarations
         class JoinProcessorType;
         class JoinResponseProcessingNode;
         class JoinResponseProcessorFactory;
         class JoinResponseProcessorInfo;
         class JoinInterlockProcessorInfoTypeFactory;
    static class JoinProcessorType // enum
    {
        static SIGNED_LONG_INTEGER Digital;
        static SIGNED_LONG_INTEGER Analog;
        static SIGNED_LONG_INTEGER Serial;
        static SIGNED_LONG_INTEGER Interlock;
    };

     class JoinResponseProcessingNode 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ResponseComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class JoinResponseProcessorFactory 
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

     class JoinResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ResponseTypeName[];

        // class properties
        STRING JoinNumberPlaceholder[];
    };

     class JoinInterlockProcessorInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Responses.Delimiter;
        // class declarations
         class DelimitedListResponseProcessorInfo;
         class DelimitedListResponseInfoInfoTypeFactory;
         class DelimiterResponseProcessorInfo;
         class DelimiterResponseInfoTypeFactory;
         class DelimiterResponseProcessor;
         class DelimiterResponseProcessorFactory;
         class DelimitedListResponseProcessorFactory;
     class DelimitedListResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING MultiResponseType[];
        static STRING ResponseType[];

        // class properties
        STRING StartDelimiter[];
        STRING Encoding[];
        STRING DelimiterEscapeChars[];
        STRING QuoteChars[];
        STRING QuoteEscapeChars[];
        STRING EscapeEscapeChars[];
        STRING EscapeChars[];
        STRING TrimChars[];
    };

     class DelimitedListResponseInfoInfoTypeFactory 
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

     class DelimiterResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ResponseType[];

        // class properties
        STRING StartDelimiter[];
        STRING Encoding[];
        STRING DelimiterEscapeChars[];
        STRING QuoteChars[];
        STRING QuoteEscapeChars[];
        STRING EscapeEscapeChars[];
        STRING EscapeChars[];
        STRING TrimChars[];
    };

     class DelimiterResponseInfoTypeFactory 
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

     class DelimiterResponseProcessorFactory 
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

     class DelimitedListResponseProcessorFactory 
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

namespace Crestron.DeviceDrivers.SDK.Responses.BinaryPacket;
        // class declarations
         class BinaryPacketComponent;
         class BinaryPacketResponseProcessor;
         class BinaryPacketResponseProcessorFactory;
     class BinaryPacketResponseProcessorFactory 
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

namespace Crestron.DeviceDrivers.SDK.Xml;
        // class declarations
         class XmlCommandBuilderFactory;
         class XmlCommandInfo;
         class XmlCommandInfoTypeFactory;
     class XmlCommandBuilderFactory 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandType[];

        // class properties
    };

     class XmlCommandInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandDefinitionType[];

        // class properties
        STRING Content[];
    };

     class XmlCommandInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Text;
        // class declarations
         class TextCommandInfo;
         class TextCommandInfoTypeFactory;
         class TextCommand;
         class TextCommandBuilder;
         class TextCommandBuilderFactory;
     class TextCommandInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandDefinitionType[];

        // class properties
        STRING Content[];
    };

     class TextCommandInfoTypeFactory 
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

     class TextCommandBuilderFactory 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandType[];

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.Json.Responses;
        // class declarations
         class JsonResponseProcessor;
         class JsonResponseProcessorFactory;
         class JsonResponseProcessorInfo;
         class JsonResponseProcessorInfoTypeFactory;
     class JsonResponseProcessorFactory 
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

     class JsonResponseProcessorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ResponseTypeName[];

        // class properties
        STRING Encoding[];
    };

     class JsonResponseProcessorInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Joins;
        // class declarations
         class JoinConstants;
         class JoinTransportInputType;
         class JoinType;
    static class JoinConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Slot[];
        static STRING Type[];
        static STRING Number[];
        static STRING Value[];

        // class properties
    };

    static class JoinTransportInputType // enum
    {
        static SIGNED_LONG_INTEGER Digital;
        static SIGNED_LONG_INTEGER Analog;
        static SIGNED_LONG_INTEGER Serial;
        static SIGNED_LONG_INTEGER IntegerParameter;
        static SIGNED_LONG_INTEGER StringParameter;
    };

    static class JoinType // enum
    {
        static SIGNED_LONG_INTEGER Digital;
        static SIGNED_LONG_INTEGER Analog;
        static SIGNED_LONG_INTEGER Serial;
    };

namespace Crestron.DeviceDrivers.SDK.Controllers.ValueController;
        // class declarations
         class ValueStateController;
         class ValueStateControllerFactory;
         class ValueStateControllerInfo;
         class ValueStateControllerInfoTypeFactory;
     class ValueStateControllerFactory 
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

     class ValueStateControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class ValueStateControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.TunerController;
        // class declarations
         class TunerController;
         class TunerControllerFactory;
         class TunerControllerState;
     class TunerControllerFactory 
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

    static class TunerControllerState 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GetBand ( LONG_INTEGER kHz );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING BandKey[];
        static STRING DigitalChannelKey[];
        static STRING KilohertzKey[];
        static STRING FrequencyBandFm[];
        static STRING FrequencyBandAm[];

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.Controllers.TimedStatusController;
        // class declarations
         class TimedStatusControllerInfo;
         class TimedStatusControllerInfoTypeFactory;
         class TimedStatusStateController;
         class TimedStatusStateControllerFactory;
     class TimedStatusControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        LONG_INTEGER MinTimeout;
        LONG_INTEGER Timeout;
    };

     class TimedStatusControllerInfoTypeFactory 
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

     class TimedStatusStateControllerFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.SubDeviceController;
        // class declarations
         class DriverFeatureFragment;
         class DriverFeatureFragmentCreationArgs;
         class SubDeviceStateController;
         class SubDeviceStateControllerFactory;
         class SubDeviceStateControllerInfo;
         class SubDeviceStateControllerInfoTypeFactory;
     class SubDeviceStateControllerFactory 
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

     class SubDeviceStateControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];
        static STRING DefaultUxCategoryProperty[];
        static STRING DefaultNameProperty[];
        static STRING DefaultManufacturerProperty[];
        static STRING DefaultModelProperty[];
        static STRING DefaultSerialNumberProperty[];

        // class properties
        STRING UxCategoryTemplate[];
        STRING NameTemplate[];
        STRING ManufacturerTemplate[];
        STRING ModelTemplate[];
        STRING SerialNumberTemplate[];
    };

     class SubDeviceStateControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.StringController;
        // class declarations
         class StringStateController;
         class StringStateControllerFactory;
         class StringControllerInfo;
         class StringControllerInfoTypeFactory;
     class StringStateControllerFactory 
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

     class StringControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class StringControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.StreamController;
        // class declarations
         class StreamStateController;
         class StreamStateControllerFactory;
         class StreamControllerInfo;
         class StringControllerInfoTypeFactory;
     class StreamStateControllerFactory 
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

     class StreamControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class StringControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.ObjectController;
        // class declarations
         class ObjectController;
         class ObjectControllerFactory;
         class ObjectControllerInfo;
         class ObjectControllerInfoTypeFactory;
     class ObjectControllerFactory 
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

     class ObjectControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        STRING Key[];
        STRING Value[];
        STRING FilterCondition[];
    };

     class ObjectControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.NumericController;
        // class declarations
         class NumericControllerInfo;
         class NumericControllerInfoTypeFactory;
         class NumericControllerRangeMode;
         class NumericControllerSetCommandStrategy;
         class NumericStateController;
         class NumericStateControllerFactory;
     class NumericControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        NumericControllerRangeMode Mode;
        STRING OnOffState[];
        NumericControllerSetCommandStrategy SetCommandStrategy;
    };

     class NumericControllerInfoTypeFactory 
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

    static class NumericControllerRangeMode // enum
    {
        static SIGNED_LONG_INTEGER Default;
        static SIGNED_LONG_INTEGER AbsoluteRange;
        static SIGNED_LONG_INTEGER RelativeRange;
        static SIGNED_LONG_INTEGER None;
    };

    static class NumericControllerSetCommandStrategy // enum
    {
        static SIGNED_LONG_INTEGER ValueFirst;
        static SIGNED_LONG_INTEGER OnOffFirst;
        static SIGNED_LONG_INTEGER ValueWhileOn;
        static SIGNED_LONG_INTEGER ValueWhileOff;
        static SIGNED_LONG_INTEGER ValueOnlyIfOn;
    };

     class NumericStateControllerFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.NumericController.Scaling;
        // class declarations
         class AcceleratingLevelRamper;
         class LevelRamper;
         class IntegerLevel;
         class PercentUshortLevelTranslator;
         class ScalingLevelTranslator;
         class Scale;
         class ScaledValue;
         class ScalingExtensions;
    static class ScalingExtensions 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.MultiValueController;
        // class declarations
         class MultiValueControllerStateInfo;
         class MultiValueStateController;
         class GenericStateControllerFactory;
         class MultiValueStateControllerInfo;
         class MultiValueStateControllerInfoTypeFactory;
     class MultiValueControllerStateInfo 
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

     class GenericStateControllerFactory 
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

     class MultiValueStateControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class MultiValueStateControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.GenericController;
        // class declarations
         class GenericStateController;
         class GenericStateControllerFactory;
         class GenericStateControllerInfo;
         class GenericStateControllerInfoTypeFactory;
     class GenericStateControllerFactory 
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

     class GenericStateControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class GenericStateControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.EventController;
        // class declarations
         class EventStateController;
         class EventStateControllerFactory;
         class EventStateControllerInfo;
         class EventStateControllerInfoTypeFactory;
     class EventStateControllerFactory 
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

     class EventStateControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class EventStateControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.EnumController;
        // class declarations
         class EnumControllerInfo;
         class EnumControllerInfoTypeFactory;
         class EnumStateController;
         class EnumStateControllerFactory;
     class EnumControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class EnumControllerInfoTypeFactory 
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

     class EnumStateControllerFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.DebounceController;
        // class declarations
         class DebounceStateController;
         class DebounceStateControllerFactory;
         class DebounceStateControllerInfo;
         class DebounceStateControllerInfoTypeFactory;
     class DebounceStateControllerFactory 
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

     class DebounceStateControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        LONG_INTEGER MinimumOffDuration;
        LONG_INTEGER MinimumOnDuration;
        LONG_INTEGER MinimumTriggerOffDuration;
        LONG_INTEGER MinimumTriggerOnDuration;
    };

     class DebounceStateControllerInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.CommandController;
        // class declarations
         class CommandControllerInfo;
         class CommandControllerInfoTypeFactory;
         class CommandController;
         class CommandControllerFactory;
         class CustomCommandRepeatTiming;
     class CommandControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        STRING AppliesTo[];
        STRING ReleaseCommand[];
        LONG_INTEGER RepeatDelay;
        LONG_INTEGER RepeatHoldOff;
    };

     class CommandControllerInfoTypeFactory 
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

     class CommandControllerFactory 
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

     class CustomCommandRepeatTiming 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Command[];
        LONG_INTEGER RepeatDelay;
        LONG_INTEGER RepeatHoldOff;
    };

namespace Crestron.DeviceDrivers.SDK.Controllers.BooleanController;
        // class declarations
         class BooleanStateController;
         class BooleanStateControllerFactory;
     class BooleanStateControllerFactory 
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

namespace Crestron.DeviceDrivers.SDK.Controllers.ArrayController;
        // class declarations
         class ArrayControllerInfo;
         class ArrayControllerInfoTypeFactory;
         class ArrayStateController;
         class ArrayStateControllerFactory;
     class ArrayControllerInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        SIGNED_LONG_INTEGER Size;
    };

     class ArrayControllerInfoTypeFactory 
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

     class ArrayStateControllerFactory 
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

namespace Crestron.DeviceDrivers.SDK.Conditions.ExistsCondition;
        // class declarations
         class ExistsCondition;
         class ExistsConditionFactory;
         class ExistsConditionInfo;
         class ExistsConditionInfoTypeFactory;
     class ExistsCondition 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ConditionComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ExistsConditionFactory 
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

     class ExistsConditionInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ConditionType[];

        // class properties
    };

     class ExistsConditionInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Conditions.CompareCondition;
        // class declarations
         class CompareConditionInfo;
         class CompareConditionInfoTypeFactory;
         class IsEqualCondition;
         class IsEqualConditionFactory;
         class IsGreaterThanCondition;
         class IsGreaterThanConditionFactory;
         class IsLessThanCondition;
         class IsLessThanConditionFactory;
         class IsMatchCondition;
         class IsMatchConditionFactory;
     class CompareConditionInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING EqualCondition[];
        static STRING MatchCondition[];
        static STRING LessThanCondition[];
        static STRING GreaterThanCondition[];

        // class properties
    };

     class CompareConditionInfoTypeFactory 
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

     class IsEqualCondition 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ConditionComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class IsEqualConditionFactory 
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

     class IsGreaterThanCondition 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ConditionComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class IsGreaterThanConditionFactory 
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

     class IsLessThanCondition 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ConditionComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class IsLessThanConditionFactory 
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

     class IsMatchCondition 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( ConditionComponentArgs args );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class IsMatchConditionFactory 
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

namespace Crestron.DeviceDrivers.SDK.Conditions.CombinationCondition;
        // class declarations
         class CombinationCondition;
         class AndFactory;
         class OrFactory;
         class CombinationType;
         class CombinationConditionInfo;
         class CombinationConditionInfoTypeFactory;
     class AndFactory 
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

     class OrFactory 
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

    static class CombinationType // enum
    {
        static SIGNED_LONG_INTEGER And;
        static SIGNED_LONG_INTEGER Or;
    };

     class CombinationConditionInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING OrCondition[];
        static STRING AndCondition[];

        // class properties
    };

     class CombinationConditionInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Commands.WakeOnLan;
        // class declarations
         class WolCommand;
         class WolCommandBuilder;
         class WolCommandBuilderFactory;
         class WolCommandInfo;
         class WolCommandInfoTypeFactory;
     class WolCommandBuilderFactory 
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

     class WolCommandInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandDefinitionType[];

        // class properties
        STRING MacAddress[];
    };

     class WolCommandInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.SDK.Commands.Template;
        // class declarations
         class TemplateCommandBuilder;
         class TemplateCommandBuilderFactory;
         class TemplateCommandInfo;
         class TemplateCommandInfoTypeFactory;
     class TemplateCommandBuilderFactory 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandType[];

        // class properties
    };

     class TemplateCommandInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING CommandDefinitionType[];

        // class properties
        STRING CommandName[];
    };

     class TemplateCommandInfoTypeFactory 
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

