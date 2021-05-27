using DataBase.ConnectionToOracleDB;
using Oracle.ManagedDataAccess.Client;
using System;
using DataBase.Exceptions;
using System.Data;

namespace DataBase.Querys
{
    public class InsertInto
    {
        public static void Records(Connection connection, string name, int points)
        {
            try
            {
                OracleConnection connectionString = connection.ConnectionString;
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
    }
}
