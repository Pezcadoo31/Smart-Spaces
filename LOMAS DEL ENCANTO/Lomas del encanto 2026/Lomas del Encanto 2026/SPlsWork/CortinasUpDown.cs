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

namespace UserModule_CORTINASUPDOWN
{
    public class UserModuleClass_CORTINASUPDOWN : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput _UP;
        Crestron.Logos.SplusObjects.DigitalInput _DOWN;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLE;
        Crestron.Logos.SplusObjects.AnalogInput MAXTIME;
        Crestron.Logos.SplusObjects.DigitalOutput UP_;
        Crestron.Logos.SplusObjects.DigitalOutput DOWN_;
        Crestron.Logos.SplusObjects.DigitalOutput STOP_;
        Crestron.Logos.SplusObjects.AnalogOutput MAXTIMEFB;
        ushort MOVING = 0;
        ushort DIR = 0;
        object _UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 169;
                MAXTIMEFB  .Value = (ushort) ( MAXTIME  .UshortValue ) ; 
                __context__.SourceCodeLine = 170;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVING == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 172;
                    Functions.Pulse ( 50, UP_ ) ; 
                    __context__.SourceCodeLine = 173;
                    DIR = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 174;
                    MOVING = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 175;
                    Functions.Delay (  (int) ( MAXTIME  .UshortValue ) ) ; 
                    __context__.SourceCodeLine = 176;
                    MOVING = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 178;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVING == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 180;
                        Functions.Pulse ( 50, STOP_ ) ; 
                        __context__.SourceCodeLine = 181;
                        MOVING = (ushort) ( 0 ) ; 
                        } 
                    
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object _DOWN_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 187;
            MAXTIMEFB  .Value = (ushort) ( MAXTIME  .UshortValue ) ; 
            __context__.SourceCodeLine = 188;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVING == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 190;
                Functions.Pulse ( 50, DOWN_ ) ; 
                __context__.SourceCodeLine = 191;
                DIR = (ushort) ( 3 ) ; 
                __context__.SourceCodeLine = 192;
                MOVING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 193;
                Functions.Delay (  (int) ( MAXTIME  .UshortValue ) ) ; 
                __context__.SourceCodeLine = 194;
                MOVING = (ushort) ( 0 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 196;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVING == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 198;
                    Functions.Pulse ( 50, STOP_ ) ; 
                    __context__.SourceCodeLine = 199;
                    MOVING = (ushort) ( 0 ) ; 
                    } 
                
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    
    _UP = new Crestron.Logos.SplusObjects.DigitalInput( _UP__DigitalInput__, this );
    m_DigitalInputList.Add( _UP__DigitalInput__, _UP );
    
    _DOWN = new Crestron.Logos.SplusObjects.DigitalInput( _DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( _DOWN__DigitalInput__, _DOWN );
    
    TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLE__DigitalInput__, TOGGLE );
    
    UP_ = new Crestron.Logos.SplusObjects.DigitalOutput( UP___DigitalOutput__, this );
    m_DigitalOutputList.Add( UP___DigitalOutput__, UP_ );
    
    DOWN_ = new Crestron.Logos.SplusObjects.DigitalOutput( DOWN___DigitalOutput__, this );
    m_DigitalOutputList.Add( DOWN___DigitalOutput__, DOWN_ );
    
    STOP_ = new Crestron.Logos.SplusObjects.DigitalOutput( STOP___DigitalOutput__, this );
    m_DigitalOutputList.Add( STOP___DigitalOutput__, STOP_ );
    
    MAXTIME = new Crestron.Logos.SplusObjects.AnalogInput( MAXTIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAXTIME__AnalogSerialInput__, MAXTIME );
    
    MAXTIMEFB = new Crestron.Logos.SplusObjects.AnalogOutput( MAXTIMEFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAXTIMEFB__AnalogSerialOutput__, MAXTIMEFB );
    
    
    _UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( _UP_OnPush_0, false ) );
    _DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( _DOWN_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CORTINASUPDOWN ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint _UP__DigitalInput__ = 0;
const uint _DOWN__DigitalInput__ = 1;
const uint TOGGLE__DigitalInput__ = 2;
const uint MAXTIME__AnalogSerialInput__ = 0;
const uint UP___DigitalOutput__ = 0;
const uint DOWN___DigitalOutput__ = 1;
const uint STOP___DigitalOutput__ = 2;
const uint MAXTIMEFB__AnalogSerialOutput__ = 0;

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
