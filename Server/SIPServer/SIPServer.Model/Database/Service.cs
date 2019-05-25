using System.Runtime.Serialization;

namespace SIPServer.Model.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = Constants.NamespaceModel)]
    public class Service : ISIPServerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class.
        /// </summary>
        public Service()
        {
        }

        /// <summary>
        /// Gets or sets the service ID.
        /// </summary>
        /// <value>The service ID.</value>
        [DataMember(IsRequired = true)]
        public int ServiceID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the contract.
        /// </summary>
        /// <value>The name of the contract.</value>
        [DataMember(IsRequired = true)]
        public string ContractName
        {
            get;
            set;
        }
    }
}
