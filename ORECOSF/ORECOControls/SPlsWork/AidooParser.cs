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

namespace UserModule_AIDOOPARSER
{
    public class UserModuleClass_AIDOOPARSER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.StringOutput TEMPERATURE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput TEMP_VALUE;
        Crestron.Logos.SplusObjects.DigitalOutput IS_ON_FB;
        CrestronString BUFFER__DOLLAR__;
        private ushort ISWHITESPACE (  SplusExecutionContext __context__, CrestronString CH ) 
            { 
            
            __context__.SourceCodeLine = 58;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == " "))  ) ) 
                {
                __context__.SourceCodeLine = 59;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 60;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == "\u0009"))  ) ) 
                {
                __context__.SourceCodeLine = 61;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 62;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == "\u000A"))  ) ) 
                {
                __context__.SourceCodeLine = 63;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 64;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == "\u000D"))  ) ) 
                {
                __context__.SourceCodeLine = 65;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 66;
            return (ushort)( 0) ; 
            
            }
            
        private ushort ISDELIMITER (  SplusExecutionContext __context__, CrestronString CH ) 
            { 
            
            __context__.SourceCodeLine = 72;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == ","))  ) ) 
                {
                __context__.SourceCodeLine = 73;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 74;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == "}"))  ) ) 
                {
                __context__.SourceCodeLine = 75;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 76;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CH == "]"))  ) ) 
                {
                __context__.SourceCodeLine = 77;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 78;
            return (ushort)( 0) ; 
            
            }
            
        private ushort FINDFIELDSTART (  SplusExecutionContext __context__, CrestronString JSON , CrestronString FIELDNAME ) 
            { 
            ushort POS = 0;
            
            CrestronString SEARCHKEY;
            SEARCHKEY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 87;
            SEARCHKEY  .UpdateValue ( "\"" + FIELDNAME + "\":"  ) ; 
            __context__.SourceCodeLine = 89;
            POS = (ushort) ( Functions.Find( SEARCHKEY , JSON ) ) ; 
            __context__.SourceCodeLine = 90;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POS == 0))  ) ) 
                {
                __context__.SourceCodeLine = 91;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 93;
            POS = (ushort) ( (POS + Functions.Length( SEARCHKEY )) ) ; 
            __context__.SourceCodeLine = 94;
            return (ushort)( POS) ; 
            
            }
            
        private CrestronString EXTRACTVALUE (  SplusExecutionContext __context__, CrestronString JSON , ushort STARTPOS ) 
            { 
            CrestronString RESULT;
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            CrestronString CH;
            CH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            ushort I = 0;
            
            ushort JSONLEN = 0;
            
            
            __context__.SourceCodeLine = 105;
            RESULT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 106;
            JSONLEN = (ushort) ( Functions.Length( JSON ) ) ; 
            __context__.SourceCodeLine = 108;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( STARTPOS ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)JSONLEN; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 110;
                CH  .UpdateValue ( Functions.Mid ( JSON ,  (int) ( I ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 112;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISDELIMITER( __context__ , CH ) == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 113;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISWHITESPACE( __context__ , CH ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 116;
                    RESULT  .UpdateValue ( RESULT + CH  ) ; 
                    }
                
                __context__.SourceCodeLine = 108;
                } 
            
            __context__.SourceCodeLine = 119;
            return ( RESULT ) ; 
            
            }
            
        private void PROCESSCOMPLETEJSON (  SplusExecutionContext __context__ ) 
            { 
            ushort POSON = 0;
            
            ushort POSTEMP = 0;
            
            CrestronString VALUEON;
            VALUEON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            CrestronString VALUETEMP;
            VALUETEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            ushort TEMPINT = 0;
            
            ushort TEMPFRAC = 0;
            
            ushort DOTPOS = 0;
            
            CrestronString INTPART;
            INTPART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString FRACPART;
            FRACPART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 136;
            POSON = (ushort) ( FINDFIELDSTART( __context__ , BUFFER__DOLLAR__ , "on" ) ) ; 
            __context__.SourceCodeLine = 137;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POSON == 0))  ) ) 
                {
                __context__.SourceCodeLine = 138;
                return ; 
                }
            
            __context__.SourceCodeLine = 140;
            VALUEON  .UpdateValue ( EXTRACTVALUE (  __context__ , BUFFER__DOLLAR__, (ushort)( POSON ))  ) ; 
            __context__.SourceCodeLine = 143;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUEON == "1"))  ) ) 
                { 
                __context__.SourceCodeLine = 145;
                IS_ON_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 149;
                IS_ON_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 150;
                TEMPERATURE__DOLLAR__  .UpdateValue ( "-- \u00B0C"  ) ; 
                __context__.SourceCodeLine = 151;
                TEMP_VALUE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 152;
                return ; 
                } 
            
            __context__.SourceCodeLine = 156;
            POSTEMP = (ushort) ( FINDFIELDSTART( __context__ , BUFFER__DOLLAR__ , "roomTemp" ) ) ; 
            __context__.SourceCodeLine = 157;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POSTEMP == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 159;
                TEMPERATURE__DOLLAR__  .UpdateValue ( "-- \u00B0C"  ) ; 
                __context__.SourceCodeLine = 160;
                TEMP_VALUE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 161;
                return ; 
                } 
            
            __context__.SourceCodeLine = 164;
            VALUETEMP  .UpdateValue ( EXTRACTVALUE (  __context__ , BUFFER__DOLLAR__, (ushort)( POSTEMP ))  ) ; 
            __context__.SourceCodeLine = 166;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( VALUETEMP ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 168;
                TEMPERATURE__DOLLAR__  .UpdateValue ( "-- \u00B0C"  ) ; 
                __context__.SourceCodeLine = 169;
                TEMP_VALUE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 170;
                return ; 
                } 
            
            __context__.SourceCodeLine = 174;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUETEMP == "0"))  ) ) 
                { 
                __context__.SourceCodeLine = 176;
                TEMPERATURE__DOLLAR__  .UpdateValue ( "-- \u00B0C"  ) ; 
                __context__.SourceCodeLine = 177;
                TEMP_VALUE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 178;
                return ; 
                } 
            
            __context__.SourceCodeLine = 182;
            DOTPOS = (ushort) ( Functions.Find( "." , VALUETEMP ) ) ; 
            __context__.SourceCodeLine = 183;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( DOTPOS > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 185;
                INTPART  .UpdateValue ( Functions.Left ( VALUETEMP ,  (int) ( (DOTPOS - 1) ) )  ) ; 
                __context__.SourceCodeLine = 186;
                FRACPART  .UpdateValue ( Functions.Mid ( VALUETEMP ,  (int) ( (DOTPOS + 1) ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 187;
                TEMPINT = (ushort) ( Functions.Atoi( INTPART ) ) ; 
                __context__.SourceCodeLine = 188;
                TEMPFRAC = (ushort) ( Functions.Atoi( FRACPART ) ) ; 
                __context__.SourceCodeLine = 189;
                TEMP_VALUE  .Value = (ushort) ( ((TEMPINT * 10) + TEMPFRAC) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 193;
                TEMPINT = (ushort) ( Functions.Atoi( VALUETEMP ) ) ; 
                __context__.SourceCodeLine = 194;
                TEMP_VALUE  .Value = (ushort) ( (TEMPINT * 10) ) ; 
                __context__.SourceCodeLine = 195;
                VALUETEMP  .UpdateValue ( VALUETEMP + ".0"  ) ; 
                } 
            
            __context__.SourceCodeLine = 199;
            TEMPERATURE__DOLLAR__  .UpdateValue ( VALUETEMP + " \u00B0C"  ) ; 
            
            }
            
        object RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort CLOSEPOS = 0;
                
                
                __context__.SourceCodeLine = 210;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENABLE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 212;
                    BUFFER__DOLLAR__  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 213;
                    TEMPERATURE__DOLLAR__  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 214;
                    TEMP_VALUE  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 215;
                    IS_ON_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 216;
                    return  this ; 
                    } 
                
                __context__.SourceCodeLine = 220;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( RX__DOLLAR__ ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 221;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 225;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HTTP/1.1" , RX__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 227;
                    BUFFER__DOLLAR__  .UpdateValue ( RX__DOLLAR__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 233;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.Length( BUFFER__DOLLAR__ ) + Functions.Length( RX__DOLLAR__ )) > 3900 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 236;
                        BUFFER__DOLLAR__  .UpdateValue ( RX__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 240;
                        BUFFER__DOLLAR__  .UpdateValue ( BUFFER__DOLLAR__ + RX__DOLLAR__  ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 245;
                CLOSEPOS = (ushort) ( Functions.Find( "}]" , BUFFER__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 247;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CLOSEPOS > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 250;
                    PROCESSCOMPLETEJSON (  __context__  ) ; 
                    __context__.SourceCodeLine = 253;
                    BUFFER__DOLLAR__  .UpdateValue ( ""  ) ; 
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
            
            __context__.SourceCodeLine = 260;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 262;
            BUFFER__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 263;
            TEMPERATURE__DOLLAR__  .UpdateValue ( "-- \u00B0C"  ) ; 
            __context__.SourceCodeLine = 264;
            TEMP_VALUE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 265;
            IS_ON_FB  .Value = (ushort) ( 0 ) ; 
            
            
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
        BUFFER__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4000, this );
        
        ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
        m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
        
        IS_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( IS_ON_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( IS_ON_FB__DigitalOutput__, IS_ON_FB );
        
        TEMP_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( TEMP_VALUE__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TEMP_VALUE__AnalogSerialOutput__, TEMP_VALUE );
        
        RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RX__DOLLAR____AnalogSerialInput__, 2000, this );
        m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
        
        TEMPERATURE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TEMPERATURE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TEMPERATURE__DOLLAR____AnalogSerialOutput__, TEMPERATURE__DOLLAR__ );
        
        
        RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_AIDOOPARSER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint RX__DOLLAR____AnalogSerialInput__ = 0;
    const uint ENABLE__DigitalInput__ = 0;
    const uint TEMPERATURE__DOLLAR____AnalogSerialOutput__ = 0;
    const uint TEMP_VALUE__AnalogSerialOutput__ = 1;
    const uint IS_ON_FB__DigitalOutput__ = 0;
    
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
