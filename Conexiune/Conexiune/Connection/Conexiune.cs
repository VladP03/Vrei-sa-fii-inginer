/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using BazeDeDate.Exceptions;
using Oracle.ManagedDataAccess.Client;

namespace BazeDeDate.Connection
{
    public class Conexiune
    {
        private static OracleConnection _connectionString = null;
        private static Conexiune _singleInstance = null;

        private Conexiune()
        {
            _connectionString = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=C##ip_admin;Password=proiect;");
        }

        public static Conexiune createConnection()
        {
            try
            {
                if (_singleInstance == null)
                {
                    _singleInstance = new Conexiune();
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

        public OracleConnection ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}
