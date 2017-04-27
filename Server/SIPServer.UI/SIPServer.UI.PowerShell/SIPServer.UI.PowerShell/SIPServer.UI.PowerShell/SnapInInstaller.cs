using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using SIPServer.UI.PowerShell.Cmdlets.Get;

namespace SIPServer.UI.PowerShell
{
    /// <summary>
    /// The SnapIn-Installer
    /// </summary>
    [RunInstaller(true)]
    public class SnapInInstaller : PSSnapIn
    {
        public SnapInInstaller()
            : base()
        {
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public override string Description
        {
            get
            {
                return "The PowerShell-SnapIn to administrate the NetSIPServer.";
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public override string Name
        {
            get
            {
                return "NetSIPServer";
            }
        }

        /// <summary>
        /// Gets the vendor.
        /// </summary>
        /// <value>The vendor.</value>
        public override string Vendor
        {
            get
            {
                return "http://www.andrekirst.de";
            }
        }
    }
}
