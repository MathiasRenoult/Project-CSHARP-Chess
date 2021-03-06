﻿using System;
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
            Case expectedValue = new Case();
            int i, j;
            Board testBoard = new Board();
            testBoard.clearBoard(testBoard);
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    Assert.AreEqual(testBoard.Grid[i, j, 0].Color, expectedValue.Color);
                    Assert.AreEqual(testBoard.Grid[i, j, 0].IsAttacked, expectedValue.IsAttacked);
                  
                }
            }
        }

        [TestMethod]
        public void CreateStandardBoard() //Create a standard board, fill it with pieces then test each case content
        {
            Board testBoard = new Board();
            testBoard.clearBoard(testBoard);
            testBoard.placePieces(testBoard);
            //Testing each board's case content
            Piece piece;

            //Black Pieces
            piece = testBoard.Grid[0, 0, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Rook));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 1, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Knight));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 2, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Bishop));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 3, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Queen));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 4, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(King));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 5, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Bishop));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 6, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Knight));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[0, 7, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Rook));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 0, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 1, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 2, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 3, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 4, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 5, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 6, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            piece = testBoard.Grid[1, 7, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "black");

            //White Pieces
            piece = testBoard.Grid[7, 0, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Rook));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 1, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Knight));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 2, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Bishop));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 3, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Queen));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 4, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(King));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 5, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Bishop));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 6, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Knight));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[7, 7, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Rook));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 0, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 1, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 2, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 3, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 4, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 5, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 6, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

            piece = testBoard.Grid[6, 7, 0].WhoIsOnIt;
            Assert.IsInstanceOfType(piece, typeof(Pawn));
            Assert.AreEqual(piece.Color, "white");

        }
    }
}
