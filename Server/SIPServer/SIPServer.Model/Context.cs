using System;

namespace SIPServer.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Context
    {
        #region Constants
        /// <summary>
        /// 
        /// </summary>
        public const string STR_GENERAL_CONSTANT = "general";
        /// <summary>
        /// 
        /// </summary>
        public const string STR_GLOBALS_CONSTANT = "globals";
        #endregion

        #region Defaults
        /// <summary>
        /// 
        /// </summary>
        public static Context GENERAL = new Context()
        {
            Name = STR_GENERAL_CONSTANT
        };

        /// <summary>
        /// 
        /// </summary>
        public static Context GLOBALS = new Context()
        {
            Name = STR_GLOBALS_CONSTANT
        };
        #endregion

        #region Member

        /// <summary>
        /// 
        /// </summary>
        private string _name;

        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        public Context()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Context(string name)
        {
            Name = name;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(IsValidContextName(value))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Determines whether [is valid context name] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if [is valid context name] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidContextName(string value)
        {
            // return true if the valie is not empty/null and is a letter/digit
            return !string.IsNullOrEmpty(value) && value.IsLetterOrDigit();
        }
        #endregion
    }
}