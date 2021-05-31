/**************************************************************************
 *                                                                        *
 *  File:        Connection.cs                                            *
 *  Copyright:   (c) 2021, Paraschiv Florin-Vladut                        *
 *  E-mail:      florin-vladut.paraschiv@student.tuiasi.ro                *
 *  Description: Connection to Oracle database                            *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
        /// Open the connection to the Oracle DB with connection string
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
        /// Close connection with Oracle db
        /// </summary>
        public void closeConnection()
        {
            try
            {
                if (_singleInstance != null)
                {
                    _connectionString.Close();
                    Console.WriteLine("Closed connection to oracle db succesfully");
                    _singleInstance = null;
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
        /// Return connection string for Oracle db
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
