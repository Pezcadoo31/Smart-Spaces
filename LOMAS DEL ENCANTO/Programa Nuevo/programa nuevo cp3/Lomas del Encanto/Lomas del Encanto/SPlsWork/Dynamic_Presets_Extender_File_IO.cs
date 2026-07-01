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

namespace CrestronModule_DYNAMIC_PRESETS_EXTENDER_FILE_IO
{
    public class CrestronModuleClass_DYNAMIC_PRESETS_EXTENDER_FILE_IO : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PREV_PRESET;
        Crestron.Logos.SplusObjects.DigitalInput NEXT_PRESET;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_PRESETS;
        Crestron.Logos.SplusObjects.DigitalInput FIRST_MASTER_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput PREV_MASTER_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput NEXT_MASTER_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput LAST_MASTER_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_PREV_PRESET;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_NEXT_PRESET;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_STATION_NAME;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_IMAGE;
        Crestron.Logos.SplusObjects.AnalogInput MASTER_LIST_INDEX;
        Crestron.Logos.SplusObjects.AnalogInput MAX_CHANNEL_LENGTH;
        Crestron.Logos.SplusObjects.StringInput EDIT_STATION_NAME;
        Crestron.Logos.SplusObjects.StringInput USER_FILE_NAME;
        Crestron.Logos.SplusObjects.StringInput MASTER_FILE_NAME;
        Crestron.Logos.SplusObjects.StringInput NEW_CHANNEL_VALUE;
        Crestron.Logos.SplusObjects.DigitalOutput CLEAR_KEYPAD;
        Crestron.Logos.SplusObjects.AnalogOutput USER_INDEX;
        Crestron.Logos.SplusObjects.StringOutput WORKING_PRESET_INDEX;
        Crestron.Logos.SplusObjects.StringOutput WORKING_PRESET_STATION;
        Crestron.Logos.SplusObjects.AnalogOutput WORKING_PRESET_IMAGE;
        Crestron.Logos.SplusObjects.StringOutput WORKING_PRESET_CHANNEL;
        Crestron.Logos.SplusObjects.AnalogOutput SCROLL_BAR;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> USER_ICON;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> USER_CHANNEL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> USER_STATION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MASTER_ICON_INDEX;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MASTER_STATION;
        ushort CURRENTMASTERPAGE = 0;
        ushort TOTALMASTERPAGES = 0;
        ushort MASTERLISTPREPD = 0;
        ushort WRITINGTODISK = 0;
        ushort SERVICE = 0;
        ushort [] USERICON;
        CrestronString [] USERSTATION;
        CrestronString [] USERCHANNEL;
        ushort MASTERENTRIES = 0;
        ushort [] MASTERICON;
        CrestronString [] MASTERSTATION;
        CrestronString [] MASTERCHANNEL;
        ushort SCROLLINDEX = 0;
        CrestronString WORKINGPRESETINDEX__DOLLAR__;
        CrestronString WORKINGPRESETSTATION__DOLLAR__;
        CrestronString WORKINGPRESETCHANNEL__DOLLAR__;
        ushort WORKINGPRESETIMAGE = 0;
        ushort USECUSTOMNAME = 0;
        ushort FORCEIMAGECLEAR = 0;
        private void SORTMASTER (  SplusExecutionContext __context__ ) 
            { 
            ushort TEMPCOUNT = 0;
            
            ushort X = 0;
            
            CrestronString TEMPSWAP__DOLLAR__;
            TEMPSWAP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            CrestronString TEMPCHANNELSWAP__DOLLAR__;
            TEMPCHANNELSWAP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
            
            ushort TEMPSWAP = 0;
            
            ushort BSWAPPED = 0;
            
            
            __context__.SourceCodeLine = 123;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MASTERENTRIES > 2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 125;
                TEMPCOUNT = (ushort) ( (MASTERENTRIES - 1) ) ; 
                __context__.SourceCodeLine = 127;
                BSWAPPED = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 128;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (BSWAPPED == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 130;
                    BSWAPPED = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 131;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 2 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)TEMPCOUNT; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 133;
                        if ( Functions.TestForTrue  ( ( (Functions.CompareStrings( Functions.Upper( MASTERSTATION[ X ] ), Functions.Upper( MASTERSTATION[ (X + 1) ] ) ) > 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 135;
                            TEMPSWAP__DOLLAR__  .UpdateValue ( MASTERSTATION [ X ]  ) ; 
                            __context__.SourceCodeLine = 136;
                            MASTERSTATION [ X ]  .UpdateValue ( MASTERSTATION [ (X + 1) ]  ) ; 
                            __context__.SourceCodeLine = 137;
                            MASTERSTATION [ (X + 1) ]  .UpdateValue ( TEMPSWAP__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 139;
                            TEMPSWAP = (ushort) ( MASTERICON[ X ] ) ; 
                            __context__.SourceCodeLine = 140;
                            MASTERICON [ X] = (ushort) ( MASTERICON[ (X + 1) ] ) ; 
                            __context__.SourceCodeLine = 141;
                            MASTERICON [ (X + 1)] = (ushort) ( TEMPSWAP ) ; 
                            __context__.SourceCodeLine = 143;
                            TEMPCHANNELSWAP__DOLLAR__  .UpdateValue ( MASTERCHANNEL [ X ]  ) ; 
                            __context__.SourceCodeLine = 144;
                            MASTERCHANNEL [ X ]  .UpdateValue ( MASTERCHANNEL [ (X + 1) ]  ) ; 
                            __context__.SourceCodeLine = 145;
                            MASTERCHANNEL [ (X + 1) ]  .UpdateValue ( TEMPCHANNELSWAP__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 147;
                            BSWAPPED = (ushort) ( 1 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 131;
                        } 
                    
                    __context__.SourceCodeLine = 151;
                    TEMPCOUNT = (ushort) ( (TEMPCOUNT - 1) ) ; 
                    __context__.SourceCodeLine = 128;
                    } 
                
                } 
            
            
            }
            
        private ushort READMASTERFILE (  SplusExecutionContext __context__ ) 
            { 
            short FILE = 0;
            
            short BYTESREAD = 0;
            
            ushort READPASS = 0;
            
            CrestronString READ__DOLLAR__;
            READ__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            CrestronString READ__DOLLAR__BUFF;
            READ__DOLLAR__BUFF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString TEMP__DOLLAR__2;
            TEMP__DOLLAR__2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort LENGTH = 0;
            
            ushort X = 0;
            
            ushort Y = 0;
            
            ushort COMMAPOS = 0;
            
            
            __context__.SourceCodeLine = 175;
            X = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 176;
            READPASS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 177;
            MASTERENTRIES = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (StartFileOperations() == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                TEMP__DOLLAR__  .UpdateValue ( MASTER_FILE_NAME  ) ; 
                __context__.SourceCodeLine = 182;
                FILE = (short) ( FileOpen( MASTER_FILE_NAME ,(ushort) (0 | 16384) ) ) ; 
                __context__.SourceCodeLine = 183;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FILE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 185;
                    MASTERSTATION [ X ]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 186;
                    MASTERICON [ X] = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 188;
                    READ__DOLLAR__BUFF  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 189;
                    READ__DOLLAR__  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 190;
                    while ( Functions.TestForTrue  ( ( (Functions.BoolToInt (FileEOF( (short)( FILE ) ) == 0) & Functions.BoolToInt ( X <= 1000 )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 192;
                        BYTESREAD = (short) ( FileRead( (short)( FILE ) , READ__DOLLAR__ , (ushort)( 64 ) ) ) ; 
                        __context__.SourceCodeLine = 193;
                        READ__DOLLAR__BUFF  .UpdateValue ( READ__DOLLAR__BUFF + READ__DOLLAR__  ) ; 
                        __context__.SourceCodeLine = 194;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( BYTESREAD >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 196;
                            while ( Functions.TestForTrue  ( ( (Functions.BoolToInt ( Functions.Find( "\u000D\u000A" , READ__DOLLAR__BUFF ) > 0 ) & Functions.BoolToInt ( X < 1000 )))  ) ) 
                                { 
                                __context__.SourceCodeLine = 198;
                                X = (ushort) ( (X + 1) ) ; 
                                __context__.SourceCodeLine = 201;
                                TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , READ__DOLLAR__BUFF )  ) ; 
                                __context__.SourceCodeLine = 204;
                                COMMAPOS = (ushort) ( Functions.Find( "," , TEMP__DOLLAR__ ) ) ; 
                                __context__.SourceCodeLine = 207;
                                MASTERSTATION [ X ]  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__ ,  (int) ( Functions.Min( (COMMAPOS - 1) , 8 ) ) )  ) ; 
                                __context__.SourceCodeLine = 208;
                                TEMP__DOLLAR__  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - COMMAPOS) ) )  ) ; 
                                __context__.SourceCodeLine = 211;
                                COMMAPOS = (ushort) ( Functions.Find( "," , TEMP__DOLLAR__ ) ) ; 
                                __context__.SourceCodeLine = 214;
                                TEMP__DOLLAR__2  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__ ,  (int) ( (COMMAPOS - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 215;
                                MASTERICON [ X] = (ushort) ( Functions.Atoi( TEMP__DOLLAR__2 ) ) ; 
                                __context__.SourceCodeLine = 218;
                                TEMP__DOLLAR__2  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - COMMAPOS) ) )  ) ; 
                                __context__.SourceCodeLine = 219;
                                MASTERCHANNEL [ X ]  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__2 ,  (int) ( Functions.Min( (Functions.Length( TEMP__DOLLAR__2 ) - 2) , 6 ) ) )  ) ; 
                                __context__.SourceCodeLine = 196;
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 190;
                        } 
                    
                    __context__.SourceCodeLine = 223;
                    MASTERENTRIES = (ushort) ( (X - 1) ) ; 
                    __context__.SourceCodeLine = 225;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MASTERENTRIES < 1000 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 227;
                        Y = (ushort) ( Mod( MASTERENTRIES , 9 ) ) ; 
                        __context__.SourceCodeLine = 228;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Y != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 230;
                            Y = (ushort) ( (9 - Y) ) ; 
                            __context__.SourceCodeLine = 231;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Y > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 233;
                                X = (ushort) ( (X + 1) ) ; 
                                __context__.SourceCodeLine = 234;
                                MASTERSTATION [ X ]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 235;
                                MASTERICON [ X] = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 236;
                                MASTERCHANNEL [ X ]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 237;
                                Y = (ushort) ( (Y - 1) ) ; 
                                __context__.SourceCodeLine = 231;
                                } 
                            
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 241;
                    Print( "Dynamic Presets Master File Read: {0:d} stations found.\r\n", (short)MASTERENTRIES) ; 
                    __context__.SourceCodeLine = 242;
                    READPASS = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 243;
                    FileClose (  (short) ( FILE ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 245;
                EndFileOperations ( ) ; 
                } 
            
            __context__.SourceCodeLine = 248;
            SORTMASTER (  __context__  ) ; 
            __context__.SourceCodeLine = 250;
            TOTALMASTERPAGES = (ushort) ( ((MASTERENTRIES / 9) + 1) ) ; 
            __context__.SourceCodeLine = 251;
            CURRENTMASTERPAGE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 252;
            Print( "Total Dynamic Preset Master List Pages: {0:d}, Current Page: {1:d} \r\n", (short)TOTALMASTERPAGES, (short)CURRENTMASTERPAGE) ; 
            __context__.SourceCodeLine = 254;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TOTALMASTERPAGES > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 255;
                SCROLLINDEX = (ushort) ( (65535 / (TOTALMASTERPAGES - 1)) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 257;
                SCROLLINDEX = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 259;
            return (ushort)( READPASS) ; 
            
            }
            
        private ushort INITIALUSERFILE (  SplusExecutionContext __context__ ) 
            { 
            short FILE = 0;
            
            CrestronString WRITE__DOLLAR__;
            WRITE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            
            ushort X = 0;
            
            ushort Y = 0;
            
            CrestronString Z;
            Z  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
            
            ushort WRITEPASS = 0;
            
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            
            __context__.SourceCodeLine = 277;
            WRITEPASS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 279;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (StartFileOperations() == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 281;
                TEMP__DOLLAR__  .UpdateValue ( USER_FILE_NAME  ) ; 
                __context__.SourceCodeLine = 282;
                FILE = (short) ( FileOpen( TEMP__DOLLAR__ ,(ushort) (((1 | 256) | 512) | 16384) ) ) ; 
                __context__.SourceCodeLine = 283;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FILE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 285;
                    Y = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 286;
                    Z  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 287;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)27; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 289;
                        MakeString ( WRITE__DOLLAR__ , "{0:d}:PRE {1:d2}:{2:d}:{3}\r\n", (short)X, (short)X, (short)Y, Z ) ; 
                        __context__.SourceCodeLine = 290;
                        FileWrite (  (short) ( FILE ) , WRITE__DOLLAR__ ,  (ushort) ( Functions.Length( WRITE__DOLLAR__ ) ) ) ; 
                        __context__.SourceCodeLine = 287;
                        } 
                    
                    __context__.SourceCodeLine = 292;
                    WRITEPASS = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 293;
                    FileClose (  (short) ( FILE ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 295;
                EndFileOperations ( ) ; 
                } 
            
            __context__.SourceCodeLine = 297;
            return (ushort)( WRITEPASS) ; 
            
            }
            
        private ushort WRITEUSERFILE (  SplusExecutionContext __context__, ushort MASTERLISTINDEX ) 
            { 
            short FILE = 0;
            
            ushort X = 0;
            
            ushort WRITEPASS = 0;
            
            CrestronString WRITE__DOLLAR__;
            WRITE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            
            __context__.SourceCodeLine = 312;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WRITINGTODISK == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 314;
                WRITINGTODISK = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 315;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (StartFileOperations() == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 317;
                    TEMP__DOLLAR__  .UpdateValue ( USER_FILE_NAME  ) ; 
                    __context__.SourceCodeLine = 318;
                    FILE = (short) ( FileOpen( TEMP__DOLLAR__ ,(ushort) (1 | 16384) ) ) ; 
                    __context__.SourceCodeLine = 319;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FILE >= 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 321;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MASTERLISTINDEX > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 323;
                            X = (ushort) ( (((CURRENTMASTERPAGE - 1) * 9) + MASTERLISTINDEX) ) ; 
                            __context__.SourceCodeLine = 324;
                            if ( Functions.TestForTrue  ( ( (Functions.BoolToInt ( X <= MASTERENTRIES ) & Functions.BoolToInt ( X <= 1000 )))  ) ) 
                                { 
                                __context__.SourceCodeLine = 326;
                                USERICON [ USER_INDEX  .Value] = (ushort) ( MASTERICON[ (X + 1) ] ) ; 
                                __context__.SourceCodeLine = 327;
                                USERSTATION [ USER_INDEX  .Value ]  .UpdateValue ( MASTERSTATION [ (X + 1) ]  ) ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 331;
                        USERCHANNEL [ USER_INDEX  .Value ]  .UpdateValue ( WORKINGPRESETCHANNEL__DOLLAR__  ) ; 
                        __context__.SourceCodeLine = 333;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (USECUSTOMNAME == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 335;
                            USERSTATION [ USER_INDEX  .Value ]  .UpdateValue ( WORKINGPRESETSTATION__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 336;
                            USECUSTOMNAME = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 338;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FORCEIMAGECLEAR == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 340;
                            USERICON [ USER_INDEX  .Value] = (ushort) ( WORKINGPRESETIMAGE ) ; 
                            __context__.SourceCodeLine = 341;
                            FORCEIMAGECLEAR = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 344;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)27; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 346;
                            WRITE__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( X ) ) + ":" + USERSTATION [ X ] + ":" + Functions.ItoA (  (int) ( USERICON[ X ] ) ) + ":" + USERCHANNEL [ X ] + "\r\n"  ) ; 
                            __context__.SourceCodeLine = 347;
                            FileWrite (  (short) ( FILE ) , WRITE__DOLLAR__ ,  (ushort) ( Functions.Length( WRITE__DOLLAR__ ) ) ) ; 
                            __context__.SourceCodeLine = 349;
                            USER_STATION [ X]  .UpdateValue ( USERSTATION [ X ]  ) ; 
                            __context__.SourceCodeLine = 350;
                            USER_ICON [ X]  .Value = (ushort) ( USERICON[ X ] ) ; 
                            __context__.SourceCodeLine = 351;
                            USER_CHANNEL [ X]  .UpdateValue ( USERCHANNEL [ X ]  ) ; 
                            __context__.SourceCodeLine = 344;
                            } 
                        
                        __context__.SourceCodeLine = 353;
                        WRITEPASS = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 354;
                        FileClose (  (short) ( FILE ) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 356;
                    EndFileOperations ( ) ; 
                    } 
                
                __context__.SourceCodeLine = 358;
                WRITINGTODISK = (ushort) ( 0 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 360;
                WRITEPASS = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 362;
            return (ushort)( WRITEPASS) ; 
            
            }
            
        private ushort READUSERFILE (  SplusExecutionContext __context__ ) 
            { 
            short FILE = 0;
            
            short BYTESREAD = 0;
            
            ushort READPASS = 0;
            
            CrestronString READ__DOLLAR__;
            READ__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            CrestronString READ__DOLLAR__BUFF;
            READ__DOLLAR__BUFF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort X = 0;
            
            ushort I = 0;
            
            ushort COLONPOS = 0;
            
            
            __context__.SourceCodeLine = 382;
            X = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 383;
            READPASS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 385;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (StartFileOperations() == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 387;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SetCurrentDirectory( "\\NVRAM" ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 389;
                    FILE = (short) ( FileOpen( USER_FILE_NAME ,(ushort) (0 | 16384) ) ) ; 
                    __context__.SourceCodeLine = 390;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FILE >= 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 392;
                        READ__DOLLAR__BUFF  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 393;
                        READ__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 394;
                        while ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileEOF( (short)( FILE ) ) == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 396;
                            BYTESREAD = (short) ( FileRead( (short)( FILE ) , READ__DOLLAR__ , (ushort)( 64 ) ) ) ; 
                            __context__.SourceCodeLine = 397;
                            READ__DOLLAR__BUFF  .UpdateValue ( READ__DOLLAR__BUFF + READ__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 398;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( BYTESREAD >= 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 400;
                                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D\u000A" , READ__DOLLAR__BUFF ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 402;
                                    X = (ushort) ( (X + 1) ) ; 
                                    __context__.SourceCodeLine = 405;
                                    TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , READ__DOLLAR__BUFF )  ) ; 
                                    __context__.SourceCodeLine = 408;
                                    COLONPOS = (ushort) ( Functions.Find( ":" , TEMP__DOLLAR__ ) ) ; 
                                    __context__.SourceCodeLine = 411;
                                    TEMP__DOLLAR__  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - COLONPOS) ) )  ) ; 
                                    __context__.SourceCodeLine = 414;
                                    COLONPOS = (ushort) ( Functions.Find( ":" , TEMP__DOLLAR__ ) ) ; 
                                    __context__.SourceCodeLine = 417;
                                    USERSTATION [ X ]  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__ ,  (int) ( (COLONPOS - 1) ) )  ) ; 
                                    __context__.SourceCodeLine = 418;
                                    USER_STATION [ X]  .UpdateValue ( USERSTATION [ X ]  ) ; 
                                    __context__.SourceCodeLine = 419;
                                    TEMP__DOLLAR__  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - COLONPOS) ) )  ) ; 
                                    __context__.SourceCodeLine = 422;
                                    COLONPOS = (ushort) ( Functions.Find( ":" , TEMP__DOLLAR__ ) ) ; 
                                    __context__.SourceCodeLine = 425;
                                    USERICON [ X] = (ushort) ( Functions.Atoi( Functions.Left( TEMP__DOLLAR__ , (int)( (COLONPOS - 1) ) ) ) ) ; 
                                    __context__.SourceCodeLine = 426;
                                    USER_ICON [ X]  .Value = (ushort) ( USERICON[ X ] ) ; 
                                    __context__.SourceCodeLine = 429;
                                    USERCHANNEL [ X ]  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - COLONPOS) ) )  ) ; 
                                    __context__.SourceCodeLine = 430;
                                    USERCHANNEL [ X ]  .UpdateValue ( Functions.Left ( USERCHANNEL [ X ] ,  (int) ( Functions.Min( (Functions.Length( USERCHANNEL[ X ] ) - 2) , 6 ) ) )  ) ; 
                                    __context__.SourceCodeLine = 431;
                                    USER_CHANNEL [ X]  .UpdateValue ( USERCHANNEL [ X ]  ) ; 
                                    __context__.SourceCodeLine = 400;
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 394;
                            } 
                        
                        __context__.SourceCodeLine = 435;
                        Print( "Dynamic Presets User File Read: {0:d} Stations.\r\n", (short)X) ; 
                        __context__.SourceCodeLine = 436;
                        FileClose (  (short) ( FILE ) ) ; 
                        __context__.SourceCodeLine = 437;
                        READPASS = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 440;
                EndFileOperations ( ) ; 
                } 
            
            __context__.SourceCodeLine = 442;
            return (ushort)( READPASS) ; 
            
            }
            
        private void POPMASTERLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort X = 0;
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 454;
            X = (ushort) ( (((CURRENTMASTERPAGE - 1) * 9) + 1) ) ; 
            __context__.SourceCodeLine = 455;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)9; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 457;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X < 1000 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 459;
                    X = (ushort) ( (X + 1) ) ; 
                    __context__.SourceCodeLine = 460;
                    MASTER_STATION [ I]  .UpdateValue ( MASTERSTATION [ X ]  ) ; 
                    __context__.SourceCodeLine = 461;
                    MASTER_ICON_INDEX [ I]  .Value = (ushort) ( MASTERICON[ X ] ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 465;
                    MASTER_STATION [ I]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 466;
                    MASTER_ICON_INDEX [ I]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 455;
                } 
            
            
            }
            
        private void POPCURRENTPRESET (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 477;
            WORKINGPRESETINDEX__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( USER_INDEX  .Value ) )  ) ; 
            __context__.SourceCodeLine = 478;
            WORKINGPRESETSTATION__DOLLAR__  .UpdateValue ( USERSTATION [ USER_INDEX  .Value ]  ) ; 
            __context__.SourceCodeLine = 479;
            WORKINGPRESETIMAGE = (ushort) ( USERICON[ USER_INDEX  .Value ] ) ; 
            __context__.SourceCodeLine = 483;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WORKINGPRESETIMAGE == 0))  ) ) 
                {
                __context__.SourceCodeLine = 484;
                WORKINGPRESETIMAGE = (ushort) ( 1 ) ; 
                }
            
            __context__.SourceCodeLine = 486;
            WORKING_PRESET_CHANNEL  .UpdateValue ( USERCHANNEL [ USER_INDEX  .Value ]  ) ; 
            __context__.SourceCodeLine = 487;
            WORKINGPRESETCHANNEL__DOLLAR__  .UpdateValue ( USERCHANNEL [ USER_INDEX  .Value ]  ) ; 
            
            }
            
        private void POPWORKINGPRESET (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 496;
            WORKING_PRESET_INDEX  .UpdateValue ( WORKINGPRESETINDEX__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 497;
            WORKING_PRESET_IMAGE  .Value = (ushort) ( WORKINGPRESETIMAGE ) ; 
            __context__.SourceCodeLine = 498;
            WORKING_PRESET_STATION  .UpdateValue ( WORKINGPRESETSTATION__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 499;
            WORKING_PRESET_CHANNEL  .UpdateValue ( WORKINGPRESETCHANNEL__DOLLAR__  ) ; 
            
            }
            
        object NEXT_PRESET_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                ushort Y = 0;
                
                
                __context__.SourceCodeLine = 509;
                X = (ushort) ( USER_INDEX  .Value ) ; 
                __context__.SourceCodeLine = 510;
                Y = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 512;
                do 
                    { 
                    __context__.SourceCodeLine = 514;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X >= 27 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 514;
                        X = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 515;
                        X = (ushort) ( (X + 1) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 516;
                    Y = (ushort) ( (Y + 1) ) ; 
                    } 
                while (false == ( Functions.TestForTrue  ( (Functions.BoolToInt (USERCHANNEL[ X ] != "") | Functions.BoolToInt (Y == 27))) )); 
                __context__.SourceCodeLine = 519;
                USER_INDEX  .Value = (ushort) ( X ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PREV_PRESET_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            ushort Y = 0;
            
            
            __context__.SourceCodeLine = 526;
            X = (ushort) ( USER_INDEX  .Value ) ; 
            __context__.SourceCodeLine = 527;
            Y = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 529;
            do 
                { 
                __context__.SourceCodeLine = 531;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X <= 1 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 531;
                    X = (ushort) ( 27 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 532;
                    X = (ushort) ( (X - 1) ) ; 
                    }
                
                __context__.SourceCodeLine = 533;
                Y = (ushort) ( (Y + 1) ) ; 
                } 
            while (false == ( Functions.TestForTrue  ( (Functions.BoolToInt (USERCHANNEL[ X ] != "") | Functions.BoolToInt (Y == 27))) )); 
            __context__.SourceCodeLine = 536;
            USER_INDEX  .Value = (ushort) ( X ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object EDIT_PREV_PRESET_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 541;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERVICE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 543;
            SERVICE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 545;
            WRITEUSERFILE (  __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue )) ; 
            __context__.SourceCodeLine = 547;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (USER_INDEX  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 547;
                USER_INDEX  .Value = (ushort) ( 27 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 548;
                USER_INDEX  .Value = (ushort) ( (USER_INDEX  .Value - 1) ) ; 
                }
            
            __context__.SourceCodeLine = 550;
            POPCURRENTPRESET (  __context__  ) ; 
            __context__.SourceCodeLine = 551;
            POPWORKINGPRESET (  __context__  ) ; 
            __context__.SourceCodeLine = 552;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WRITEUSERFILE( __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue ) ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 553;
                Print( "Attempt to change working preset before last preset finished saving.\r\nCurrent selection could not be saved.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 555;
            SERVICE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_NEXT_PRESET_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 561;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERVICE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 563;
            SERVICE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 565;
            WRITEUSERFILE (  __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue )) ; 
            __context__.SourceCodeLine = 567;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (USER_INDEX  .Value == 27))  ) ) 
                {
                __context__.SourceCodeLine = 567;
                USER_INDEX  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 568;
                USER_INDEX  .Value = (ushort) ( (USER_INDEX  .Value + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 570;
            POPCURRENTPRESET (  __context__  ) ; 
            __context__.SourceCodeLine = 571;
            POPWORKINGPRESET (  __context__  ) ; 
            __context__.SourceCodeLine = 572;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WRITEUSERFILE( __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue ) ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 573;
                Print( "Attempt to change working preset before last preset finished saving.\r\nCurrent selection could not be saved.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 574;
            SERVICE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEW_CHANNEL_VALUE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 580;
        WORKINGPRESETCHANNEL__DOLLAR__  .UpdateValue ( NEW_CHANNEL_VALUE  ) ; 
        __context__.SourceCodeLine = 581;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WRITEUSERFILE( __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue ) ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 582;
            Print( "Attempt to change working preset before last preset finished saving.\r\nCurrent selection could not be saved.\r\n") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_STATION_NAME_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 587;
        WORKINGPRESETSTATION__DOLLAR__  .UpdateValue ( EDIT_STATION_NAME  ) ; 
        __context__.SourceCodeLine = 588;
        USECUSTOMNAME = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 589;
        POPWORKINGPRESET (  __context__  ) ; 
        __context__.SourceCodeLine = 590;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WRITEUSERFILE( __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue ) ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 591;
            Print( "Attempt to change working preset before last preset finished saving.\r\nCurrent selection could not be saved.\r\n") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_IMAGE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 596;
        WORKINGPRESETIMAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 597;
        FORCEIMAGECLEAR = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 598;
        POPWORKINGPRESET (  __context__  ) ; 
        __context__.SourceCodeLine = 599;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (WRITEUSERFILE( __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue ) ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 600;
            Print( "Attempt to change working preset before last preset finished saving.\r\nCurrent selection could not be saved.\r\n") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTER_LIST_INDEX_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        ushort MASTERLISTINDEX = 0;
        
        
        __context__.SourceCodeLine = 608;
        MASTERLISTINDEX = (ushort) ( MASTER_LIST_INDEX  .UshortValue ) ; 
        __context__.SourceCodeLine = 610;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MASTERLISTINDEX == 0))  ) ) 
            {
            __context__.SourceCodeLine = 610;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 612;
        FORCEIMAGECLEAR = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 614;
        X = (ushort) ( (((CURRENTMASTERPAGE - 1) * 9) + MASTERLISTINDEX) ) ; 
        __context__.SourceCodeLine = 615;
        if ( Functions.TestForTrue  ( ( (Functions.BoolToInt ( X <= MASTERENTRIES ) & Functions.BoolToInt ( X <= 1000 )))  ) ) 
            { 
            __context__.SourceCodeLine = 617;
            CLEAR_KEYPAD  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 618;
            CLEAR_KEYPAD  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 620;
            X = (ushort) ( (X + 1) ) ; 
            __context__.SourceCodeLine = 621;
            WORKINGPRESETIMAGE = (ushort) ( MASTERICON[ X ] ) ; 
            __context__.SourceCodeLine = 622;
            WORKINGPRESETSTATION__DOLLAR__  .UpdateValue ( MASTERSTATION [ X ]  ) ; 
            __context__.SourceCodeLine = 624;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( MASTERCHANNEL[ X ] ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 625;
                WORKINGPRESETCHANNEL__DOLLAR__  .UpdateValue ( MASTERCHANNEL [ X ]  ) ; 
                }
            
            __context__.SourceCodeLine = 627;
            POPWORKINGPRESET (  __context__  ) ; 
            __context__.SourceCodeLine = 629;
            WRITEUSERFILE (  __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_PRESETS_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 635;
        POPCURRENTPRESET (  __context__  ) ; 
        __context__.SourceCodeLine = 636;
        POPWORKINGPRESET (  __context__  ) ; 
        __context__.SourceCodeLine = 637;
        WRITEUSERFILE (  __context__ , (ushort)( MASTER_LIST_INDEX  .UshortValue )) ; 
        __context__.SourceCodeLine = 639;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MASTERLISTPREPD == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 641;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (READMASTERFILE( __context__ ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 643;
                GenerateUserError ( "Problem accessing Dynamic Preset Master List file.\r\nPlease check the file exists, and NVRAM is enabled.\r\n") ; 
                __context__.SourceCodeLine = 644;
                return  this ; 
                } 
            
            __context__.SourceCodeLine = 646;
            MASTERLISTPREPD = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 648;
        POPMASTERLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 649;
        SCROLL_BAR  .Value = (ushort) ( (SCROLLINDEX * (TOTALMASTERPAGES - CURRENTMASTERPAGE)) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXT_MASTER_PAGE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 654;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENTMASTERPAGE < TOTALMASTERPAGES ))  ) ) 
            { 
            __context__.SourceCodeLine = 656;
            CURRENTMASTERPAGE = (ushort) ( (CURRENTMASTERPAGE + 1) ) ; 
            __context__.SourceCodeLine = 657;
            POPMASTERLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 658;
            SCROLL_BAR  .Value = (ushort) ( (SCROLLINDEX * (TOTALMASTERPAGES - CURRENTMASTERPAGE)) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREV_MASTER_PAGE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 664;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENTMASTERPAGE > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 666;
            CURRENTMASTERPAGE = (ushort) ( (CURRENTMASTERPAGE - 1) ) ; 
            __context__.SourceCodeLine = 667;
            POPMASTERLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 668;
            SCROLL_BAR  .Value = (ushort) ( (SCROLLINDEX * (TOTALMASTERPAGES - CURRENTMASTERPAGE)) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FIRST_MASTER_PAGE_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 674;
        CURRENTMASTERPAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 675;
        POPMASTERLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 676;
        SCROLL_BAR  .Value = (ushort) ( (SCROLLINDEX * (TOTALMASTERPAGES - CURRENTMASTERPAGE)) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LAST_MASTER_PAGE_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 681;
        CURRENTMASTERPAGE = (ushort) ( TOTALMASTERPAGES ) ; 
        __context__.SourceCodeLine = 682;
        POPMASTERLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 683;
        SCROLL_BAR  .Value = (ushort) ( (SCROLLINDEX * (TOTALMASTERPAGES - CURRENTMASTERPAGE)) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort TEMP = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 694;
        MASTERLISTPREPD = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 695;
        USECUSTOMNAME = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 697;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 699;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (READUSERFILE( __context__ ) == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 701;
            TEMP = (ushort) ( INITIALUSERFILE( __context__ ) ) ; 
            __context__.SourceCodeLine = 702;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP == 0))  ) ) 
                {
                __context__.SourceCodeLine = 702;
                GenerateUserError ( "Could not create Dynamic Presets User List file.\r\nPlease check NVRAM is enabled and not full.\r\n") ; 
                }
            
            __context__.SourceCodeLine = 704;
            TEMP = (ushort) ( READUSERFILE( __context__ ) ) ; 
            __context__.SourceCodeLine = 705;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP == 0))  ) ) 
                {
                __context__.SourceCodeLine = 705;
                GenerateUserError ( "Could not create Dynamic Presets User List file.\r\nPlease check NVRAM is enabled and not full.\r\n") ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 707;
        WRITINGTODISK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 708;
        SERVICE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 710;
        Functions.ProcessLogic ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    USERICON  = new ushort[ 28 ];
    MASTERICON  = new ushort[ 1001 ];
    WORKINGPRESETINDEX__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    WORKINGPRESETSTATION__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    WORKINGPRESETCHANNEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    USERSTATION  = new CrestronString[ 28 ];
    for( uint i = 0; i < 28; i++ )
        USERSTATION [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    USERCHANNEL  = new CrestronString[ 28 ];
    for( uint i = 0; i < 28; i++ )
        USERCHANNEL [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    MASTERSTATION  = new CrestronString[ 1001 ];
    for( uint i = 0; i < 1001; i++ )
        MASTERSTATION [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    MASTERCHANNEL  = new CrestronString[ 1001 ];
    for( uint i = 0; i < 1001; i++ )
        MASTERCHANNEL [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    
    PREV_PRESET = new Crestron.Logos.SplusObjects.DigitalInput( PREV_PRESET__DigitalInput__, this );
    m_DigitalInputList.Add( PREV_PRESET__DigitalInput__, PREV_PRESET );
    
    NEXT_PRESET = new Crestron.Logos.SplusObjects.DigitalInput( NEXT_PRESET__DigitalInput__, this );
    m_DigitalInputList.Add( NEXT_PRESET__DigitalInput__, NEXT_PRESET );
    
    EDIT_PRESETS = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_PRESETS__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_PRESETS__DigitalInput__, EDIT_PRESETS );
    
    FIRST_MASTER_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( FIRST_MASTER_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( FIRST_MASTER_PAGE__DigitalInput__, FIRST_MASTER_PAGE );
    
    PREV_MASTER_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( PREV_MASTER_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( PREV_MASTER_PAGE__DigitalInput__, PREV_MASTER_PAGE );
    
    NEXT_MASTER_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( NEXT_MASTER_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( NEXT_MASTER_PAGE__DigitalInput__, NEXT_MASTER_PAGE );
    
    LAST_MASTER_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( LAST_MASTER_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( LAST_MASTER_PAGE__DigitalInput__, LAST_MASTER_PAGE );
    
    EDIT_PREV_PRESET = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_PREV_PRESET__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_PREV_PRESET__DigitalInput__, EDIT_PREV_PRESET );
    
    EDIT_NEXT_PRESET = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_NEXT_PRESET__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_NEXT_PRESET__DigitalInput__, EDIT_NEXT_PRESET );
    
    SAVE_STATION_NAME = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_STATION_NAME__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_STATION_NAME__DigitalInput__, SAVE_STATION_NAME );
    
    CLEAR_IMAGE = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_IMAGE__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_IMAGE__DigitalInput__, CLEAR_IMAGE );
    
    CLEAR_KEYPAD = new Crestron.Logos.SplusObjects.DigitalOutput( CLEAR_KEYPAD__DigitalOutput__, this );
    m_DigitalOutputList.Add( CLEAR_KEYPAD__DigitalOutput__, CLEAR_KEYPAD );
    
    MASTER_LIST_INDEX = new Crestron.Logos.SplusObjects.AnalogInput( MASTER_LIST_INDEX__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MASTER_LIST_INDEX__AnalogSerialInput__, MASTER_LIST_INDEX );
    
    MAX_CHANNEL_LENGTH = new Crestron.Logos.SplusObjects.AnalogInput( MAX_CHANNEL_LENGTH__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAX_CHANNEL_LENGTH__AnalogSerialInput__, MAX_CHANNEL_LENGTH );
    
    USER_INDEX = new Crestron.Logos.SplusObjects.AnalogOutput( USER_INDEX__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( USER_INDEX__AnalogSerialOutput__, USER_INDEX );
    
    WORKING_PRESET_IMAGE = new Crestron.Logos.SplusObjects.AnalogOutput( WORKING_PRESET_IMAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WORKING_PRESET_IMAGE__AnalogSerialOutput__, WORKING_PRESET_IMAGE );
    
    SCROLL_BAR = new Crestron.Logos.SplusObjects.AnalogOutput( SCROLL_BAR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SCROLL_BAR__AnalogSerialOutput__, SCROLL_BAR );
    
    USER_ICON = new InOutArray<AnalogOutput>( 27, this );
    for( uint i = 0; i < 27; i++ )
    {
        USER_ICON[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( USER_ICON__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( USER_ICON__AnalogSerialOutput__ + i, USER_ICON[i+1] );
    }
    
    MASTER_ICON_INDEX = new InOutArray<AnalogOutput>( 9, this );
    for( uint i = 0; i < 9; i++ )
    {
        MASTER_ICON_INDEX[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MASTER_ICON_INDEX__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MASTER_ICON_INDEX__AnalogSerialOutput__ + i, MASTER_ICON_INDEX[i+1] );
    }
    
    EDIT_STATION_NAME = new Crestron.Logos.SplusObjects.StringInput( EDIT_STATION_NAME__AnalogSerialInput__, 8, this );
    m_StringInputList.Add( EDIT_STATION_NAME__AnalogSerialInput__, EDIT_STATION_NAME );
    
    USER_FILE_NAME = new Crestron.Logos.SplusObjects.StringInput( USER_FILE_NAME__AnalogSerialInput__, 128, this );
    m_StringInputList.Add( USER_FILE_NAME__AnalogSerialInput__, USER_FILE_NAME );
    
    MASTER_FILE_NAME = new Crestron.Logos.SplusObjects.StringInput( MASTER_FILE_NAME__AnalogSerialInput__, 128, this );
    m_StringInputList.Add( MASTER_FILE_NAME__AnalogSerialInput__, MASTER_FILE_NAME );
    
    NEW_CHANNEL_VALUE = new Crestron.Logos.SplusObjects.StringInput( NEW_CHANNEL_VALUE__AnalogSerialInput__, 6, this );
    m_StringInputList.Add( NEW_CHANNEL_VALUE__AnalogSerialInput__, NEW_CHANNEL_VALUE );
    
    WORKING_PRESET_INDEX = new Crestron.Logos.SplusObjects.StringOutput( WORKING_PRESET_INDEX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( WORKING_PRESET_INDEX__AnalogSerialOutput__, WORKING_PRESET_INDEX );
    
    WORKING_PRESET_STATION = new Crestron.Logos.SplusObjects.StringOutput( WORKING_PRESET_STATION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( WORKING_PRESET_STATION__AnalogSerialOutput__, WORKING_PRESET_STATION );
    
    WORKING_PRESET_CHANNEL = new Crestron.Logos.SplusObjects.StringOutput( WORKING_PRESET_CHANNEL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( WORKING_PRESET_CHANNEL__AnalogSerialOutput__, WORKING_PRESET_CHANNEL );
    
    USER_CHANNEL = new InOutArray<StringOutput>( 27, this );
    for( uint i = 0; i < 27; i++ )
    {
        USER_CHANNEL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( USER_CHANNEL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( USER_CHANNEL__AnalogSerialOutput__ + i, USER_CHANNEL[i+1] );
    }
    
    USER_STATION = new InOutArray<StringOutput>( 27, this );
    for( uint i = 0; i < 27; i++ )
    {
        USER_STATION[i+1] = new Crestron.Logos.SplusObjects.StringOutput( USER_STATION__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( USER_STATION__AnalogSerialOutput__ + i, USER_STATION[i+1] );
    }
    
    MASTER_STATION = new InOutArray<StringOutput>( 9, this );
    for( uint i = 0; i < 9; i++ )
    {
        MASTER_STATION[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MASTER_STATION__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MASTER_STATION__AnalogSerialOutput__ + i, MASTER_STATION[i+1] );
    }
    
    
    NEXT_PRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXT_PRESET_OnPush_0, false ) );
    PREV_PRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREV_PRESET_OnPush_1, false ) );
    EDIT_PREV_PRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_PREV_PRESET_OnPush_2, false ) );
    EDIT_NEXT_PRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_NEXT_PRESET_OnPush_3, false ) );
    NEW_CHANNEL_VALUE.OnSerialChange.Add( new InputChangeHandlerWrapper( NEW_CHANNEL_VALUE_OnChange_4, false ) );
    SAVE_STATION_NAME.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_STATION_NAME_OnPush_5, false ) );
    CLEAR_IMAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_IMAGE_OnPush_6, false ) );
    MASTER_LIST_INDEX.OnAnalogChange.Add( new InputChangeHandlerWrapper( MASTER_LIST_INDEX_OnChange_7, false ) );
    EDIT_PRESETS.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_PRESETS_OnPush_8, false ) );
    NEXT_MASTER_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXT_MASTER_PAGE_OnPush_9, false ) );
    PREV_MASTER_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREV_MASTER_PAGE_OnPush_10, false ) );
    FIRST_MASTER_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FIRST_MASTER_PAGE_OnPush_11, false ) );
    LAST_MASTER_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LAST_MASTER_PAGE_OnPush_12, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_DYNAMIC_PRESETS_EXTENDER_FILE_IO ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PREV_PRESET__DigitalInput__ = 0;
