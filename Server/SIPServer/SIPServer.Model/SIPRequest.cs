using SIPServer.Model.Messages;

namespace SIPServer.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SIPRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPRequest"/> class.
        /// </summary>
        public SIPRequest()
        {
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public SIPMessage Message
        {
            get;
            set;
        }
    }
}