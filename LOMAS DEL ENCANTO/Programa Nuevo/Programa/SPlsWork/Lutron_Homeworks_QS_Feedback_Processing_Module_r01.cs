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

namespace UserModule_LUTRON_HOMEWORKS_QS_FEEDBACK_PROCESSING_MODULE_R01
{
    public class UserModuleClass_LUTRON_HOMEWORKS_QS_FEEDBACK_PROCESSING_MODULE_R01 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SHOW_TRACE_MSGS;
        Crestron.Logos.SplusObjects.BufferInput FROM_CORE_MODULE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ERROR;
        Crestron.Logos.SplusObjects.StringOutput MONITORING__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> INTEGRATION_ID__DOLLAR__;
        object FROM_CORE_MODULE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString TEMP__DOLLAR__;
                CrestronString TEMP2__DOLLAR__;
                TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
                TEMP2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
                
                ushort INT_ID = 0;
                ushort ERROR_ID = 0;
                
                
                __context__.SourceCodeLine = 177;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , FROM_CORE_MODULE__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 179;
                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0000" , FROM_CORE_MODULE__DOLLAR__ )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 181;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "QNET> " , FROM_CORE_MODULE__DOLLAR__ ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "\r\n" , FROM_CORE_MODULE__DOLLAR__ ) == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 183;
                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "QNET> " , FROM_CORE_MODULE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 184;
                    if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 185;
                        Trace( "QNET> REMOVED\r\n") ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 187;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FROM_CORE_MODULE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "\r\n" , FROM_CORE_MODULE__DOLLAR__ ) > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 189;
                    TEMP__DOLLAR__  .UpdateValue ( Functions.Gather ( "\r\n" , FROM_CORE_MODULE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 190;
                    if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 191;
                        Trace( "GATHERED={0}\r\n", TEMP__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 192;
                    while ( Functions.TestForTrue  ( ( Functions.Find( "QNET> " , TEMP__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 194;
                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "QNET> " , TEMP__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 195;
                        if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 196;
                            Trace( "QNET> REMOVED, TEMP$={0}\r\n", TEMP__DOLLAR__ ) ; 
                            }
                        
                        __context__.SourceCodeLine = 192;
                        } 
                    
                    __context__.SourceCodeLine = 198;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~MONITORING" , TEMP__DOLLAR__ ) == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 200;
                        MONITORING__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 202;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~SYSTEM" , TEMP__DOLLAR__ ) == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 205;
                            if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 206;
                                Trace( "SYSTEM RESPONSE RECEIVED, TEMP$={0}\r\n", TEMP__DOLLAR__ ) ; 
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 208;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~ERROR" , TEMP__DOLLAR__ ) == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 210;
                                ERROR_ID = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                                __context__.SourceCodeLine = 211;
                                Functions.Pulse ( 10, ERROR [ ERROR_ID] ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 213;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~" , TEMP__DOLLAR__ ) == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 215;
                                    INT_ID = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                                    __context__.SourceCodeLine = 216;
                                    if ( Functions.TestForTrue  ( ( IsSignalDefined( INTEGRATION_ID__DOLLAR__[ INT_ID ] ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 218;
                                        INTEGRATION_ID__DOLLAR__ [ INT_ID]  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 222;
                                        Print( "INTEGRATION ID {0:d} NOT DEFINED ON LUTRON FEEDBACK PROCESSOR\r\n", (short)INT_ID) ; 
                                        } 
                                    
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 187;
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
            
            __context__.SourceCodeLine = 270;
            Functions.ClearBuffer ( FROM_CORE_MODULE__DOLLAR__ ) ; 
            
            
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
        
        SHOW_TRACE_MSGS = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_TRACE_MSGS__DigitalInput__, this );
        m_DigitalInputList.Add( SHOW_TRACE_MSGS__DigitalInput__, SHOW_TRACE_MSGS );
        
        ERROR = new InOutArray<DigitalOutput>( 5, this );
        for( uint i = 0; i < 5; i++ )
        {
            ERROR[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ERROR__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( ERROR__DigitalOutput__ + i, ERROR[i+1] );
        }
        
        MONITORING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MONITORING__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MONITORING__DOLLAR____AnalogSerialOutput__, MONITORING__DOLLAR__ );
        
        INTEGRATION_ID__DOLLAR__ = new InOutArray<StringOutput>( 200, this );
        for( uint i = 0; i < 200; i++ )
        {
            INTEGRATION_ID__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( INTEGRATION_ID__DOLLAR____AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( INTEGRATION_ID__DOLLAR____AnalogSerialOutput__ + i, INTEGRATION_ID__DOLLAR__[i+1] );
        }
        
        FROM_CORE_MODULE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_CORE_MODULE__DOLLAR____AnalogSerialInput__, 1000, this );
        m_StringInputList.Add( FROM_CORE_MODULE__DOLLAR____AnalogSerialInput__, FROM_CORE_MODULE__DOLLAR__ );
        
        
        FROM_CORE_MODULE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_CORE_MODULE__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_LUTRON_HOMEWORKS_QS_FEEDBACK_PROCESSING_MODULE_R01 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SHOW_TRACE_MSGS__DigitalInput__ = 0;
    const uint FROM_CORE_MODULE__DOLLAR____AnalogSerialInput__ = 0;
    const uint ERROR__DigitalOutput__ = 0;
    const uint MONITORING__DOLLAR____AnalogSerialOutput__ = 0;
    const uint INTEGRATION_ID__DOLLAR____AnalogSerialOutput__ = 1;
    
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
