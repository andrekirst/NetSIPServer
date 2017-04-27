using System;
using System.Runtime.Serialization;

namespace SIPServer.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum SIPCommands
    {
        /// <summary>
        /// Initiates a session. This method includes information about the calling and called users and the type of media that is to be exchanged.
        /// </summary>
        REGISTER = 1,
        /// <summary>
        /// Used by a client to login and register its address with a SIP registrar server.
        /// </summary>
        INVITE = 2,
        /// <summary>
        /// Sent by the client who sends the INVITE. ACK is sent to confirm that the session is established. Media can then be exchanged.
        /// </summary>
        ACK = 4,
        /// <summary>
        /// Terminates a session. This method can be sent by either user.
        /// </summary>
        BYE = 8,
        /// <summary>
        /// Terminates a pending request, such as an outstanding INVITE. After a session is established, a BYE method needs to be used to terminate the session.
        /// </summary>
        CANCEL = 16,
        /// <summary>
        /// Queries the capabilities of the server or other devices. It can be used to check media capabilities before issuing an INVITE.
        /// </summary>
        OPTIONS = 32,
        /// <summary>
        /// Used for mid-session signaling
        /// </summary>
        INFO = 64,
        /// <summary>
        /// 
        /// </summary>
        UPDATE = 128,
        /// <summary>
        /// 
        /// </summary>
        MESSAGE = 256,
        /// <summary>
        /// 
        /// </summary>
        NOTIFY = 512
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SIPServerType
    {
        /// <summary>
        /// The servicer is a master server.
        /// </summary>
        MASTER = 0,
        /// <summary>
        /// The servicer is a secondary server.
        /// </summary>
        SECONDARY = 1,
        /// <summary>
        /// The servicer is a proxy server.
        /// </summary>
        PROXY = 2
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public enum InformationStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "Success")]
        Success = 0,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "Information")]
        Information = 1,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning = 2,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 3
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public enum PresenceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Offline = 0,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Available = 1,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Busy = 2,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Inactive = 3,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        InACall = 4,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        InAMeeting = 5,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        InAMeetingInactive = 6,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        DontDisturb = 7,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        DontDisturbInactive = 8,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Away = 9,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        PresenceUnknown = 10
    }
}