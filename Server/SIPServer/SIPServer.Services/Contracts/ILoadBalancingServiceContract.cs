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
    [ServiceContract(
        SessionMode = SessionMode.Allowed,
        ProtectionLevel = ProtectionLevel.EncryptAndSign,
        Namespace = Constants.NamespaceILoadBalancingService
    )]
    public interface ILoadBalancingServiceContract : ISIPServerServiceContractBase
    {
    }
}
