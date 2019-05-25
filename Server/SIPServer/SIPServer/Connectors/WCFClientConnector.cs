namespace SIPServer.Connectors
{
    /// <summary>
    /// 
    /// </summary>
    public class WCFClientConnector : ConnectorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WCFClientConnector"/> class.
        /// </summary>
        public WCFClientConnector()
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
                return "WCFClientConnector";
            }
        }
    }
}
