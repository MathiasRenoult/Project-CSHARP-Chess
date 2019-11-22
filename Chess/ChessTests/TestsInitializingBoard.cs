using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;

namespace ChessTests
{
    [TestClass]
    public class InitialisingBoard
    {
        [TestMethod]
        public void CreateAnEmptyBoard()
        {
            int expectedValue = 0;
            int i, j;
            Board testBoard = new Board(0);
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    Assert.AreEqual(testBoard.Grid[i,j], expectedValue);
                }
            }
        }
    }
}
