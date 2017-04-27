using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIPServer.Model.Database;
using System.Data.Common;

namespace SIPServer.Management.Database.DataAccessModel
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceDataAccess : IDBGetData<Service>
    {
        /// <summary>
        /// 
        /// </summary>
        private const string STR_CONTRACTNAME = "CONTRACTNAME";
        /// <summary>
        /// 
        /// </summary>
        private const string STR_ServiceID = "ServiceID";
        #region IDBGetData<Service> Members

        /// <summary>
        /// Gets the DB data.
        /// </summary>
        /// <param name="dbDataReader">The db data reader.</param>
        /// <returns></returns>
        public Service GetDBData(DbDataReader dbDataReader)
        {
            if(dbDataReader == null)
            {
                throw new NullReferenceException("The DbDataReader-Object can not be null");
            }
            if(dbDataReader.FieldCount == 0)
            {
                throw new Exception("The FieldCount is 0");
            }

            return new Service()
            {
                ContractName = dbDataReader.GetString(STR_CONTRACTNAME),
                ServiceID = dbDataReader.GetInt32(STR_ServiceID)
            };
        }

        #endregion
    }
}
