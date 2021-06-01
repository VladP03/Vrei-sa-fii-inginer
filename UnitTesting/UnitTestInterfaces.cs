/**************************************************************************
 *                                                                        *
 *  File:        UnitTestInterfaces.cs                                    *
 *  Copyright:   (c) 2021, Butnaru Silviu                                 *
 *  E-mail:      silviu.butnaru@student.tuiasi.ro                         *
 *  Description: Unit Testing interfaces                                  *
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
