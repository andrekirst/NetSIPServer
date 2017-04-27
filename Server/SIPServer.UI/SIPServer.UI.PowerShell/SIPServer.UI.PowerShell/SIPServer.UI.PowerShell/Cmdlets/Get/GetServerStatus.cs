using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using SIPServer.UI.PowerShell.ManagementServiceReference;

namespace SIPServer.UI.PowerShell.Cmdlets.Get
{
    /// <summary>
    /// 
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "ServerStatus")]
    public class GetServerStatus : NetSIPServerCmdletBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServerStatus"/> class.
        /// </summary>
        public GetServerStatus()
        {
        }

        /// <summary>
        /// Begins the processing.
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        /// <summary>
        /// Ends the processing.
        /// </summary>
        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        /// <summary>
        /// Processes the record.
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
        }

        /// <summary>
        /// Stops the processing.
        /// </summary>
        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

        /// <summary>
        /// Gets the error record.
        /// </summary>
        /// <value>The error record.</value>
        public override ErrorRecord ErrorRecord
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}