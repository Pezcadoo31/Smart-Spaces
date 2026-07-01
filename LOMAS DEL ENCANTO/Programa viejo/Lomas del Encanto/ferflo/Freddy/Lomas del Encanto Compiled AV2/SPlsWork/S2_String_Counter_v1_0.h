#ifndef __S2_STRING_COUNTER_V1_0_H__
#define __S2_STRING_COUNTER_V1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/



#define __S2_String_Counter_v1_0_SIITEMTEXT$_STRING_INPUT 0
#define __S2_String_Counter_v1_0_SIITEMTEXT$_ARRAY_NUM_ELEMS 50
#define __S2_String_Counter_v1_0_SIITEMTEXT$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_String_Counter_v1_0, __SIITEMTEXT$, __S2_String_Counter_v1_0_SIITEMTEXT$_ARRAY_NUM_ELEMS, __S2_String_Counter_v1_0_SIITEMTEXT$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_String_Counter_v1_0_AOBUTTONSELECT_ANALOG_OUTPUT 0



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

START_GLOBAL_VAR_STRUCT( S2_String_Counter_v1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_INUMBERITEMS;
   DECLARE_STRING_ARRAY( S2_String_Counter_v1_0, __SIITEMTEXT$ );
};

START_NVRAM_VAR_STRUCT( S2_String_Counter_v1_0 )
{
};



#endif //__S2_STRING_COUNTER_V1_0_H__

