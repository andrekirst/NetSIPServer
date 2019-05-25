using SIPServer.Model.Header;
using SIPServer.Model.Body;

namespace SIPServer.Model.Messages
{
    /// <summary>
    /// 
    /// </summary>
    public class SIPMessage : MessageBase<SIPHeader, SIPBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPMessage"/> class.
        /// </summary>
        public SIPMessage()
        {
        }
    }
}