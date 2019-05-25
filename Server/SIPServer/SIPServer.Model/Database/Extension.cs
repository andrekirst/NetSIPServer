using System.Runtime.Serialization;

namespace SIPServer.Model.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public class Extension : ISIPServerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extension"/> class.
        /// </summary>
        public Extension()
        {
        }

        /// <summary>
        /// Gets or sets the extension ID.
        /// </summary>
        /// <value>The extension ID.</value>
        [DataMember(IsRequired = true)]
        public int ExtensionID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        [DataMember(IsRequired = true)]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PIN.
        /// </summary>
        /// <value>The PIN.</value>
        [DataMember(IsRequired = true)]
        public char[] PIN
        {
            get;
            set;
        }
    }
}