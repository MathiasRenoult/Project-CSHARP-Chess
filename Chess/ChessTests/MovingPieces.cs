using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;

namespace ChessTests
{
    /// <summary>
    /// Description résumée pour MovingPieces
    /// </summary>
    [TestClass]
    public class MovingPieces
    {
        [TestMethod]
        public void TestKnightMoves()
        {
            Board testBoard = new Board();
            testBoard.clearBoard(testBoard);

            Knight newBlackKnight1 = new Knight("black", 4, 4, testBoard);
            testBoard.Grid[4, 4].whoIsOnIt = newBlackKnight1;

            Rook newBlackRook1 = new Rook("black", 2, 5, testBoard);
            testBoard.Grid[2, 5].whoIsOnIt = newBlackRook1;

            Rook newWhiteRook1 = new Rook("white", 5, 6, testBoard);
            testBoard.Grid[5, 6].whoIsOnIt = newWhiteRook1;

            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(5, 6) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(3, 6) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(3, 2) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(5, 2) > 0);

            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(6, 5) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(6, 3) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(2, 3) > 0);
            Assert.IsFalse(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(2, 5) > 0);
        
            //Output the entire board. 0=allowed case to move on, 0 = not allowed case to move on
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                    if(testBoard.Grid[4, 4].whoIsOnIt.CanMoveThere(i, j)>0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine("");
            }

        }

        [TestMethod]
        public void TestPawnMoves()
        {
            Board testBoard = new Board();
            testBoard.clearBoard(testBoard);

            //Tests for black moves
            Pawn newBlackPawn1 = new Pawn("black", 1, 1, testBoard);
            testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt = newBlackPawn1;
            Pawn newBlackPawn2 = new Pawn("black", 1, 5, testBoard);
            testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt = newBlackPawn2;

            Pawn newWhitePawn1 = new Pawn("white", 2, 0, testBoard);
            testBoard.Grid[newWhitePawn1.X, newWhitePawn1.Y].whoIsOnIt = newWhitePawn1;
            Pawn newWhitePawn2 = new Pawn("white", 2, 2, testBoard);
            testBoard.Grid[newWhitePawn2.X, newWhitePawn2.Y].whoIsOnIt = newWhitePawn2;
            Pawn newWhitePawn3 = new Pawn("white", 3, 5, testBoard);
            testBoard.Grid[newWhitePawn3.X, newWhitePawn3.Y].whoIsOnIt = newWhitePawn3;

            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(2, 1)>0);
            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(3, 1)>0);
            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(2, 2)>0);
            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(2, 0)>0);

            Assert.IsFalse(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(0, 1)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(0, 2)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y].whoIsOnIt.CanMoveThere(0, 0)>0);

            Assert.IsTrue(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(2, 5)>0);

            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(3, 5)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(2, 6)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(2, 4)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(0, 5)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(0, 4)>0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y].whoIsOnIt.CanMoveThere(0, 6)>0);


            //Tests fo white pieces
            testBoard.clearBoard(testBoard);

            Pawn newWhitePawn4 = new Pawn("white", 6, 1, testBoard);
            testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt = newWhitePawn4;
            Pawn newWhitePawn5 = new Pawn("white", 6, 5, testBoard);
            testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt = newWhitePawn5;

            Pawn newBlackPawn3 = new Pawn("black", 5, 0, testBoard);
            testBoard.Grid[newBlackPawn3.X, newBlackPawn3.Y].whoIsOnIt = newBlackPawn3;
            Pawn newBlackPawn4 = new Pawn("black", 5, 2, testBoard);
            testBoard.Grid[newBlackPawn4.X, newBlackPawn4.Y].whoIsOnIt = newBlackPawn4;
            Pawn newBlackPawn5 = new Pawn("black", 4, 5, testBoard);
            testBoard.Grid[newBlackPawn5.X, newBlackPawn5.Y].whoIsOnIt = newBlackPawn5;

            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(5, 1)>0);
            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(4, 1)>0);
            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(5, 2)>0);
            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(5, 0)>0);

            Assert.IsFalse(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(7, 1)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(7, 2)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y].whoIsOnIt.CanMoveThere(7, 0)>0);

            Assert.IsTrue(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(5, 5)>0);

            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(4, 5)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(5, 6)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(5, 4)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(7, 5)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(7, 4)>0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y].whoIsOnIt.CanMoveThere(7, 6)>0);
        }
    }
}
