using BazeDeDate.Entities;
using BazeDeDate.Exceptions;
using BazeDeDate.Connection;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace BazeDeDate.Querys
{
    public class SelectAll
    {
        public static List<Records> FromRecords(Conexiune connection)
        {
            try
            {
                OracleConnection connectionString = connection.ConnectionString;
                List<Records> records = new List<Records>();

                OracleCommand command = new OracleCommand(
                    "Select * FROM records WHERE ROWNUM <=3 ORDER BY points DESC",
                    connectionString);

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Records temp = new Records(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetValue(3));
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

        public static List<Questions> FromQuestions(Conexiune connection)
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
                            Questions temp = new Questions(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
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
    }
}
