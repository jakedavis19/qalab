using Microsoft.VisualStudio.TestTools.UnitTesting;
using QALab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALab7.Tests
{
    [TestClass()]
    public class ticMethodsTests
    {
        ticMethods test = new ticMethods();

        [TestMethod()]
        public void createBoardTest()
        {
            int expected = 9;
            int actual = test.createBoard().Length;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void currentPlayerTest()
        {
            string expected = "player1";
            string actual = test.currentPlayer(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void currentPlayerTest2()
        {
            string expected = "player2";
            string actual = test.currentPlayer(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void changePlayerTest()
        {
            string expected = "player2";
            string actual = test.changePlayer(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void makeMoveTest()
        {
            string expected = "o";
            string actual = test.makeMove(2, 1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void spaceInUseTest()
        {
            bool expected = false;
            bool actual = test.spaceInUse(1,1);
            Assert.AreEqual(expected, actual);
        }
    }
}