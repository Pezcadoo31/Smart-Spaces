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

namespace UserModule_CLA_SCROLLING_FAVS_V1
{
    public class UserModuleClass_CLA_SCROLLING_FAVS_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput READFILE;
        Crestron.Logos.SplusObjects.DigitalInput CATEGORIES;
        Crestron.Logos.SplusObjects.DigitalInput CHANNELS;
        Crestron.Logos.SplusObjects.DigitalInput NEXTLINE;
        Crestron.Logos.SplusObjects.DigitalInput PREVLINE;
        Crestron.Logos.SplusObjects.DigitalInput FIRSTLINE;
        Crestron.Logos.SplusObjects.DigitalInput LASTLINE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LINESEL;
        Crestron.Logos.SplusObjects.StringInput MAINMENUNAME;
        Crestron.Logos.SplusObjects.StringInput ALLCHANNELSNAME;
        Crestron.Logos.SplusObjects.StringInput NVRAM_FILE;
        Crestron.Logos.SplusObjects.AnalogInput FILELOCATION;
        Crestron.Logos.SplusObjects.DigitalOutput USING_FILE;
        Crestron.Logos.SplusObjects.DigitalOutput ENTER;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDCATEGORY__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTIONNUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput FAVSFOUNDLINES;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> LISTHEADER;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> LINE;
        
        
        CrestronString FILENAME;
        CrestronString SBUF;
        CrestronString CBUF;
        CrestronString CLINE;
        CrestronString SLINE;
        CrestronString TEMPSTRING;
        CrestronString [] G_TEMPLINE;
        ushort LINE1INDEX = 0;
        ushort NUMUSEDLINES = 0;
        ushort CATSLINES = 0;
        ushort FAVSLINES = 0;
        ushort FILELINES = 0;
        ushort T_BFORE_ENTER = 0;
        ushort T_ENTER_LNGT = 0;
        ushort CATEGORYLINESEL = 0;
        ushort LISTTYPE = 0;
        ushort DISPLAYEDFAVS = 0;
        ushort G_TEMP_LINES = 0;
        ushort [] SUBINDEX;
        CHANNELSTRUCT [] STRUCTREAD;
        CATEGORIESSTRUCT [] CATEGORIESREAD;
        private void MAKEMENU (  SplusExecutionContext __context__ ) 
            { 
            ushort O = 0;
            
            
            __context__.SourceCodeLine = 222;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NUMUSEDLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( O  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (O  >= __FN_FORSTART_VAL__1) && (O  <= __FN_FOREND_VAL__1) ) : ( (O  <= __FN_FORSTART_VAL__1) && (O  >= __FN_FOREND_VAL__1) ) ; O  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 224;
                LINE [ O]  .UpdateValue ( G_TEMPLINE [ O ]  ) ; 
                __context__.SourceCodeLine = 222;
                } 
            
            
            }
            
        private void ERASEFILE (  SplusExecutionContext __context__ ) 
            { 
            ushort X = 0;
            
            short SIFILE = 0;
            
            CrestronString WRTLINE;
            WRTLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
            
            
            __context__.SourceCodeLine = 233;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 235;
            SIFILE = (short) ( FileOpen( FILENAME ,(ushort) 1 ) ) ; 
            __context__.SourceCodeLine = 237;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)FILELINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 239;
                WRTLINE  .UpdateValue ( "Line : " + Functions.ItoA (  (int) ( X ) ) + "\r\n"  ) ; 
                __context__.SourceCodeLine = 240;
                WriteString (  (short) ( SIFILE ) , WRTLINE ) ; 
                __context__.SourceCodeLine = 237;
                } 
            
            __context__.SourceCodeLine = 242;
            FileClose (  (short) ( SIFILE ) ) ; 
            __context__.SourceCodeLine = 243;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 245;
            Functions.ClearBuffer ( WRTLINE ) ; 
            
            }
            
        private void RELOADFILE (  SplusExecutionContext __context__ ) 
            { 
            ushort W = 0;
            ushort X = 0;
            ushort Y = 0;
            ushort Z = 0;
            
            short SIFILE = 0;
            
            CrestronString [] WRTLINE;
            WRTLINE  = new CrestronString[ 51 ];
            for( uint i = 0; i < 51; i++ )
                WRTLINE [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
            
            
            __context__.SourceCodeLine = 253;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 255;
            SIFILE = (short) ( FileOpen( FILENAME ,(ushort) 1 ) ) ; 
            __context__.SourceCodeLine = 257;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)CATSLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 259;
                WRTLINE [ X ]  .UpdateValue ( Functions.ItoA (  (int) ( CATEGORIESREAD[ X ].NUMBER ) ) + "\u0009" + CATEGORIESREAD [ X] . NOMBRE  ) ; 
                __context__.SourceCodeLine = 257;
                } 
            
            __context__.SourceCodeLine = 261;
            X = (ushort) ( (X + 1) ) ; 
            __context__.SourceCodeLine = 262;
            WRTLINE [ X ]  .UpdateValue ( "FAVS" + "\r\n"  ) ; 
            __context__.SourceCodeLine = 263;
            X = (ushort) ( (X + 1) ) ; 
            __context__.SourceCodeLine = 264;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)FAVSLINES; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( Y  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (Y  >= __FN_FORSTART_VAL__2) && (Y  <= __FN_FOREND_VAL__2) ) : ( (Y  <= __FN_FORSTART_VAL__2) && (Y  >= __FN_FOREND_VAL__2) ) ; Y  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 266;
                WRTLINE [ X ]  .UpdateValue ( STRUCTREAD [ Y] . CANAL + "\u0009" + Functions.ItoA (  (int) ( STRUCTREAD[ Y ].NUMBER ) ) + "\u0009" + Functions.ItoA (  (int) ( STRUCTREAD[ X ].CATEGORY ) ) + "\r\n"  ) ; 
                __context__.SourceCodeLine = 267;
                X = (ushort) ( (X + 1) ) ; 
                __context__.SourceCodeLine = 264;
                } 
            
            __context__.SourceCodeLine = 269;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)X; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( Z  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (Z  >= __FN_FORSTART_VAL__3) && (Z  <= __FN_FOREND_VAL__3) ) : ( (Z  <= __FN_FORSTART_VAL__3) && (Z  >= __FN_FOREND_VAL__3) ) ; Z  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 271;
                WriteString (  (short) ( SIFILE ) , WRTLINE [ Z ] ) ; 
                __context__.SourceCodeLine = 269;
                } 
            
            __context__.SourceCodeLine = 273;
            FileClose (  (short) ( SIFILE ) ) ; 
            __context__.SourceCodeLine = 274;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 276;
            ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__4 = (ushort)X; 
            int __FN_FORSTEP_VAL__4 = (int)1; 
            for ( W  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (W  >= __FN_FORSTART_VAL__4) && (W  <= __FN_FOREND_VAL__4) ) : ( (W  <= __FN_FORSTART_VAL__4) && (W  >= __FN_FOREND_VAL__4) ) ; W  += (ushort)__FN_FORSTEP_VAL__4) 
                { 
                __context__.SourceCodeLine = 278;
                Functions.ClearBuffer ( WRTLINE [ W ] ) ; 
                __context__.SourceCodeLine = 276;
                } 
            
            
            }
            
        object READFILE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort G = 0;
                ushort H = 0;
                ushort J = 0;
                
                short NFILEHANDLE = 0;
                short CBUFFERDONE = 0;
                short BBUFFERDONE = 0;
                short ICHUNKCOUNT = 0;
                short LINECOUNT = 0;
                short CLINECOUNT = 0;
                short CHNLS_POS = 0;
                short I = 0;
                
                CrestronString CATEGORIES__DOLLAR__;
                CrestronString TLINE;
                CATEGORIES__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
                TLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
                
                
                __context__.SourceCodeLine = 295;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)50; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( G  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (G  >= __FN_FORSTART_VAL__1) && (G  <= __FN_FOREND_VAL__1) ) : ( (G  <= __FN_FORSTART_VAL__1) && (G  >= __FN_FOREND_VAL__1) ) ; G  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 297;
                    CATEGORIESREAD [ I] . NUMBER = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 298;
                    CATEGORIESREAD [ I] . NOMBRE  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 295;
                    } 
                
                __context__.SourceCodeLine = 300;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)150; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( H  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (H  >= __FN_FORSTART_VAL__2) && (H  <= __FN_FOREND_VAL__2) ) : ( (H  <= __FN_FORSTART_VAL__2) && (H  >= __FN_FOREND_VAL__2) ) ; H  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 302;
                    STRUCTREAD [ I] . CANAL  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 303;
                    STRUCTREAD [ I] . NUMBER = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 304;
                    STRUCTREAD [ I] . CATEGORY = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 300;
                    } 
                
                __context__.SourceCodeLine = 306;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)G_TEMP_LINES; 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( J  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (J  >= __FN_FORSTART_VAL__3) && (J  <= __FN_FOREND_VAL__3) ) : ( (J  <= __FN_FORSTART_VAL__3) && (J  >= __FN_FOREND_VAL__3) ) ; J  += (ushort)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 308;
                    G_TEMPLINE [ J ]  .UpdateValue ( " "  ) ; 
                    __context__.SourceCodeLine = 306;
                    } 
                
                __context__.SourceCodeLine = 311;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FILELOCATION  .UshortValue == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 312;
                    FILENAME  .UpdateValue ( "\\NVRAM\\" + NVRAM_FILE  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 313;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FILELOCATION  .UshortValue == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 314;
                        FILENAME  .UpdateValue ( "\\CF0\\" + NVRAM_FILE  ) ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 316;
                StartFileOperations ( ) ; 
                __context__.SourceCodeLine = 317;
                USING_FILE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 319;
                NFILEHANDLE = (short) ( FileOpen( FILENAME ,(ushort) 0 ) ) ; 
                __context__.SourceCodeLine = 321;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 324;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FileRead( (short)( NFILEHANDLE ) , SBUF , (ushort)( 10000 ) ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 326;
                        BBUFFERDONE = (short) ( 0 ) ; 
                        __context__.SourceCodeLine = 327;
                        CBUFFERDONE = (short) ( 0 ) ; 
                        __context__.SourceCodeLine = 329;
                        CATEGORIES__DOLLAR__  .UpdateValue ( Functions.Remove ( "FAVS\r\n" , SBUF )  ) ; 
                        __context__.SourceCodeLine = 330;
                        CHNLS_POS = (short) ( Functions.Find( "FAVS" , CATEGORIES__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 331;
                        CBUF  .UpdateValue ( Functions.Left ( CATEGORIES__DOLLAR__ ,  (int) ( CHNLS_POS ) )  ) ; 
                        __context__.SourceCodeLine = 332;
                        CLINECOUNT = (short) ( 0 ) ; 
                        __context__.SourceCodeLine = 335;
                        do 
                            { 
                            __context__.SourceCodeLine = 337;
                            CLINE  .UpdateValue ( Functions.Remove ( "||" , CBUF )  ) ; 
                            __context__.SourceCodeLine = 338;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( CLINE ) == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 340;
                                CBUFFERDONE = (short) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 344;
                                CLINECOUNT = (short) ( (CLINECOUNT + 1) ) ; 
                                __context__.SourceCodeLine = 345;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "//" , CLINE ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 347;
                                    TLINE  .UpdateValue ( Functions.Remove ( "//" , CLINE )  ) ; 
                                    __context__.SourceCodeLine = 348;
                                    CATEGORIESREAD [ CLINECOUNT] . NUMBER = (ushort) ( Functions.Atoi( Functions.Left( CLINE , (int)( (Functions.Find( "\u0009" , CLINE ) - 1) ) ) ) ) ; 
                                    __context__.SourceCodeLine = 349;
                                    TLINE  .UpdateValue ( Functions.Remove ( "\u0009" , CLINE )  ) ; 
                                    __context__.SourceCodeLine = 350;
                                    CATEGORIESREAD [ CLINECOUNT] . NOMBRE  .UpdateValue ( Functions.Left ( CLINE ,  (int) ( (Functions.Find( "||" , CLINE ) - 1) ) )  ) ; 
                                    __context__.SourceCodeLine = 351;
                                    CLINE  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        while (false == ( Functions.TestForTrue  ( CBUFFERDONE) )); 
                        __context__.SourceCodeLine = 357;
                        Functions.ClearBuffer ( CLINE ) ; 
                        __context__.SourceCodeLine = 358;
                        Functions.ClearBuffer ( TLINE ) ; 
                        __context__.SourceCodeLine = 360;
                        CATSLINES = (ushort) ( CLINECOUNT ) ; 
                        __context__.SourceCodeLine = 362;
                        short __FN_FORSTART_VAL__4 = (short) ( (CLINECOUNT + 1) ) ;
                        short __FN_FOREND_VAL__4 = (short)50; 
                        int __FN_FORSTEP_VAL__4 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (I  >= __FN_FORSTART_VAL__4) && (I  <= __FN_FOREND_VAL__4) ) : ( (I  <= __FN_FORSTART_VAL__4) && (I  >= __FN_FOREND_VAL__4) ) ; I  += (short)__FN_FORSTEP_VAL__4) 
                            { 
                            __context__.SourceCodeLine = 364;
                            CATEGORIESREAD [ I] . NUMBER = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 365;
                            CATEGORIESREAD [ I] . NOMBRE  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 362;
                            } 
                        
                        __context__.SourceCodeLine = 369;
                        LINECOUNT = (short) ( 0 ) ; 
                        __context__.SourceCodeLine = 372;
                        do 
                            { 
                            __context__.SourceCodeLine = 374;
                            SLINE  .UpdateValue ( Functions.Remove ( "||" , SBUF )  ) ; 
                            __context__.SourceCodeLine = 375;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SLINE ) == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 377;
                                BBUFFERDONE = (short) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 382;
                                LINECOUNT = (short) ( (LINECOUNT + 1) ) ; 
                                __context__.SourceCodeLine = 384;
                                TLINE  .UpdateValue ( Functions.Remove ( "//" , SLINE )  ) ; 
                                __context__.SourceCodeLine = 385;
                                STRUCTREAD [ LINECOUNT] . CANAL  .UpdateValue ( Functions.Left ( SLINE ,  (int) ( (Functions.Find( "\u0009" , SLINE ) - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 386;
                                TLINE  .UpdateValue ( Functions.Remove ( "\u0009" , SLINE )  ) ; 
                                __context__.SourceCodeLine = 387;
                                STRUCTREAD [ LINECOUNT] . NUMBER = (ushort) ( Functions.Atoi( Functions.Left( SLINE , (int)( (Functions.Find( "\u0009)" , SLINE ) - 1) ) ) ) ) ; 
                                __context__.SourceCodeLine = 388;
                                TLINE  .UpdateValue ( Functions.Remove ( "\u0009" , SLINE )  ) ; 
                                __context__.SourceCodeLine = 389;
                                STRUCTREAD [ LINECOUNT] . CATEGORY = (ushort) ( Functions.Atoi( Functions.Left( SLINE , (int)( (Functions.Find( "||)" , SLINE ) - 1) ) ) ) ) ; 
                                __context__.SourceCodeLine = 390;
                                SLINE  .UpdateValue ( ""  ) ; 
                                } 
                            
                            } 
                        while (false == ( Functions.TestForTrue  ( BBUFFERDONE) )); 
                        __context__.SourceCodeLine = 395;
                        Functions.ClearBuffer ( SLINE ) ; 
                        __context__.SourceCodeLine = 396;
                        Functions.ClearBuffer ( TLINE ) ; 
                        __context__.SourceCodeLine = 398;
                        FAVSLINES = (ushort) ( LINECOUNT ) ; 
                        __context__.SourceCodeLine = 399;
                        FAVSFOUNDLINES  .Value = (ushort) ( FAVSLINES ) ; 
                        __context__.SourceCodeLine = 400;
                        short __FN_FORSTART_VAL__5 = (short) ( (LINECOUNT + 1) ) ;
                        short __FN_FOREND_VAL__5 = (short)150; 
                        int __FN_FORSTEP_VAL__5 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (I  >= __FN_FORSTART_VAL__5) && (I  <= __FN_FOREND_VAL__5) ) : ( (I  <= __FN_FORSTART_VAL__5) && (I  >= __FN_FOREND_VAL__5) ) ; I  += (short)__FN_FORSTEP_VAL__5) 
                            { 
                            __context__.SourceCodeLine = 402;
                            STRUCTREAD [ I] . CANAL  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 403;
                            STRUCTREAD [ I] . NUMBER = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 404;
                            STRUCTREAD [ I] . CATEGORY = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 400;
                            } 
                        
                        __context__.SourceCodeLine = 408;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 410;
                            Print( "Error closing file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 411;
                        FILELINES = (ushort) ( ((CATSLINES + 1) + FAVSLINES) ) ; 
                        __context__.SourceCodeLine = 324;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 416;
                EndFileOperations ( ) ; 
                __context__.SourceCodeLine = 417;
                USING_FILE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 419;
                Functions.ClearBuffer ( SBUF ) ; 
                __context__.SourceCodeLine = 420;
                Functions.ClearBuffer ( CBUF ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CHANNELS_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort N = 0;
            
            
            __context__.SourceCodeLine = 428;
            LISTHEADER [ 1]  .UpdateValue ( ALLCHANNELSNAME  ) ; 
            __context__.SourceCodeLine = 429;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)FAVSLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( N  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (N  >= __FN_FORSTART_VAL__1) && (N  <= __FN_FOREND_VAL__1) ) : ( (N  <= __FN_FORSTART_VAL__1) && (N  >= __FN_FOREND_VAL__1) ) ; N  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 431;
                G_TEMPLINE [ N ]  .UpdateValue ( STRUCTREAD [ N] . CANAL  ) ; 
                __context__.SourceCodeLine = 432;
                SUBINDEX [ N] = (ushort) ( N ) ; 
                __context__.SourceCodeLine = 429;
                } 
            
            __context__.SourceCodeLine = 434;
            G_TEMP_LINES = (ushort) ( FAVSLINES ) ; 
            __context__.SourceCodeLine = 435;
            DISPLAYEDFAVS = (ushort) ( FAVSLINES ) ; 
            __context__.SourceCodeLine = 436;
            MAKEMENU (  __context__  ) ; 
            __context__.SourceCodeLine = 437;
            LINE1INDEX = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 438;
            LISTTYPE = (ushort) ( 2 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CATEGORIES_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort N = 0;
        ushort M = 0;
        
        
        __context__.SourceCodeLine = 444;
        LISTHEADER [ 1]  .UpdateValue ( MAINMENUNAME  ) ; 
        __context__.SourceCodeLine = 445;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)CATSLINES; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( N  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (N  >= __FN_FORSTART_VAL__1) && (N  <= __FN_FOREND_VAL__1) ) : ( (N  <= __FN_FORSTART_VAL__1) && (N  >= __FN_FOREND_VAL__1) ) ; N  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 447;
            G_TEMPLINE [ N ]  .UpdateValue ( CATEGORIESREAD [ N] . NOMBRE  ) ; 
            __context__.SourceCodeLine = 448;
            SUBINDEX [ N] = (ushort) ( N ) ; 
            __context__.SourceCodeLine = 445;
            } 
        
        __context__.SourceCodeLine = 450;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CATSLINES < NUMUSEDLINES ))  ) ) 
            { 
            __context__.SourceCodeLine = 452;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( (CATSLINES + 1) ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)NUMUSEDLINES; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( M  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (M  >= __FN_FORSTART_VAL__2) && (M  <= __FN_FOREND_VAL__2) ) : ( (M  <= __FN_FORSTART_VAL__2) && (M  >= __FN_FOREND_VAL__2) ) ; M  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 454;
                G_TEMPLINE [ M ]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 452;
                } 
            
            } 
        
        __context__.SourceCodeLine = 457;
        G_TEMP_LINES = (ushort) ( CATSLINES ) ; 
        __context__.SourceCodeLine = 458;
        MAKEMENU (  __context__  ) ; 
        __context__.SourceCodeLine = 459;
        LINE1INDEX = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 460;
        LISTTYPE = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXTLINE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort O = 0;
        ushort IND = 0;
        
        
        __context__.SourceCodeLine = 467;
        O = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 468;
        IND = (ushort) ( LINE1INDEX ) ; 
        __context__.SourceCodeLine = 470;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE1INDEX <= (G_TEMP_LINES - NUMUSEDLINES) ))  ) ) 
            { 
            __context__.SourceCodeLine = 472;
            LINE1INDEX = (ushort) ( (LINE1INDEX + 1) ) ; 
            __context__.SourceCodeLine = 473;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NUMUSEDLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( O  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (O  >= __FN_FORSTART_VAL__1) && (O  <= __FN_FOREND_VAL__1) ) : ( (O  <= __FN_FORSTART_VAL__1) && (O  >= __FN_FOREND_VAL__1) ) ; O  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 475;
                IND = (ushort) ( (IND + 1) ) ; 
                __context__.SourceCodeLine = 476;
                LINE [ O]  .UpdateValue ( G_TEMPLINE [ IND ]  ) ; 
                __context__.SourceCodeLine = 473;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREVLINE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort O = 0;
        ushort IND = 0;
        
        
        __context__.SourceCodeLine = 484;
        O = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 485;
        IND = (ushort) ( LINE1INDEX ) ; 
        __context__.SourceCodeLine = 487;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE1INDEX > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 489;
            IND = (ushort) ( (IND - 1) ) ; 
            __context__.SourceCodeLine = 490;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NUMUSEDLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( O  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (O  >= __FN_FORSTART_VAL__1) && (O  <= __FN_FOREND_VAL__1) ) : ( (O  <= __FN_FORSTART_VAL__1) && (O  >= __FN_FOREND_VAL__1) ) ; O  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 492;
                LINE [ O]  .UpdateValue ( G_TEMPLINE [ IND ]  ) ; 
                __context__.SourceCodeLine = 493;
                IND = (ushort) ( (IND + 1) ) ; 
                __context__.SourceCodeLine = 490;
                } 
            
            __context__.SourceCodeLine = 496;
            LINE1INDEX = (ushort) ( (LINE1INDEX - 1) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FIRSTLINE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort O = 0;
        ushort IND = 0;
        
        
        __context__.SourceCodeLine = 503;
        O = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 505;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE1INDEX > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 507;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NUMUSEDLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( O  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (O  >= __FN_FORSTART_VAL__1) && (O  <= __FN_FOREND_VAL__1) ) : ( (O  <= __FN_FORSTART_VAL__1) && (O  >= __FN_FOREND_VAL__1) ) ; O  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 509;
                LINE [ O]  .UpdateValue ( G_TEMPLINE [ O ]  ) ; 
                __context__.SourceCodeLine = 507;
                } 
            
            __context__.SourceCodeLine = 512;
            LINE1INDEX = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LASTLINE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort O = 0;
        ushort IND = 0;
        
        
        __context__.SourceCodeLine = 518;
        O = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 520;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LINE1INDEX <= (G_TEMP_LINES - NUMUSEDLINES) ))  ) ) 
            { 
            __context__.SourceCodeLine = 522;
            LINE1INDEX = (ushort) ( (G_TEMP_LINES - NUMUSEDLINES) ) ; 
            __context__.SourceCodeLine = 523;
            IND = (ushort) ( LINE1INDEX ) ; 
            __context__.SourceCodeLine = 524;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NUMUSEDLINES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( O  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (O  >= __FN_FORSTART_VAL__1) && (O  <= __FN_FOREND_VAL__1) ) : ( (O  <= __FN_FORSTART_VAL__1) && (O  >= __FN_FOREND_VAL__1) ) ; O  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 526;
                IND = (ushort) ( (IND + 1) ) ; 
                __context__.SourceCodeLine = 527;
                LINE [ O]  .UpdateValue ( G_TEMPLINE [ IND ]  ) ; 
                __context__.SourceCodeLine = 524;
                } 
            
            __context__.SourceCodeLine = 529;
            LINE1INDEX = (ushort) ( ((G_TEMP_LINES - NUMUSEDLINES) + 1) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINESEL_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort N = 0;
        ushort L = 0;
        ushort I = 0;
        ushort CNT = 0;
        ushort CATEGORYSEL = 0;
        
        
        __context__.SourceCodeLine = 537;
        CATEGORYLINESEL = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 538;
        N = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 539;
        CNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 540;
        L = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 542;
        CATEGORYSEL = (ushort) ( ((LINE1INDEX + CATEGORYLINESEL) - 1) ) ; 
        __context__.SourceCodeLine = 544;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)LISTTYPE);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 549;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CATEGORYSEL <= CATSLINES ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 551;
                        do 
                            { 
                            __context__.SourceCodeLine = 552;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STRUCTREAD[ N ].CATEGORY == CATEGORYSEL))  ) ) 
                                { 
                                __context__.SourceCodeLine = 554;
                                G_TEMPLINE [ L ]  .UpdateValue ( STRUCTREAD [ N] . CANAL  ) ; 
                                __context__.SourceCodeLine = 555;
                                SUBINDEX [ L] = (ushort) ( N ) ; 
                                __context__.SourceCodeLine = 556;
                                CNT = (ushort) ( (CNT + 1) ) ; 
                                __context__.SourceCodeLine = 557;
                                L = (ushort) ( (L + 1) ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 559;
                            N = (ushort) ( (N + 1) ) ; 
                            } 
                        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (N == (FAVSLINES + 1))) )); 
                        __context__.SourceCodeLine = 562;
                        LINE1INDEX = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 563;
                        DISPLAYEDFAVS = (ushort) ( CNT ) ; 
                        __context__.SourceCodeLine = 564;
                        G_TEMP_LINES = (ushort) ( DISPLAYEDFAVS ) ; 
                        __context__.SourceCodeLine = 565;
                        LISTHEADER [ 1]  .UpdateValue ( CATEGORIESREAD [ CATEGORYSEL] . NOMBRE  ) ; 
                        __context__.SourceCodeLine = 567;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CNT < (NUMUSEDLINES + 1) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 569;
                            ushort __FN_FORSTART_VAL__1 = (ushort) ( (CNT + 1) ) ;
                            ushort __FN_FOREND_VAL__1 = (ushort)NUMUSEDLINES; 
                            int __FN_FORSTEP_VAL__1 = (int)1; 
                            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                                {
                                __context__.SourceCodeLine = 570;
                                G_TEMPLINE [ I ]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 569;
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 572;
                        MAKEMENU (  __context__  ) ; 
                        __context__.SourceCodeLine = 573;
                        LISTTYPE = (ushort) ( 2 ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 578;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CATEGORYLINESEL <= DISPLAYEDFAVS ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 580;
                        SELECTEDNAME__DOLLAR__  .UpdateValue ( STRUCTREAD [ SUBINDEX[ CATEGORYSEL ]] . CANAL  ) ; 
                        __context__.SourceCodeLine = 581;
                        SELECTIONNUMBER  .Value = (ushort) ( STRUCTREAD[ SUBINDEX[ CATEGORYSEL ] ].NUMBER ) ; 
                        __context__.SourceCodeLine = 583;
                        SELECTEDCATEGORY__DOLLAR__  .UpdateValue ( CATEGORIESREAD [ STRUCTREAD[ SUBINDEX[ CATEGORYSEL ] ].CATEGORY] . NOMBRE  ) ; 
                        __context__.SourceCodeLine = 584;
                        Functions.Delay (  (int) ( T_BFORE_ENTER ) ) ; 
                        __context__.SourceCodeLine = 585;
                        ENTER  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 586;
                        Functions.Delay (  (int) ( T_ENTER_LNGT ) ) ; 
                        __context__.SourceCodeLine = 587;
                        ENTER  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                } 
                
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
        
        __context__.SourceCodeLine = 610;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 614;
        NUMUSEDLINES = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 616;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 11 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1; 
        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
        for ( NUMUSEDLINES  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NUMUSEDLINES  >= __FN_FORSTART_VAL__1) && (NUMUSEDLINES  <= __FN_FOREND_VAL__1) ) : ( (NUMUSEDLINES  <= __FN_FORSTART_VAL__1) && (NUMUSEDLINES  >= __FN_FOREND_VAL__1) ) ; NUMUSEDLINES  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 618;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( LINE[ NUMUSEDLINES ] ))  ) ) 
                {
                __context__.SourceCodeLine = 619;
                break ; 
                }
            
            __context__.SourceCodeLine = 616;
            } 
        
        __context__.SourceCodeLine = 623;
        T_BFORE_ENTER = (ushort) ( (1 * 1) ) ; 
        __context__.SourceCodeLine = 624;
        T_ENTER_LNGT = (ushort) ( (1 * 1) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SUBINDEX  = new ushort[ 151 ];
    FILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    SBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    CBUF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    CLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    SLINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    G_TEMPLINE  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        G_TEMPLINE [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    STRUCTREAD  = new CHANNELSTRUCT[ 151 ];
    for( uint i = 0; i < 151; i++ )
    {
        STRUCTREAD [i] = new CHANNELSTRUCT( this, true );
        STRUCTREAD [i].PopulateCustomAttributeList( false );
        
    }
    CATEGORIESREAD  = new CATEGORIESSTRUCT[ 51 ];
    for( uint i = 0; i < 51; i++ )
    {
        CATEGORIESREAD [i] = new CATEGORIESSTRUCT( this, true );
        CATEGORIESREAD [i].PopulateCustomAttributeList( false );
        
    }
    
    READFILE = new Crestron.Logos.SplusObjects.DigitalInput( READFILE__DigitalInput__, this );
    m_DigitalInputList.Add( READFILE__DigitalInput__, READFILE );
    
    CATEGORIES = new Crestron.Logos.SplusObjects.DigitalInput( CATEGORIES__DigitalInput__, this );
    m_DigitalInputList.Add( CATEGORIES__DigitalInput__, CATEGORIES );
    
    CHANNELS = new Crestron.Logos.SplusObjects.DigitalInput( CHANNELS__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNELS__DigitalInput__, CHANNELS );
    
    NEXTLINE = new Crestron.Logos.SplusObjects.DigitalInput( NEXTLINE__DigitalInput__, this );
    m_DigitalInputList.Add( NEXTLINE__DigitalInput__, NEXTLINE );
    
    PREVLINE = new Crestron.Logos.SplusObjects.DigitalInput( PREVLINE__DigitalInput__, this );
    m_DigitalInputList.Add( PREVLINE__DigitalInput__, PREVLINE );
    
    FIRSTLINE = new Crestron.Logos.SplusObjects.DigitalInput( FIRSTLINE__DigitalInput__, this );
    m_DigitalInputList.Add( FIRSTLINE__DigitalInput__, FIRSTLINE );
    
    LASTLINE = new Crestron.Logos.SplusObjects.DigitalInput( LASTLINE__DigitalInput__, this );
    m_DigitalInputList.Add( LASTLINE__DigitalInput__, LASTLINE );
    
    LINESEL = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LINESEL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LINESEL__DigitalInput__ + i, LINESEL__DigitalInput__, this );
        m_DigitalInputList.Add( LINESEL__DigitalInput__ + i, LINESEL[i+1] );
    }
    
    USING_FILE = new Crestron.Logos.SplusObjects.DigitalOutput( USING_FILE__DigitalOutput__, this );
    m_DigitalOutputList.Add( USING_FILE__DigitalOutput__, USING_FILE );
    
    ENTER = new Crestron.Logos.SplusObjects.DigitalOutput( ENTER__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENTER__DigitalOutput__, ENTER );
    
    FILELOCATION = new Crestron.Logos.SplusObjects.AnalogInput( FILELOCATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FILELOCATION__AnalogSerialInput__, FILELOCATION );
    
    SELECTIONNUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTIONNUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTIONNUMBER__AnalogSerialOutput__, SELECTIONNUMBER );
    
    FAVSFOUNDLINES = new Crestron.Logos.SplusObjects.AnalogOutput( FAVSFOUNDLINES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FAVSFOUNDLINES__AnalogSerialOutput__, FAVSFOUNDLINES );
    
    MAINMENUNAME = new Crestron.Logos.SplusObjects.StringInput( MAINMENUNAME__AnalogSerialInput__, 20, this );
    m_StringInputList.Add( MAINMENUNAME__AnalogSerialInput__, MAINMENUNAME );
    
    ALLCHANNELSNAME = new Crestron.Logos.SplusObjects.StringInput( ALLCHANNELSNAME__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( ALLCHANNELSNAME__AnalogSerialInput__, ALLCHANNELSNAME );
    
    NVRAM_FILE = new Crestron.Logos.SplusObjects.StringInput( NVRAM_FILE__AnalogSerialInput__, 30, this );
    m_StringInputList.Add( NVRAM_FILE__AnalogSerialInput__, NVRAM_FILE );
    
    SELECTEDNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDNAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDNAME__DOLLAR____AnalogSerialOutput__, SELECTEDNAME__DOLLAR__ );
    
    SELECTEDCATEGORY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDCATEGORY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDCATEGORY__DOLLAR____AnalogSerialOutput__, SELECTEDCATEGORY__DOLLAR__ );
    
    LISTHEADER = new InOutArray<StringOutput>( 1, this );
    for( uint i = 0; i < 1; i++ )
    {
        LISTHEADER[i+1] = new Crestron.Logos.SplusObjects.StringOutput( LISTHEADER__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( LISTHEADER__AnalogSerialOutput__ + i, LISTHEADER[i+1] );
    }
    
    LINE = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LINE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( LINE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( LINE__AnalogSerialOutput__ + i, LINE[i+1] );
    }
    
    
    READFILE.OnDigitalPush.Add( new InputChangeHandlerWrapper( READFILE_OnPush_0, false ) );
    CHANNELS.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNELS_OnPush_1, false ) );
    CATEGORIES.OnDigitalPush.Add( new InputChangeHandlerWrapper( CATEGORIES_OnPush_2, false ) );
    NEXTLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXTLINE_OnPush_3, false ) );
    PREVLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREVLINE_OnPush_4, false ) );
    FIRSTLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FIRSTLINE_OnPush_5, false ) );
    LASTLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LASTLINE_OnPush_6, false ) );
    for( uint i = 0; i < 10; i++ )
        LINESEL[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( LINESEL_OnPush_7, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CLA_SCROLLING_FAVS_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint READFILE__DigitalInput__ = 0;
const uint CATEGORIES__DigitalInput__ = 1;
const uint CHANNELS__DigitalInput__ = 2;
const uint NEXTLINE__DigitalInput__ = 3;
const uint PREVLINE__DigitalInput__ = 4;
const uint FIRSTLINE__DigitalInput__ = 5;
const uint LASTLINE__DigitalInput__ = 6;
const uint LINESEL__DigitalInput__ = 7;
const uint MAINMENUNAME__AnalogSerialInput__ = 0;
const uint ALLCHANNELSNAME__AnalogSerialInput__ = 1;
const uint NVRAM_FILE__AnalogSerialInput__ = 2;
const uint FILELOCATION__AnalogSerialInput__ = 3;
const uint USING_FILE__DigitalOutput__ = 0;
const uint ENTER__DigitalOutput__ = 1;
const uint SELECTEDNAME__DOLLAR____AnalogSerialOutput__ = 0;
const uint SELECTEDCATEGORY__DOLLAR____AnalogSerialOutput__ = 1;
const uint SELECTIONNUMBER__AnalogSerialOutput__ = 2;
const uint FAVSFOUNDLINES__AnalogSerialOutput__ = 3;
const uint LISTHEADER__AnalogSerialOutput__ = 4;
const uint LINE__AnalogSerialOutput__ = 5;

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

[SplusStructAttribute(-1, true, false)]
public class CHANNELSTRUCT : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  CANAL;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  NUMBER = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  CATEGORY = 0;
    
    
    public CHANNELSTRUCT( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        CANAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class CATEGORIESSTRUCT : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  NUMBER = 0;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  NOMBRE;
    
    
    public CATEGORIESSTRUCT( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        NOMBRE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        
        
    }
    
}

}
