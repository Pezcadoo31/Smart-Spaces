#ifndef __S2_DYNAMIC_PRESETS_EXTENDER_FILE_IO_H__
#define __S2_DYNAMIC_PRESETS_EXTENDER_FILE_IO_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Dynamic_Presets_Extender_File_IO_PREV_PRESET_DIG_INPUT 0
#define __S2_Dynamic_Presets_Extender_File_IO_NEXT_PRESET_DIG_INPUT 1
#define __S2_Dynamic_Presets_Extender_File_IO_EDIT_PRESETS_DIG_INPUT 2
#define __S2_Dynamic_Presets_Extender_File_IO_FIRST_MASTER_PAGE_DIG_INPUT 3
#define __S2_Dynamic_Presets_Extender_File_IO_PREV_MASTER_PAGE_DIG_INPUT 4
#define __S2_Dynamic_Presets_Extender_File_IO_NEXT_MASTER_PAGE_DIG_INPUT 5
#define __S2_Dynamic_Presets_Extender_File_IO_LAST_MASTER_PAGE_DIG_INPUT 6
#define __S2_Dynamic_Presets_Extender_File_IO_EDIT_PREV_PRESET_DIG_INPUT 7
#define __S2_Dynamic_Presets_Extender_File_IO_EDIT_NEXT_PRESET_DIG_INPUT 8
#define __S2_Dynamic_Presets_Extender_File_IO_SAVE_STATION_NAME_DIG_INPUT 9
#define __S2_Dynamic_Presets_Extender_File_IO_CLEAR_IMAGE_DIG_INPUT 10


/*
* ANALOG_INPUT
*/
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_LIST_INDEX_ANALOG_INPUT 0
#define __S2_Dynamic_Presets_Extender_File_IO_MAX_CHANNEL_LENGTH_ANALOG_INPUT 1

#define __S2_Dynamic_Presets_Extender_File_IO_EDIT_STATION_NAME_STRING_INPUT 2
#define __S2_Dynamic_Presets_Extender_File_IO_EDIT_STATION_NAME_STRING_MAX_LEN 8
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __EDIT_STATION_NAME, __S2_Dynamic_Presets_Extender_File_IO_EDIT_STATION_NAME_STRING_MAX_LEN );
#define __S2_Dynamic_Presets_Extender_File_IO_USER_FILE_NAME_STRING_INPUT 3
#define __S2_Dynamic_Presets_Extender_File_IO_USER_FILE_NAME_STRING_MAX_LEN 128
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __USER_FILE_NAME, __S2_Dynamic_Presets_Extender_File_IO_USER_FILE_NAME_STRING_MAX_LEN );
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_FILE_NAME_STRING_INPUT 4
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_FILE_NAME_STRING_MAX_LEN 128
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __MASTER_FILE_NAME, __S2_Dynamic_Presets_Extender_File_IO_MASTER_FILE_NAME_STRING_MAX_LEN );
#define __S2_Dynamic_Presets_Extender_File_IO_NEW_CHANNEL_VALUE_STRING_INPUT 5
#define __S2_Dynamic_Presets_Extender_File_IO_NEW_CHANNEL_VALUE_STRING_MAX_LEN 6
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __NEW_CHANNEL_VALUE, __S2_Dynamic_Presets_Extender_File_IO_NEW_CHANNEL_VALUE_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_Dynamic_Presets_Extender_File_IO_CLEAR_KEYPAD_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_Dynamic_Presets_Extender_File_IO_USER_INDEX_ANALOG_OUTPUT 0
#define __S2_Dynamic_Presets_Extender_File_IO_WORKING_PRESET_IMAGE_ANALOG_OUTPUT 3
#define __S2_Dynamic_Presets_Extender_File_IO_SCROLL_BAR_ANALOG_OUTPUT 5

#define __S2_Dynamic_Presets_Extender_File_IO_WORKING_PRESET_INDEX_STRING_OUTPUT 1
#define __S2_Dynamic_Presets_Extender_File_IO_WORKING_PRESET_STATION_STRING_OUTPUT 2
#define __S2_Dynamic_Presets_Extender_File_IO_WORKING_PRESET_CHANNEL_STRING_OUTPUT 4

