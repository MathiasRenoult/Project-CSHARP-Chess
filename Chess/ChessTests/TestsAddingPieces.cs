using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;

namespace ChessTests
{
    [TestClass]
    public class AdddingPieces
    {
        [TestMethod]
        public void AddingPawn()
        {
             string actualColor = "white";
            int actualX = 4;
            int actualY = 5;
            Board newBoard = new Board();
            Pawn p1 = new Pawn(actualColor,actualX,actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingKnight()
        {
            string actualColor = "black";
            int actualX = 6;
            int actualY = 7;
            Board newBoard = new Board();
            Knight p1 = new Knight(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingRook()
        {
            string actualColor = "black";
            int actualX = 1;
            int actualY = 2;
            Board newBoard = new Board();
            Rook p1 = new Rook(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingBishop()
        {
            string actualColor = "black";
            int actualX = 4;
            int actualY = 4;
            Board newBoard = new Board();
            Bishop p1 = new Bishop(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingQueen()
        {
            string actualColor = "black";
            int actualX = 7;
            int actualY = 7;
            Board newBoard = new Board();
            Queen p1 = new Queen(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingKing()
        {
            string actualColor = "black";
            int actualX = 0;
            int actualY = 4;
            Board newBoard = new Board();
            King p1 = new King(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
    }
}
