/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

using System;

namespace DataBase.Exceptions
{
    public class ConnectionException : Exception
    {
        #region Constructor
        public ConnectionException(string message) : base(message)
        {
        }
        #endregion
    }
}
