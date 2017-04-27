using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIPServer.Services.Contracts;
using System.ServiceModel;
using System.Transactions;
using System.ServiceModel.Security;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;

namespace SIPServer.Services.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(
        ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.PerCall,
        UseSynchronizationContext = true,
        Namespace = Constants.NamespaceICallService,
        MaxItemsInObjectGraph = int.MaxValue
    )]
    public class CallServiceImplementation : SIPServerServiceImplementationBase, ICallService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallServiceImplementation"/> class.
        /// </summary>
        public CallServiceImplementation()
        {
        }

        #region ICallService Members

        /// <summary>
        /// Opens the call.
        /// </summary>
        /// <param name="sip">The sip.</param>
        public void OpenCall(string sip)
        {
        }

        #endregion
    }
}