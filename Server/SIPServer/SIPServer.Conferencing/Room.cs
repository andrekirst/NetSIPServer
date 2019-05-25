using System;

namespace SIPServer.Conferencing
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Room
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room"/> class.
        /// </summary>
        public Room()
        {
        }

        /// <summary>
        /// Gets or sets the PIN.
        /// </summary>
        /// <value>The PIN.</value>
        public string PIN
        {
            get;
            set;
        }
    }
}