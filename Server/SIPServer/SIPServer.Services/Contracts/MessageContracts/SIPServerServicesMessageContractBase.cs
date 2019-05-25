using System.ServiceModel;
using System.Net.Security;

namespace SIPServer.Services.Contracts.MessageContracts
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false, ProtectionLevel = ProtectionLevel.EncryptAndSign)]
    public abstract class SIPServerServicesMessageContractBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPServerServicesMessageContractBase"/> class.
        /// </summary>
        public SIPServerServicesMessageContractBase()
        {
        }
    }
}