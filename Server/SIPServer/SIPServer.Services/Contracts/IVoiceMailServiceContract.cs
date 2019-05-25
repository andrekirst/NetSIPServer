using System.ServiceModel;
using System.Net.Security;

namespace SIPServer.Services.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract(SessionMode = SessionMode.Required, ProtectionLevel = ProtectionLevel.EncryptAndSign)]
    public interface IVoiceMailServiceContract : ISIPServerServiceContractBase
    {
    }
}
