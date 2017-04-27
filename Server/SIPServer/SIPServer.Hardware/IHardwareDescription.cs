using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPServer.Hardware
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHardwareDescription
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name
        {
            get;
        }

        /// <summary>
        /// Gets or sets the vendor.
        /// </summary>
        /// <value>The vendor.</value>
        string Vendor
        {
            get;
        }
    }
}
