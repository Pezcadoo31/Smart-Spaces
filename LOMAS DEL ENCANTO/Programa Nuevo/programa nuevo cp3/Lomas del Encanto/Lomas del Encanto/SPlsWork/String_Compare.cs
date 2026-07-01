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

namespace UserModule_STRING_COMPARE
{
    public class UserModuleClass_STRING_COMPARE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput UPDATESTRING;
        Crestron.Logos.SplusObjects.StringInput CURRENTSTRING__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> COMPARESTRING__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> HIGHLIGHTITEM;
        object UPDATESTRING_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort EQUAL = 0;
                ushort X = 0;
                
                
                __context__.SourceCodeLine = 61;
                Functions.Delay (  (int) ( 10 ) ) ; 
                __context__.SourceCodeLine = 62;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)10; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 64;
                    EQUAL = (ushort) ( Functions.CompareStrings( CURRENTSTRING__DOLLAR__ , COMPARESTRING__DOLLAR__[ X ] ) ) ; 
                    __context__.SourceCodeLine = 65;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EQUAL == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 66;
                        HIGHLIGHTITEM [ X]  .Value = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 68;
                        HIGHLIGHTITEM [ X]  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 62;
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
            
            __context__.SourceCodeLine = 75;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        UPDATESTRING = new Crestron.Logos.SplusObjects.DigitalInput( UPDATESTRING__DigitalInput__, this );
        m_DigitalInputList.Add( UPDATESTRING__DigitalInput__, UPDATESTRING );
        
        HIGHLIGHTITEM = new InOutArray<DigitalOutput>( 10, this );
        for( uint i = 0; i < 10; i++ )
        {
            HIGHLIGHTITEM[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( HIGHLIGHTITEM__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( HIGHLIGHTITEM__DigitalOutput__ + i, HIGHLIGHTITEM[i+1] );
        }
        
        CURRENTSTRING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( CURRENTSTRING__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( CURRENTSTRING__DOLLAR____AnalogSerialInput__, CURRENTSTRING__DOLLAR__ );
        
        COMPARESTRING__DOLLAR__ = new InOutArray<StringInput>( 10, this );
        for( uint i = 0; i < 10; i++ )
        {
            COMPARESTRING__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( COMPARESTRING__DOLLAR____AnalogSerialInput__ + i, COMPARESTRING__DOLLAR____AnalogSerialInput__, 50, this );
            m_StringInputList.Add( COMPARESTRING__DOLLAR____AnalogSerialInput__ + i, COMPARESTRING__DOLLAR__[i+1] );
        }
        
        
        UPDATESTRING.OnDigitalChange.Add( new InputChangeHandlerWrapper( UPDATESTRING_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_STRING_COMPARE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint UPDATESTRING__DigitalInput__ = 0;
    const uint CURRENTSTRING__DOLLAR____AnalogSerialInput__ = 0;
    const uint COMPARESTRING__DOLLAR____AnalogSerialInput__ = 1;
    const uint HIGHLIGHTITEM__DigitalOutput__ = 0;
    
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
