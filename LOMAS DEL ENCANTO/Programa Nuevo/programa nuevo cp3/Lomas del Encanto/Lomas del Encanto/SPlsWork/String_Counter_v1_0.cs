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

namespace UserModule_STRING_COUNTER_V1_0
{
    public class UserModuleClass_STRING_COUNTER_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIITEMTEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput AOBUTTONSELECT;
        ushort G_INUMBERITEMS = 0;
        private void SHOWBUTTONSELECT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS <= 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 19;
                AOBUTTONSELECT  .Value = (ushort) ( 0 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 21;
                AOBUTTONSELECT  .Value = (ushort) ( 1 ) ; 
                }
            
            
            }
            
        object SIITEMTEXT__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ITEM = 0;
                
                ushort FOUND = 0;
                
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 30;
                ITEM = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 32;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SIITEMTEXT__DOLLAR__[ ITEM ] ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 34;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEM > G_INUMBERITEMS ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 36;
                        G_INUMBERITEMS = (ushort) ( ITEM ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 41;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM == G_INUMBERITEMS))  ) ) 
                        { 
                        __context__.SourceCodeLine = 43;
                        FOUND = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 44;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( G_INUMBERITEMS ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)1; 
                        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 46;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SIITEMTEXT__DOLLAR__[ I ] ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 48;
                                G_INUMBERITEMS = (ushort) ( I ) ; 
                                __context__.SourceCodeLine = 49;
                                FOUND = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 50;
                                break ; 
                                } 
                            
                            __context__.SourceCodeLine = 44;
                            } 
                        
                        __context__.SourceCodeLine = 54;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FOUND == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 56;
                            G_INUMBERITEMS = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 61;
                SHOWBUTTONSELECT (  __context__  ) ; 
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS > 50 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 64;
                    GenerateUserError ( "Number of items to scroll list ({0:d}) exceeds maximum of {1:d}!", (ushort)G_INUMBERITEMS, (ushort)50) ; 
                    }
                
                __context__.SourceCodeLine = 66;
                
                
                
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
            
            __context__.SourceCodeLine = 73;
            G_INUMBERITEMS = (ushort) ( 0 ) ; 
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
        
        AOBUTTONSELECT = new Crestron.Logos.SplusObjects.AnalogOutput( AOBUTTONSELECT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( AOBUTTONSELECT__AnalogSerialOutput__, AOBUTTONSELECT );
        
        SIITEMTEXT__DOLLAR__ = new InOutArray<StringInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            SIITEMTEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIITEMTEXT__DOLLAR____AnalogSerialInput__ + i, SIITEMTEXT__DOLLAR____AnalogSerialInput__, 50, this );
            m_StringInputList.Add( SIITEMTEXT__DOLLAR____AnalogSerialInput__ + i, SIITEMTEXT__DOLLAR__[i+1] );
        }
        
        
        for( uint i = 0; i < 50; i++ )
            SIITEMTEXT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( SIITEMTEXT__DOLLAR___OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_STRING_COUNTER_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SIITEMTEXT__DOLLAR____AnalogSerialInput__ = 0;
    const uint AOBUTTONSELECT__AnalogSerialOutput__ = 0;
    
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
