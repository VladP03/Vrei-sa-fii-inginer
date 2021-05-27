/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

using System;

namespace DataBase.Exceptions
{
    public class SelectAllFromException : Exception
    {
        #region Constructor
        public SelectAllFromException(string message) : base(message)
        {

        }
        #endregion
    }
}
