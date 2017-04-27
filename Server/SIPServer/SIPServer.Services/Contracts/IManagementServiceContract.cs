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
        SessionMode = SessionMode.Required,
        ProtectionLevel = ProtectionLevel.EncryptAndSign,
        Namespace = Constants.NamespaceIManagementService
    )]
    public interface IManagementServiceContract : ISIPServerServiceContractBase
    {
        /// <summary>
        /// Logins this instance.
        /// </summary>
        [OperationContract(IsInitiating = true)]
        void Login();

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        [OperationContract(IsTerminating = true)]
        void Logout();

        /// <summary>
        /// Gets the SIP server list.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Model.Database.SIPServer> GetSIPServerList();
    }
}