using System;
using System.Net.Sockets;
using System.Net;

namespace SIPServer
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class SIPServerHost
    {
        /// <summary>
        /// The default port.
        /// </summary>
        public const int DEFAULTPORT = 5060;

        private int _port = DEFAULTPORT;

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPServerHost"/> class.
        /// </summary>
        public SIPServerHost()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPServerHost"/> class.
        /// </summary>
        /// <param name="port">The port.</param>
        public SIPServerHost(int port)
        {
            Port = port;
            InitTcpListener();
        }

        /// <summary>
        /// Inits the TCP listener.
        /// </summary>
        private void InitTcpListener()
        {
            TcpListener tcpListener = new TcpListener(localaddr: IPAddress.Any, port: Port);
        }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>The port.</value>
        public int Port
        {
            get
            {
                return _port;
            }
            set
            {
                if(value.IsValidPort())
                {
                    _port = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Port", value, "The Port is not valid.");
                }
            }
        }
    }
}