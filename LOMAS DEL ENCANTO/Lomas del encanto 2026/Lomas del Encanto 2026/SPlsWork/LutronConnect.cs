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

namespace UserModule_LUTRONCONNECT
{
    public class UserModuleClass_LUTRONCONNECT : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput CONNECTF;
        Crestron.Logos.SplusObjects.AnalogInput STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput CONNECT;
        private void RETRIGGER (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 130;
            Functions.Delay (  (int) ( 400 ) ) ; 
            __context__.SourceCodeLine = 131;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECTF  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 133;
                CONNECT  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 134;
                Functions.Delay (  (int) ( 300 ) ) ; 
                __context__.SourceCodeLine = 135;
                CONNECT  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        object CONNECTF_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 169;
                CONNECT  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CONNECTF_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 176;
            CONNECT  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 177;
            Functions.Delay (  (int) ( 300 ) ) ; 
            __context__.SourceCodeLine = 178;
            CONNECT  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 179;
            RETRIGGER (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 233;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 234;
        CONNECT  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 235;
        RETRIGGER (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    
    CONNECTF = new Crestron.Logos.SplusObjects.DigitalInput( CONNECTF__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECTF__DigitalInput__, CONNECTF );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalOutput( CONNECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONNECT__DigitalOutput__, CONNECT );
    
    STATUS = new Crestron.Logos.SplusObjects.AnalogInput( STATUS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( STATUS__AnalogSerialInput__, STATUS );
    
    
    CONNECTF.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECTF_OnPush_0, false ) );
    CONNECTF.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CONNECTF_OnRelease_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_LUTRONCONNECT ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CONNECTF__DigitalInput__ = 0;
const uint STATUS__AnalogSerialInput__ = 0;
const uint CONNECT__DigitalOutput__ = 0;

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
