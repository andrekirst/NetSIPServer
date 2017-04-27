using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPServer.Connectors
{
    /// <summary>
    /// 
    /// </summary>
    public class SkypeConnector : ConnectorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkypeConnector"/> class.
        /// </summary>
        public SkypeConnector()
        {
        }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>The name of the connector.</value>
        public override string ConnectorName
        {
            get
            {
                return "SkypeConnector";
            }
        }
    }
}
