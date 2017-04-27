using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using SIPServer.Services.Contracts;

namespace SIPServer.Services.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(
        ConcurrencyMode = ConcurrencyMode.Multiple,
        MaxItemsInObjectGraph = 65536,
        InstanceContextMode = InstanceContextMode.PerSession
        )]
    public class ManagementServiceImplementation : SIPServerServiceImplementationBase, IManagementServiceContract
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementServiceImplementation"/> class.
        /// </summary>
        public ManagementServiceImplementation()
        {
        }

        #region IManagementContract Members

        /// <summary>
        /// Logins this instance.
        /// </summary>
        [OperationBehavior(
            Impersonation = ImpersonationOption.Required,
            ReleaseInstanceMode = ReleaseInstanceMode.BeforeCall
        )]
        public void Login()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        public void Logout()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the SIP server list.
        /// </summary>
        /// <returns></returns>
        public List<SIPServer.Model.Database.SIPServer> GetSIPServerList()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
