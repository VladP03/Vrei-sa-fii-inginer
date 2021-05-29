/**************************************************************************
 *                                                                        *
 *  File:        InsertInto.cs                                            *
 *  Copyright:   (c) 2021, Paraschiv Florin-Vladut                        *
 *  E-mail:      florin-vladut.paraschiv@student.tuiasi.ro                *
 *  Description: Selecting data from database                             *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using DataBase.Entities;
using DataBase.Exceptions;
using DataBase.ConnectionToOracleDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace DataBase.Queries
{
    public class SelectAll
    {
        #region Public Static Methods
        /// <summary>
        /// Selecting name and points for hall of fame
        /// </summary>
        /// <param name="connection"> connection string for Oracle db </param>
        /// <returns> An list of records </returns>
        public static List<Records> FromRecords(Connection connection)
        {
            try
            {
                OracleConnection connectionString = connection.ConnectionString;
                List<Records> records = new List<Records>();

                OracleCommand command = new OracleCommand(
                    "Select * FROM records ORDER BY points DESC",
                    connectionString);

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Records temp = new Records(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                        records.Add(temp);
                    }
                }

                return records;
            }
            catch (Exception)
            {
                throw new SelectAllFromException("PROBLEM WITH selectAllFromRecords");
            }
        }

        /// <summary>
        /// Selecting course, questions and answers from db
        /// </summary>
        /// <param name="connection"></param>
        /// <returns> An list of questions </returns>
        public static List<Questions> FromQuestions(Connection connection)
        {
            try
            {
                OracleConnection connectionString = connection.ConnectionString;
                List<Questions> questions = new List<Questions>();

                OracleCommand command = new OracleCommand(
                    "Select * FROM questions",
                    connectionString);
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Questions temp = new Questions(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                            questions.Add(temp);
                        }
                    }
                }

                return questions;
            }
            catch (Exception)
            {
                throw new SelectAllFromException("PROBLEM WITH selectAllFromQuestions");
            }
        }
        #endregion
    }
}
