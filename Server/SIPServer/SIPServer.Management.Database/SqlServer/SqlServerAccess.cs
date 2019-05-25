namespace SIPServer.Management.Database.SqlServer
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlServerAccess : DBAccessBase
    {
        /// <summary>
        /// Determines whether [is valid connection string].
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if the connectionstring is valid otherwise, <c>false</c>.
        /// </returns>
        public override bool IsValidConnectionString()
        {
            return false;
        }
    }
}