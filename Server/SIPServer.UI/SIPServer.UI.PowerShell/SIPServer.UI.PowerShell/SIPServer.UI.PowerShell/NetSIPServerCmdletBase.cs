using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.Reflection;

namespace SIPServer.UI.PowerShell
{
    public abstract class NetSIPServerCmdletBase :  PSCmdlet, IContainsErrorRecord
    {
        public NetSIPServerCmdletBase()
        {
        }

        #region IContainsErrorRecord Members

        public abstract ErrorRecord ErrorRecord
        {
            get;
        }

        #endregion
    }
}
