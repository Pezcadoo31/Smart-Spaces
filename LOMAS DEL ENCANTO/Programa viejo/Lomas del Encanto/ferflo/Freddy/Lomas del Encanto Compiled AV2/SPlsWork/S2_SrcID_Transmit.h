#ifndef __S2_SRCID_TRANSMIT_H__
#define __S2_SRCID_TRANSMIT_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_SrcID_Transmit_ROOM_OFF_DIG_INPUT 0

#define __S2_SrcID_Transmit_SRC_SELECTED_FB_DIG_INPUT 1
#define __S2_SrcID_Transmit_SRC_SELECTED_FB_ARRAY_LENGTH 24

/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/


#define __S2_SrcID_Transmit_ID_FOR_TYPE_ANALOG_OUTPUT 0
#define __S2_SrcID_Transmit_ID_FOR_TYPE_ARRAY_LENGTH 30

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
#define __S2_SrcID_Transmit_SRC_TYPE_INTEGER_PARAMETER 10
#define __S2_SrcID_Transmit_SRC_TYPE_ARRAY_LENGTH 24
#define __S2_SrcID_Transmit_SRC_CONTROL_ID_INTEGER_PARAMETER 34
#define __S2_SrcID_Transmit_SRC_CONTROL_ID_ARRAY_LENGTH 24
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

START_GLOBAL_VAR_STRUCT( S2_SrcID_Transmit )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SRC_TYPE );
   DECLARE_IO_ARRAY( __SRC_CONTROL_ID );
   DECLARE_IO_ARRAY( __SRC_SELECTED_FB );
   DECLARE_IO_ARRAY( __ID_FOR_TYPE );
};

START_NVRAM_VAR_STRUCT( S2_SrcID_Transmit )
{
};



#endif //__S2_SRCID_TRANSMIT_H__

