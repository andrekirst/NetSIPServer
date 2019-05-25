using System;
using SIPServer.Services.Contracts;

namespace SIPServer.Services.Implementations
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SIPServerServiceImplementationBase : ISIPServerServiceContractBase, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPServerServiceImplementationBase"/> class.
        /// </summary>
        public SIPServerServiceImplementationBase()
        {
        }

        #region IDisposable Member

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            GC.Collect();
        }

        #endregion
    }
}