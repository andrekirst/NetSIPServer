using SIPServer.Model;
using System.Data.Common;

namespace SIPServer.Management.Database
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public interface IDBGetData<TModel>
        where TModel : ISIPServerModel
    {
        /// <summary>
        /// Gets the DB data.
        /// </summary>
        /// <param name="dbDataReader">The db data reader.</param>
        /// <returns></returns>
        TModel GetDBData(DbDataReader dbDataReader);
    }
}
