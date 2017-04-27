using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SIPServer.Management.Database
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DBAccessBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBAccessBase"/> class.
        /// </summary>
        public DBAccessBase()
        {
        }

        #region Properties
        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
        public string ConnectionString
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>The connection.</value>
        public IDbConnection Connection
        {
            get;
            set;
        }
        #endregion

        /// <summary>
        /// Opens this instance.
        /// </summary>
        public void Open()
        {
            if(IsValidConnectionString())
            {
                Connection.Open();
            }
        }

        /// <summary>
        /// Determines whether [is valid connection string].
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if [is valid connection string]; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool IsValidConnectionString();
    }
}