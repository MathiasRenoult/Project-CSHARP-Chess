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
            Case expectedValue = new Case();
            int i, j;
            Board testBoard = new Board();
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    Assert.AreEqual(testBoard.Grid[i,j].Color, expectedValue.Color);
                    Assert.AreEqual(testBoard.Grid[i, j].IsAttacked, expectedValue.IsAttacked);
                  
                }
            }
        }

        [TestMethod]
        public void CreateStandardBoard() //Create a standard board, fill it with pieces then test each case content
        {
            Board testBoard = new Board();
            //Instancing each piece
            Rook newBlackRook1 = new Rook("black",0,0,false);
            Knight newBlackKnight1= new Knight("black", 0, 1, false);
            Bishop newBlackBishop1 = new Bishop("black", 0, 2, false);
            Queen newBlackQueen = new Queen("black", 0, 3, false);
            King newBlackKing = new King("black", 0, 4, false);
            Bishop newBlackBishop2 = new Bishop("black", 0, 5, false);
            Knight newBlackKnight2 = new Knight("black", 0, 6, false);
            Rook newBlackRook2 = new Rook("black", 0, 7, false);

            Pawn newBlackPawn1 = new Pawn("black", 1, 0, false);
            Pawn newBlackPawn2 = new Pawn("black", 1, 1, false);
            Pawn newBlackPawn3 = new Pawn("black", 1, 2, false);
            Pawn newBlackPawn4 = new Pawn("black", 1, 3, false);
            Pawn newBlackPawn5 = new Pawn("black", 1, 4, false);
            Pawn newBlackPawn6 = new Pawn("black", 1, 5, false);
            Pawn newBlackPawn7 = new Pawn("black", 1, 6, false);
            Pawn newBlackPawn8 = new Pawn("black", 1, 7, false);
            

            Rook newWhiteRook1 = new Rook("white", 0, 0, false);
            Knight newWhiteKnight1 = new Knight("white", 0, 1, false);
            Bishop newWhiteBishop1 = new Bishop("white", 0, 2, false);
            Queen newWhiteQueen = new Queen("white", 0, 3, false);
            King newWhiteKing = new King("white", 0, 4, false);
            Bishop newWhiteBishop2 = new Bishop("white", 0, 5, false);
            Knight newWhiteKnight2 = new Knight("white", 0, 6, false);
            Rook newWhiteRook2 = new Rook("white", 0, 7, false);

            Pawn newWhitePawn1 = new Pawn("white", 1, 0, false);
            Pawn newWhitePawn2 = new Pawn("white", 1, 1, false);
            Pawn newWhitePawn3 = new Pawn("white", 1, 2, false);
            Pawn newWhitePawn4 = new Pawn("white", 1, 3, false);
            Pawn newWhitePawn5 = new Pawn("white", 1, 4, false);
            Pawn newWhitePawn6 = new Pawn("white", 1, 5, false);
            Pawn newWhitePawn7 = new Pawn("white", 1, 6, false);
            Pawn newWhitePawn8 = new Pawn("white", 1, 7, false);

            //Placing each piece on the board
            testBoard.Grid[0, 0].WhoIsOnIt = newBlackRook1;
            testBoard.Grid[0, 1].WhoIsOnIt = newBlackKnight1;
            testBoard.Grid[0, 2].WhoIsOnIt = newBlackBishop1;
            testBoard.Grid[0, 3].WhoIsOnIt = newBlackQueen;
            testBoard.Grid[0, 4].WhoIsOnIt = newBlackKing;
            testBoard.Grid[0, 5].WhoIsOnIt = newBlackBishop2;
            testBoard.Grid[0, 6].WhoIsOnIt = newBlackKnight2;
            testBoard.Grid[0, 7].WhoIsOnIt = newBlackRook2;

            testBoard.Grid[1, 0].WhoIsOnIt = newBlackPawn1;
            testBoard.Grid[1, 1].WhoIsOnIt = newBlackPawn2;
            testBoard.Grid[1, 2].WhoIsOnIt = newBlackPawn3;
            testBoard.Grid[1, 3].WhoIsOnIt = newBlackPawn4;
            testBoard.Grid[1, 4].WhoIsOnIt = newBlackPawn5;
            testBoard.Grid[1, 5].WhoIsOnIt = newBlackPawn6;
            testBoard.Grid[1, 6].WhoIsOnIt = newBlackPawn7;
            testBoard.Grid[1, 7].WhoIsOnIt = newBlackPawn8;

            testBoard.Grid[7, 0].WhoIsOnIt = newWhiteRook1;
            testBoard.Grid[7, 1].WhoIsOnIt = newWhiteKnight1;
            testBoard.Grid[7, 2].WhoIsOnIt = newWhiteBishop1;
            testBoard.Grid[7, 3].WhoIsOnIt = newWhiteQueen;
            testBoard.Grid[7, 4].WhoIsOnIt = newWhiteKing;
            testBoard.Grid[7, 5].WhoIsOnIt = newWhiteBishop2;
            testBoard.Grid[7, 6].WhoIsOnIt = newWhiteKnight2;
            testBoard.Grid[7, 7].WhoIsOnIt = newWhiteRook2;

            testBoard.Grid[6, 0].WhoIsOnIt = newWhitePawn1;
            testBoard.Grid[6, 1].WhoIsOnIt = newWhitePawn2;
            testBoard.Grid[6, 2].WhoIsOnIt = newWhitePawn3;
            testBoard.Grid[6, 3].WhoIsOnIt = newWhitePawn4;
            testBoard.Grid[6, 4].WhoIsOnIt = newWhitePawn5;
            testBoard.Grid[6, 5].WhoIsOnIt = newWhitePawn6;
            testBoard.Grid[6, 6].WhoIsOnIt = newWhitePawn7;
            testBoard.Grid[6, 7].WhoIsOnIt = newWhitePawn8;

            //Testing each board's case content
            Assert.AreEqual(testBoard.Grid[0, 0].WhoIsOnIt,newBlackRook1);
            Assert.AreEqual(testBoard.Grid[0, 1].WhoIsOnIt, newBlackKnight1);
            Assert.AreEqual(testBoard.Grid[0, 2].WhoIsOnIt, newBlackBishop1);
            Assert.AreEqual(testBoard.Grid[0, 3].WhoIsOnIt, newBlackQueen);
            Assert.AreEqual(testBoard.Grid[0, 4].WhoIsOnIt, newBlackKing);
            Assert.AreEqual(testBoard.Grid[0, 5].WhoIsOnIt, newBlackBishop2);
            Assert.AreEqual(testBoard.Grid[0, 6].WhoIsOnIt, newBlackKnight2);
            Assert.AreEqual(testBoard.Grid[0, 7].WhoIsOnIt, newBlackRook2);
 
            Assert.AreEqual(testBoard.Grid[1, 0].WhoIsOnIt, newBlackPawn1);
            Assert.AreEqual(testBoard.Grid[1, 1].WhoIsOnIt, newBlackPawn2);
            Assert.AreEqual(testBoard.Grid[1, 2].WhoIsOnIt, newBlackPawn3);
            Assert.AreEqual(testBoard.Grid[1, 3].WhoIsOnIt, newBlackPawn4);
            Assert.AreEqual(testBoard.Grid[1, 4].WhoIsOnIt, newBlackPawn5);
            Assert.AreEqual(testBoard.Grid[1, 5].WhoIsOnIt, newBlackPawn6);
            Assert.AreEqual(testBoard.Grid[1, 6].WhoIsOnIt, newBlackPawn7);
            Assert.AreEqual(testBoard.Grid[1, 7].WhoIsOnIt, newBlackPawn8);

            Assert.AreEqual(testBoard.Grid[7, 0].WhoIsOnIt, newWhiteRook1);
            Assert.AreEqual(testBoard.Grid[7, 1].WhoIsOnIt, newWhiteKnight1);
            Assert.AreEqual(testBoard.Grid[7, 2].WhoIsOnIt, newWhiteBishop1);
            Assert.AreEqual(testBoard.Grid[7, 3].WhoIsOnIt, newWhiteQueen);
            Assert.AreEqual(testBoard.Grid[7, 4].WhoIsOnIt, newWhiteKing);
            Assert.AreEqual(testBoard.Grid[7, 5].WhoIsOnIt, newWhiteBishop2);
            Assert.AreEqual(testBoard.Grid[7, 6].WhoIsOnIt, newWhiteKnight2);
            Assert.AreEqual(testBoard.Grid[7, 7].WhoIsOnIt, newWhiteRook2);

            Assert.AreEqual(testBoard.Grid[6, 0].WhoIsOnIt, newWhitePawn1);
            Assert.AreEqual(testBoard.Grid[6, 1].WhoIsOnIt, newWhitePawn2);
            Assert.AreEqual(testBoard.Grid[6, 2].WhoIsOnIt, newWhitePawn3);
            Assert.AreEqual(testBoard.Grid[6, 3].WhoIsOnIt, newWhitePawn4);
            Assert.AreEqual(testBoard.Grid[6, 4].WhoIsOnIt, newWhitePawn5);
            Assert.AreEqual(testBoard.Grid[6, 5].WhoIsOnIt, newWhitePawn6);
            Assert.AreEqual(testBoard.Grid[6, 6].WhoIsOnIt, newWhitePawn7);
            Assert.AreEqual(testBoard.Grid[6, 7].WhoIsOnIt, newWhitePawn8);

        }
    }
}
