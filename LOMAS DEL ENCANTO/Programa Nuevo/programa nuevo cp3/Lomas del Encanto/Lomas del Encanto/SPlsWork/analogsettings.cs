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

namespace CrestronModule_ANALOGSETTINGS
{
    public class CrestronModuleClass_ANALOGSETTINGS : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        Crestron.Logos.SplusObjects.StringInput FILE_PATH;
        Crestron.Logos.SplusObjects.DigitalOutput READ_OK;
        Crestron.Logos.SplusObjects.DigitalOutput WRITE_OK;
        Crestron.Logos.SplusObjects.DigitalOutput NVRAM_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput READ_ERROR;
        Crestron.Logos.SplusObjects.DigitalOutput WRITE_ERROR;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ANLG_PRESET;
        ushort G_INUMANALOGPRESETS = 0;
        object READ_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort IPRESETNUM = 0;
                
                ushort IPRESETLEVEL = 0;
                
                short IFILEHANDLE = 0;
                
                CrestronString SREADBUF;
                SREADBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4096, this );
                
                short IERRCODE = 0;
                
                ushort ISTARTPOS = 0;
                
                ushort IENDPOS = 0;
                
                
                __context__.SourceCodeLine = 49;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 51;
                    
                    __context__.SourceCodeLine = 54;
                    Functions.Pulse ( 50, READ_ERROR ) ; 
                    __context__.SourceCodeLine = 55;
                    Functions.TerminateEvent (); 
                    } 
                
                __context__.SourceCodeLine = 59;
                IFILEHANDLE = (short) ( FileOpen( FILE_PATH ,(ushort) (0 | 16384) ) ) ; 
                __context__.SourceCodeLine = 60;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 62;
                    
                    __context__.SourceCodeLine = 65;
                    Functions.Pulse ( 50, READ_ERROR ) ; 
                    __context__.SourceCodeLine = 66;
                    EndFileOperations ( ) ; 
                    __context__.SourceCodeLine = 67;
                    Functions.TerminateEvent (); 
                    } 
                
                __context__.SourceCodeLine = 70;
                IERRCODE = (short) ( FileRead( (short)( IFILEHANDLE ) , SREADBUF , (ushort)( 4096 ) ) ) ; 
                __context__.SourceCodeLine = 72;
                IPRESETNUM = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 73;
                ISTARTPOS = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 75;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPRESETNUM <= G_INUMANALOGPRESETS ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 77;
                    IENDPOS = (ushort) ( (Functions.Find( "," , SREADBUF , ISTARTPOS ) - 1) ) ; 
                    __context__.SourceCodeLine = 79;
                    
                    __context__.SourceCodeLine = 83;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IENDPOS == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 84;
                        break ; 
                        }
                    
                    __context__.SourceCodeLine = 86;
                    IPRESETLEVEL = (ushort) ( Functions.Atoi( Functions.Mid( SREADBUF , (int)( ISTARTPOS ) , (int)( IENDPOS ) ) ) ) ; 
                    __context__.SourceCodeLine = 87;
                    ANLG_PRESET [ IPRESETNUM]  .Value = (ushort) ( IPRESETLEVEL ) ; 
                    __context__.SourceCodeLine = 89;
                    ISTARTPOS = (ushort) ( (IENDPOS + 2) ) ; 
                    __context__.SourceCodeLine = 90;
                    IPRESETNUM = (ushort) ( (IPRESETNUM + 1) ) ; 
                    __context__.SourceCodeLine = 75;
                    } 
                
                __context__.SourceCodeLine = 93;
                IERRCODE = (short) ( FileClose( (short)( IFILEHANDLE ) ) ) ; 
                __context__.SourceCodeLine = 94;
                
                __context__.SourceCodeLine = 98;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( EndFileOperations() < 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 100;
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 105;
                    Functions.Pulse ( 50, READ_OK ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object WRITE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort IPRESETNUM = 0;
            
            short IFILEHANDLE = 0;
            
            short IERRCODE = 0;
            
            CrestronString SBUF;
            SBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4096, this );
            
            
            __context__.SourceCodeLine = 115;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( StartFileOperations() < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 117;
                Print( "ERROR: Cannot start file ops\r\n") ; 
                __context__.SourceCodeLine = 118;
                Functions.Pulse ( 50, WRITE_ERROR ) ; 
                __context__.SourceCodeLine = 119;
                Functions.TerminateEvent (); 
                } 
            
            __context__.SourceCodeLine = 122;
            IFILEHANDLE = (short) ( FileOpen( FILE_PATH ,(ushort) (((256 | 1) | 16384) | 512) ) ) ; 
            __context__.SourceCodeLine = 124;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IFILEHANDLE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 126;
                Print( "ERROR: Cannot open file '{0}' for write.\r\n Error Code={1:d}\r\n", FILE_PATH , (short)IFILEHANDLE) ; 
                __context__.SourceCodeLine = 127;
                Functions.Pulse ( 50, WRITE_ERROR ) ; 
                __context__.SourceCodeLine = 128;
                Functions.TerminateEvent (); 
                } 
            
            __context__.SourceCodeLine = 131;
            Functions.ClearBuffer ( SBUF ) ; 
            __context__.SourceCodeLine = 133;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_INUMANALOGPRESETS; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( IPRESETNUM  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (IPRESETNUM  >= __FN_FORSTART_VAL__1) && (IPRESETNUM  <= __FN_FOREND_VAL__1) ) : ( (IPRESETNUM  <= __FN_FORSTART_VAL__1) && (IPRESETNUM  >= __FN_FOREND_VAL__1) ) ; IPRESETNUM  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 135;
                MakeString ( SBUF , "{0}{1:d}", SBUF , (ushort)ANLG_PRESET[ IPRESETNUM ] .Value) ; 
                __context__.SourceCodeLine = 137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPRESETNUM < G_INUMANALOGPRESETS ))  ) ) 
                    {
                    __context__.SourceCodeLine = 138;
                    MakeString ( SBUF , "{0},", SBUF ) ; 
                    }
                
                __context__.SourceCodeLine = 133;
                } 
            
            __context__.SourceCodeLine = 141;
            IERRCODE = (short) ( FileWrite( (short)( IFILEHANDLE ) , SBUF , (ushort)( Functions.Length( SBUF ) ) ) ) ; 
            __context__.SourceCodeLine = 143;
            
            __context__.SourceCodeLine = 148;
            IERRCODE = (short) ( FileClose( (short)( IFILEHANDLE ) ) ) ; 
            __context__.SourceCodeLine = 150;
            
            __context__.SourceCodeLine = 155;
            IERRCODE = (short) ( EndFileOperations() ) ; 
            __context__.SourceCodeLine = 157;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRCODE < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 159;
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 164;
                Functions.Pulse ( 50, WRITE_OK ) ; 
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
        
        __context__.SourceCodeLine = 169;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CheckForNVRAMDisk() != 1))  ) ) 
            { 
            __context__.SourceCodeLine = 171;
            Print( "ERROR: No NVRAM disk available.\r\n") ; 
            __context__.SourceCodeLine = 172;
            NVRAM_AVAILABLE  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 175;
            NVRAM_AVAILABLE  .Value = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 177;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 200 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1; 
        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
        for ( G_INUMANALOGPRESETS  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (G_INUMANALOGPRESETS  >= __FN_FORSTART_VAL__1) && (G_INUMANALOGPRESETS  <= __FN_FOREND_VAL__1) ) : ( (G_INUMANALOGPRESETS  <= __FN_FORSTART_VAL__1) && (G_INUMANALOGPRESETS  >= __FN_FOREND_VAL__1) ) ; G_INUMANALOGPRESETS  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( ANLG_PRESET[ G_INUMANALOGPRESETS ] ))  ) ) 
                {
                __context__.SourceCodeLine = 180;
                break ; 
                }
            
            __context__.SourceCodeLine = 177;
            } 
        
        
        
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
    
    READ = new Crestron.Logos.SplusObjects.DigitalInput( READ__DigitalInput__, this );
    m_DigitalInputList.Add( READ__DigitalInput__, READ );
    
    WRITE = new Crestron.Logos.SplusObjects.DigitalInput( WRITE__DigitalInput__, this );
    m_DigitalInputList.Add( WRITE__DigitalInput__, WRITE );
    
    READ_OK = new Crestron.Logos.SplusObjects.DigitalOutput( READ_OK__DigitalOutput__, this );
    m_DigitalOutputList.Add( READ_OK__DigitalOutput__, READ_OK );
    
    WRITE_OK = new Crestron.Logos.SplusObjects.DigitalOutput( WRITE_OK__DigitalOutput__, this );
    m_DigitalOutputList.Add( WRITE_OK__DigitalOutput__, WRITE_OK );
    
    NVRAM_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( NVRAM_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( NVRAM_AVAILABLE__DigitalOutput__, NVRAM_AVAILABLE );
    
    READ_ERROR = new Crestron.Logos.SplusObjects.DigitalOutput( READ_ERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( READ_ERROR__DigitalOutput__, READ_ERROR );
    
    WRITE_ERROR = new Crestron.Logos.SplusObjects.DigitalOutput( WRITE_ERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( WRITE_ERROR__DigitalOutput__, WRITE_ERROR );
    
    ANLG_PRESET = new InOutArray<AnalogOutput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        ANLG_PRESET[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ANLG_PRESET__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ANLG_PRESET__AnalogSerialOutput__ + i, ANLG_PRESET[i+1] );
    }
    
    FILE_PATH = new Crestron.Logos.SplusObjects.StringInput( FILE_PATH__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FILE_PATH__AnalogSerialInput__, FILE_PATH );
    
    
    READ.OnDigitalPush.Add( new InputChangeHandlerWrapper( READ_OnPush_0, false ) );
    WRITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WRITE_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_ANALOGSETTINGS ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint READ__DigitalInput__ = 0;
const uint WRITE__DigitalInput__ = 1;
const uint FILE_PATH__AnalogSerialInput__ = 0;
const uint READ_OK__DigitalOutput__ = 0;
const uint WRITE_OK__DigitalOutput__ = 1;
const uint NVRAM_AVAILABLE__DigitalOutput__ = 2;
const uint READ_ERROR__DigitalOutput__ = 3;
const uint WRITE_ERROR__DigitalOutput__ = 4;
const uint ANLG_PRESET__AnalogSerialOutput__ = 0;

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
