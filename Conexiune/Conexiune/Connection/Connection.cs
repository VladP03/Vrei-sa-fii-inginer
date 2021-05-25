/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using DataBase.Exceptions;
using Oracle.ManagedDataAccess.Client;

namespace DataBase.ConnectionToOracleDB
{
    public class Connection
    {
        #region Fields
        private static OracleConnection _connectionString = null;
        private static Connection _singleInstance = null;
        #endregion

        #region Private Constructor
        /// <summary>
        /// Initialize connection string for connection
        /// </summary>
        private Connection()
        {
            _connectionString = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=C##ip_admin;Password=proiect;");
        }
        #endregion

        #region Public Static Method
        /// <summary>
        /// Open the connection to the ORACLE DB with connection string
        /// Singleton Design Pattern used
        /// </summary>
        /// <returns> An singleton object used for create, close and get DB </returns>
        public static Connection createConnection()
        {
            try
            {
                if (_singleInstance == null)
                {
                    _singleInstance = new Connection();
                    _connectionString.Open();
                    Console.WriteLine("Connection to oracle db succesfully");
                }

                return _singleInstance;
            }
            catch
            {
                throw new ConnectionException("PROBLEM WITH CONNECTION WITH ORACLE DATABASE");
            }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Close connection with ORACLE db
        /// </summary>
        public void closeConnection()
        {
            try
            {
                if (_singleInstance != null)
                {
                    _connectionString.Close();
                    Console.WriteLine("Closed connection to oracle db succesfully");
                }
            }
            catch
            {
                throw new ConnectionException("PROBLEM WITH CLOSING ORACLE DATABASE");
            }
        }
        #endregion

        #region Getter
        /// <summary>
        /// Return connection string for ORACLE db
        /// </summary>
        public OracleConnection ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
        #endregion
    }
}
