using System;
using System.Runtime.Serialization;

namespace SIPServer.Model.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public class SIPServerHistory : ISIPServerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPServerHistory"/> class.
        /// </summary>
        public SIPServerHistory()
        {
        }

        /// <summary>
        /// Gets or sets the SIP server history ID.
        /// </summary>
        /// <value>The SIP server history ID.</value>
        [DataMember(IsRequired = true)]
        public int SIPServerHistoryID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the server ID.
        /// </summary>
        /// <value>The server ID.</value>
        [DataMember(IsRequired = true)]
        public int ServerID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the stamp.
        /// </summary>
        /// <value>The stamp.</value>
        [DataMember(IsRequired = true)]
        public DateTime Stamp
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [DataMember(IsRequired = true)]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the information status.
        /// </summary>
        /// <value>The type of the information status.</value>
        [DataMember(IsRequired = true)]
        public InformationStatusType InformationStatusType
        {
            get;
            set;
        }
    }
}