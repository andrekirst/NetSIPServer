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
        Namespace = Constants.NamespaceIInstantMessagingService
    )]
    public interface IInstantMessagingServiceContract : ISIPServerServiceContractBase
    {
    }
}
