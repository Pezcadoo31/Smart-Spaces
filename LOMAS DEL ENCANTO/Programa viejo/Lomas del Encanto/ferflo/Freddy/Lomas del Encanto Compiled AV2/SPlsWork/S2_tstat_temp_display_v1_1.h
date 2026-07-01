#ifndef __S2_TSTAT_TEMP_DISPLAY_V1_1_H__
#define __S2_TSTAT_TEMP_DISPLAY_V1_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_tstat_temp_display_v1_1_SHOW_HALF_DEGREES_DIG_INPUT 0
#define __S2_tstat_temp_display_v1_1_HIDE_VALUE_DIG_INPUT 1


/*
* ANALOG_INPUT
*/
#define __S2_tstat_temp_display_v1_1_TEMPERATURE_IN_TENTHS_ANALOG_INPUT 0

#define __S2_tstat_temp_display_v1_1_APPEND_CHARS_STRING_INPUT 1
#define __S2_tstat_temp_display_v1_1_APPEND_CHARS_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_tstat_temp_display_v1_1, __APPEND_CHARS, __S2_tstat_temp_display_v1_1_APPEND_CHARS_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_tstat_temp_display_v1_1_TEMPERATURE_DISPLAY$_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_tstat_temp_display_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_tstat_temp_display_v1_1, __APPEND_CHARS );
};

START_NVRAM_VAR_STRUCT( S2_tstat_temp_display_v1_1 )
{
};



#endif //__S2_TSTAT_TEMP_DISPLAY_V1_1_H__

