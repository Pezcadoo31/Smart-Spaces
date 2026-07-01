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

namespace CrestronModule_HD_CHANNEL_DECODER
{
    public class CrestronModuleClass_HD_CHANNEL_DECODER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        Crestron.Logos.SplusObjects.StringInput CHANNEL_STRING;
        Crestron.Logos.SplusObjects.DigitalOutput KEY0;
        Crestron.Logos.SplusObjects.DigitalOutput KEY1;
        Crestron.Logos.SplusObjects.DigitalOutput KEY2;
        Crestron.Logos.SplusObjects.DigitalOutput KEY3;
        Crestron.Logos.SplusObjects.DigitalOutput KEY4;
        Crestron.Logos.SplusObjects.DigitalOutput KEY5;
        Crestron.Logos.SplusObjects.DigitalOutput KEY6;
        Crestron.Logos.SplusObjects.DigitalOutput KEY7;
        Crestron.Logos.SplusObjects.DigitalOutput KEY8;
        Crestron.Logos.SplusObjects.DigitalOutput KEY9;
        Crestron.Logos.SplusObjects.DigitalOutput KEYDASH;
        Crestron.Logos.SplusObjects.DigitalOutput KEYENTER;
        Crestron.Logos.SplusObjects.AnalogInput KEY_PULSE_TIME;
        Crestron.Logos.SplusObjects.AnalogInput KEY_DELAY_TIME;
        Crestron.Logos.SplusObjects.AnalogInput MAX_CHANNEL_LENGTH;
        Crestron.Logos.SplusObjects.AnalogInput LEADING_0;
        Crestron.Logos.SplusObjects.AnalogInput TRAILING_ENTER;
        object SEND_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                CrestronString TEMP_STRING;
                TEMP_STRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
                
                
                __context__.SourceCodeLine = 175;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( CHANNEL_STRING ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 175;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 176;
                TEMP_STRING  .UpdateValue ( CHANNEL_STRING  ) ; 
                __context__.SourceCodeLine = 178;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.SENDING == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 180;
                    _SplusNVRAM.SENDING = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 182;
                    if ( Functions.TestForTrue  ( ( (Functions.BoolToInt (LEADING_0  .UshortValue == 1) & Functions.BoolToInt (Functions.Length( TEMP_STRING ) != MAX_CHANNEL_LENGTH  .UshortValue)))  ) ) 
                        { 
                        __context__.SourceCodeLine = 184;
                        Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY0 ) ; 
                        __context__.SourceCodeLine = 185;
                        Functions.Delay (  (int) ( KEY_DELAY_TIME  .UshortValue ) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 188;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( TEMP_STRING ); 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 190;
                        
                            {
                            int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( TEMP_STRING , (int)( I ) ));
                            
                                { 
                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 45) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 192;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEYDASH ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 48) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 193;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY0 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 49) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 194;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY1 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 50) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 195;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY2 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 51) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 196;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY3 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 52) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 197;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY4 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 53) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 198;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY5 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 54) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 199;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY6 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 55) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 200;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY7 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 56) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 201;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY8 ) ; 
                                    }
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 57) ) ) ) 
                                    {
                                    __context__.SourceCodeLine = 202;
                                    Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEY9 ) ; 
                                    }
                                
                                } 
                                
                            }
                            
                        
                        __context__.SourceCodeLine = 204;
                        Functions.Delay (  (int) ( KEY_DELAY_TIME  .UshortValue ) ) ; 
                        __context__.SourceCodeLine = 188;
                        } 
                    
                    __context__.SourceCodeLine = 206;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TRAILING_ENTER  .UshortValue != 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 206;
                        Functions.Pulse ( KEY_PULSE_TIME  .UshortValue, KEYENTER ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 208;
                _SplusNVRAM.SENDING = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
        m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
        
        KEY0 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY0__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY0__DigitalOutput__, KEY0 );
        
        KEY1 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY1__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY1__DigitalOutput__, KEY1 );
        
        KEY2 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY2__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY2__DigitalOutput__, KEY2 );
        
        KEY3 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY3__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY3__DigitalOutput__, KEY3 );
        
        KEY4 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY4__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY4__DigitalOutput__, KEY4 );
        
        KEY5 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY5__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY5__DigitalOutput__, KEY5 );
        
        KEY6 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY6__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY6__DigitalOutput__, KEY6 );
        
        KEY7 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY7__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY7__DigitalOutput__, KEY7 );
        
        KEY8 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY8__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY8__DigitalOutput__, KEY8 );
        
        KEY9 = new Crestron.Logos.SplusObjects.DigitalOutput( KEY9__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEY9__DigitalOutput__, KEY9 );
        
        KEYDASH = new Crestron.Logos.SplusObjects.DigitalOutput( KEYDASH__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEYDASH__DigitalOutput__, KEYDASH );
        
        KEYENTER = new Crestron.Logos.SplusObjects.DigitalOutput( KEYENTER__DigitalOutput__, this );
        m_DigitalOutputList.Add( KEYENTER__DigitalOutput__, KEYENTER );
        
        KEY_PULSE_TIME = new Crestron.Logos.SplusObjects.AnalogInput( KEY_PULSE_TIME__AnalogSerialInput__, this );
        m_AnalogInputList.Add( KEY_PULSE_TIME__AnalogSerialInput__, KEY_PULSE_TIME );
        
        KEY_DELAY_TIME = new Crestron.Logos.SplusObjects.AnalogInput( KEY_DELAY_TIME__AnalogSerialInput__, this );
        m_AnalogInputList.Add( KEY_DELAY_TIME__AnalogSerialInput__, KEY_DELAY_TIME );
        
        MAX_CHANNEL_LENGTH = new Crestron.Logos.SplusObjects.AnalogInput( MAX_CHANNEL_LENGTH__AnalogSerialInput__, this );
        m_AnalogInputList.Add( MAX_CHANNEL_LENGTH__AnalogSerialInput__, MAX_CHANNEL_LENGTH );
        
        LEADING_0 = new Crestron.Logos.SplusObjects.AnalogInput( LEADING_0__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LEADING_0__AnalogSerialInput__, LEADING_0 );
        
        TRAILING_ENTER = new Crestron.Logos.SplusObjects.AnalogInput( TRAILING_ENTER__AnalogSerialInput__, this );
        m_AnalogInputList.Add( TRAILING_ENTER__AnalogSerialInput__, TRAILING_ENTER );
        
        CHANNEL_STRING = new Crestron.Logos.SplusObjects.StringInput( CHANNEL_STRING__AnalogSerialInput__, 6, this );
        m_StringInputList.Add( CHANNEL_STRING__AnalogSerialInput__, CHANNEL_STRING );
        
        
        SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_HD_CHANNEL_DECODER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SEND__DigitalInput__ = 0;
    const uint CHANNEL_STRING__AnalogSerialInput__ = 0;
    const uint KEY0__DigitalOutput__ = 0;
    const uint KEY1__DigitalOutput__ = 1;
    const uint KEY2__DigitalOutput__ = 2;
    const uint KEY3__DigitalOutput__ = 3;
    const uint KEY4__DigitalOutput__ = 4;
    const uint KEY5__DigitalOutput__ = 5;
    const uint KEY6__DigitalOutput__ = 6;
    const uint KEY7__DigitalOutput__ = 7;
    const uint KEY8__DigitalOutput__ = 8;
    const uint KEY9__DigitalOutput__ = 9;
    const uint KEYDASH__DigitalOutput__ = 10;
    const uint KEYENTER__DigitalOutput__ = 11;
    const uint KEY_PULSE_TIME__AnalogSerialInput__ = 1;
    const uint KEY_DELAY_TIME__AnalogSerialInput__ = 2;
    const uint MAX_CHANNEL_LENGTH__AnalogSerialInput__ = 3;
    const uint LEADING_0__AnalogSerialInput__ = 4;
    const uint TRAILING_ENTER__AnalogSerialInput__ = 5;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        [SplusStructAttribute(0, false, true)]
            public ushort SENDING = 0;
            
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
