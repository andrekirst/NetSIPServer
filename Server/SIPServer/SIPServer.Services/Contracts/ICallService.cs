using System.ServiceModel;
using System.Net.Security;

namespace SIPServer.Services.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract(
        SessionMode = SessionMode.Allowed,
        ProtectionLevel = ProtectionLevel.EncryptAndSign,
        Namespace = Constants.NamespaceICallService
    )]
    public interface ICallService : ISIPServerServiceContractBase
    {
        /// <summary>
        /// Opens the call.
        /// </summary>
        /// <param name="sip">The sip.</param>
        [OperationContract]
        void OpenCall(string sip);
    }
}