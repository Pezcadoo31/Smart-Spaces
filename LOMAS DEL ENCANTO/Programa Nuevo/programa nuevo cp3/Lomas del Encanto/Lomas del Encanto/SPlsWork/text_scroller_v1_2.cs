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

namespace UserModule_TEXT_SCROLLER_V1_2
{
    public class UserModuleClass_TEXT_SCROLLER_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DISCROLLUP;
        Crestron.Logos.SplusObjects.DigitalInput DISCROLLDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DIPAGEUP;
        Crestron.Logos.SplusObjects.DigitalInput DIPAGEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DITOPOFLIST;
        Crestron.Logos.SplusObjects.DigitalInput DIBOTTOMOFLIST;
        Crestron.Logos.SplusObjects.DigitalInput DIRESETSELECTED;
        Crestron.Logos.SplusObjects.DigitalInput DISELECTHIGHLIGHTEDITEM;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DISELECTITEMINWINDOW;
        Crestron.Logos.SplusObjects.AnalogInput AIPAGESIZE;
        Crestron.Logos.SplusObjects.AnalogInput AISCROLLBAR;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> AIITEMIMAGE;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIITEMTEXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIITEMSTATUS1__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIITEMSTATUS2__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOACTUALITEMSELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOHIGHLIGHTBAR;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOLINESELECTED;
        Crestron.Logos.SplusObjects.AnalogOutput AOSCROLLBARF;
        Crestron.Logos.SplusObjects.AnalogOutput AOBUTTONSELECT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> AOITEMIMAGEWINDOW;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOITEMTEXTWINDOW__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOITEMSTATUS1WINDOW__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOITEMSTATUS2WINDOW__DOLLAR__;
        ushort G_INUMBERITEMS = 0;
        ushort G_IACTUALITEMHIGHLIGHTEDNUM = 0;
        ushort G_IBARPOSITIONINWINDOW = 0;
        ushort G_IITEMNUMBERATTOPOFWINDOW = 0;
        ushort G_IPAGESIZE = 0;
        private ushort MOVEHIGHLIGHTBARTO (  SplusExecutionContext __context__, ushort POSITION ) 
            { 
            
            __context__.SourceCodeLine = 59;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((G_IITEMNUMBERATTOPOFWINDOW + POSITION) - 1) > G_INUMBERITEMS ))  ) ) 
                {
                __context__.SourceCodeLine = 60;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 62;
            DOHIGHLIGHTBAR [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 63;
            G_IBARPOSITIONINWINDOW = (ushort) ( POSITION ) ; 
            __context__.SourceCodeLine = 64;
            DOHIGHLIGHTBAR [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 66;
            return (ushort)( 1) ; 
            
            }
            
        private void SHOWBUTTONSELECT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 72;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS <= 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 73;
                AOBUTTONSELECT  .Value = (ushort) ( 0 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 75;
                AOBUTTONSELECT  .Value = (ushort) ( 1 ) ; 
                }
            
            
            }
            
        private void UPDATESCROLLBARFB (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 81;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS <= 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 82;
                AOSCROLLBARF  .Value = (ushort) ( 65535 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 84;
                AOSCROLLBARF  .Value = (ushort) ( (65535 - Functions.MulDiv( (ushort)( (G_IACTUALITEMHIGHLIGHTEDNUM - 1) ) , (ushort)( 65535 ) , (ushort)( (G_INUMBERITEMS - 1) ) )) ) ; 
                }
            
            
            }
            
        private void GOTOTOP (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 91;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 92;
            UPDATESCROLLBARFB (  __context__  ) ; 
            __context__.SourceCodeLine = 95;
            MOVEHIGHLIGHTBARTO (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 98;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
            
            }
            
        private void RESENDTEXT (  SplusExecutionContext __context__, ushort LASTMODIFIED , ushort TEXTORIMAGE ) 
            { 
            ushort UPPERBOUND = 0;
            
            
            __context__.SourceCodeLine = 105;
            UPPERBOUND = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) - 1) ) ; 
            __context__.SourceCodeLine = 106;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( UPPERBOUND > 50 ))  ) ) 
                { 
                __context__.SourceCodeLine = 108;
                UPPERBOUND = (ushort) ( 50 ) ; 
                } 
            
            __context__.SourceCodeLine = 111;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( LASTMODIFIED >= G_IITEMNUMBERATTOPOFWINDOW ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LASTMODIFIED <= UPPERBOUND ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 113;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEXTORIMAGE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 115;
                    SOITEMTEXTWINDOW__DOLLAR__ [ ((LASTMODIFIED - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMTEXT__DOLLAR__ [ LASTMODIFIED ]  ) ; 
                    __context__.SourceCodeLine = 116;
                    SOITEMSTATUS1WINDOW__DOLLAR__ [ ((LASTMODIFIED - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMSTATUS1__DOLLAR__ [ LASTMODIFIED ]  ) ; 
                    __context__.SourceCodeLine = 117;
                    SOITEMSTATUS2WINDOW__DOLLAR__ [ ((LASTMODIFIED - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMSTATUS2__DOLLAR__ [ LASTMODIFIED ]  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 119;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEXTORIMAGE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 122;
                        AOITEMIMAGEWINDOW [ ((LASTMODIFIED - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .Value = (ushort) ( AIITEMIMAGE[ LASTMODIFIED ] .UshortValue ) ; 
                        } 
                    
                    }
                
                } 
            
            
            }
            
        private void REDRAWWINDOW (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort UPPERBOUND = 0;
            
            
            __context__.SourceCodeLine = 133;
            UPPERBOUND = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) - 1) ) ; 
            __context__.SourceCodeLine = 135;
            
            __context__.SourceCodeLine = 138;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( UPPERBOUND > 50 ))  ) ) 
                { 
                __context__.SourceCodeLine = 140;
                UPPERBOUND = (ushort) ( 50 ) ; 
                } 
            
            __context__.SourceCodeLine = 143;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( G_IITEMNUMBERATTOPOFWINDOW ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)UPPERBOUND; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 145;
                AOITEMIMAGEWINDOW [ ((I - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .Value = (ushort) ( AIITEMIMAGE[ I ] .UshortValue ) ; 
                __context__.SourceCodeLine = 146;
                SOITEMTEXTWINDOW__DOLLAR__ [ ((I - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMTEXT__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 147;
                SOITEMSTATUS1WINDOW__DOLLAR__ [ ((I - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMSTATUS1__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 148;
                SOITEMSTATUS2WINDOW__DOLLAR__ [ ((I - G_IITEMNUMBERATTOPOFWINDOW) + 1)]  .UpdateValue ( SIITEMSTATUS2__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 143;
                } 
            
            
            }
            
        object DISELECTITEMINWINDOW_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 156;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 157;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 160;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 161;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 164;
                Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
                __context__.SourceCodeLine = 165;
                DOACTUALITEMSELECTED [ G_IACTUALITEMHIGHLIGHTEDNUM]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 171;
                Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
                __context__.SourceCodeLine = 172;
                DOLINESELECTED [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DISELECTHIGHLIGHTEDITEM_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 178;
            Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
            __context__.SourceCodeLine = 179;
            DOACTUALITEMSELECTED [ G_IACTUALITEMHIGHLIGHTEDNUM]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 185;
            Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
            __context__.SourceCodeLine = 186;
            DOLINESELECTED [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SIITEMTEXT__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEM = 0;
        
        ushort FOUND = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 202;
        ITEM = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 204;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SIITEMTEXT__DOLLAR__[ ITEM ] ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 206;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEM > G_INUMBERITEMS ))  ) ) 
                { 
                __context__.SourceCodeLine = 208;
                G_INUMBERITEMS = (ushort) ( ITEM ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 213;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM == G_INUMBERITEMS))  ) ) 
                { 
                __context__.SourceCodeLine = 215;
                FOUND = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 216;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( G_INUMBERITEMS ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 218;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SIITEMTEXT__DOLLAR__[ I ] ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 220;
                        G_INUMBERITEMS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 221;
                        FOUND = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 222;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 216;
                    } 
                
                __context__.SourceCodeLine = 226;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FOUND == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 228;
                    G_INUMBERITEMS = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            } 
        
        __context__.SourceCodeLine = 233;
        RESENDTEXT (  __context__ , (ushort)( ITEM ), (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 234;
        UPDATESCROLLBARFB (  __context__  ) ; 
        __context__.SourceCodeLine = 235;
        SHOWBUTTONSELECT (  __context__  ) ; 
        __context__.SourceCodeLine = 237;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS > 50 ))  ) ) 
            {
            __context__.SourceCodeLine = 238;
            GenerateUserError ( "Number of items to scroll list ({0:d}) exceeds maximum of {1:d}!", (ushort)G_INUMBERITEMS, (ushort)50) ; 
            }
        
        __context__.SourceCodeLine = 240;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRESETSELECTED_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 247;
        Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 248;
        Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 250;
        GOTOTOP (  __context__  ) ; 
        __context__.SourceCodeLine = 251;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCROLLUP_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IPREVIOUSACTUALITEMHIGHLIGHTED = 0;
        
        
        __context__.SourceCodeLine = 258;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBARPOSITIONINWINDOW > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 261;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( (G_IBARPOSITIONINWINDOW - 1) ) ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 262;
                return  this ; 
                }
            
            __context__.SourceCodeLine = 265;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
            __context__.SourceCodeLine = 266;
            UPDATESCROLLBARFB (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 268;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IITEMNUMBERATTOPOFWINDOW > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 272;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW - 1) ) ; 
                __context__.SourceCodeLine = 273;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 274;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 275;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 278;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCROLLDOWN_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 285;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IBARPOSITIONINWINDOW < G_IPAGESIZE ))  ) ) 
            { 
            __context__.SourceCodeLine = 288;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( (G_IBARPOSITIONINWINDOW + 1) ) ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 289;
                return  this ; 
                }
            
            __context__.SourceCodeLine = 292;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
            __context__.SourceCodeLine = 293;
            UPDATESCROLLBARFB (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 295;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) <= G_INUMBERITEMS ))  ) ) 
                { 
                __context__.SourceCodeLine = 299;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW + 1) ) ; 
                __context__.SourceCodeLine = 300;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 301;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 302;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 305;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIPAGEUP_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort CURRENTITEMHIGHLIGHTED = 0;
        
        
        __context__.SourceCodeLine = 314;
        CURRENTITEMHIGHLIGHTED = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
        __context__.SourceCodeLine = 318;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IITEMNUMBERATTOPOFWINDOW > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 321;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (CURRENTITEMHIGHLIGHTED - G_IPAGESIZE) > (G_IBARPOSITIONINWINDOW - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 323;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW - G_IPAGESIZE) ) ; 
                __context__.SourceCodeLine = 324;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 325;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 326;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 333;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 334;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 335;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 336;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 339;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENTITEMHIGHLIGHTED > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 343;
                MOVEHIGHLIGHTBARTO (  __context__ , (ushort)( 1 )) ; 
                __context__.SourceCodeLine = 346;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 347;
                UPDATESCROLLBARFB (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 350;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIPAGEDOWN_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort CURRENTITEMHIGHLIGHTED = 0;
        
        
        __context__.SourceCodeLine = 358;
        CURRENTITEMHIGHLIGHTED = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
        __context__.SourceCodeLine = 362;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) <= G_INUMBERITEMS ))  ) ) 
            { 
            __context__.SourceCodeLine = 365;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_INUMBERITEMS - (CURRENTITEMHIGHLIGHTED + G_IPAGESIZE)) >= (G_IPAGESIZE - G_IBARPOSITIONINWINDOW) ))  ) ) 
                { 
                __context__.SourceCodeLine = 367;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( (G_IITEMNUMBERATTOPOFWINDOW + G_IPAGESIZE) ) ; 
                __context__.SourceCodeLine = 368;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 369;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 370;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 377;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((G_INUMBERITEMS - G_IPAGESIZE) + 1) ) ; 
                __context__.SourceCodeLine = 378;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 379;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 380;
                REDRAWWINDOW (  __context__  ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 383;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CURRENTITEMHIGHLIGHTED < G_INUMBERITEMS ))  ) ) 
                { 
                __context__.SourceCodeLine = 387;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( Functions.Min( G_INUMBERITEMS , G_IPAGESIZE ) ) ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 388;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 391;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
                __context__.SourceCodeLine = 392;
                UPDATESCROLLBARFB (  __context__  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 395;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DITOPOFLIST_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 402;
        GOTOTOP (  __context__  ) ; 
        __context__.SourceCodeLine = 403;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIBOTTOMOFLIST_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 408;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( Functions.Min( G_INUMBERITEMS , G_IPAGESIZE ) ) ) == 0))  ) ) 
            {
            __context__.SourceCodeLine = 409;
            return  this ; 
            }
        
        __context__.SourceCodeLine = 411;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_INUMBERITEMS < G_IPAGESIZE ))  ) ) 
            {
            __context__.SourceCodeLine = 412;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 414;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((G_INUMBERITEMS - G_IPAGESIZE) + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 416;
        G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( ((G_IITEMNUMBERATTOPOFWINDOW + G_IBARPOSITIONINWINDOW) - 1) ) ; 
        __context__.SourceCodeLine = 417;
        UPDATESCROLLBARFB (  __context__  ) ; 
        __context__.SourceCodeLine = 418;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AISCROLLBAR_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort OUTVAL = 0;
        
        short NUMITEMSNEEDEDABOVE = 0;
        short NUMITEMSNEEDEDBELOW = 0;
        
        short NUMITEMSAVAILABOVE = 0;
        short NUMITEMSAVAILBELOW = 0;
        
        
        __context__.SourceCodeLine = 428;
        OUTVAL = (ushort) ( (1 + Functions.MulDiv( (ushort)( (65535 - AISCROLLBAR  .UshortValue) ) , (ushort)( (G_INUMBERITEMS - 1) ) , (ushort)( 65535 ) )) ) ; 
        __context__.SourceCodeLine = 429;
        NUMITEMSAVAILABOVE = (short) ( (OUTVAL - 1) ) ; 
        __context__.SourceCodeLine = 430;
        NUMITEMSNEEDEDABOVE = (short) ( (G_IBARPOSITIONINWINDOW - 1) ) ; 
        __context__.SourceCodeLine = 431;
        NUMITEMSAVAILBELOW = (short) ( (G_INUMBERITEMS - OUTVAL) ) ; 
        __context__.SourceCodeLine = 432;
        NUMITEMSNEEDEDBELOW = (short) ( (G_IPAGESIZE - G_IBARPOSITIONINWINDOW) ) ; 
        __context__.SourceCodeLine = 434;
        
        __context__.SourceCodeLine = 439;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NUMITEMSAVAILABOVE >= NUMITEMSNEEDEDABOVE ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NUMITEMSAVAILBELOW >= NUMITEMSNEEDEDBELOW ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 442;
            G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((OUTVAL - G_IBARPOSITIONINWINDOW) + 1) ) ; 
            __context__.SourceCodeLine = 443;
            G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( OUTVAL ) ; 
            __context__.SourceCodeLine = 444;
            UPDATESCROLLBARFB (  __context__  ) ; 
            __context__.SourceCodeLine = 445;
            REDRAWWINDOW (  __context__  ) ; 
            __context__.SourceCodeLine = 446;
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 450;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUMITEMSAVAILABOVE < NUMITEMSNEEDEDABOVE ))  ) ) 
                { 
                __context__.SourceCodeLine = 452;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( OUTVAL ) ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 453;
                    return  this ; 
                    }
                
                __context__.SourceCodeLine = 455;
                G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 456;
                G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( OUTVAL ) ; 
                __context__.SourceCodeLine = 457;
                UPDATESCROLLBARFB (  __context__  ) ; 
                __context__.SourceCodeLine = 458;
                REDRAWWINDOW (  __context__  ) ; 
                __context__.SourceCodeLine = 459;
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 463;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUMITEMSAVAILBELOW < NUMITEMSNEEDEDBELOW ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 465;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MOVEHIGHLIGHTBARTO( __context__ , (ushort)( ((OUTVAL - G_INUMBERITEMS) + G_IPAGESIZE) ) ) == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 466;
                        return  this ; 
                        }
                    
                    __context__.SourceCodeLine = 468;
                    G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( ((G_INUMBERITEMS - G_IPAGESIZE) + 1) ) ; 
                    __context__.SourceCodeLine = 469;
                    G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( OUTVAL ) ; 
                    __context__.SourceCodeLine = 470;
                    UPDATESCROLLBARFB (  __context__  ) ; 
                    __context__.SourceCodeLine = 471;
                    REDRAWWINDOW (  __context__  ) ; 
                    __context__.SourceCodeLine = 472;
                    
                    } 
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AIPAGESIZE_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 481;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( AIPAGESIZE  .UshortValue > 15 ))  ) ) 
            { 
            __context__.SourceCodeLine = 483;
            GenerateUserError ( "Page size of {0:d} exceeds maximum page size of {1:d}, Clipping to 1.", (ushort)AIPAGESIZE  .UshortValue, (ushort)15) ; 
            __context__.SourceCodeLine = 484;
            G_IPAGESIZE = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 488;
            G_IPAGESIZE = (ushort) ( AIPAGESIZE  .UshortValue ) ; 
            __context__.SourceCodeLine = 489;
            REDRAWWINDOW (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 495;
        G_IITEMNUMBERATTOPOFWINDOW = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 496;
        G_INUMBERITEMS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 497;
        G_IPAGESIZE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 498;
        Functions.SetArray ( DOACTUALITEMSELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 499;
        G_IACTUALITEMHIGHLIGHTEDNUM = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 500;
        Functions.SetArray ( DOHIGHLIGHTBAR , (ushort)0) ; 
        __context__.SourceCodeLine = 501;
        G_IBARPOSITIONINWINDOW = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 502;
        DOHIGHLIGHTBAR [ G_IBARPOSITIONINWINDOW]  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 503;
        Functions.SetArray ( DOLINESELECTED , (ushort)0) ; 
        __context__.SourceCodeLine = 505;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 507;
        REDRAWWINDOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DISCROLLUP = new Crestron.Logos.SplusObjects.DigitalInput( DISCROLLUP__DigitalInput__, this );
    m_DigitalInputList.Add( DISCROLLUP__DigitalInput__, DISCROLLUP );
    
    DISCROLLDOWN = new Crestron.Logos.SplusObjects.DigitalInput( DISCROLLDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( DISCROLLDOWN__DigitalInput__, DISCROLLDOWN );
    
    DIPAGEUP = new Crestron.Logos.SplusObjects.DigitalInput( DIPAGEUP__DigitalInput__, this );
    m_DigitalInputList.Add( DIPAGEUP__DigitalInput__, DIPAGEUP );
    
    DIPAGEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( DIPAGEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( DIPAGEDOWN__DigitalInput__, DIPAGEDOWN );
    
    DITOPOFLIST = new Crestron.Logos.SplusObjects.DigitalInput( DITOPOFLIST__DigitalInput__, this );
    m_DigitalInputList.Add( DITOPOFLIST__DigitalInput__, DITOPOFLIST );
    
    DIBOTTOMOFLIST = new Crestron.Logos.SplusObjects.DigitalInput( DIBOTTOMOFLIST__DigitalInput__, this );
    m_DigitalInputList.Add( DIBOTTOMOFLIST__DigitalInput__, DIBOTTOMOFLIST );
    
    DIRESETSELECTED = new Crestron.Logos.SplusObjects.DigitalInput( DIRESETSELECTED__DigitalInput__, this );
    m_DigitalInputList.Add( DIRESETSELECTED__DigitalInput__, DIRESETSELECTED );
    
    DISELECTHIGHLIGHTEDITEM = new Crestron.Logos.SplusObjects.DigitalInput( DISELECTHIGHLIGHTEDITEM__DigitalInput__, this );
    m_DigitalInputList.Add( DISELECTHIGHLIGHTEDITEM__DigitalInput__, DISELECTHIGHLIGHTEDITEM );
    
    DISELECTITEMINWINDOW = new InOutArray<DigitalInput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DISELECTITEMINWINDOW[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DISELECTITEMINWINDOW__DigitalInput__ + i, DISELECTITEMINWINDOW__DigitalInput__, this );
        m_DigitalInputList.Add( DISELECTITEMINWINDOW__DigitalInput__ + i, DISELECTITEMINWINDOW[i+1] );
    }
    
    DOACTUALITEMSELECTED = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        DOACTUALITEMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOACTUALITEMSELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOACTUALITEMSELECTED__DigitalOutput__ + i, DOACTUALITEMSELECTED[i+1] );
    }
    
    DOHIGHLIGHTBAR = new InOutArray<DigitalOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DOHIGHLIGHTBAR[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOHIGHLIGHTBAR__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOHIGHLIGHTBAR__DigitalOutput__ + i, DOHIGHLIGHTBAR[i+1] );
    }
    
    DOLINESELECTED = new InOutArray<DigitalOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DOLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOLINESELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOLINESELECTED__DigitalOutput__ + i, DOLINESELECTED[i+1] );
    }
    
    AIPAGESIZE = new Crestron.Logos.SplusObjects.AnalogInput( AIPAGESIZE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AIPAGESIZE__AnalogSerialInput__, AIPAGESIZE );
    
    AISCROLLBAR = new Crestron.Logos.SplusObjects.AnalogInput( AISCROLLBAR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AISCROLLBAR__AnalogSerialInput__, AISCROLLBAR );
    
    AIITEMIMAGE = new InOutArray<AnalogInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        AIITEMIMAGE[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( AIITEMIMAGE__AnalogSerialInput__ + i, AIITEMIMAGE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( AIITEMIMAGE__AnalogSerialInput__ + i, AIITEMIMAGE[i+1] );
    }
    
    AOSCROLLBARF = new Crestron.Logos.SplusObjects.AnalogOutput( AOSCROLLBARF__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AOSCROLLBARF__AnalogSerialOutput__, AOSCROLLBARF );
    
    AOBUTTONSELECT = new Crestron.Logos.SplusObjects.AnalogOutput( AOBUTTONSELECT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AOBUTTONSELECT__AnalogSerialOutput__, AOBUTTONSELECT );
    
    AOITEMIMAGEWINDOW = new InOutArray<AnalogOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        AOITEMIMAGEWINDOW[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( AOITEMIMAGEWINDOW__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( AOITEMIMAGEWINDOW__AnalogSerialOutput__ + i, AOITEMIMAGEWINDOW[i+1] );
    }
    
    SIITEMTEXT__DOLLAR__ = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SIITEMTEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIITEMTEXT__DOLLAR____AnalogSerialInput__ + i, SIITEMTEXT__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SIITEMTEXT__DOLLAR____AnalogSerialInput__ + i, SIITEMTEXT__DOLLAR__[i+1] );
    }
    
    SIITEMSTATUS1__DOLLAR__ = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SIITEMSTATUS1__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIITEMSTATUS1__DOLLAR____AnalogSerialInput__ + i, SIITEMSTATUS1__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SIITEMSTATUS1__DOLLAR____AnalogSerialInput__ + i, SIITEMSTATUS1__DOLLAR__[i+1] );
    }
    
    SIITEMSTATUS2__DOLLAR__ = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SIITEMSTATUS2__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIITEMSTATUS2__DOLLAR____AnalogSerialInput__ + i, SIITEMSTATUS2__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SIITEMSTATUS2__DOLLAR____AnalogSerialInput__ + i, SIITEMSTATUS2__DOLLAR__[i+1] );
    }
    
    SOITEMTEXTWINDOW__DOLLAR__ = new InOutArray<StringOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        SOITEMTEXTWINDOW__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOITEMTEXTWINDOW__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOITEMTEXTWINDOW__DOLLAR____AnalogSerialOutput__ + i, SOITEMTEXTWINDOW__DOLLAR__[i+1] );
    }
    
    SOITEMSTATUS1WINDOW__DOLLAR__ = new InOutArray<StringOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        SOITEMSTATUS1WINDOW__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOITEMSTATUS1WINDOW__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOITEMSTATUS1WINDOW__DOLLAR____AnalogSerialOutput__ + i, SOITEMSTATUS1WINDOW__DOLLAR__[i+1] );
    }
    
    SOITEMSTATUS2WINDOW__DOLLAR__ = new InOutArray<StringOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        SOITEMSTATUS2WINDOW__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOITEMSTATUS2WINDOW__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOITEMSTATUS2WINDOW__DOLLAR____AnalogSerialOutput__ + i, SOITEMSTATUS2WINDOW__DOLLAR__[i+1] );
    }
    
    
    for( uint i = 0; i < 15; i++ )
        DISELECTITEMINWINDOW[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DISELECTITEMINWINDOW_OnPush_0, false ) );
        
    DISELECTHIGHLIGHTEDITEM.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISELECTHIGHLIGHTEDITEM_OnPush_1, false ) );
    for( uint i = 0; i < 50; i++ )
        SIITEMTEXT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( SIITEMTEXT__DOLLAR___OnChange_2, false ) );
        
    DIRESETSELECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRESETSELECTED_OnPush_3, false ) );
    DISCROLLUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCROLLUP_OnPush_4, false ) );
    DISCROLLDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCROLLDOWN_OnPush_5, false ) );
    DIPAGEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIPAGEUP_OnPush_6, false ) );
    DIPAGEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIPAGEDOWN_OnPush_7, false ) );
    DITOPOFLIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( DITOPOFLIST_OnPush_8, false ) );
    DIBOTTOMOFLIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIBOTTOMOFLIST_OnPush_9, false ) );
    AISCROLLBAR.OnAnalogChange.Add( new InputChangeHandlerWrapper( AISCROLLBAR_OnChange_10, false ) );
    AIPAGESIZE.OnAnalogChange.Add( new InputChangeHandlerWrapper( AIPAGESIZE_OnChange_11, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TEXT_SCROLLER_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DISCROLLUP__DigitalInput__ = 0;
const uint DISCROLLDOWN__DigitalInput__ = 1;
const uint DIPAGEUP__DigitalInput__ = 2;
const uint DIPAGEDOWN__DigitalInput__ = 3;
const uint DITOPOFLIST__DigitalInput__ = 4;
const uint DIBOTTOMOFLIST__DigitalInput__ = 5;
const uint DIRESETSELECTED__DigitalInput__ = 6;
const uint DISELECTHIGHLIGHTEDITEM__DigitalInput__ = 7;
const uint DISELECTITEMINWINDOW__DigitalInput__ = 8;
const uint AIPAGESIZE__AnalogSerialInput__ = 0;
const uint AISCROLLBAR__AnalogSerialInput__ = 1;
const uint AIITEMIMAGE__AnalogSerialInput__ = 2;
const uint SIITEMTEXT__DOLLAR____AnalogSerialInput__ = 52;
const uint SIITEMSTATUS1__DOLLAR____AnalogSerialInput__ = 102;
const uint SIITEMSTATUS2__DOLLAR____AnalogSerialInput__ = 152;
const uint DOACTUALITEMSELECTED__DigitalOutput__ = 0;
const uint DOHIGHLIGHTBAR__DigitalOutput__ = 50;
const uint DOLINESELECTED__DigitalOutput__ = 65;
const uint AOSCROLLBARF__AnalogSerialOutput__ = 0;
const uint AOBUTTONSELECT__AnalogSerialOutput__ = 1;
const uint AOITEMIMAGEWINDOW__AnalogSerialOutput__ = 2;
const uint SOITEMTEXTWINDOW__DOLLAR____AnalogSerialOutput__ = 17;
const uint SOITEMSTATUS1WINDOW__DOLLAR____AnalogSerialOutput__ = 32;
const uint SOITEMSTATUS2WINDOW__DOLLAR____AnalogSerialOutput__ = 47;

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
