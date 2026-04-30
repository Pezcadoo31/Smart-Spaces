namespace Ultamation.SimplSharp.BluOS.Api;
        // class declarations
         class PresetUpdateEventArgs;
     class PresetUpdateEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        SIGNED_LONG_INTEGER NewCount;

        // class properties
    };

namespace Ultamation.SimplSharp.BluOS;
        // class declarations
         class BluOSClient;
         class ListRefreshArgs;
         class ListUpdateArgs;
         class BluOSGroup;
         class BluOSInfo;
         class TransLanguage;
         class VolumeEventArgs;
     class BluOSClient 
    {
        // class delegates
        delegate FUNCTION SPlusStringDelegate ( SIMPLSHARPSTRING arg );
        delegate FUNCTION SPlusMenuItemDelegate ( INTEGER index , SIMPLSHARPSTRING item , SIMPLSHARPSTRING iconUrl , SIMPLSHARPSTRING itemSummary );
        delegate FUNCTION SPlusIntegerDelegate ( INTEGER arg );
        delegate FUNCTION SPlusIndexedStateDelegate ( INTEGER index , INTEGER state );
        delegate FUNCTION SPlusStateDelegate ( INTEGER state );

        // class events
        EventHandler UpdateGroupVolume ( BluOSClient sender, VolumeEventArgs e );
        EventHandler PlayQueueItemsUpdate ( BluOSClient sender, ListUpdateArgs e );
        EventHandler PlayQueueUpdate ( BluOSClient sender, ListRefreshArgs e );
        EventHandler PresetsUpdate ( BluOSClient sender, ListRefreshArgs e );
        EventHandler BrowseableServicesUpdate ( BluOSClient sender, ListRefreshArgs e );
        EventHandler BrowseableInputsUpdate ( BluOSClient sender, ListRefreshArgs e );

        // class functions
        FUNCTION Debug ( INTEGER dbgOn );
        STRING_FUNCTION FormUrl ( STRING url );
        FUNCTION Initialise ( INTEGER port , INTEGER adapter , SIMPLSHARPSTRING nameOrIp , INTEGER zone , SIMPLSHARPSTRING lang );
        FUNCTION ListDiscoveredDevices ();
        FUNCTION DirectPlay ();
        FUNCTION DirectPause ();
        FUNCTION DirectStop ();
        FUNCTION DirectSkipBack ();
        FUNCTION DirectSkipFwd ();
        FUNCTION DirectRepeat ( INTEGER state );
        FUNCTION DirectShuffle ( INTEGER state );
        FUNCTION DirectMute ( INTEGER state );
        FUNCTION DirectVolume ( INTEGER level );
        FUNCTION MuteGroup ( INTEGER state );
        FUNCTION VolumeGroup ( INTEGER level );
        FUNCTION RefreshPlayQueueItems ( SIGNED_LONG_INTEGER startIdx , SIGNED_LONG_INTEGER endIdx );
        FUNCTION RaisePlayQueueUpdate ( SIGNED_LONG_INTEGER count );
        FUNCTION RaisePresetsUpdate ( SIGNED_LONG_INTEGER count );
        FUNCTION RecallPreset ( INTEGER presetId );
        FUNCTION RaiseBrowseableServicesUpdate ( SIGNED_LONG_INTEGER count );
        FUNCTION CallUrl ( STRING url );
        FUNCTION RaiseBrowseableInputsUpdate ( SIGNED_LONG_INTEGER count );
        FUNCTION InitialiseBrowser ();
        FUNCTION BrowseTop ();
        FUNCTION BrowseBack ();
        FUNCTION BrowseSelect ( INTEGER index , INTEGER state );
        FUNCTION BrowseToPage ( INTEGER page );
        FUNCTION BrowsePrevPage ();
        FUNCTION BrowseNextPage ();
        FUNCTION BrowseScroll ( INTEGER pagePer );
        FUNCTION InputSelect ( INTEGER inputSelected );
        FUNCTION InputSelectByName ( SIMPLSHARPSTRING inputName );
        FUNCTION BrowsePageSize ( INTEGER size );
        FUNCTION ActivatePresets ( INTEGER state );
        FUNCTION SelectPresetMenu ();
        FUNCTION BrowseQuery ( SIMPLSHARPSTRING query );
        FUNCTION UpdateServices ();
        FUNCTION PageItemUpdate ( SIGNED_LONG_INTEGER order , STRING label , STRING iconUrl , STRING itemSummary );
        FUNCTION MenuItemCountUpdate ( SIGNED_LONG_INTEGER itemCount );
        FUNCTION MenuSliderUpdate ( SIGNED_LONG_INTEGER sliderPerFb );
        FUNCTION CurrentPageItemIndexUpdate ( SIGNED_LONG_INTEGER pageItem );
        FUNCTION CurrentPageIndexUpdate ( SIGNED_LONG_INTEGER pageIndex );
        FUNCTION PageCountUpdate ( SIGNED_LONG_INTEGER pageCount );
        FUNCTION TitleUpdate ( STRING title );
        FUNCTION SubtitleUpdate ( STRING subtitle );
        FUNCTION InputUpdate ( SIGNED_LONG_INTEGER idx , STRING input , STRING iconUrl );
        FUNCTION CrpcMessageIn ( SIMPLSHARPSTRING crpcIn );
        FUNCTION SetLanguage ( SIMPLSHARPSTRING lang );
        SIGNED_LONG_INTEGER_FUNCTION Seek ( SIGNED_LONG_INTEGER time );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER RewindSpeed;
        SIGNED_LONG_INTEGER FfwdSpeed;
        STRING StationName[];
        SIGNED_LONG_INTEGER TrackCnt;
        SIGNED_LONG_INTEGER TrackNum;
        STRING NextTitle[];
        STRING Band[][];
        SIGNED_LONG_INTEGER PlayerIcon;
        STRING LaunchIconUrl[];
        SIGNED_LONG_INTEGER Version;
        SIGNED_LONG_INTEGER Instance;
        STRING Language[];
        STRING ActionsSupported[][];
        STRING ActionsAvailable[][];
        STRING PropertiesSupported[][];
        STRING ProviderName[];
        STRING PlayerName[];
        STRING StreamState[];
        STRING MediaType[];
        STRING TextLines[][];
        STRING PlayerState[];
        STRING Title[];
        STRING Artist[];
        STRING Album[];
        STRING Genre[];
        STRING Composer[];
        STRING AlbumArtUrl[];
        SIGNED_LONG_INTEGER ElapsedSec;
        SIGNED_LONG_INTEGER TrackSec;
        STRING PlayerIconURL[];
        STRING LaunchUri[];
        SIGNED_LONG_INTEGER ShuffleState;
        SIGNED_LONG_INTEGER RepeatState;
        DelegateProperty SPlusStringDelegate CrpcMessageOut;
        STRING MaxPresets[][];
        STRING PresetNames[][];
        DelegateProperty SPlusMenuItemDelegate BrowseItemUpdate;
        DelegateProperty SPlusMenuItemDelegate InputItemUpdate;
        DelegateProperty SPlusIntegerDelegate MenuItemCountUpdated;
        DelegateProperty SPlusIntegerDelegate MenuSliderUpdated;
        DelegateProperty SPlusIntegerDelegate CurrentPageItemIndexUpdated;
        DelegateProperty SPlusIntegerDelegate CurrentPageIndexUpdated;
        DelegateProperty SPlusIntegerDelegate PageCountUpdated;
        DelegateProperty SPlusIndexedStateDelegate MenuItemVisibilityUpdate;
        DelegateProperty SPlusIndexedStateDelegate MenuIconVisibilityUpdate;
        DelegateProperty SPlusIndexedStateDelegate InputIconVisibilityUpdate;
        DelegateProperty SPlusStringDelegate TitleUpdated;
        DelegateProperty SPlusStringDelegate SubtitleUpdated;
        DelegateProperty SPlusStateDelegate MenuStateUpdated;
        DelegateProperty SPlusIntegerDelegate UpdateConnectionState;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceInfo;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceState;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceVolume;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceVolumeDb;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceVolumeFixed;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceMute;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceRepeat;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceShuffle;
        DelegateProperty SPlusIntegerDelegate UpdateDevicePosition;
        DelegateProperty SPlusIntegerDelegate UpdateDeviceLength;
        DelegateProperty SPlusStringDelegate UpdateDeviceLine1;
        DelegateProperty SPlusStringDelegate UpdateDeviceLine2;
        DelegateProperty SPlusStringDelegate UpdateDeviceLine3;
        DelegateProperty SPlusStringDelegate UpdateDeviceUrl;
        INTEGER HostPort;
        SIMPLSHARPSTRING SpPlayerName[];
        SIMPLSHARPSTRING SpPlayerIconUrl[];
        TransLanguage SelectedLanguage;
    };

     class ListRefreshArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        SIGNED_LONG_INTEGER Count;

        // class properties
    };

     class ListUpdateArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        SIGNED_LONG_INTEGER StartIndex;
        SIGNED_LONG_INTEGER EndIndex;

        // class properties
    };

     class BluOSGroup 
    {
        // class delegates
        delegate FUNCTION SPlusDelegate ( );
        delegate FUNCTION SPlusIntegerDelegate ( INTEGER arg );

        // class events

        // class functions
        INTEGER_FUNCTION IsPlayerInGroup ( INTEGER i );
        FUNCTION Initialise ( SIMPLSHARPSTRING nameOrIp , INTEGER portOffset );
        FUNCTION DissolveGroup ();
        FUNCTION AddPlayer ( INTEGER playerIdx );
        FUNCTION RemovePlayer ( INTEGER playerIdx );
        FUNCTION ConfigureGroup ();
        FUNCTION Play ();
        FUNCTION Pause ();
        FUNCTION SkipFwd ();
        FUNCTION SkipBack ();
        FUNCTION VolUp ();
        FUNCTION VolDown ();
        FUNCTION MuteGroup ( INTEGER on );
        FUNCTION VolumeGroup ( INTEGER vol );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty SPlusDelegate UpdateGroupInformation;
        DelegateProperty SPlusIntegerDelegate UpdateGroupVolume;
        SIMPLSHARPSTRING GroupMaster[];
        SIMPLSHARPSTRING GroupName[];
        INTEGER GroupIsActive;
        INTEGER GroupSize;
    };

     class BluOSInfo 
    {
        // class delegates
        delegate FUNCTION SPlusIntegerDelegate ( INTEGER arg );

        // class events

        // class functions
        FUNCTION Initialise ();
        SIMPLSHARPSTRING_FUNCTION GetPlayerNameByIndex ( INTEGER idx );
        INTEGER_FUNCTION GetPlayerOnlineStateByIndex ( INTEGER idx );
        FUNCTION IdentifySlotByName ( INTEGER idx , SIMPLSHARPSTRING playerName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty SPlusIntegerDelegate UpdateSystemInformation;
        INTEGER PlayerCount;
    };

    static class TransLanguage // enum
    {
        static SIGNED_LONG_INTEGER en;
        static SIGNED_LONG_INTEGER enGB;
        static SIGNED_LONG_INTEGER enUS;
        static SIGNED_LONG_INTEGER zh;
        static SIGNED_LONG_INTEGER cz;
        static SIGNED_LONG_INTEGER da;
        static SIGNED_LONG_INTEGER nl;
        static SIGNED_LONG_INTEGER fi;
        static SIGNED_LONG_INTEGER frFR;
        static SIGNED_LONG_INTEGER frCA;
        static SIGNED_LONG_INTEGER de;
        static SIGNED_LONG_INTEGER hu;
        static SIGNED_LONG_INTEGER it;
        static SIGNED_LONG_INTEGER ja;
        static SIGNED_LONG_INTEGER ko;
        static SIGNED_LONG_INTEGER pl;
        static SIGNED_LONG_INTEGER pt;
        static SIGNED_LONG_INTEGER ru;
        static SIGNED_LONG_INTEGER sk;
        static SIGNED_LONG_INTEGER es;
        static SIGNED_LONG_INTEGER sv;
    };

namespace Ultamation.SimplSharp.BluOS.MediaPlayer;
        // class declarations
         class BluOSMediaPlayerMenu;
         class MessageType;
    static class MessageType // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER ConfirmClearPlayQueue;
        static SIGNED_LONG_INTEGER Error;
    };

namespace ultaBluOs;
        // class declarations
         class L;
     class L 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION f ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

