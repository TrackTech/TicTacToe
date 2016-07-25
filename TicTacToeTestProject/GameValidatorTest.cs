using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTestProject
{
    [TestClass()]
    public class GameValidatorTest
    {
        #region Memebers
        private TestContext testContextInstance;

        private Player human = new Player() { symbol = 'Y', type = PlayerType.Human };
        private Player computer = new Player() { symbol = 'O', type = PlayerType.Computer };

        #endregion

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Draw Test Method
        /// <summary>
        ///Test a successful draw
        ///</summary>
        [TestMethod()]
        public void ValidateDrawTestPositive()
        {
            int moves = 8; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = GameValidator.ValidateDraw(moves);
            Assert.AreEqual(expected, actual);            
        }

        /// <summary>
        ///A test for un successful draw
        ///</summary>
        [TestMethod()]
        public void ValidateDrawTestNegative()
        {
            int moves = 7; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = GameValidator.ValidateDraw(moves);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Victory Test Methods
        /// <summary>
        ///A test for victory using row rule
        ///</summary>
        [TestMethod()]
        public void ValidateWonTestPosRow()
        {            
            Cell[] matrix = new Cell[5]; // TODO: Initialize to an appropriate value
            matrix[0] = new Cell() { Player = human, Row = 0, Col = 0,IsOccupied=true };
            matrix[1] = new Cell() { Player = computer, Row = 1, Col = 0, IsOccupied = true };
            matrix[2] = new Cell() { Player = human, Row = 0, Col = 1, IsOccupied = true };
            matrix[3] = new Cell() { Player = computer, Row = 1, Col = 1, IsOccupied = true };
            matrix[4] = new Cell() { Player = human, Row = 0, Col = 2, IsOccupied = true };

            Cell lastMove = matrix[4]; // TODO: Initialize to an appropriate value
            int moves = 5; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = GameValidator.ValidateWon(matrix, lastMove, moves);
            Assert.AreEqual(expected, actual);            
        }


        /// <summary>
        ///A test for victory using column rule
        ///</summary>
        [TestMethod()]
        public void ValidateWonTestPosCol()
        {
            Cell[] matrix = new Cell[5]; // TODO: Initialize to an appropriate value
            matrix[0] = new Cell() { Player = human, Row = 0, Col = 0, IsOccupied = true };
            matrix[1] = new Cell() { Player = computer, Row = 0, Col = 1, IsOccupied = true };
            matrix[2] = new Cell() { Player = human, Row = 1, Col = 0, IsOccupied = true };
            matrix[3] = new Cell() { Player = computer, Row = 1, Col = 1, IsOccupied = true };
            matrix[4] = new Cell() { Player = human, Row = 2, Col = 0, IsOccupied = true };

            Cell lastMove = matrix[4]; // TODO: Initialize to an appropriate value
            int moves = 5; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = GameValidator.ValidateWon(matrix, lastMove, moves);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for no vicotry
        ///</summary>
        [TestMethod()]
        public void ValidateWonTestPosDiag()
        {
            Cell[] matrix = new Cell[5]; // TODO: Initialize to an appropriate value
            matrix[0] = new Cell() { Player = human, Row = 0, Col = 0, IsOccupied = true };
            matrix[1] = new Cell() { Player = computer, Row = 1, Col = 0, IsOccupied = true };
            matrix[2] = new Cell() { Player = human, Row = 1, Col = 1, IsOccupied = true };
            matrix[3] = new Cell() { Player = computer, Row = 1, Col = 2, IsOccupied = true };
            matrix[4] = new Cell() { Player = human, Row = 2, Col = 2, IsOccupied = true };

            Cell lastMove = matrix[4]; // TODO: Initialize to an appropriate value
            int moves = 5; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = GameValidator.ValidateWon(matrix, lastMove, moves);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///A test for no vicotry
        ///</summary>
        [TestMethod()]
        public void ValidateWonTestNeg()
        {
            Cell[] matrix = new Cell[5]; // TODO: Initialize to an appropriate value
            matrix[0] = new Cell() { Player = human, Row = 0, Col = 0, IsOccupied = true };
            matrix[1] = new Cell() { Player = computer, Row = 1, Col = 0, IsOccupied = true };
            matrix[2] = new Cell() { Player = human, Row = 2, Col = 1, IsOccupied = true };
            matrix[3] = new Cell() { Player = computer, Row = 1, Col = 1, IsOccupied = true };
            matrix[4] = new Cell() { Player = human, Row = 0, Col = 2, IsOccupied = true };

            Cell lastMove = matrix[4]; // TODO: Initialize to an appropriate value
            int moves = 5; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = GameValidator.ValidateWon(matrix, lastMove, moves);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Private Method Tests
        [TestMethod]
        public void TestPrivateIsLastMovePos()
        {
            PrivateType privateType = new PrivateType(typeof(GameValidator));

            int moves = 8;
            bool expected = true;
            bool actual = (bool)privateType.InvokeStatic("IsLastMove", moves);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPrivateIsLastMoveNeg()
        {
            PrivateType privateType = new PrivateType(typeof(GameValidator));
            int moves = 7;
            bool expected = false;
            bool actual = (bool)privateType.InvokeStatic("IsLastMove", moves);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
