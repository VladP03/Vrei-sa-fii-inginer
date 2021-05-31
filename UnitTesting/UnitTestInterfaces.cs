using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfataQuestions;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestInterfaces
    {
        [TestMethod]
        public void TestInterfaceQuestions()
        {
            FormQuestions formQuestions = new FormQuestions();
        }

        [TestMethod]
        public void TestInterfaceBeginning()
        {
            FormBeginning formBeginning = new FormBeginning();
        }

        [TestMethod]
        public void TestInterfaceFinish()
        {
            FormFinish formFinish = new FormFinish(5);
        }

        [TestMethod]
        public void TestInterfaceRecords()
        {
            FormRecords formRecords = new FormRecords();
        }
    }
}
