using SIPServer.Model.Body;
using SIPServer.Model.Header;

namespace SIPServer.Model.Messages
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="THeader">The type of the header.</typeparam>
    /// <typeparam name="TBody">The type of the body.</typeparam>
    public abstract class MessageBase<THeader, TBody>
        where TBody : IMessageBody
        where THeader : IMessageHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBase&lt;THeader, TBody&gt;"/> class.
        /// </summary>
        public MessageBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBase&lt;THeader, TBody&gt;"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="body">The body.</param>
        public MessageBase(THeader header, TBody body)
        {
            Header = header;
            Body = body;
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>The header.</value>
        public THeader Header
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        public TBody Body
        {
            get;
            set;
        }
    }
}