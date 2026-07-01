namespace Crestron.DeviceDrivers.NonSandboxed;
        // class declarations
         class VC4AuthenticationPlugin;

namespace Crestron.DeviceDrivers.SDK.Transports.Cip;
        // class declarations
         class CipClientTransport;
         class CipClientTransportFactory;
     class CipClientTransportFactory 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.DeviceDrivers.SDK.Transports.Cip.ActiveCNX;
        // class declarations
         class ActiveCNXEventArgs;
         class ActiveCNXErrorEventArgs;
         class ActiveCNXConnectionEventArgs;
         class ActiveCNXCertificateEventArgs;
         class ActiveCNXIncomingConnectEventArgs;
         class ActiveCNXIdentificationEventArgs;
         class ActiveCNX;
         class BackgroundTaskQueue;
     class ActiveCNXIncomingConnectEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ConnectionInfo[];
        SIGNED_LONG_INTEGER IPID;
    };

     class ActiveCNXIdentificationEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING MACAddress[];
        STRING ProgramInstanceId[];
        STRING DeviceHostName[];
        STRING Slots[];
    };

     class ActiveCNX 
    {
        // class delegates

        // class events
        EventHandler onCertVerification ( ActiveCNX sender, ActiveCNXCertificateEventArgs e );
        EventHandler onDigital ( ActiveCNX sender, ActiveCNXEventArgs e );
        EventHandler onAnalog ( ActiveCNX sender, ActiveCNXEventArgs e );
        EventHandler onSerial ( ActiveCNX sender, ActiveCNXEventArgs e );
        EventHandler onError ( ActiveCNX sender, ActiveCNXErrorEventArgs e );
        EventHandler onConnect ( ActiveCNX sender, ActiveCNXConnectionEventArgs e );
        EventHandler onDisconnect ( ActiveCNX sender, ActiveCNXConnectionEventArgs e );
        EventHandler onIncomingConnect ( ActiveCNX sender, ActiveCNXIncomingConnectEventArgs e );
        EventHandler onCIPIdentification ( ActiveCNX sender, ActiveCNXIdentificationEventArgs e );

        // class functions
        FUNCTION CreateDisconnectResponsePacket ();
        static STRING_FUNCTION StackTraceToString ();
        FUNCTION Connect ();
        FUNCTION InitiateReceive ();
        FUNCTION Disconnect ();
        FUNCTION UpdateRequest ();
        FUNCTION SendProgramReady ();
        FUNCTION Deactivate ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        SIGNED_LONG_INTEGER NumberOfAnalogSignalsReceived;
        SIGNED_LONG_INTEGER NumberOfDigitalSignalsReceived;
        SIGNED_LONG_INTEGER NumberOfSerialSignalsReceived;
        STRING m_strAuthenticated[];
        STRING m_strMutuallyAuthenticated[];
        STRING m_strStreamEncrypted[];
        STRING m_strStreamSigned[];
        SIGNED_LONG_INTEGER LocalPort;
        SIGNED_LONG_INTEGER m_iRemotePort;
        STRING m_MACAddress[];
        STRING m_ProgramInstanceId[];
        STRING m_MftID[];
        STRING m_ModelID[];
        STRING m_DeviceHostName[];
        STRING m_Slots[];

        // class properties
        STRING IPAddress[];
        SIGNED_LONG_INTEGER MaxLength;
    };

     class BackgroundTaskQueue 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION RemoveData ( STRING key );
        STRING_FUNCTION ToString ();
        FUNCTION Dispose ();
        FUNCTION Cancel ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

namespace Crestron.DeviceDrivers.NonSandboxed.Authentication;
        // class declarations
         class MarshalUtils;
         class LibPam;
         class LibC;
         class PamUser;
    static class MarshalUtils 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class LibPam 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class LibC 
    {
        // class delegates

        // class events

        // class functions
        static SIGNED_LONG_INTEGER_FUNCTION getgrouplist ( STRING user , SIGNED_LONG_INTEGER groupId , SIGNED_LONG_INTEGER groupIdArray[] , BYREF SIGNED_LONG_INTEGER numberOfGroups );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class PamUser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

