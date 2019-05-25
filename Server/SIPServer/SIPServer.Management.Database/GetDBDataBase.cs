namespace SIPServer.Management.Database
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class GetDBDataBase : DBAccessBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDBDataBase"/> class.
        /// </summary>
        public GetDBDataBase(DBAccessBase dbAccessBase)
        {
            DBAccessBase = dbAccessBase;
        }

        /// <summary>
        /// Gets or sets the DB access base.
        /// </summary>
        /// <value>The DB access base.</value>
        public DBAccessBase DBAccessBase
        {
            get;
            set;
        }
    }
}