using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
