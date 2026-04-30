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

namespace UserModule_AIRZONE_SYSTEM_V1_0
{
    public class UserModuleClass_AIRZONE_SYSTEM_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput MANUALPOLL;
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
        Crestron.Logos.SplusObjects.AnalogInput MODES_VALUE_SET;
        Crestron.Logos.SplusObjects.AnalogInput FANSPEEDS_VALUE_SET;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput POLLING;
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
        Crestron.Logos.SplusObjects.AnalogOutput MODES_ACTIVE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput FANSPEEDS_ACTIVE_ANALOG;
        Crestron.Logos.SplusObjects.StringOutput MODES_ACTIVE_SERIAL;
        Crestron.Logos.SplusObjects.StringOutput FANSPEEDS_ACTIVE_SERIAL;
        UShortParameter SYSTEMNUMBERPARAM;
        UShortParameter SETPOINTMODEPARAM;
        AirZone.Simpl.AirzoneSystemSimpl MYAIRZONESYSTEMSIMPL;
        object MANUALPOLL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 56;
                MYAIRZONESYSTEMSIMPL . ManualPoll ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object MODES_STOP_SET_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 61;
            MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( 1 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object MODES_COOLING_SET_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 66;
        MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_HEATING_SET_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 71;
        MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_FAN_SET_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 76;
        MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_DRY_SET_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 81;
        MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_AUTO_SET_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MODES_VALUE_SET_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 91;
        MYAIRZONESYSTEMSIMPL . SetModus ( (ushort)( MODES_VALUE_SET  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_AUTO_SET_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 96;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_1_SET_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 101;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_2_SET_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 107;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_3_SET_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 113;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_4_SET_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 118;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_5_SET_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 123;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_6_SET_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 128;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_7_SET_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 134;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FANSPEEDS_VALUE_SET_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
        MYAIRZONESYSTEMSIMPL . SetFanspeed ( (ushort)( FANSPEEDS_VALUE_SET  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void ONINITIALIZEDCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, AirZone.Simpl.EventArguments.SimplUShortEventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 147;
        INITIALIZED  .Value = (ushort) ( E.Value ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONPOLLING ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, EventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 152;
        Functions.Pulse ( 10, POLLING ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONLOADED ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSystemLoadedEventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 157;
        MODES_AVAILABLE  .Value = (ushort) ( E.ModesAvailable ) ; 
        __context__.SourceCodeLine = 158;
        MODES_CONTROLLABLE  .Value = (ushort) ( E.ModeControllable ) ; 
        __context__.SourceCodeLine = 160;
        MODES_STOP_AVAILABLE  .Value = (ushort) ( E.ModeStopAvailable ) ; 
        __context__.SourceCodeLine = 161;
        MODES_COOLING_AVAILABLE  .Value = (ushort) ( E.ModeCoolingAvailable ) ; 
        __context__.SourceCodeLine = 162;
        MODES_HEATING_AVAILABLE  .Value = (ushort) ( E.ModeHeatingAvailable ) ; 
        __context__.SourceCodeLine = 163;
        MODES_FAN_AVAILABLE  .Value = (ushort) ( E.ModeFanAvailable ) ; 
        __context__.SourceCodeLine = 164;
        MODES_DRY_AVAILABLE  .Value = (ushort) ( E.ModeDryAvailable ) ; 
        __context__.SourceCodeLine = 165;
        MODES_AUTO_AVAILABLE  .Value = (ushort) ( E.ModeAutoAvailable ) ; 
        __context__.SourceCodeLine = 167;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 168;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 169;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 170;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 171;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 172;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 174;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 175;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        __context__.SourceCodeLine = 177;
        FANSPEEDS_AVAILABLE  .Value = (ushort) ( E.SpeedsAvailable ) ; 
        __context__.SourceCodeLine = 178;
        FANSPEEDS_CONTROLLABLE  .Value = (ushort) ( E.SpeedControllable ) ; 
        __context__.SourceCodeLine = 180;
        FANSPEEDS_AUTO_AVAILABLE  .Value = (ushort) ( E.SpeedAutoAvailable ) ; 
        __context__.SourceCodeLine = 181;
        FANSPEEDS_1_AVAILABLE  .Value = (ushort) ( E.SpeedOneAvailable ) ; 
        __context__.SourceCodeLine = 182;
        FANSPEEDS_2_AVAILABLE  .Value = (ushort) ( E.SpeedTwoAvailable ) ; 
        __context__.SourceCodeLine = 183;
        FANSPEEDS_3_AVAILABLE  .Value = (ushort) ( E.SpeedThreeAvailable ) ; 
        __context__.SourceCodeLine = 184;
        FANSPEEDS_4_AVAILABLE  .Value = (ushort) ( E.SpeedFourAvailable ) ; 
        __context__.SourceCodeLine = 185;
        FANSPEEDS_5_AVAILABLE  .Value = (ushort) ( E.SpeedFiveAvailable ) ; 
        __context__.SourceCodeLine = 186;
        FANSPEEDS_6_AVAILABLE  .Value = (ushort) ( E.SpeedSixAvailable ) ; 
        __context__.SourceCodeLine = 187;
        FANSPEEDS_7_AVAILABLE  .Value = (ushort) ( E.SpeedSevenAvailable ) ; 
        __context__.SourceCodeLine = 189;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 190;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 191;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 192;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 193;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 194;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 195;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 196;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 198;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 199;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONMODESCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, AirZone.Simpl.EventArguments.SimplModesEventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 204;
        MODES_AVAILABLE  .Value = (ushort) ( E.ModesAvailable ) ; 
        __context__.SourceCodeLine = 205;
        MODES_CONTROLLABLE  .Value = (ushort) ( E.ModeControllable ) ; 
        __context__.SourceCodeLine = 207;
        MODES_STOP_AVAILABLE  .Value = (ushort) ( E.ModeStopAvailable ) ; 
        __context__.SourceCodeLine = 208;
        MODES_COOLING_AVAILABLE  .Value = (ushort) ( E.ModeCoolingAvailable ) ; 
        __context__.SourceCodeLine = 209;
        MODES_HEATING_AVAILABLE  .Value = (ushort) ( E.ModeHeatingAvailable ) ; 
        __context__.SourceCodeLine = 210;
        MODES_FAN_AVAILABLE  .Value = (ushort) ( E.ModeFanAvailable ) ; 
        __context__.SourceCodeLine = 211;
        MODES_DRY_AVAILABLE  .Value = (ushort) ( E.ModeDryAvailable ) ; 
        __context__.SourceCodeLine = 212;
        MODES_AUTO_AVAILABLE  .Value = (ushort) ( E.ModeAutoAvailable ) ; 
        __context__.SourceCodeLine = 214;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 215;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 216;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 217;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 218;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 219;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 221;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 222;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONMODEACTIVECHANGED ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, AirZone.Simpl.EventArguments.SimplModeActiveEventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 227;
        MODES_STOP_ACTIVE  .Value = (ushort) ( E.ModeStopActive ) ; 
        __context__.SourceCodeLine = 228;
        MODES_COOLING_ACTIVE  .Value = (ushort) ( E.ModeCoolingActive ) ; 
        __context__.SourceCodeLine = 229;
        MODES_HEATING_ACTIVE  .Value = (ushort) ( E.ModeHeatingActive ) ; 
        __context__.SourceCodeLine = 230;
        MODES_FAN_ACTIVE  .Value = (ushort) ( E.ModeFanActive ) ; 
        __context__.SourceCodeLine = 231;
        MODES_DRY_ACTIVE  .Value = (ushort) ( E.ModeDryActive ) ; 
        __context__.SourceCodeLine = 232;
        MODES_AUTO_ACTIVE  .Value = (ushort) ( E.ModeAutoActive ) ; 
        __context__.SourceCodeLine = 234;
        MODES_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveModeAnalog ) ; 
        __context__.SourceCodeLine = 235;
        MODES_ACTIVE_SERIAL  .UpdateValue ( E . ActiveModeSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSPEEDSCHANGED ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSpeedsEventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 240;
        FANSPEEDS_AVAILABLE  .Value = (ushort) ( E.SpeedsAvailable ) ; 
        __context__.SourceCodeLine = 241;
        FANSPEEDS_CONTROLLABLE  .Value = (ushort) ( E.SpeedControllable ) ; 
        __context__.SourceCodeLine = 243;
        FANSPEEDS_AUTO_AVAILABLE  .Value = (ushort) ( E.SpeedAutoAvailable ) ; 
        __context__.SourceCodeLine = 244;
        FANSPEEDS_1_AVAILABLE  .Value = (ushort) ( E.SpeedOneAvailable ) ; 
        __context__.SourceCodeLine = 245;
        FANSPEEDS_2_AVAILABLE  .Value = (ushort) ( E.SpeedTwoAvailable ) ; 
        __context__.SourceCodeLine = 246;
        FANSPEEDS_3_AVAILABLE  .Value = (ushort) ( E.SpeedThreeAvailable ) ; 
        __context__.SourceCodeLine = 247;
        FANSPEEDS_4_AVAILABLE  .Value = (ushort) ( E.SpeedFourAvailable ) ; 
        __context__.SourceCodeLine = 248;
        FANSPEEDS_5_AVAILABLE  .Value = (ushort) ( E.SpeedFiveAvailable ) ; 
        __context__.SourceCodeLine = 249;
        FANSPEEDS_6_AVAILABLE  .Value = (ushort) ( E.SpeedSixAvailable ) ; 
        __context__.SourceCodeLine = 250;
        FANSPEEDS_7_AVAILABLE  .Value = (ushort) ( E.SpeedSevenAvailable ) ; 
        __context__.SourceCodeLine = 252;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 253;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 254;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 255;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 256;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 257;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 258;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 259;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 261;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 262;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ONSPEEDACTIVECHANGED ( object __sender__ /*AirZone.Simpl.AirzoneSystemSimpl SENDER */, AirZone.Simpl.EventArguments.SimplSpeedActiveEventArgs E ) 
    { 
    AirzoneSystemSimpl  SENDER  = (AirzoneSystemSimpl )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 267;
        FANSPEEDS_AUTO_ACTIVE  .Value = (ushort) ( E.SpeedAutoActive ) ; 
        __context__.SourceCodeLine = 268;
        FANSPEEDS_1_ACTIVE  .Value = (ushort) ( E.SpeedOneActive ) ; 
        __context__.SourceCodeLine = 269;
        FANSPEEDS_2_ACTIVE  .Value = (ushort) ( E.SpeedTwoActive ) ; 
        __context__.SourceCodeLine = 270;
        FANSPEEDS_3_ACTIVE  .Value = (ushort) ( E.SpeedThreeActive ) ; 
        __context__.SourceCodeLine = 271;
        FANSPEEDS_4_ACTIVE  .Value = (ushort) ( E.SpeedFourActive ) ; 
        __context__.SourceCodeLine = 272;
        FANSPEEDS_5_ACTIVE  .Value = (ushort) ( E.SpeedFiveActive ) ; 
        __context__.SourceCodeLine = 273;
        FANSPEEDS_6_ACTIVE  .Value = (ushort) ( E.SpeedSixActive ) ; 
        __context__.SourceCodeLine = 274;
        FANSPEEDS_7_ACTIVE  .Value = (ushort) ( E.SpeedSevenActive ) ; 
        __context__.SourceCodeLine = 276;
        FANSPEEDS_ACTIVE_ANALOG  .Value = (ushort) ( E.ActiveSpeedAnalog ) ; 
        __context__.SourceCodeLine = 277;
        FANSPEEDS_ACTIVE_SERIAL  .UpdateValue ( E . ActiveSpeedSerial  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 285;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 287;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONINITIALIZEDCHANGED , ONINITIALIZEDCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnInitializedChanged  += ONINITIALIZEDCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 288;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONPOLLING , ONPOLLING ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnPolling  += ONPOLLING; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 289;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONLOADED , ONLOADED ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnLoaded  += ONLOADED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 290;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONMODESCHANGED , ONMODESCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnModesChanged  += ONMODESCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 291;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONMODEACTIVECHANGED , ONMODEACTIVECHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnModeActiveChanged  += ONMODEACTIVECHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 292;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONSPEEDSCHANGED , ONSPEEDSCHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnSpeedsChanged  += ONSPEEDSCHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 293;
        // RegisterEvent( MYAIRZONESYSTEMSIMPL , ONSPEEDACTIVECHANGED , ONSPEEDACTIVECHANGED ) 
        try { g_criticalSection.Enter(); MYAIRZONESYSTEMSIMPL .OnSpeedActiveChanged  += ONSPEEDACTIVECHANGED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 296;
        MYAIRZONESYSTEMSIMPL . Initialize ( (ushort)( SYSTEMNUMBERPARAM  .Value ), (ushort)( SETPOINTMODEPARAM  .Value )) ; 
        
        
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
    
    MODES_VALUE_SET = new Crestron.Logos.SplusObjects.AnalogInput( MODES_VALUE_SET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MODES_VALUE_SET__AnalogSerialInput__, MODES_VALUE_SET );
    
    FANSPEEDS_VALUE_SET = new Crestron.Logos.SplusObjects.AnalogInput( FANSPEEDS_VALUE_SET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FANSPEEDS_VALUE_SET__AnalogSerialInput__, FANSPEEDS_VALUE_SET );
    
    MODES_ACTIVE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( MODES_ACTIVE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MODES_ACTIVE_ANALOG__AnalogSerialOutput__, MODES_ACTIVE_ANALOG );
    
    FANSPEEDS_ACTIVE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( FANSPEEDS_ACTIVE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FANSPEEDS_ACTIVE_ANALOG__AnalogSerialOutput__, FANSPEEDS_ACTIVE_ANALOG );
    
    MODES_ACTIVE_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( MODES_ACTIVE_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MODES_ACTIVE_SERIAL__AnalogSerialOutput__, MODES_ACTIVE_SERIAL );
    
    FANSPEEDS_ACTIVE_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( FANSPEEDS_ACTIVE_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FANSPEEDS_ACTIVE_SERIAL__AnalogSerialOutput__, FANSPEEDS_ACTIVE_SERIAL );
    
    SYSTEMNUMBERPARAM = new UShortParameter( SYSTEMNUMBERPARAM__Parameter__, this );
    m_ParameterList.Add( SYSTEMNUMBERPARAM__Parameter__, SYSTEMNUMBERPARAM );
    
    SETPOINTMODEPARAM = new UShortParameter( SETPOINTMODEPARAM__Parameter__, this );
    m_ParameterList.Add( SETPOINTMODEPARAM__Parameter__, SETPOINTMODEPARAM );
    
    
    MANUALPOLL.OnDigitalPush.Add( new InputChangeHandlerWrapper( MANUALPOLL_OnPush_0, false ) );
    MODES_STOP_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_STOP_SET_OnPush_1, false ) );
    MODES_COOLING_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_COOLING_SET_OnPush_2, false ) );
    MODES_HEATING_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_HEATING_SET_OnPush_3, false ) );
    MODES_FAN_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_FAN_SET_OnPush_4, false ) );
    MODES_DRY_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_DRY_SET_OnPush_5, false ) );
    MODES_AUTO_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( MODES_AUTO_SET_OnPush_6, false ) );
    MODES_VALUE_SET.OnAnalogChange.Add( new InputChangeHandlerWrapper( MODES_VALUE_SET_OnChange_7, false ) );
    FANSPEEDS_AUTO_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_AUTO_SET_OnPush_8, false ) );
    FANSPEEDS_1_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_1_SET_OnPush_9, false ) );
    FANSPEEDS_2_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_2_SET_OnPush_10, false ) );
    FANSPEEDS_3_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_3_SET_OnPush_11, false ) );
    FANSPEEDS_4_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_4_SET_OnPush_12, false ) );
    FANSPEEDS_5_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_5_SET_OnPush_13, false ) );
    FANSPEEDS_6_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_6_SET_OnPush_14, false ) );
    FANSPEEDS_7_SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( FANSPEEDS_7_SET_OnPush_15, false ) );
    FANSPEEDS_VALUE_SET.OnAnalogChange.Add( new InputChangeHandlerWrapper( FANSPEEDS_VALUE_SET_OnChange_16, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYAIRZONESYSTEMSIMPL  = new AirZone.Simpl.AirzoneSystemSimpl();
    
    
}

public UserModuleClass_AIRZONE_SYSTEM_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint MANUALPOLL__DigitalInput__ = 0;
const uint MODES_STOP_SET__DigitalInput__ = 1;
const uint MODES_COOLING_SET__DigitalInput__ = 2;
const uint MODES_HEATING_SET__DigitalInput__ = 3;
const uint MODES_FAN_SET__DigitalInput__ = 4;
const uint MODES_DRY_SET__DigitalInput__ = 5;
const uint MODES_AUTO_SET__DigitalInput__ = 6;
const uint FANSPEEDS_AUTO_SET__DigitalInput__ = 7;
const uint FANSPEEDS_1_SET__DigitalInput__ = 8;
const uint FANSPEEDS_2_SET__DigitalInput__ = 9;
const uint FANSPEEDS_3_SET__DigitalInput__ = 10;
const uint FANSPEEDS_4_SET__DigitalInput__ = 11;
const uint FANSPEEDS_5_SET__DigitalInput__ = 12;
const uint FANSPEEDS_6_SET__DigitalInput__ = 13;
const uint FANSPEEDS_7_SET__DigitalInput__ = 14;
const uint MODES_VALUE_SET__AnalogSerialInput__ = 0;
const uint FANSPEEDS_VALUE_SET__AnalogSerialInput__ = 1;
const uint INITIALIZED__DigitalOutput__ = 0;
const uint POLLING__DigitalOutput__ = 1;
const uint MODES_AVAILABLE__DigitalOutput__ = 2;
const uint MODES_CONTROLLABLE__DigitalOutput__ = 3;
const uint MODES_STOP_AVAILABLE__DigitalOutput__ = 4;
const uint MODES_COOLING_AVAILABLE__DigitalOutput__ = 5;
const uint MODES_HEATING_AVAILABLE__DigitalOutput__ = 6;
const uint MODES_FAN_AVAILABLE__DigitalOutput__ = 7;
const uint MODES_DRY_AVAILABLE__DigitalOutput__ = 8;
const uint MODES_AUTO_AVAILABLE__DigitalOutput__ = 9;
const uint MODES_STOP_ACTIVE__DigitalOutput__ = 10;
const uint MODES_COOLING_ACTIVE__DigitalOutput__ = 11;
const uint MODES_HEATING_ACTIVE__DigitalOutput__ = 12;
const uint MODES_FAN_ACTIVE__DigitalOutput__ = 13;
const uint MODES_DRY_ACTIVE__DigitalOutput__ = 14;
const uint MODES_AUTO_ACTIVE__DigitalOutput__ = 15;
const uint FANSPEEDS_AVAILABLE__DigitalOutput__ = 16;
const uint FANSPEEDS_CONTROLLABLE__DigitalOutput__ = 17;
const uint FANSPEEDS_AUTO_AVAILABLE__DigitalOutput__ = 18;
const uint FANSPEEDS_1_AVAILABLE__DigitalOutput__ = 19;
const uint FANSPEEDS_2_AVAILABLE__DigitalOutput__ = 20;
const uint FANSPEEDS_3_AVAILABLE__DigitalOutput__ = 21;
const uint FANSPEEDS_4_AVAILABLE__DigitalOutput__ = 22;
const uint FANSPEEDS_5_AVAILABLE__DigitalOutput__ = 23;
const uint FANSPEEDS_6_AVAILABLE__DigitalOutput__ = 24;
const uint FANSPEEDS_7_AVAILABLE__DigitalOutput__ = 25;
const uint FANSPEEDS_AUTO_ACTIVE__DigitalOutput__ = 26;
const uint FANSPEEDS_1_ACTIVE__DigitalOutput__ = 27;
const uint FANSPEEDS_2_ACTIVE__DigitalOutput__ = 28;
const uint FANSPEEDS_3_ACTIVE__DigitalOutput__ = 29;
const uint FANSPEEDS_4_ACTIVE__DigitalOutput__ = 30;
const uint FANSPEEDS_5_ACTIVE__DigitalOutput__ = 31;
const uint FANSPEEDS_6_ACTIVE__DigitalOutput__ = 32;
const uint FANSPEEDS_7_ACTIVE__DigitalOutput__ = 33;
const uint MODES_ACTIVE_ANALOG__AnalogSerialOutput__ = 0;
const uint FANSPEEDS_ACTIVE_ANALOG__AnalogSerialOutput__ = 1;
const uint MODES_ACTIVE_SERIAL__AnalogSerialOutput__ = 2;
const uint FANSPEEDS_ACTIVE_SERIAL__AnalogSerialOutput__ = 3;
const uint SYSTEMNUMBERPARAM__Parameter__ = 10;
const uint SETPOINTMODEPARAM__Parameter__ = 11;

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
