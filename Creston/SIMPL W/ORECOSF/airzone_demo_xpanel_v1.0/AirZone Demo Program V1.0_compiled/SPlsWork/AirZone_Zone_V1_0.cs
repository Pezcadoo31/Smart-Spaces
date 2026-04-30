using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using AirZone.Communication.DataPackets.Commands;
using AirZone.Communication.DataPackets.Feedback;
using AirZone.Helpers;
using AirZone.Logic.Model.Enums;
using AirZone.Logic.Model;
using AirZone.Simpl;
using AirZone.Simpl.EventArguments;
using AirZone.Ucmd;

namespace UserModule_AIRZONE_ZONE_V1_0
{
    public class UserModuleClass_AIRZONE_ZONE_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput MANUALPOLL;
        Crestron.Logos.SplusObjects.DigitalInput SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput STAGES_AIR_SET;
        Crestron.Logos.SplusObjects.DigitalInput STAGES_RADIANT_SET;
        Crestron.Logos.SplusObjects.DigitalInput STAGES_COMBINED_SET;
        Crestron.Logos.SplusObjects.DigitalInput MODES_STOP_SET;
        Crestron.Logos.SplusObjects.DigitalInput MODES_COOLING_SET;
        Crestron.Logos.SplusObjects.DigitalInput MODES_HEATING_SET;
        Crestron.Logos.SplusObjects.DigitalInput MODES_FAN_SET;
        Crestron.Logos.SplusObjects.DigitalInput MODES_DRY_SET;
        Crestron.Logos.SplusObjects.DigitalInput MODES_AUTO_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_AUTO_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_1_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_2_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_3_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_4_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_5_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_6_SET;
        Crestron.Logos.SplusObjects.DigitalInput FANSPEEDS_7_SET;
        Crestron.Logos.SplusObjects.AnalogInput STAGES_VALUE_SET;
        Crestron.Logos.SplusObjects.AnalogInput MODES_VALUE_SET;
        Crestron.Logos.SplusObjects.AnalogInput FANSPEEDS_VALUE_SET;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput POLLING;
        Crestron.Logos.SplusObjects.DigitalOutput HASZONEERRORS;
        Crestron.Logos.SplusObjects.DigitalOutput HASZONEWARNINGS;
        Crestron.Logos.SplusObjects.DigitalOutput UNIT_CELSIUS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput UNIT_FAHRENHEIT_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput HUMIDITY_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput SETPOINT_LOWERLIMIT_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput SETPOINT_UPPERLIMIT_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput POWERED_ON;
        Crestron.Logos.SplusObjects.DigitalOutput POWERED_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_CONTROLLABLE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_AIR_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_RADIANT_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_COMBINED_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_AIR_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_RADIANT_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput STAGES_COMBINED_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_CONTROLLABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_STOP_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_COOLING_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_HEATING_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_FAN_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_DRY_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_AUTO_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_STOP_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_COOLING_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_HEATING_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_FAN_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_DRY_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MODES_AUTO_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_CONTROLLABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_AUTO_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_1_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_2_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_3_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_4_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_5_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_6_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_7_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_AUTO_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_1_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_2_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_3_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_4_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_5_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_6_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput FANSPEEDS_7_ACTIVE;
        Crestron.Logos.SplusObjects.AnalogOutput TEMPERATURE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput HUMIDITY_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput SETPOINT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput SETPOINTLOWERLIMIT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput SETPOINTUPPERLIMIT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput STAGES_ACTIVE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput MODES_ACTIVE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput FANSPEEDS_ACTIVE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput ZONEERRORSCOUNT;
        Crestron.Logos.SplusObjects.AnalogOutput ZONEWARNINGSCOUNT;
        Crestron.Logos.SplusObjects.StringOutput TEMPERATURE;
        Crestron.Logos.SplusObjects.StringOutput HUMIDITY;
        Crestron.Logos.SplusObjects.StringOutput SETPOINT;
        Crestron.Logos.SplusObjects.StringOutput SETPOINTLOWERLIMIT;
        Crestron.Logos.SplusObjects.StringOutput SETPOINTUPPERLIMIT;
        Crestron.Logos.SplusObjects.StringOutput STAGES_ACTIVE_SERIAL;
        Crestron.Logos.SplusObjects.StringOutput MODES_ACTIVE_SERIAL;
        Crestron.Logos.SplusObjects.StringOutput FANSPEEDS_ACTIVE_SERIAL;
        Crestron.Logos.SplusObjects.StringOutput NAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ZONEERRORS;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ZONEWARNINGS;
        UShortParameter SYSTEMNUMBER;
        UShortParameter ZONENUMBER;
        UShortParameter AIRSTAGECONTROLENABLED;
        UShortParameter RADIANTSTAGECONTROLENABLED;
        UShortParameter MODECONTROLENABLED;
        UShortParameter FANSPEEDCONTROLENABLED;
        AirZone.Simpl.AirzoneZoneSimpl MYAIRZONEZONESIMPL;
        object MANUALPOLL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 106;
                MYAIRZONEZONESIMPL . ManualPoll ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SETPOINT_UP_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 111;
            MYAIRZONEZONESIMPL . SetpointUp ( (ushort)( 1 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SETPOINT_UP_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 116;
        MYAIRZONEZONESIMPL . SetpointUp ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETPOINT_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 121;
        MYAIRZONEZONESIMPL . SetpointDown ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETPOINT_DOWN_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 126;
        MYAIRZONEZONESIMPL . SetpointDown ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_ON_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 131;
        MYAIRZONEZONESIMPL . PowerOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_OFF_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 136;
        MYAIRZONEZONESIMPL . PowerOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STAGES_AIR_SET_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        MYAIRZONEZONESIMPL . SetStage ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STAGES_RADIANT_SET_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        MYAIRZONEZONESIMPL . SetStage ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STAGES_COMBINED_SET_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 152;
        MYAIRZONEZONESIMPL . SetStage ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STAGES_VALUE_SET_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 157;
        MYAIRZONEZONESIMPL . SetStage ( (ushort)( STAGES_VALUE_SET  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_STOP_SET_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_COOLING_SET_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 167;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_HEATING_SET_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 172;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_FAN_SET_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_DRY_SET_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 182;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_AUTO_SET_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 187;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_VALUE_SET_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 192;
        MYAIRZONEZONESIMPL . SetModus ( (ushort)( MODES_VALUE_SET  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_AUTO_SET_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 197;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_1_SET_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 202;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_2_SET_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 208;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_3_SET_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 214;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_4_SET_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 219;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_5_SET_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 224;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_6_SET_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 229;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_7_SET_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 235;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_VALUE_SET_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 240;
        MYAIRZONEZONESIMPL . SetFanspeed ( (ushort)( FANSPEEDS_VALUE_SET  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void ONINITIALIZEDCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplUShortEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 250;
        INITIALIZED  .Value = (ushort) ( E.Value ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONPOLLING ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, EventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 255;
        Functions.Pulse ( 100, POLLING ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONLOADED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplZoneLoadedEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 260;
        NAME  .UpdateValue ( E . Name  ) ; 
        __context__.SourceCodeLine = 262;
        TEMPERATURE  .UpdateValue ( E . Temperature  ) ; 
        __context__.SourceCodeLine = 263;
        TEMPERATURE_ANALOG  .Value = (ushort) ( E.TemperatureAnalog ) ; 
        __context__.SourceCodeLine = 265;
        HUMIDITY  .UpdateValue ( E . Humidity  ) ; 
        __context__.SourceCodeLine = 266;
        HUMIDITY_ANALOG  .Value = (ushort) ( E.HumidityAnalog ) ; 
        __context__.SourceCodeLine = 267;
        HUMIDITY_AVAILABLE  .Value = (ushort) ( E.HumidityAvailable ) ; 
        __context__.SourceCodeLine = 269;
        SETPOINT  .UpdateValue ( E . Setpoint  ) ; 
        __context__.SourceCodeLine = 270;
        SETPOINT_ANALOG  .Value = (ushort) ( E.SetpointAnalog ) ; 
        __context__.SourceCodeLine = 272;
        SETPOINTLOWERLIMIT  .UpdateValue ( E . SetpointLowerLimit  ) ; 
        __context__.SourceCodeLine = 273;
        SETPOINTUPPERLIMIT  .UpdateValue ( E . SetpointUpperLimit  ) ; 
        __context__.SourceCodeLine = 274;
        SETPOINTLOWERLIMIT_ANALOG  .Value = (ushort) ( E.SetpointLowerLimitAnalog ) ; 
        __context__.SourceCodeLine = 275;
        SETPOINTUPPERLIMIT_ANALOG  .Value = (ushort) ( E.SetpointUpperLimitAnalog ) ; 
        __context__.SourceCodeLine = 276;
        SETPOINT_LOWERLIMIT_AVAILABLE  .Value = (ushort) ( E.SetpointLowerLimitAvailable ) ; 
        __context__.SourceCodeLine = 277;
        SETPOINT_UPPERLIMIT_AVAILABLE  .Value = (ushort) ( E.SetpointUpperLimitAvailable ) ; 
        __context__.SourceCodeLine = 279;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (E.PowerStatus == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 281;
            POWERED_OFF  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 282;
            POWERED_ON  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 285;
            POWERED_ON  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 286;
            POWERED_OFF  .Value = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 289;
        STAGES_AVAILABLE  .Value = (ushort) ( E.StagesAvailable ) ; 
        __context__.SourceCodeLine = 290;
        STAGES_CONTROLLABLE  .Value = (ushort) ( E.StageControllable ) ; 
        __context__.SourceCodeLine = 292;
        STAGES_AIR_AVAILABLE  .Value = (ushort) ( E.StageAirAvailable ) ; 
        __context__.SourceCodeLine = 293;
        STAGES_RADIANT_AVAILABLE  .Value = (ushort) ( E.StageRadiantAvailable ) ; 
        __context__.SourceCodeLine = 294;
        STAGES_COMBINED_AVAILABLE  .Value = (ushort) ( E.StageCombinedAvailable ) ; 
        __context__.SourceCodeLine = 296;
        STAGES_AIR_ACTIVE  .Value = (ushort) ( E.StageAirActive ) ; 
        __context__.SourceCodeLine = 297;
        STAGES_RADIANT_ACTIVE  .Value = (ushort) ( E.StageRadiantActive ) ; 
        __context__.SourceCodeLine = 298;
        STAGES_COMBINED_ACTIVE  .Value = (ushort) ( E.StageCombinedActive ) ; 
        __context__.SourceCodeLine = 300;
        STAGES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveStageAnalog ) ; 
        __context__.SourceCodeLine = 301;
        STAGES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveStageSerial  ) ; 
        __context__.SourceCodeLine = 303;
        MODES_AVAILABLE  .Value = (ushort) ( E.ModesAvailable ) ; 
        __context__.SourceCodeLine = 304;
        MODES_CONTROLLABLE  .Value = (ushort) ( E.ModeControllable ) ; 
        __context__.SourceCodeLine = 306;
        MODES_STOP_AVAILABLE  .Value = (ushort) ( E.ModeStopAvailable ) ; 
        __context__.SourceCodeLine = 307;
        MODES_COOLING_AVAILABLE  .Value = (ushort) ( E.ModeCoolingAvailable ) ; 
        __context__.SourceCodeLine = 308;
        MODES_HEATING_AVAILABLE  .Value = (ushort) ( E.ModeHeatingAvailable ) ; 
        __context__.SourceCodeLine = 309;
        MODES_FAN_AVAILABLE  .Value = (ushort) ( E.ModeFanAvailable ) ; 
        __context__.SourceCodeLine = 310;
        MODES_DRY_AVAILABLE  .Value = (ushort) ( E.ModeDryAvailable ) ; 
        __context__.SourceCodeLine = 311;
        MODES_AUTO_AVAILABLE  .Value = (ushort) ( E.ModeAutoAvailable ) ; 
        __context__.SourceCodeLine = 313;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 314;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 315;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 316;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 317;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 318;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 320;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 321;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        __context__.SourceCodeLine = 323;
        FANSPEEDS_AVAILABLE  .Value = (ushort) ( E.SpeedsAvailable ) ; 
        __context__.SourceCodeLine = 324;
        FANSPEEDS_CONTROLLABLE  .Value = (ushort) ( E.SpeedControllable ) ; 
        __context__.SourceCodeLine = 326;
        FANSPEEDS_AUTO_AVAILABLE  .Value = (ushort) ( E.SpeedAutoAvailable ) ; 
        __context__.SourceCodeLine = 327;
        FANSPEEDS_1_AVAILABLE  .Value = (ushort) ( E.SpeedOneAvailable ) ; 
        __context__.SourceCodeLine = 328;
        FANSPEEDS_2_AVAILABLE  .Value = (ushort) ( E.SpeedTwoAvailable ) ; 
        __context__.SourceCodeLine = 329;
        FANSPEEDS_3_AVAILABLE  .Value = (ushort) ( E.SpeedThreeAvailable ) ; 
        __context__.SourceCodeLine = 330;
        FANSPEEDS_4_AVAILABLE  .Value = (ushort) ( E.SpeedFourAvailable ) ; 
        __context__.SourceCodeLine = 331;
        FANSPEEDS_5_AVAILABLE  .Value = (ushort) ( E.SpeedFiveAvailable ) ; 
        __context__.SourceCodeLine = 332;
        FANSPEEDS_6_AVAILABLE  .Value = (ushort) ( E.SpeedSixAvailable ) ; 
        __context__.SourceCodeLine = 333;
        FANSPEEDS_7_AVAILABLE  .Value = (ushort) ( E.SpeedSevenAvailable ) ; 
        __context__.SourceCodeLine = 335;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 336;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 337;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 338;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 339;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 340;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 341;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 342;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 344;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 345;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSTATUSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplZoneStatusEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 350;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (E.PowerStatus == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 352;
            POWERED_OFF  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 353;
            POWERED_ON  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 356;
            POWERED_ON  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 357;
            POWERED_OFF  .Value = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 360;
        TEMPERATURE  .UpdateValue ( E . Temperature  ) ; 
        __context__.SourceCodeLine = 361;
        TEMPERATURE_ANALOG  .Value = (ushort) ( E.TemperatureAnalog ) ; 
        __context__.SourceCodeLine = 363;
        HUMIDITY  .UpdateValue ( E . Humidity  ) ; 
        __context__.SourceCodeLine = 364;
        HUMIDITY_ANALOG  .Value = (ushort) ( E.HumidityAnalog ) ; 
        __context__.SourceCodeLine = 366;
        STAGES_AIR_ACTIVE  .Value = (ushort) ( E.StageAirActive ) ; 
        __context__.SourceCodeLine = 367;
        STAGES_RADIANT_ACTIVE  .Value = (ushort) ( E.StageRadiantActive ) ; 
        __context__.SourceCodeLine = 368;
        STAGES_COMBINED_ACTIVE  .Value = (ushort) ( E.StageCombinedActive ) ; 
        __context__.SourceCodeLine = 370;
        STAGES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveStageAnalog ) ; 
        __context__.SourceCodeLine = 371;
        STAGES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveStageSerial  ) ; 
        __context__.SourceCodeLine = 373;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 374;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 375;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 376;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 377;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 378;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 380;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 381;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        __context__.SourceCodeLine = 383;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 384;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 385;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 386;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 387;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 388;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 389;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 390;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 392;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 393;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONNAMECHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplNameEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 398;
        NAME  .UpdateValue ( E . Name  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSETPOINTSTATUSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSetpointEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 403;
        SETPOINT  .UpdateValue ( E . Setpoint  ) ; 
        __context__.SourceCodeLine = 404;
        SETPOINT_ANALOG  .Value = (ushort) ( E.SetpointAnalog ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONHUMIDITYCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplHumidityEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 409;
        HUMIDITY  .UpdateValue ( E . Humidity  ) ; 
        __context__.SourceCodeLine = 410;
        HUMIDITY_ANALOG  .Value = (ushort) ( E.HumidityAnalog ) ; 
        __context__.SourceCodeLine = 411;
        HUMIDITY_AVAILABLE  .Value = (ushort) ( E.HumidityAvailable ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSETPOINTLIMITSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSetpointLimitEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 416;
        SETPOINTLOWERLIMIT  .UpdateValue ( E . SetpointLowerLimit  ) ; 
        __context__.SourceCodeLine = 417;
        SETPOINTUPPERLIMIT  .UpdateValue ( E . SetpointUpperLimit  ) ; 
        __context__.SourceCodeLine = 418;
        SETPOINTLOWERLIMIT_ANALOG  .Value = (ushort) ( E.SetpointLowerLimitAnalog ) ; 
        __context__.SourceCodeLine = 419;
        SETPOINTUPPERLIMIT_ANALOG  .Value = (ushort) ( E.SetpointUpperLimitAnalog ) ; 
        __context__.SourceCodeLine = 420;
        SETPOINT_LOWERLIMIT_AVAILABLE  .Value = (ushort) ( E.SetpointLowerLimitAvailable ) ; 
        __context__.SourceCodeLine = 421;
        SETPOINT_UPPERLIMIT_AVAILABLE  .Value = (ushort) ( E.SetpointUpperLimitAvailable ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONMODESCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplModesEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 426;
        MODES_AVAILABLE  .Value = (ushort) ( E.ModesAvailable ) ; 
        __context__.SourceCodeLine = 427;
        MODES_CONTROLLABLE  .Value = (ushort) ( E.ModeControllable ) ; 
        __context__.SourceCodeLine = 429;
        MODES_STOP_AVAILABLE  .Value = (ushort) ( E.ModeStopAvailable ) ; 
        __context__.SourceCodeLine = 430;
        MODES_COOLING_AVAILABLE  .Value = (ushort) ( E.ModeCoolingAvailable ) ; 
        __context__.SourceCodeLine = 431;
        MODES_HEATING_AVAILABLE  .Value = (ushort) ( E.ModeHeatingAvailable ) ; 
        __context__.SourceCodeLine = 432;
        MODES_FAN_AVAILABLE  .Value = (ushort) ( E.ModeFanAvailable ) ; 
        __context__.SourceCodeLine = 433;
        MODES_DRY_AVAILABLE  .Value = (ushort) ( E.ModeDryAvailable ) ; 
        __context__.SourceCodeLine = 434;
        MODES_AUTO_AVAILABLE  .Value = (ushort) ( E.ModeAutoAvailable ) ; 
        __context__.SourceCodeLine = 436;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 437;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 438;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 439;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 440;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 441;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 443;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 444;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSPEEDSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSpeedsEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 449;
        FANSPEEDS_AVAILABLE  .Value = (ushort) ( E.SpeedsAvailable ) ; 
        __context__.SourceCodeLine = 450;
        FANSPEEDS_CONTROLLABLE  .Value = (ushort) ( E.SpeedControllable ) ; 
        __context__.SourceCodeLine = 452;
        FANSPEEDS_AUTO_AVAILABLE  .Value = (ushort) ( E.SpeedAutoAvailable ) ; 
        __context__.SourceCodeLine = 453;
        FANSPEEDS_1_AVAILABLE  .Value = (ushort) ( E.SpeedOneAvailable ) ; 
        __context__.SourceCodeLine = 454;
        FANSPEEDS_2_AVAILABLE  .Value = (ushort) ( E.SpeedTwoAvailable ) ; 
        __context__.SourceCodeLine = 455;
        FANSPEEDS_3_AVAILABLE  .Value = (ushort) ( E.SpeedThreeAvailable ) ; 
        __context__.SourceCodeLine = 456;
        FANSPEEDS_4_AVAILABLE  .Value = (ushort) ( E.SpeedFourAvailable ) ; 
        __context__.SourceCodeLine = 457;
        FANSPEEDS_5_AVAILABLE  .Value = (ushort) ( E.SpeedFiveAvailable ) ; 
        __context__.SourceCodeLine = 458;
        FANSPEEDS_6_AVAILABLE  .Value = (ushort) ( E.SpeedSixAvailable ) ; 
        __context__.SourceCodeLine = 459;
        FANSPEEDS_7_AVAILABLE  .Value = (ushort) ( E.SpeedSevenAvailable ) ; 
        __context__.SourceCodeLine = 461;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 462;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 463;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 464;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 465;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 466;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 467;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 468;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 470;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 471;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSTAGESCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplStagesEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 476;
        STAGES_AVAILABLE  .Value = (ushort) ( E.StagesAvailable ) ; 
        __context__.SourceCodeLine = 477;
        STAGES_CONTROLLABLE  .Value = (ushort) ( E.StageControllable ) ; 
        __context__.SourceCodeLine = 479;
        STAGES_AIR_AVAILABLE  .Value = (ushort) ( E.StageAirAvailable ) ; 
        __context__.SourceCodeLine = 480;
        STAGES_RADIANT_AVAILABLE  .Value = (ushort) ( E.StageRadiantAvailable ) ; 
        __context__.SourceCodeLine = 481;
        STAGES_COMBINED_AVAILABLE  .Value = (ushort) ( E.StageCombinedAvailable ) ; 
        __context__.SourceCodeLine = 483;
        STAGES_AIR_ACTIVE  .Value = (ushort) ( E.StageAirActive ) ; 
        __context__.SourceCodeLine = 484;
        STAGES_RADIANT_ACTIVE  .Value = (ushort) ( E.StageRadiantActive ) ; 
        __context__.SourceCodeLine = 485;
        STAGES_COMBINED_ACTIVE  .Value = (ushort) ( E.StageCombinedActive ) ; 
        __context__.SourceCodeLine = 487;
        STAGES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveStageAnalog ) ; 
        __context__.SourceCodeLine = 488;
        STAGES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveStageSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONUNITCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplUnitEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 493;
        UNIT_CELSIUS_ACTIVE  .Value = (ushort) ( E.Celsius ) ; 
        __context__.SourceCodeLine = 494;
        UNIT_FAHRENHEIT_ACTIVE  .Value = (ushort) ( E.Fahrenheit ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONWARNINGSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplWarningsEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 501;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)E.Count; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 503;
            ZONEWARNINGS [ I]  .UpdateValue ( E . Messages [ (I - 1) ]  ) ; 
            __context__.SourceCodeLine = 501;
            } 
        
        __context__.SourceCodeLine = 506;
        HASZONEWARNINGS  .Value = (ushort) ( E.HasWarnings ) ; 
        __context__.SourceCodeLine = 507;
        ZONEWARNINGSCOUNT  .Value = (ushort) ( E.Count ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONERRORSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplErrorsEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 514;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)E.Count; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 516;
            ZONEERRORS [ I]  .UpdateValue ( E . Messages [ (I - 1) ]  ) ; 
            __context__.SourceCodeLine = 514;
            } 
        
        __context__.SourceCodeLine = 519;
        HASZONEERRORS  .Value = (ushort) ( E.HasErrors ) ; 
        __context__.SourceCodeLine = 520;
        ZONEERRORSCOUNT  .Value = (ushort) ( E.Count ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONPOWERSTATUSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplPowerStatusEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 525;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (E.PowerStatus == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 527;
            POWERED_OFF  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 528;
            POWERED_ON  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 531;
            POWERED_ON  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 532;
            POWERED_OFF  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSTAGEACTIVECHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplStageActiveEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 539;
        STAGES_AIR_ACTIVE  .Value = (ushort) ( E.StageAirActive ) ; 
        __context__.SourceCodeLine = 540;
        STAGES_RADIANT_ACTIVE  .Value = (ushort) ( E.StageRadiantActive ) ; 
        __context__.SourceCodeLine = 541;
        STAGES_COMBINED_ACTIVE  .Value = (ushort) ( E.StageCombinedActive ) ; 
        __context__.SourceCodeLine = 543;
        STAGES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveStageAnalog ) ; 
        __context__.SourceCodeLine = 544;
        STAGES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveStageSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONMODEACTIVECHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplModeActiveEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 549;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 550;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 551;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 552;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 553;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 554;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 556;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 557;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSPEEDACTIVECHANGED ( object __sender__ /*AirZone.Simpl.AirzoneZoneSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSpeedActiveEventArgs E ) 
    { 
    AirzoneZoneSimpl  SENDER  = (AirzoneZoneSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 562;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 563;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 564;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 565;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 566;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 567;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 568;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 569;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 571;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 572;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 581;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 583;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONINITIALIZEDCHANGED , ONINITIALIZEDCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnInitializedChanged  += ONINITIALIZEDCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 584;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONPOLLING , ONPOLLING ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnPolling  += ONPOLLING; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 585;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONLOADED , ONLOADED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnLoaded  += ONLOADED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 586;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSTATUSCHANGED , ONSTATUSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnStatusChanged  += ONSTATUSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 587;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONNAMECHANGED , ONNAMECHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnNameChanged  += ONNAMECHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 588;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONHUMIDITYCHANGED , ONHUMIDITYCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnHumidityChanged  += ONHUMIDITYCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 589;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSETPOINTLIMITSCHANGED , ONSETPOINTLIMITSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnSetpointLimitsChanged  += ONSETPOINTLIMITSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 590;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONMODESCHANGED , ONMODESCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnModesChanged  += ONMODESCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 591;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSTAGESCHANGED , ONSTAGESCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnStagesChanged  += ONSTAGESCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 592;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSPEEDSCHANGED , ONSPEEDSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnSpeedsChanged  += ONSPEEDSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 593;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONUNITCHANGED , ONUNITCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnUnitChanged  += ONUNITCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 594;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONERRORSCHANGED , ONERRORSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnErrorsChanged  += ONERRORSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 595;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONWARNINGSCHANGED , ONWARNINGSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnWarningsChanged  += ONWARNINGSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 597;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSETPOINTSTATUSCHANGED , ONSETPOINTSTATUSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnSetpointStatusChanged  += ONSETPOINTSTATUSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 598;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONPOWERSTATUSCHANGED , ONPOWERSTATUSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnPowerStatusChanged  += ONPOWERSTATUSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 599;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSTAGEACTIVECHANGED , ONSTAGEACTIVECHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnStageActiveChanged  += ONSTAGEACTIVECHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 600;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONMODEACTIVECHANGED , ONMODEACTIVECHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnModeActiveChanged  += ONMODEACTIVECHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 601;
        // RegisterEvent( MYAIRZONEZONESIMPL , ONSPEEDACTIVECHANGED , ONSPEEDACTIVECHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONEZONESIMPL .OnSpeedActiveChanged  += ONSPEEDACTIVECHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 603;
        MYAIRZONEZONESIMPL . Initialize ( (ushort)( SYSTEMNUMBER  .Value ), (ushort)( ZONENUMBER  .Value ), (ushort)( AIRSTAGECONTROLENABLED  .Value ), (ushort)( RADIANTSTAGECONTROLENABLED  .Value ), (ushort)( MODECONTROLENABLED  .Value ), (ushort)( FANSPEEDCONTROLENABLED  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    MANUALPOLL = new Crestron.Logos.SplusObjects.DigitalInput( MANUALPOLL__DigitalInput__, this );
    m_DigitalInputList.Add( MANUALPOLL__DigitalInput__, MANUALPOLL );
    
    SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SETPOINT_UP__DigitalInput__, SETPOINT_UP );
    
    SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SETPOINT_DOWN__DigitalInput__, SETPOINT_DOWN );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON__DigitalInput__, POWER_ON );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF__DigitalInput__, POWER_OFF );
    
    STAGES_AIR_SET = new Crestron.Logos.SplusObjects.DigitalInput( STAGES_AIR_SET__DigitalInput__, this );
    m_DigitalInputList.Add( STAGES_AIR_SET__DigitalInput__, STAGES_AIR_SET );
    
    STAGES_RADIANT_SET = new Crestron.Logos.SplusObjects.DigitalInput( STAGES_RADIANT_SET__DigitalInput__, this );
    m_DigitalInputList.Add( STAGES_RADIANT_SET__DigitalInput__, STAGES_RADIANT_SET );
    
    STAGES_COMBINED_SET = new Crestron.Logos.SplusObjects.DigitalInput( STAGES_COMBINED_SET__DigitalInput__, this );
    m_DigitalInputList.Add( STAGES_COMBINED_SET__DigitalInput__, STAGES_COMBINED_SET );
    
    MODES_STOP_SET = new Crestron.Logos.SplusObjects.DigitalInput( MODES_STOP_SET__DigitalInput__, this );
    m_DigitalInputList.Add( MODES_STOP_SET__DigitalInput__, MODES_STOP_SET );
    
    MODES_COOLING_SET = new Crestron.Logos.SplusObjects.DigitalInput( MODES_COOLING_SET__DigitalInput__, this );
    m_DigitalInputList.Add( MODES_COOLING_SET__DigitalInput__, MODES_COOLING_SET );
    
    MODES_HEATING_SET = new Crestron.Logos.SplusObjects.DigitalInput( MODES_HEATING_SET__DigitalInput__, this );
    m_DigitalInputList.Add( MODES_HEATING_SET__DigitalInput__, MODES_HEATING_SET );
    
    MODES_FAN_SET = new Crestron.Logos.SplusObjects.DigitalInput( MODES_FAN_SET__DigitalInput__, this );
    m_DigitalInputList.Add( MODES_FAN_SET__DigitalInput__, MODES_FAN_SET );
    
    MODES_DRY_SET = new Crestron.Logos.SplusObjects.DigitalInput( MODES_DRY_SET__DigitalInput__, this );
    m_DigitalInputList.Add( MODES_DRY_SET__DigitalInput__, MODES_DRY_SET );
    
    MODES_AUTO_SET = new Crestron.Logos.SplusObjects.DigitalInput( MODES_AUTO_SET__DigitalInput__, this );
    m_DigitalInputList.Add( MODES_AUTO_SET__DigitalInput__, MODES_AUTO_SET );
    
    FANSPEEDS_AUTO_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_AUTO_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_AUTO_SET__DigitalInput__, FANSPEEDS_AUTO_SET );
    
    FANSPEEDS_1_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_1_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_1_SET__DigitalInput__, FANSPEEDS_1_SET );
    
    FANSPEEDS_2_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_2_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_2_SET__DigitalInput__, FANSPEEDS_2_SET );
    
    FANSPEEDS_3_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_3_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_3_SET__DigitalInput__, FANSPEEDS_3_SET );
    
    FANSPEEDS_4_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_4_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_4_SET__DigitalInput__, FANSPEEDS_4_SET );
    
    FANSPEEDS_5_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_5_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_5_SET__DigitalInput__, FANSPEEDS_5_SET );
    
    FANSPEEDS_6_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_6_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_6_SET__DigitalInput__, FANSPEEDS_6_SET );
    
    FANSPEEDS_7_SET = new Crestron.Logos.SplusObjects.DigitalInput( FANSPEEDS_7_SET__DigitalInput__, this );
    m_DigitalInputList.Add( FANSPEEDS_7_SET__DigitalInput__, FANSPEEDS_7_SET );
    
    INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZED__DigitalOutput__, INITIALIZED );
    
    POLLING = new Crestron.Logos.SplusObjects.DigitalOutput( POLLING__DigitalOutput__, this );
    m_DigitalOutputList.Add( POLLING__DigitalOutput__, POLLING );
    
    HASZONEERRORS = new Crestron.Logos.SplusObjects.DigitalOutput( HASZONEERRORS__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASZONEERRORS__DigitalOutput__, HASZONEERRORS );
    
    HASZONEWARNINGS = new Crestron.Logos.SplusObjects.DigitalOutput( HASZONEWARNINGS__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASZONEWARNINGS__DigitalOutput__, HASZONEWARNINGS );
    
    UNIT_CELSIUS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( UNIT_CELSIUS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( UNIT_CELSIUS_ACTIVE__DigitalOutput__, UNIT_CELSIUS_ACTIVE );
    
    UNIT_FAHRENHEIT_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( UNIT_FAHRENHEIT_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( UNIT_FAHRENHEIT_ACTIVE__DigitalOutput__, UNIT_FAHRENHEIT_ACTIVE );
    
    HUMIDITY_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( HUMIDITY_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( HUMIDITY_AVAILABLE__DigitalOutput__, HUMIDITY_AVAILABLE );
    
    SETPOINT_LOWERLIMIT_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( SETPOINT_LOWERLIMIT_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SETPOINT_LOWERLIMIT_AVAILABLE__DigitalOutput__, SETPOINT_LOWERLIMIT_AVAILABLE );
    
    SETPOINT_UPPERLIMIT_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( SETPOINT_UPPERLIMIT_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SETPOINT_UPPERLIMIT_AVAILABLE__DigitalOutput__, SETPOINT_UPPERLIMIT_AVAILABLE );
    
    POWERED_ON = new Crestron.Logos.SplusObjects.DigitalOutput( POWERED_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWERED_ON__DigitalOutput__, POWERED_ON );
    
    POWERED_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( POWERED_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWERED_OFF__DigitalOutput__, POWERED_OFF );
    
    STAGES_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_AVAILABLE__DigitalOutput__, STAGES_AVAILABLE );
    
    STAGES_CONTROLLABLE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_CONTROLLABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_CONTROLLABLE__DigitalOutput__, STAGES_CONTROLLABLE );
    
    STAGES_AIR_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_AIR_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_AIR_AVAILABLE__DigitalOutput__, STAGES_AIR_AVAILABLE );
    
    STAGES_RADIANT_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_RADIANT_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_RADIANT_AVAILABLE__DigitalOutput__, STAGES_RADIANT_AVAILABLE );
    
    STAGES_COMBINED_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_COMBINED_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_COMBINED_AVAILABLE__DigitalOutput__, STAGES_COMBINED_AVAILABLE );
    
    STAGES_AIR_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_AIR_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_AIR_ACTIVE__DigitalOutput__, STAGES_AIR_ACTIVE );
    
    STAGES_RADIANT_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_RADIANT_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_RADIANT_ACTIVE__DigitalOutput__, STAGES_RADIANT_ACTIVE );
    
    STAGES_COMBINED_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( STAGES_COMBINED_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STAGES_COMBINED_ACTIVE__DigitalOutput__, STAGES_COMBINED_ACTIVE );
    
    MODES_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_AVAILABLE__DigitalOutput__, MODES_AVAILABLE );
    
    MODES_CONTROLLABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_CONTROLLABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_CONTROLLABLE__DigitalOutput__, MODES_CONTROLLABLE );
    
    MODES_STOP_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_STOP_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_STOP_AVAILABLE__DigitalOutput__, MODES_STOP_AVAILABLE );
    
    MODES_COOLING_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_COOLING_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_COOLING_AVAILABLE__DigitalOutput__, MODES_COOLING_AVAILABLE );
    
    MODES_HEATING_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_HEATING_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_HEATING_AVAILABLE__DigitalOutput__, MODES_HEATING_AVAILABLE );
    
    MODES_FAN_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_FAN_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_FAN_AVAILABLE__DigitalOutput__, MODES_FAN_AVAILABLE );
    
    MODES_DRY_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_DRY_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_DRY_AVAILABLE__DigitalOutput__, MODES_DRY_AVAILABLE );
    
    MODES_AUTO_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_AUTO_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_AUTO_AVAILABLE__DigitalOutput__, MODES_AUTO_AVAILABLE );
    
    MODES_STOP_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_STOP_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_STOP_ACTIVE__DigitalOutput__, MODES_STOP_ACTIVE );
    
    MODES_COOLING_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_COOLING_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_COOLING_ACTIVE__DigitalOutput__, MODES_COOLING_ACTIVE );
    
    MODES_HEATING_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_HEATING_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_HEATING_ACTIVE__DigitalOutput__, MODES_HEATING_ACTIVE );
    
    MODES_FAN_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_FAN_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_FAN_ACTIVE__DigitalOutput__, MODES_FAN_ACTIVE );
    
    MODES_DRY_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_DRY_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_DRY_ACTIVE__DigitalOutput__, MODES_DRY_ACTIVE );
    
    MODES_AUTO_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MODES_AUTO_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODES_AUTO_ACTIVE__DigitalOutput__, MODES_AUTO_ACTIVE );
    
    FANSPEEDS_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_AVAILABLE__DigitalOutput__, FANSPEEDS_AVAILABLE );
    
    FANSPEEDS_CONTROLLABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_CONTROLLABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_CONTROLLABLE__DigitalOutput__, FANSPEEDS_CONTROLLABLE );
    
    FANSPEEDS_AUTO_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_AUTO_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_AUTO_AVAILABLE__DigitalOutput__, FANSPEEDS_AUTO_AVAILABLE );
    
    FANSPEEDS_1_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_1_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_1_AVAILABLE__DigitalOutput__, FANSPEEDS_1_AVAILABLE );
    
    FANSPEEDS_2_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_2_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_2_AVAILABLE__DigitalOutput__, FANSPEEDS_2_AVAILABLE );
    
    FANSPEEDS_3_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_3_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_3_AVAILABLE__DigitalOutput__, FANSPEEDS_3_AVAILABLE );
    
    FANSPEEDS_4_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_4_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_4_AVAILABLE__DigitalOutput__, FANSPEEDS_4_AVAILABLE );
    
    FANSPEEDS_5_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_5_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_5_AVAILABLE__DigitalOutput__, FANSPEEDS_5_AVAILABLE );
    
    FANSPEEDS_6_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_6_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_6_AVAILABLE__DigitalOutput__, FANSPEEDS_6_AVAILABLE );
    
    FANSPEEDS_7_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_7_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_7_AVAILABLE__DigitalOutput__, FANSPEEDS_7_AVAILABLE );
    
    FANSPEEDS_AUTO_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_AUTO_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_AUTO_ACTIVE__DigitalOutput__, FANSPEEDS_AUTO_ACTIVE );
    
    FANSPEEDS_1_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_1_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_1_ACTIVE__DigitalOutput__, FANSPEEDS_1_ACTIVE );
    
    FANSPEEDS_2_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_2_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_2_ACTIVE__DigitalOutput__, FANSPEEDS_2_ACTIVE );
    
    FANSPEEDS_3_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_3_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_3_ACTIVE__DigitalOutput__, FANSPEEDS_3_ACTIVE );
    
    FANSPEEDS_4_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_4_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_4_ACTIVE__DigitalOutput__, FANSPEEDS_4_ACTIVE );
    
    FANSPEEDS_5_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_5_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_5_ACTIVE__DigitalOutput__, FANSPEEDS_5_ACTIVE );
    
    FANSPEEDS_6_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_6_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_6_ACTIVE__DigitalOutput__, FANSPEEDS_6_ACTIVE );
    
    FANSPEEDS_7_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( FANSPEEDS_7_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FANSPEEDS_7_ACTIVE__DigitalOutput__, FANSPEEDS_7_ACTIVE );
    
    STAGES_VALUE_SET = new Crestron.Logos.SplusObjects.AnalogInput( STAGES_VALUE_SET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( STAGES_VALUE_SET__AnalogSerialInput__, STAGES_VALUE_SET );
    
    MODES_VALUE_SET = new Crestron.Logos.SplusObjects.AnalogInput( MODES_VALUE_SET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MODES_VALUE_SET__AnalogSerialInput__, MODES_VALUE_SET );
    
    FANSPEEDS_VALUE_SET = new Crestron.Logos.SplusObjects.AnalogInput( FANSPEEDS_VALUE_SET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FANSPEEDS_VALUE_SET__AnalogSerialInput__, FANSPEEDS_VALUE_SET );
    
    TEMPERATURE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( TEMPERATURE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TEMPERATURE_ANALOG__AnalogSerialOutput__, TEMPERATURE_ANALOG );
    
    HUMIDITY_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( HUMIDITY_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( HUMIDITY_ANALOG__AnalogSerialOutput__, HUMIDITY_ANALOG );
    
    SETPOINT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( SETPOINT_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SETPOINT_ANALOG__AnalogSerialOutput__, SETPOINT_ANALOG );
    
    SETPOINTLOWERLIMIT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( SETPOINTLOWERLIMIT_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SETPOINTLOWERLIMIT_ANALOG__AnalogSerialOutput__, SETPOINTLOWERLIMIT_ANALOG );
    
    SETPOINTUPPERLIMIT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( SETPOINTUPPERLIMIT_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SETPOINTUPPERLIMIT_ANALOG__AnalogSerialOutput__, SETPOINTUPPERLIMIT_ANALOG );
    
    STAGES_ACTIVE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( STAGES_ACTIVE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( STAGES_ACTIVE_ANALOG__AnalogSerialOutput__, STAGES_ACTIVE_ANALOG );
    
    MODES_ACTIVE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( MODES_ACTIVE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MODES_ACTIVE_ANALOG__AnalogSerialOutput__, MODES_ACTIVE_ANALOG );
    
    FANSPEEDS_ACTIVE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( FANSPEEDS_ACTIVE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FANSPEEDS_ACTIVE_ANALOG__AnalogSerialOutput__, FANSPEEDS_ACTIVE_ANALOG );
    
    ZONEERRORSCOUNT = new Crestron.Logos.SplusObjects.AnalogOutput( ZONEERRORSCOUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONEERRORSCOUNT__AnalogSerialOutput__, ZONEERRORSCOUNT );
    
    ZONEWARNINGSCOUNT = new Crestron.Logos.SplusObjects.AnalogOutput( ZONEWARNINGSCOUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONEWARNINGSCOUNT__AnalogSerialOutput__, ZONEWARNINGSCOUNT );
    
    TEMPERATURE = new Crestron.Logos.SplusObjects.StringOutput( TEMPERATURE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TEMPERATURE__AnalogSerialOutput__, TEMPERATURE );
    
    HUMIDITY = new Crestron.Logos.SplusObjects.StringOutput( HUMIDITY__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HUMIDITY__AnalogSerialOutput__, HUMIDITY );
    
    SETPOINT = new Crestron.Logos.SplusObjects.StringOutput( SETPOINT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SETPOINT__AnalogSerialOutput__, SETPOINT );
    
    SETPOINTLOWERLIMIT = new Crestron.Logos.SplusObjects.StringOutput( SETPOINTLOWERLIMIT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SETPOINTLOWERLIMIT__AnalogSerialOutput__, SETPOINTLOWERLIMIT );
    
    SETPOINTUPPERLIMIT = new Crestron.Logos.SplusObjects.StringOutput( SETPOINTUPPERLIMIT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SETPOINTUPPERLIMIT__AnalogSerialOutput__, SETPOINTUPPERLIMIT );
    
    STAGES_ACTIVE_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( STAGES_ACTIVE_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( STAGES_ACTIVE_SERIAL__AnalogSerialOutput__, STAGES_ACTIVE_SERIAL );
    
    MODES_ACTIVE_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( MODES_ACTIVE_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MODES_ACTIVE_SERIAL__AnalogSerialOutput__, MODES_ACTIVE_SERIAL );
    
    FANSPEEDS_ACTIVE_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( FANSPEEDS_ACTIVE_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FANSPEEDS_ACTIVE_SERIAL__AnalogSerialOutput__, FANSPEEDS_ACTIVE_SERIAL );
    
    NAME = new Crestron.Logos.SplusObjects.StringOutput( NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAME__AnalogSerialOutput__, NAME );
    
    ZONEERRORS = new InOutArray<StringOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        ZONEERRORS[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ZONEERRORS__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ZONEERRORS__AnalogSerialOutput__ + i, ZONEERRORS[i+1] );
    }
    
    ZONEWARNINGS = new InOutArray<StringOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        ZONEWARNINGS[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ZONEWARNINGS__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ZONEWARNINGS__AnalogSerialOutput__ + i, ZONEWARNINGS[i+1] );
    }
    
    SYSTEMNUMBER = new UShortParameter( SYSTEMNUMBER__Parameter__, this );
    m_ParameterList.Add( SYSTEMNUMBER__Parameter__, SYSTEMNUMBER );
    
    ZONENUMBER = new UShortParameter( ZONENUMBER__Parameter__, this );
    m_ParameterList.Add( ZONENUMBER__Parameter__, ZONENUMBER );
    
    AIRSTAGECONTROLENABLED = new UShortParameter( AIRSTAGECONTROLENABLED__Parameter__, this );
    m_ParameterList.Add( AIRSTAGECONTROLENABLED__Parameter__, AIRSTAGECONTROLENABLED );
    
    RADIANTSTAGECONTROLENABLED = new UShortParameter( RADIANTSTAGECONTROLENABLED__Parameter__, this );
    m_ParameterList.Add( RADIANTSTAGECONTROLENABLED__Parameter__, RADIANTSTAGECONTROLENABLED );
    
    MODECONTROLENABLED = new UShortParameter( MODECONTROLENABLED__Parameter__, this );
    m_ParameterList.Add( MODECONTROLENABLED__Parameter__, MODECONTROLENABLED );
    
    FANSPEEDCONTROLENABLED = new UShortParameter( FANSPEEDCONTROLENABLED__Parameter__, this );
    m_ParameterList.Add( FANSPEEDCONTROLENABLED__Parameter__, FANSPEEDCONTROLENABLED );
    
    
    MANUALPOLL.OnDigitalPush.Add( new InputChangeHandlerWrapper( MANUALPOLL_OnPush_0, false ) );
    SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETPOINT_UP_OnPush_1, false ) );
    SETPOINT_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SETPOINT_UP_OnRelease_2, false ) );
    SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETPOINT_DOWN_OnPush_3, false ) );
    SETPOINT_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SETPOINT_DOWN_OnRelease_4, false ) );
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_5, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_6, false ) );
    STAGES_AIR_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( STAGES_AIR_SET_OnPush_7, false ) );
    STAGES_RADIANT_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( STAGES_RADIANT_SET_OnPush_8, false ) );
    STAGES_COMBINED_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( STAGES_COMBINED_SET_OnPush_9, false ) );
    STAGES_VALUE_SET.OnAnalogChange.Add( new InputChangeHandlerWrapper( STAGES_VALUE_SET_OnChange_10, false ) );
    MODES_STOP_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_STOP_SET_OnPush_11, false ) );
    MODES_COOLING_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_COOLING_SET_OnPush_12, false ) );
    MODES_HEATING_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_HEATING_SET_OnPush_13, false ) );
    MODES_FAN_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_FAN_SET_OnPush_14, false ) );
    MODES_DRY_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_DRY_SET_OnPush_15, false ) );
    MODES_AUTO_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_AUTO_SET_OnPush_16, false ) );
    MODES_VALUE_SET.OnAnalogChange.Add( new InputChangeHandlerWrapper( MODES_VALUE_SET_OnChange_17, false ) );
    FANSPEEDS_AUTO_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_AUTO_SET_OnPush_18, false ) );
    FANSPEEDS_1_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_1_SET_OnPush_19, false ) );
    FANSPEEDS_2_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_2_SET_OnPush_20, false ) );
    FANSPEEDS_3_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_3_SET_OnPush_21, false ) );
    FANSPEEDS_4_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_4_SET_OnPush_22, false ) );
    FANSPEEDS_5_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_5_SET_OnPush_23, false ) );
    FANSPEEDS_6_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_6_SET_OnPush_24, false ) );
    FANSPEEDS_7_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_7_SET_OnPush_25, false ) );
    FANSPEEDS_VALUE_SET.OnAnalogChange.Add( new InputChangeHandlerWrapper( FANSPEEDS_VALUE_SET_OnChange_26, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYAIRZONEZONESIMPL  = new AirZone.Simpl.AirzoneZoneSimpl();
    
    
}

public UserModuleClass_AIRZONE_ZONE_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint MANUALPOLL__DigitalInput__ = 0;
const uint SETPOINT_UP__DigitalInput__ = 1;
const uint SETPOINT_DOWN__DigitalInput__ = 2;
const uint POWER_ON__DigitalInput__ = 3;
const uint POWER_OFF__DigitalInput__ = 4;
const uint STAGES_AIR_SET__DigitalInput__ = 5;
const uint STAGES_RADIANT_SET__DigitalInput__ = 6;
const uint STAGES_COMBINED_SET__DigitalInput__ = 7;
const uint MODES_STOP_SET__DigitalInput__ = 8;
const uint MODES_COOLING_SET__DigitalInput__ = 9;
const uint MODES_HEATING_SET__DigitalInput__ = 10;
const uint MODES_FAN_SET__DigitalInput__ = 11;
const uint MODES_DRY_SET__DigitalInput__ = 12;
const uint MODES_AUTO_SET__DigitalInput__ = 13;
const uint FANSPEEDS_AUTO_SET__DigitalInput__ = 14;
const uint FANSPEEDS_1_SET__DigitalInput__ = 15;
const uint FANSPEEDS_2_SET__DigitalInput__ = 16;
const uint FANSPEEDS_3_SET__DigitalInput__ = 17;
const uint FANSPEEDS_4_SET__DigitalInput__ = 18;
const uint FANSPEEDS_5_SET__DigitalInput__ = 19;
const uint FANSPEEDS_6_SET__DigitalInput__ = 20;
const uint FANSPEEDS_7_SET__DigitalInput__ = 21;
const uint STAGES_VALUE_SET__AnalogSerialInput__ = 0;
const uint MODES_VALUE_SET__AnalogSerialInput__ = 1;
const uint FANSPEEDS_VALUE_SET__AnalogSerialInput__ = 2;
const uint INITIALIZED__DigitalOutput__ = 0;
const uint POLLING__DigitalOutput__ = 1;
const uint HASZONEERRORS__DigitalOutput__ = 2;
const uint HASZONEWARNINGS__DigitalOutput__ = 3;
const uint UNIT_CELSIUS_ACTIVE__DigitalOutput__ = 4;
const uint UNIT_FAHRENHEIT_ACTIVE__DigitalOutput__ = 5;
const uint HUMIDITY_AVAILABLE__DigitalOutput__ = 6;
const uint SETPOINT_LOWERLIMIT_AVAILABLE__DigitalOutput__ = 7;
const uint SETPOINT_UPPERLIMIT_AVAILABLE__DigitalOutput__ = 8;
const uint POWERED_ON__DigitalOutput__ = 9;
const uint POWERED_OFF__DigitalOutput__ = 10;
const uint STAGES_AVAILABLE__DigitalOutput__ = 11;
const uint STAGES_CONTROLLABLE__DigitalOutput__ = 12;
const uint STAGES_AIR_AVAILABLE__DigitalOutput__ = 13;
const uint STAGES_RADIANT_AVAILABLE__DigitalOutput__ = 14;
const uint STAGES_COMBINED_AVAILABLE__DigitalOutput__ = 15;
const uint STAGES_AIR_ACTIVE__DigitalOutput__ = 16;
const uint STAGES_RADIANT_ACTIVE__DigitalOutput__ = 17;
const uint STAGES_COMBINED_ACTIVE__DigitalOutput__ = 18;
const uint MODES_AVAILABLE__DigitalOutput__ = 19;
const uint MODES_CONTROLLABLE__DigitalOutput__ = 20;
const uint MODES_STOP_AVAILABLE__DigitalOutput__ = 21;
const uint MODES_COOLING_AVAILABLE__DigitalOutput__ = 22;
const uint MODES_HEATING_AVAILABLE__DigitalOutput__ = 23;
const uint MODES_FAN_AVAILABLE__DigitalOutput__ = 24;
const uint MODES_DRY_AVAILABLE__DigitalOutput__ = 25;
const uint MODES_AUTO_AVAILABLE__DigitalOutput__ = 26;
const uint MODES_STOP_ACTIVE__DigitalOutput__ = 27;
const uint MODES_COOLING_ACTIVE__DigitalOutput__ = 28;
const uint MODES_HEATING_ACTIVE__DigitalOutput__ = 29;
const uint MODES_FAN_ACTIVE__DigitalOutput__ = 30;
const uint MODES_DRY_ACTIVE__DigitalOutput__ = 31;
const uint MODES_AUTO_ACTIVE__DigitalOutput__ = 32;
const uint FANSPEEDS_AVAILABLE__DigitalOutput__ = 33;
const uint FANSPEEDS_CONTROLLABLE__DigitalOutput__ = 34;
const uint FANSPEEDS_AUTO_AVAILABLE__DigitalOutput__ = 35;
const uint FANSPEEDS_1_AVAILABLE__DigitalOutput__ = 36;
const uint FANSPEEDS_2_AVAILABLE__DigitalOutput__ = 37;
const uint FANSPEEDS_3_AVAILABLE__DigitalOutput__ = 38;
const uint FANSPEEDS_4_AVAILABLE__DigitalOutput__ = 39;
const uint FANSPEEDS_5_AVAILABLE__DigitalOutput__ = 40;
const uint FANSPEEDS_6_AVAILABLE__DigitalOutput__ = 41;
const uint FANSPEEDS_7_AVAILABLE__DigitalOutput__ = 42;
const uint FANSPEEDS_AUTO_ACTIVE__DigitalOutput__ = 43;
const uint FANSPEEDS_1_ACTIVE__DigitalOutput__ = 44;
const uint FANSPEEDS_2_ACTIVE__DigitalOutput__ = 45;
const uint FANSPEEDS_3_ACTIVE__DigitalOutput__ = 46;
const uint FANSPEEDS_4_ACTIVE__DigitalOutput__ = 47;
const uint FANSPEEDS_5_ACTIVE__DigitalOutput__ = 48;
const uint FANSPEEDS_6_ACTIVE__DigitalOutput__ = 49;
const uint FANSPEEDS_7_ACTIVE__DigitalOutput__ = 50;
const uint TEMPERATURE_ANALOG__AnalogSerialOutput__ = 0;
const uint HUMIDITY_ANALOG__AnalogSerialOutput__ = 1;
const uint SETPOINT_ANALOG__AnalogSerialOutput__ = 2;
const uint SETPOINTLOWERLIMIT_ANALOG__AnalogSerialOutput__ = 3;
const uint SETPOINTUPPERLIMIT_ANALOG__AnalogSerialOutput__ = 4;
const uint STAGES_ACTIVE_ANALOG__AnalogSerialOutput__ = 5;
const uint MODES_ACTIVE_ANALOG__AnalogSerialOutput__ = 6;
const uint FANSPEEDS_ACTIVE_ANALOG__AnalogSerialOutput__ = 7;
const uint ZONEERRORSCOUNT__AnalogSerialOutput__ = 8;
const uint ZONEWARNINGSCOUNT__AnalogSerialOutput__ = 9;
const uint TEMPERATURE__AnalogSerialOutput__ = 10;
const uint HUMIDITY__AnalogSerialOutput__ = 11;
const uint SETPOINT__AnalogSerialOutput__ = 12;
const uint SETPOINTLOWERLIMIT__AnalogSerialOutput__ = 13;
const uint SETPOINTUPPERLIMIT__AnalogSerialOutput__ = 14;
const uint STAGES_ACTIVE_SERIAL__AnalogSerialOutput__ = 15;
const uint MODES_ACTIVE_SERIAL__AnalogSerialOutput__ = 16;
const uint FANSPEEDS_ACTIVE_SERIAL__AnalogSerialOutput__ = 17;
const uint NAME__AnalogSerialOutput__ = 18;
const uint ZONEERRORS__AnalogSerialOutput__ = 19;
const uint ZONEWARNINGS__AnalogSerialOutput__ = 39;
const uint SYSTEMNUMBER__Parameter__ = 10;
const uint ZONENUMBER__Parameter__ = 11;
const uint AIRSTAGECONTROLENABLED__Parameter__ = 12;
const uint RADIANTSTAGECONTROLENABLED__Parameter__ = 13;
const uint MODECONTROLENABLED__Parameter__ = 14;
const uint FANSPEEDCONTROLENABLED__Parameter__ = 15;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
