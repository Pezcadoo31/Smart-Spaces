#ifndef __S2_LUTRON_HOMEWORKS_QS_FEEDBACK_PROCESSING_MODULE_R01_H__
#define __S2_LUTRON_HOMEWORKS_QS_FEEDBACK_PROCESSING_MODULE_R01_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_SHOW_TRACE_MSGS_DIG_INPUT 0


/*
* ANALOG_INPUT
*/


#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_FROM_CORE_MODULE$_BUFFER_INPUT 0
#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_FROM_CORE_MODULE$_BUFFER_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01, __FROM_CORE_MODULE$, __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_FROM_CORE_MODULE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/

#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_ERROR_DIG_OUTPUT 0
#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_ERROR_ARRAY_LENGTH 5

/*
* ANALOG_OUTPUT
*/

#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_MONITORING$_STRING_OUTPUT 0

#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_INTEGRATION_ID$_STRING_OUTPUT 1
#define __S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01_INTEGRATION_ID$_ARRAY_LENGTH 200

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

START_GLOBAL_VAR_STRUCT( S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __ERROR );
   DECLARE_IO_ARRAY( __INTEGRATION_ID$ );
   DECLARE_STRING_STRUCT( S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01, __FROM_CORE_MODULE$ );
};

START_NVRAM_VAR_STRUCT( S2_Lutron_Homeworks_QS_Feedback_Processing_Module_r01 )
{
};



#endif //__S2_LUTRON_HOMEWORKS_QS_FEEDBACK_PROCESSING_MODULE_R01_H__

