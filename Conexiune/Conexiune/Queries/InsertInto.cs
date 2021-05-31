/**************************************************************************
 *                                                                        *
 *  File:        InsertInto.cs                                            *
 *  Copyright:   (c) 2021, Paraschiv Florin-Vladut                        *
 *  E-mail:      florin-vladut.paraschiv@student.tuiasi.ro                *
 *  Description: Inserting data in database                               *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using DataBase.ConnectionToOracleDB;
using Oracle.ManagedDataAccess.Client;
using System;
using DataBase.Exceptions;
using System.Data;

namespace DataBase.Queries
{
    public class InsertInto
    {
        #region Public static methods
        /// <summary>
        /// Insert player name and points into database
        /// </summary>
        /// <param name="connection"> connection string for Oracle db </param>
        /// <param name="name"> name of the player </param>
        /// <param name="points"> total points he get right </param>
        /// </summary>
        public static void Records(Connection connection, string name, int points)
        {
            OracleConnection connectionString;

            try
            {
                connectionString = connection.ConnectionString;
            }
            catch (Exception)
            {
                throw new ConnectionException("PROBLEM WITH CONNECTION WITH ORACLE DATABASE at InsertIntoRecords");
            }

            try
            {
                OracleCommand command = connectionString.CreateCommand();
                OracleTransaction transaction = connectionString.BeginTransaction(IsolationLevel.ReadCommitted);

                command.Transaction = transaction;

                command.CommandText = "INSERT INTO records(name, points) VALUES (\'" + name + "\', " + points + ")";

                command.ExecuteNonQuery();

                transaction.Commit();

            }
            catch (Exception)
            {
                throw new InsertIntoException("PROBLEM WITH InsertIntoRecords");
            }

        }
        #endregion
    }
}
