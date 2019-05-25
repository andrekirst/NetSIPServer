namespace SIPServer.Model.Header
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMessageHeader
    {
        /// <summary>
        /// Gets the message header version.
        /// </summary>
        /// <value>The message header version.</value>
        string MessageHeaderVersion
        {
            get;
        }
    }
}
