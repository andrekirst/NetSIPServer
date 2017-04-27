using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SIPServer.Model.Header
{
    /// <summary>
    /// 
    /// </summary>
    public class SIPHeader : IMessageHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPHeader"/> class.
        /// </summary>
        public SIPHeader()
        {
            Command = SIPCommands.INVITE;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPHeader"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public SIPHeader(SIPCommands command)
        {
            Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPHeader"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        public SIPHeader(byte[] header)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPHeader"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        public SIPHeader(string header)
        {
            AnalyseHeaderFromString(header);
        }

        /// <summary>
        /// Analyses the header from string.
        /// </summary>
        /// <param name="header">The header.</param>
        public void AnalyseHeaderFromString(string header)
        {
            if(String.IsNullOrEmpty(header))
            {
                throw new ArgumentException(String.Format("The Parameter Header can not be {0}.", header == null ? "null" : "empty"), "header");
            }
            string[] splitter = header.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string item in splitter)
            {
                int firstSpace = item.IndexOf(" ");
                int firstColon = item.IndexOf(":");
                if(firstColon < 0 || firstSpace < 0)
                {
                    continue;
                }
                int z = firstSpace < firstColon ? firstSpace : firstColon;
                string s = item.Substring(0, z);
                string value = item.Substring(z + 1);
                value = value.Trim();
                switch(s)
                {
                    case "REGISTER":
                        {
                            Command = SIPServer.Model.SIPCommands.REGISTER;
                            CommandValue = value;
                            break;
                        }
                    case "INVITE":
                        {
                            Command = SIPServer.Model.SIPCommands.INVITE;
                            CommandValue = value;
                            break;
                        }
                    case "Via":
                        {
                            Via = value;
                            break;
                        }
                    case "From":
                        {
                            From = value;
                            break;
                        }
                    case "To":
                        {
                            To = value;
                            break;
                        }
                    case "Call-ID":
                        {
                            CallID = value;
                            break;
                        }
                    case "CSeq":
                        {
                            string cseq = value.Substring(2);
                            CSeq = (SIPCommands)Enum.Parse(typeof(SIPCommands), cseq);
                            break;
                        }
                    case "Contact":
                        {
                            Contact = value;
                            break;
                        }
                    case "Allow":
                        {
                            Allow = (SIPCommands)Enum.Parse(typeof(SIPCommands), value);
                            break;
                        }
                    case "Max-Forwards":
                        {
                            int maxForwards = 0;
                            Int32.TryParse(value, out maxForwards);
                            MaxForwards = maxForwards;
                            break;
                        }
                    case "User-Agent":
                        {
                            UserAgent = value;
                            break;
                        }
                    case "Expires":
                        {
                            int expires = 0;
                            Int32.TryParse(value, out expires);
                            Expires = expires;
                            break;
                        }
                    case "Content-Length":
                        {
                            int contentLength = 0;
                            Int32.TryParse(value, out contentLength);
                            ContentLength = contentLength;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        #region Properties
        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>To.</value>
        public string To
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public SIPCommands Command
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the command value.
        /// </summary>
        /// <value>The command value.</value>
        public string CommandValue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>From.</value>
        public string From
        {
            get;
            set;
        }

        /// <summary>
        /// To set the IP-Address, Portnumber and the transport protocol for the response
        /// </summary>
        /// <example>
        /// SIP/2.0/UDP 192.168.50.106:5060
        /// </example>
        public string Via
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the max forwards.
        /// </summary>
        /// <value>The max forwards.</value>
        public int MaxForwards
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the call ID.
        /// </summary>
        /// <value>The call ID.</value>
        public string CallID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>The contact.</value>
        public string Contact
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the length of the content.
        /// </summary>
        /// <value>The length of the content.</value>
        public int ContentLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the allow.
        /// </summary>
        /// <value>The allow.</value>
        public SIPCommands Allow
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the C seq.
        /// </summary>
        /// <value>The C seq.</value>
        public SIPCommands CSeq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        public string UserAgent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the expires.
        /// </summary>
        /// <value>The expires.</value>
        public int Expires
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the content.
        /// </summary>
        /// <value>The type of the content.</value>
        public string ContentType
        {
            get;
            set;
        }
        #endregion

        #region IMessageHeader Members

        /// <summary>
        /// Gets the message header version.
        /// </summary>
        /// <value>The message header version.</value>
        public string MessageHeaderVersion
        {
            get
            {
                return "0.0.1.0";
            }
        }

        #endregion
    }
}