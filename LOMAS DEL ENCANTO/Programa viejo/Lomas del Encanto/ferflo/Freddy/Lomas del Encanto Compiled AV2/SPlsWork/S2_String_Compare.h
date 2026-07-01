#ifndef __S2_STRING_COMPARE_H__
#define __S2_STRING_COMPARE_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_String_Compare_UPDATESTRING_DIG_INPUT 0


/*
* ANALOG_INPUT
*/

#define __S2_String_Compare_CURRENTSTRING$_STRING_INPUT 0
#define __S2_String_Compare_CURRENTSTRING$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_String_Compare, __CURRENTSTRING$, __S2_String_Compare_CURRENTSTRING$_STRING_MAX_LEN );


#define __S2_String_Compare_COMPARESTRING$_STRING_INPUT 1
#define __S2_String_Compare_COMPARESTRING$_ARRAY_NUM_ELEMS 10
#define __S2_String_Compare_COMPARESTRING$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_String_Compare, __COMPARESTRING$, __S2_String_Compare_COMPARESTRING$_ARRAY_NUM_ELEMS, __S2_String_Compare_COMPARESTRING$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/

#define __S2_String_Compare_HIGHLIGHTITEM_DIG_OUTPUT 0
#define __S2_String_Compare_HIGHLIGHTITEM_ARRAY_LENGTH 10

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

START_GLOBAL_VAR_STRUCT( S2_String_Compare )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __HIGHLIGHTITEM );
   DECLARE_STRING_STRUCT( S2_String_Compare, __CURRENTSTRING$ );
   DECLARE_STRING_ARRAY( S2_String_Compare, __COMPARESTRING$ );
};

START_NVRAM_VAR_STRUCT( S2_String_Compare )
{
};



#endif //__S2_STRING_COMPARE_H__

