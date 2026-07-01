#ifndef __S2_HD_CHANNEL_DECODER_H__
#define __S2_HD_CHANNEL_DECODER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_HD_Channel_Decoder_SEND_DIG_INPUT 0


/*
* ANALOG_INPUT
*/
#define __S2_HD_Channel_Decoder_KEY_PULSE_TIME_ANALOG_INPUT 1
#define __S2_HD_Channel_Decoder_KEY_DELAY_TIME_ANALOG_INPUT 2
#define __S2_HD_Channel_Decoder_MAX_CHANNEL_LENGTH_ANALOG_INPUT 3
#define __S2_HD_Channel_Decoder_LEADING_0_ANALOG_INPUT 4
#define __S2_HD_Channel_Decoder_TRAILING_ENTER_ANALOG_INPUT 5

#define __S2_HD_Channel_Decoder_CHANNEL_STRING_STRING_INPUT 0
#define __S2_HD_Channel_Decoder_CHANNEL_STRING_STRING_MAX_LEN 6
CREATE_STRING_STRUCT( S2_HD_Channel_Decoder, __CHANNEL_STRING, __S2_HD_Channel_Decoder_CHANNEL_STRING_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_HD_Channel_Decoder_KEY0_DIG_OUTPUT 0
#define __S2_HD_Channel_Decoder_KEY1_DIG_OUTPUT 1
#define __S2_HD_Channel_Decoder_KEY2_DIG_OUTPUT 2
#define __S2_HD_Channel_Decoder_KEY3_DIG_OUTPUT 3
#define __S2_HD_Channel_Decoder_KEY4_DIG_OUTPUT 4
#define __S2_HD_Channel_Decoder_KEY5_DIG_OUTPUT 5
#define __S2_HD_Channel_Decoder_KEY6_DIG_OUTPUT 6
#define __S2_HD_Channel_Decoder_KEY7_DIG_OUTPUT 7
#define __S2_HD_Channel_Decoder_KEY8_DIG_OUTPUT 8
#define __S2_HD_Channel_Decoder_KEY9_DIG_OUTPUT 9
#define __S2_HD_Channel_Decoder_KEYDASH_DIG_OUTPUT 10
#define __S2_HD_Channel_Decoder_KEYENTER_DIG_OUTPUT 11


/*
* ANALOG_OUTPUT
*/



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

START_GLOBAL_VAR_STRUCT( S2_HD_Channel_Decoder )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_HD_Channel_Decoder, __CHANNEL_STRING );
};

START_NVRAM_VAR_STRUCT( S2_HD_Channel_Decoder )
{
   unsigned short __SENDING;
};



#endif //__S2_HD_CHANNEL_DECODER_H__