#define __S2_Dynamic_Presets_Extender_File_IO_USER_ICON_ANALOG_OUTPUT 6
#define __S2_Dynamic_Presets_Extender_File_IO_USER_ICON_ARRAY_LENGTH 27
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_ICON_INDEX_ANALOG_OUTPUT 87
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_ICON_INDEX_ARRAY_LENGTH 9
#define __S2_Dynamic_Presets_Extender_File_IO_USER_CHANNEL_STRING_OUTPUT 33
#define __S2_Dynamic_Presets_Extender_File_IO_USER_CHANNEL_ARRAY_LENGTH 27
#define __S2_Dynamic_Presets_Extender_File_IO_USER_STATION_STRING_OUTPUT 60
#define __S2_Dynamic_Presets_Extender_File_IO_USER_STATION_ARRAY_LENGTH 27
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_STATION_STRING_OUTPUT 96
#define __S2_Dynamic_Presets_Extender_File_IO_MASTER_STATION_ARRAY_LENGTH 9

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
CREATE_INTARRAY1D( S2_Dynamic_Presets_Extender_File_IO, __USERICON, 27 );;
CREATE_INTARRAY1D( S2_Dynamic_Presets_Extender_File_IO, __MASTERICON, 1000 );;


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
#define __S2_Dynamic_Presets_Extender_File_IO_WORKINGPRESETINDEX$_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __WORKINGPRESETINDEX$, __S2_Dynamic_Presets_Extender_File_IO_WORKINGPRESETINDEX$_STRING_MAX_LEN );
#define __S2_Dynamic_Presets_Extender_File_IO_WORKINGPRESETSTATION$_STRING_MAX_LEN 8
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __WORKINGPRESETSTATION$, __S2_Dynamic_Presets_Extender_File_IO_WORKINGPRESETSTATION$_STRING_MAX_LEN );
#define __S2_Dynamic_Presets_Extender_File_IO_WORKINGPRESETCHANNEL$_STRING_MAX_LEN 6
CREATE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __WORKINGPRESETCHANNEL$, __S2_Dynamic_Presets_Extender_File_IO_WORKINGPRESETCHANNEL$_STRING_MAX_LEN );
#define __S2_Dynamic_Presets_Extender_File_IO_USERSTATION_ARRAY_NUM_ELEMS 27
#define __S2_Dynamic_Presets_Extender_File_IO_USERSTATION_ARRAY_NUM_CHARS 8
CREATE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __USERSTATION, __S2_Dynamic_Presets_Extender_File_IO_USERSTATION_ARRAY_NUM_ELEMS, __S2_Dynamic_Presets_Extender_File_IO_USERSTATION_ARRAY_NUM_CHARS );
#define __S2_Dynamic_Presets_Extender_File_IO_USERCHANNEL_ARRAY_NUM_ELEMS 27
#define __S2_Dynamic_Presets_Extender_File_IO_USERCHANNEL_ARRAY_NUM_CHARS 6
CREATE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __USERCHANNEL, __S2_Dynamic_Presets_Extender_File_IO_USERCHANNEL_ARRAY_NUM_ELEMS, __S2_Dynamic_Presets_Extender_File_IO_USERCHANNEL_ARRAY_NUM_CHARS );
#define __S2_Dynamic_Presets_Extender_File_IO_MASTERSTATION_ARRAY_NUM_ELEMS 1000
#define __S2_Dynamic_Presets_Extender_File_IO_MASTERSTATION_ARRAY_NUM_CHARS 8
CREATE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __MASTERSTATION, __S2_Dynamic_Presets_Extender_File_IO_MASTERSTATION_ARRAY_NUM_ELEMS, __S2_Dynamic_Presets_Extender_File_IO_MASTERSTATION_ARRAY_NUM_CHARS );
#define __S2_Dynamic_Presets_Extender_File_IO_MASTERCHANNEL_ARRAY_NUM_ELEMS 1000
#define __S2_Dynamic_Presets_Extender_File_IO_MASTERCHANNEL_ARRAY_NUM_CHARS 6
CREATE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __MASTERCHANNEL, __S2_Dynamic_Presets_Extender_File_IO_MASTERCHANNEL_ARRAY_NUM_ELEMS, __S2_Dynamic_Presets_Extender_File_IO_MASTERCHANNEL_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Dynamic_Presets_Extender_File_IO )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __USER_ICON );
   DECLARE_IO_ARRAY( __MASTER_ICON_INDEX );
   DECLARE_IO_ARRAY( __USER_CHANNEL );
   DECLARE_IO_ARRAY( __USER_STATION );
   DECLARE_IO_ARRAY( __MASTER_STATION );
   unsigned short __CURRENTMASTERPAGE;
   unsigned short __TOTALMASTERPAGES;
   unsigned short __MASTERLISTPREPD;
   unsigned short __WRITINGTODISK;
   unsigned short __SERVICE;
   unsigned short __MASTERENTRIES;
   unsigned short __SCROLLINDEX;
   unsigned short __WORKINGPRESETIMAGE;
   unsigned short __USECUSTOMNAME;
   unsigned short __FORCEIMAGECLEAR;
   DECLARE_INTARRAY( S2_Dynamic_Presets_Extender_File_IO, __USERICON );
   DECLARE_INTARRAY( S2_Dynamic_Presets_Extender_File_IO, __MASTERICON );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __WORKINGPRESETINDEX$ );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __WORKINGPRESETSTATION$ );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __WORKINGPRESETCHANNEL$ );
   DECLARE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __USERSTATION );
   DECLARE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __USERCHANNEL );
   DECLARE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __MASTERSTATION );
   DECLARE_STRING_ARRAY( S2_Dynamic_Presets_Extender_File_IO, __MASTERCHANNEL );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __EDIT_STATION_NAME );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __USER_FILE_NAME );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __MASTER_FILE_NAME );
   DECLARE_STRING_STRUCT( S2_Dynamic_Presets_Extender_File_IO, __NEW_CHANNEL_VALUE );
};

START_NVRAM_VAR_STRUCT( S2_Dynamic_Presets_Extender_File_IO )
{
};



#endif //__S2_DYNAMIC_PRESETS_EXTENDER_FILE_IO_H__

