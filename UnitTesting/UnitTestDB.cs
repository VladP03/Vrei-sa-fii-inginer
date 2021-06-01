/**************************************************************************
 *                                                                        *
 *  File:        UnitTestDB.cs                                            *
 *  Copyright:   (c) 2021, Paraschiv Florin-Vladut                        *
 *  E-mail:      florin-vladut.paraschiv@student.tuiasi.ro                *
 *  Description: Unit Testing for Oracle DB                               *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBase.ConnectionToOracleDB;
using DataBase.Exceptions;
using DataBase.Queries;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestDB
    {
        [TestMethod]
        public void TestConnectionOpen()
        {
            Connection connectionToOracleDB;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }

        [TestMethod]
        public void TestConnectionClose()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            try
            {
                connectionToOracleDB.closeConnection();
                connectionToOracleDB = null;
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ConnectionException))]
        public void TestInsertIntoWithoutConnection()
        {
            Connection connectionToOracleDB = null;

            InsertInto.Records(connectionToOracleDB, "Test", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ConnectionException))]
        public void TestSelectAllFromQuestionsWithoutConnection()
        {
            Connection connectionToOracleDB = null;

            SelectAll.FromQuestions(connectionToOracleDB);
        }

        [TestMethod]
        [ExpectedException(typeof(ConnectionException))]
        public void TestSelectAllFromRecordsWithoutConnection()
        {
            Connection connectionToOracleDB = null;

            SelectAll.FromRecords(connectionToOracleDB);
        }

        [TestMethod]
        [ExpectedException(typeof(InsertIntoException))]
        public void TestInsertIntoWithConnection_1_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            connectionToOracleDB.closeConnection();

            InsertInto.Records(connectionToOracleDB, "Test", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InsertIntoException))]
        public void TestInsertIntoWithConnection_2_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            InsertInto.Records(connectionToOracleDB, "Test", 0);

            connectionToOracleDB.closeConnection();

            InsertInto.Records(connectionToOracleDB, "Test", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(SelectAllFromException))]
        public void TestSelectAllWithConnection_1_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            connectionToOracleDB.closeConnection();

            SelectAll.FromQuestions(connectionToOracleDB);
        }

        [TestMethod]
        [ExpectedException(typeof(SelectAllFromException))]
        public void TestSelectAllWithConnection_2_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            SelectAll.FromQuestions(connectionToOracleDB);

            connectionToOracleDB.closeConnection();

            SelectAll.FromQuestions(connectionToOracleDB);
        }

        [TestMethod]
        [ExpectedException(typeof(SelectAllFromException))]
        public void TestSelectAllWithConnection_3_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            connectionToOracleDB.closeConnection();

            SelectAll.FromRecords(connectionToOracleDB);
        }

        [TestMethod]
        [ExpectedException(typeof(SelectAllFromException))]
        public void TestSelectAllWithConnection_4_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            SelectAll.FromRecords(connectionToOracleDB);

            connectionToOracleDB.closeConnection();

            SelectAll.FromRecords(connectionToOracleDB);
        }

        [TestMethod]
        [ExpectedException(typeof(InsertIntoException))]
        public void TestInsertIntoWithConnectionButBadParameters()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            InsertInto.Records(connectionToOracleDB, null, 0);
        }



        [TestMethod]
        public void TestInsertIntoWithEverythingGood_1_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            InsertInto.Records(connectionToOracleDB, "Test", 0);
        }

        [TestMethod]
        public void TestInsertIntoWithEverythingGood_2_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            InsertInto.Records(connectionToOracleDB, "Test", 0);

            connectionToOracleDB.closeConnection();
        }

        [TestMethod]
        public void TestSelectAllFromRecordsWithEverythingGood_1_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            SelectAll.FromRecords(connectionToOracleDB);
        }

        [TestMethod]
        public void TestSelectAllFromRecordsWithEverythingGood_2_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            SelectAll.FromRecords(connectionToOracleDB);

            connectionToOracleDB.closeConnection();
        }


        [TestMethod]
        public void TestSelectAllFromQuestionsWithEverythingGood_1_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            SelectAll.FromQuestions(connectionToOracleDB);
        }

        [TestMethod]
        public void TestSelectAllFromQuestionsWithEverythingGood_2_()
        {
            Connection connectionToOracleDB = null;

            try
            {
                connectionToOracleDB = Connection.createConnection();
            }
            catch (ConnectionException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

            SelectAll.FromQuestions(connectionToOracleDB);

            connectionToOracleDB.closeConnection();
        }
    }
}
