using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace SIPServer.Services.Contracts.FaultContracts
{
    /// <summary>
    /// 
    /// </summary>
    public class SIPPhoneNotAvailableFault
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPPhoneNotAvailableFault"/> class.
        /// </summary>
        public SIPPhoneNotAvailableFault()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPPhoneNotAvailableFault"/> class.
        /// </summary>
        /// <param name="notAvailableSIPPhone">The not available SIP phone.</param>
        public SIPPhoneNotAvailableFault(string notAvailableSIPPhone)
        {
            NotAvailableSIPPhone = notAvailableSIPPhone;
        }

        /// <summary>
        /// Gets or sets the not available SIP phone.
        /// </summary>
        /// <value>The not available SIP phone.</value>
        public string NotAvailableSIPPhone
        {
            get;
            private set;
        }
    }
}
