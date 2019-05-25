using System;
using System.Runtime.Serialization;

namespace SIPServer.Model.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public class SIPServer : ISIPServerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPServer"/> class.
        /// </summary>
        public SIPServer()
        {
        }

        /// <summary>
        /// Gets or sets the SIP server ID.
        /// </summary>
        /// <value>The SIP server ID.</value>
        [DataMember]
        public int SIPServerID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the SIP server unique.
        /// </summary>
        /// <value>The name of the SIP server unique.</value>
        [DataMember(IsRequired = true)]
        public string SIPServerUniqueName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(IsRequired = false)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is master.
        /// </summary>
        /// <value><c>true</c> if this instance is master; otherwise, <c>false</c>.</value>
        [DataMember(IsRequired = true)]
        public bool IsMaster
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is secondary.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is secondary; otherwise, <c>false</c>.
        /// </value>
        [DataMember(IsRequired = true)]
        public bool IsSecondary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is proxy.
        /// </summary>
        /// <value><c>true</c> if this instance is proxy; otherwise, <c>false</c>.</value>
        [DataMember(IsRequired = true)]
        public bool IsProxy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the started at.
        /// </summary>
        /// <value>The started at.</value>
        [DataMember(IsRequired = false)]
        public DateTime? StartedAt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the stopped at.
        /// </summary>
        /// <value>The stopped at.</value>
        [DataMember(IsRequired = false)]
        public DateTime? StoppedAt
        {
            get;
            set;
        }
    }
}