const uint NEXT_PRESET__DigitalInput__ = 1;
const uint EDIT_PRESETS__DigitalInput__ = 2;
const uint FIRST_MASTER_PAGE__DigitalInput__ = 3;
const uint PREV_MASTER_PAGE__DigitalInput__ = 4;
const uint NEXT_MASTER_PAGE__DigitalInput__ = 5;
const uint LAST_MASTER_PAGE__DigitalInput__ = 6;
const uint EDIT_PREV_PRESET__DigitalInput__ = 7;
const uint EDIT_NEXT_PRESET__DigitalInput__ = 8;
const uint SAVE_STATION_NAME__DigitalInput__ = 9;
const uint CLEAR_IMAGE__DigitalInput__ = 10;
const uint MASTER_LIST_INDEX__AnalogSerialInput__ = 0;
const uint MAX_CHANNEL_LENGTH__AnalogSerialInput__ = 1;
const uint EDIT_STATION_NAME__AnalogSerialInput__ = 2;
const uint USER_FILE_NAME__AnalogSerialInput__ = 3;
const uint MASTER_FILE_NAME__AnalogSerialInput__ = 4;
const uint NEW_CHANNEL_VALUE__AnalogSerialInput__ = 5;
const uint CLEAR_KEYPAD__DigitalOutput__ = 0;
const uint USER_INDEX__AnalogSerialOutput__ = 0;
const uint WORKING_PRESET_INDEX__AnalogSerialOutput__ = 1;
const uint WORKING_PRESET_STATION__AnalogSerialOutput__ = 2;
const uint WORKING_PRESET_IMAGE__AnalogSerialOutput__ = 3;
const uint WORKING_PRESET_CHANNEL__AnalogSerialOutput__ = 4;
const uint SCROLL_BAR__AnalogSerialOutput__ = 5;
const uint USER_ICON__AnalogSerialOutput__ = 6;
const uint USER_CHANNEL__AnalogSerialOutput__ = 33;
const uint USER_STATION__AnalogSerialOutput__ = 60;
const uint MASTER_ICON_INDEX__AnalogSerialOutput__ = 87;
const uint MASTER_STATION__AnalogSerialOutput__ = 96;

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
