/* * * * * * * * * * * * * * * * * * * * * * * * *
 *          Owner: Paraschiv Vlad                *
 * * * * * * * * * * * * * * * * * * * * * * * * */

using DataBase.Entities;
using DataBase.Exceptions;
using DataBase.ConnectionToOracleDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace DataBase.Querys
{
    public class SelectAll
    {
        #region Public Static Methods
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
