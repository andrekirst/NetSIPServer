using System;
using System.Runtime.Serialization;

namespace SIPServer.Model.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public class CurrentCall : ISIPServerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentCall"/> class.
        /// </summary>
        public CurrentCall()
        {
        }

        /// <summary>
        /// Gets or sets the call ID.
        /// </summary>
        /// <value>The call ID.</value>
        [DataMember(IsRequired = true)]
        public int CallID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>From.</value>
        [DataMember(IsRequired = true)]
        public string From
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>To.</value>
        [DataMember(IsRequired = true)]
        public string To
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>The start time.</value>
        [DataMember(IsRequired = true)]
        public DateTime StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets from extension ID.
        /// </summary>
        /// <value>From extension ID.</value>
        [DataMember(IsRequired = false)]
        public int? FromExtensionID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets to extension ID.
        /// </summary>
        /// <value>To extension ID.</value>
        [DataMember(IsRequired = false)]
        public int? ToExtensionID
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
    }
}