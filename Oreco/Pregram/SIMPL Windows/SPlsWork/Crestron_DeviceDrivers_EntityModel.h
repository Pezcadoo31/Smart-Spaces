namespace Crestron.DeviceDrivers.EntityModel;
        // class declarations
         class ConfigurationItemsUpdatedEventArgs;
         class ConfigurationListChangedEventArgs;
         class ControllerIdsChangedEventArgs;
         class DefinitionChangedEventArgs;
         class DevicePropertyChangeEventArgs;
         class DriverAssemblyEntryPoint;
         class DriverAssemblyEntryPointAttribute;
         class DriverController;
         class DriverControllerCreationArgs;
         class DriverEntityCommandResult;
         class DriverEntityEventArgs;
         class StatusChangedEventArgs;
           class DriverEntityPropertyUpdate;
           class DriverControllerLogger;
           class DriverEntityEvent;
           class DriverControllerStatus;
     class DriverAssemblyEntryPoint 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DriverController 
    {
        // class delegates

        // class events
        EventHandler ConfigurationItemsUpdated ( DriverController sender, ConfigurationItemsUpdatedEventArgs e );
        EventHandler ConfigurationListChanged ( DriverController sender, ConfigurationListChangedEventArgs e );
        EventHandler ControllerIdsChanged ( DriverController sender, ControllerIdsChangedEventArgs e );
        EventHandler DefinitionChanged ( DriverController sender, DefinitionChangedEventArgs e );
        EventHandler EventRaised ( DriverController sender, DriverEntityEventArgs e );
        EventHandler LanguageTranslationsChanged ( DriverController sender, EventArgs e );
        EventHandler StatusChanged ( DriverController sender, StatusChangedEventArgs e );
        EventHandler SupportedCulturesChanged ( DriverController sender, EventArgs e );
        EventHandler ValuesChanged ( DriverController sender, DevicePropertyChangeEventArgs e );

        // class functions
        FUNCTION Dispose ();
        FUNCTION TransportRx ( STRING channelId , STRING data );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING RootControllerId[];

        // class properties
    };

namespace Crestron.DeviceDrivers.EntityModel.Data.DeviceConfiguration;
        // class declarations
         class ConfigurationItem;
         class ApplyConfigurationResult;
         class ApplyConfigurationStepResult;
         class ConfigurationItemAvailability;
         class ConfigurationItemValue;
         class ConfigurationItemValueType;
         class ConfigurationStep;
         class ConfigurationValueCollection;
           class DriverEntityLocalizedString;
     class ConfigurationItem 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DriverEntityLocalizedString Description;
        STRING Id[];
        DriverEntityLocalizedString Title;
        STRING UsageContext[];
        STRING UsageContextGroupId[];
        ConfigurationItemValue Value;
        STRING ValueType[];
        STRING Availability[];
        STRING RenderHint[];
    };

    static class ConfigurationItemAvailability 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FirstTimeConfiguration[];
        static STRING Always[];

        // class properties
    };

     class ConfigurationItemValue 
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
        STRING CurrentValue[];
        STRING CurrentValueDisplayOverride[];
        STRING DefaultValue[];
        STRING Units[];
    };

    static class ConfigurationItemValueType 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING None[];
        static STRING String[];
        static STRING Number[];
        static STRING Boolean[];
        static STRING Hex[];

        // class properties
    };

namespace Crestron.DeviceDrivers.EntityModel.Logging;
        // class declarations
         class DriverControllerLogger;
         class LogEntryLevel;
     class DriverControllerLogger 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Log ( STRING controllerId , LogEntryLevel level , STRING message );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class LogEntryLevel // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Error;
        static SIGNED_LONG_INTEGER Warning;
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER Debug;
        static SIGNED_LONG_INTEGER Trace;
    };

namespace Crestron.DeviceDrivers.EntityModel.Data;
        // class declarations
         class DriverControllerStatusChanged;
         class DriverEntityAvailableValue;
         class DriverEntityValueDataStructure;
         class DriverEntityValue;
         class DriverEntityCommandDefinition;
         class DriverEntityCommandMetadata;
         class DriverEntityDefinition;
         class DriverEntityEvent;
         class DriverEntityEventDefinition;
         class DriverEntityEventMetadata;
         class DriverEntityLocalizedString;
         class DriverEntityParameterDefinition;
         class DriverEntityPropertyDefinition;
         class DriverEntityPropertyMetadata;
         class DriverEntityPropertyUpdate;
         class DriverEntityState;
         class DriverEntityTypeDefinition;
         class DriverEntityValueDictionary;
         class DriverEntityValueList;
         class DriverEntityValueRange;
         class DriverEntityValueRelativeRange;
         class DriverEntityValueUpdate;
         class DriverEntityValueUpdateOperation;
         class DriverEntityValueType;
         class DriverControllerStatus;
     class DriverEntityValueDataStructure 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DriverEntityValueDictionary 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Count;
    };

     class DriverEntityValueList 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION CopyTo ( DriverEntityValue array[] , SIGNED_LONG_INTEGER arrayIndex );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Count;
    };

    static class DriverEntityValueUpdateOperation // enum
    {
        static SIGNED_LONG_INTEGER Update;
        static SIGNED_LONG_INTEGER Insert;
        static SIGNED_LONG_INTEGER Delete;
    };

    static class DriverEntityValueType // enum
    {
        static SIGNED_LONG_INTEGER Uninitialized;
        static SIGNED_LONG_INTEGER Boolean;
        static SIGNED_LONG_INTEGER Number;
        static SIGNED_LONG_INTEGER Integer;
        static SIGNED_LONG_INTEGER String;
        static SIGNED_LONG_INTEGER Array;
        static SIGNED_LONG_INTEGER Object;
        static SIGNED_LONG_INTEGER Entity;
        static SIGNED_LONG_INTEGER Device;
        static SIGNED_LONG_INTEGER LocalizedString;
        static SIGNED_LONG_INTEGER NumericRange;
        static SIGNED_LONG_INTEGER RelativeRange;
        static SIGNED_LONG_INTEGER AvailableValue;
        static SIGNED_LONG_INTEGER Any;
        static SIGNED_LONG_INTEGER EntityDictionary;
        static SIGNED_LONG_INTEGER DeviceDictionary;
    };

    static class DriverControllerStatus // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER NotStarted;
        static SIGNED_LONG_INTEGER NotConfigured;
        static SIGNED_LONG_INTEGER Running;
    };

