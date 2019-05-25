namespace SIPServer.Connectors
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ConnectorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorBase"/> class.
        /// </summary>
        public ConnectorBase()
        {
        }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        /// <value>The name of the connector.</value>
        public abstract string ConnectorName
        {
            get;
        }
    }
}
