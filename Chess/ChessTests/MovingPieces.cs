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

            Knight newBlackKnight1 = new Knight("black", 4, 4);
            testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt = newBlackKnight1;

            Rook newBlackRook1 = new Rook("black", 2, 5);
            testBoard.Grid[2, 5, testBoard.SelectedTurn].WhoIsOnIt = newBlackRook1;

            Rook newWhiteRook1 = new Rook("white", 5, 6);
            testBoard.Grid[5, 6, testBoard.SelectedTurn].WhoIsOnIt = newWhiteRook1;

            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 6, testBoard) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(3, 6, testBoard) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(3, 2, testBoard) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 2, testBoard) > 0);

            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(6, 5, testBoard) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(6, 3, testBoard) > 0);
            Assert.IsTrue(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 3, testBoard) > 0);
            Assert.IsFalse(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 5, testBoard) > 0);
        
            //Output the entire board. 0=allowed case to move on, 0 = not allowed case to move on
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                    if(testBoard.Grid[4, 4, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(i, j, testBoard) >0)
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
            Pawn newBlackPawn1 = new Pawn("black", 1, 1);
            testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt = newBlackPawn1;
            Pawn newBlackPawn2 = new Pawn("black", 1, 5);
            testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt = newBlackPawn2;

            Pawn newWhitePawn1 = new Pawn("white", 2, 0);
            testBoard.Grid[newWhitePawn1.X, newWhitePawn1.Y, testBoard.SelectedTurn].WhoIsOnIt = newWhitePawn1;
            Pawn newWhitePawn2 = new Pawn("white", 2, 2);
            testBoard.Grid[newWhitePawn2.X, newWhitePawn2.Y, testBoard.SelectedTurn].WhoIsOnIt = newWhitePawn2;
            Pawn newWhitePawn3 = new Pawn("white", 3, 5);
            testBoard.Grid[newWhitePawn3.X, newWhitePawn3.Y, testBoard.SelectedTurn].WhoIsOnIt = newWhitePawn3;

            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 1, testBoard) >0);
            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(3, 1, testBoard) >0);
            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 2, testBoard) >0);
            Assert.IsTrue(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 0, testBoard) >0);

            Assert.IsFalse(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(0, 1, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(0, 2, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn1.X, newBlackPawn1.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(0, 0, testBoard) >0);

            Assert.IsTrue(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 5, testBoard) >0);

            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(3, 5, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 6, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(2, 4, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(0, 5, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(0, 4, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newBlackPawn2.X, newBlackPawn2.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(0, 6, testBoard) >0);


            //Tests fo white pieces
            testBoard.clearBoard(testBoard);

            Pawn newWhitePawn4 = new Pawn("white", 6, 1);
            testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt = newWhitePawn4;
            Pawn newWhitePawn5 = new Pawn("white", 6, 5);
            testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt = newWhitePawn5;

            Pawn newBlackPawn3 = new Pawn("black", 5, 0);
            testBoard.Grid[newBlackPawn3.X, newBlackPawn3.Y, testBoard.SelectedTurn].WhoIsOnIt = newBlackPawn3;
            Pawn newBlackPawn4 = new Pawn("black", 5, 2);
            testBoard.Grid[newBlackPawn4.X, newBlackPawn4.Y, testBoard.SelectedTurn].WhoIsOnIt = newBlackPawn4;
            Pawn newBlackPawn5 = new Pawn("black", 4, 5);
            testBoard.Grid[newBlackPawn5.X, newBlackPawn5.Y, testBoard.SelectedTurn].WhoIsOnIt = newBlackPawn5;

            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 1, testBoard) >0);
            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(4, 1, testBoard) >0);
            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 2, testBoard) >0);
            Assert.IsTrue(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 0, testBoard) >0);

            Assert.IsFalse(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(7, 1, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(7, 2, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn4.X, newWhitePawn4.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(7, 0, testBoard) >0);

            Assert.IsTrue(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 5, testBoard) >0);

            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(4, 5, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 6, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(5, 4, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(7, 5, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(7, 4, testBoard) >0);
            Assert.IsFalse(testBoard.Grid[newWhitePawn5.X, newWhitePawn5.Y, testBoard.SelectedTurn].WhoIsOnIt.CanMoveThere(7, 6, testBoard) >0);
        }
    }
}
