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
            double actualX = 4;
            double actualY = 5;
            Pawn p1 = new Pawn(actualColor,actualX,actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingKnight()
        {
            string actualColor = "black";
            double actualX = 6;
            double actualY = 7;
            Knight p1 = new Knight(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingRook()
        {
            string actualColor = "black";
            double actualX = 1;
            double actualY = 2;
            Rook p1 = new Rook(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingBishop()
        {
            string actualColor = "black";
            double actualX = 4;
            double actualY = 4;
            Bishop p1 = new Bishop(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingQueen()
        {
            string actualColor = "black";
            double actualX = 7;
            double actualY = 7;
            Queen p1 = new Queen(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
        [TestMethod]
        public void AddingKing()
        {
            string actualColor = "black";
            double actualX = 0;
            double actualY = 4;
            King p1 = new King(actualColor, actualX, actualY);

            Assert.AreEqual(p1.Color, actualColor);
            Assert.AreEqual(p1.X, actualX);
            Assert.AreEqual(p1.Y, actualY);
        }
    }
}
