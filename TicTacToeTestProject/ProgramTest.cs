using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTestProject
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TossTestPos()
        {
            int args = 4;
            PlayerType expected = PlayerType.Human;

            PrivateType privateType = new PrivateType(typeof(Program));
            //PrivateObject privateObject = new PrivateObject(new Program());
            var actual = (PlayerType)privateType.InvokeStatic("Toss", args);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TossTestNeg()
        {
            int args = 59;
            PlayerType expected = PlayerType.Computer;

            PrivateType privateType = new PrivateType(typeof(Program));
            //PrivateObject privateObject = new PrivateObject(new Program());
            var actual = (PlayerType)privateType.InvokeStatic("Toss", args);
            Assert.AreEqual(expected, actual);
        }
    }
}
