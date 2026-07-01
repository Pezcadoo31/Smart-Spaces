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

namespace UserModule_SRCID_TRANSMIT
{
    public class UserModuleClass_SRCID_TRANSMIT : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ROOM_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SRC_SELECTED_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ID_FOR_TYPE;
        InOutArray<UShortParameter> SRC_TYPE;
        InOutArray<UShortParameter> SRC_CONTROL_ID;
        object SRC_SELECTED_FB_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort SOURCESEL = 0;
                ushort SOURCEID = 0;
                ushort SOURCETYPE = 0;
                
                
                __context__.SourceCodeLine = 84;
                SOURCESEL = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 86;
                SOURCEID = (ushort) ( SRC_CONTROL_ID[ SOURCESEL ] .Value ) ; 
                __context__.SourceCodeLine = 87;
                SOURCETYPE = (ushort) ( SRC_TYPE[ SOURCESEL ] .Value ) ; 
                __context__.SourceCodeLine = 88;
                ID_FOR_TYPE [ SOURCETYPE]  .Value = (ushort) ( SOURCEID ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ROOM_OFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 95;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)30; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 97;
                ID_FOR_TYPE [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 95;
                } 
            
            
            
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
        
        __context__.SourceCodeLine = 127;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ROOM_OFF = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_OFF__DigitalInput__, ROOM_OFF );
    
    SRC_SELECTED_FB = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SRC_SELECTED_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SRC_SELECTED_FB__DigitalInput__ + i, SRC_SELECTED_FB__DigitalInput__, this );
        m_DigitalInputList.Add( SRC_SELECTED_FB__DigitalInput__ + i, SRC_SELECTED_FB[i+1] );
    }
    
    ID_FOR_TYPE = new InOutArray<AnalogOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        ID_FOR_TYPE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ID_FOR_TYPE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ID_FOR_TYPE__AnalogSerialOutput__ + i, ID_FOR_TYPE[i+1] );
    }
    
    SRC_TYPE = new InOutArray<UShortParameter>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SRC_TYPE[i+1] = new UShortParameter( SRC_TYPE__Parameter__ + i, SRC_TYPE__Parameter__, this );
        m_ParameterList.Add( SRC_TYPE__Parameter__ + i, SRC_TYPE[i+1] );
    }
    
    SRC_CONTROL_ID = new InOutArray<UShortParameter>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SRC_CONTROL_ID[i+1] = new UShortParameter( SRC_CONTROL_ID__Parameter__ + i, SRC_CONTROL_ID__Parameter__, this );
        m_ParameterList.Add( SRC_CONTROL_ID__Parameter__ + i, SRC_CONTROL_ID[i+1] );
    }
    
    
    for( uint i = 0; i < 24; i++ )
        SRC_SELECTED_FB[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SRC_SELECTED_FB_OnPush_0, false ) );
        
    ROOM_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_OFF_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SRCID_TRANSMIT ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOM_OFF__DigitalInput__ = 0;
const uint SRC_SELECTED_FB__DigitalInput__ = 1;
const uint ID_FOR_TYPE__AnalogSerialOutput__ = 0;
const uint SRC_TYPE__Parameter__ = 10;
const uint SRC_CONTROL_ID__Parameter__ = 34;

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
