using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    public class Board
    {
        private int size;
        private int turn;
        private double computerDifficulty;
        private Case[,] grid;

        public Board(double computerDifficulty=0.0)
        {
            this.size = 8;
            this.turn = 0;
            this.computerDifficulty = computerDifficulty;
            Case[,] grid = new Case[size, size];
            this.grid = grid;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public double ComputerDifficulty
        {
            get { return computerDifficulty; }
            set { computerDifficulty = value; }
        }
            
        public Case[,] Grid
        {
            get { return grid; }
            set { grid = value; }
        }

        public void clearBoard(Board board)
        {
            int i, j;
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Piece standardVoid = new VoidCase("void", i, j, board);
                    grid[i, j] = new Case(standardVoid, 0);
                }
            }
        }

        public void placePieces(Board board)
        {
            board.clearBoard(board);
            //Instancing each piece
            Rook newBlackRook1 = new Rook("black", 0, 0, board);
            Knight newBlackKnight1 = new Knight("black", 0, 1, board);
            Bishop newBlackBishop1 = new Bishop("black", 0, 2, board);
            Queen newBlackQueen = new Queen("black", 0, 3, board);
            King newBlackKing = new King("black", 0, 4, board);
            Bishop newBlackBishop2 = new Bishop("black", 0, 5, board);
            Knight newBlackKnight2 = new Knight("black", 0, 6, board);
            Rook newBlackRook2 = new Rook("black", 0, 7, board);

            Pawn newBlackPawn1 = new Pawn("black", 1, 0, board);
            Pawn newBlackPawn2 = new Pawn("black", 1, 1, board);
            Pawn newBlackPawn3 = new Pawn("black", 1, 2, board);
            Pawn newBlackPawn4 = new Pawn("black", 1, 3, board);
            Pawn newBlackPawn5 = new Pawn("black", 1, 4, board);
            Pawn newBlackPawn6 = new Pawn("black", 1, 5, board);
            Pawn newBlackPawn7 = new Pawn("black", 1, 6, board);
            Pawn newBlackPawn8 = new Pawn("black", 1, 7, board);


            Rook newWhiteRook1 = new Rook("white", 7, 0, board);
            Knight newWhiteKnight1 = new Knight("white", 7, 1, board);
            Bishop newWhiteBishop1 = new Bishop("white", 7, 2, board);
            Queen newWhiteQueen = new Queen("white", 7, 3, board);
            King newWhiteKing = new King("white", 7, 4, board);
            Bishop newWhiteBishop2 = new Bishop("white", 7, 5, board);
            Knight newWhiteKnight2 = new Knight("white", 7, 6, board);
            Rook newWhiteRook2 = new Rook("white", 7, 7, board);

            Pawn newWhitePawn1 = new Pawn("white", 6, 0, board);
            Pawn newWhitePawn2 = new Pawn("white", 6, 1, board);
            Pawn newWhitePawn3 = new Pawn("white", 6, 2, board);
            Pawn newWhitePawn4 = new Pawn("white", 6, 3, board);
            Pawn newWhitePawn5 = new Pawn("white", 6, 4, board);
            Pawn newWhitePawn6 = new Pawn("white", 6, 5, board);
            Pawn newWhitePawn7 = new Pawn("white", 6, 6, board);
            Pawn newWhitePawn8 = new Pawn("white", 6, 7, board);

            //Placing each piece on the board
            board.Grid[0, 0].WhoIsOnIt = newBlackRook1;
            board.Grid[0, 1].WhoIsOnIt = newBlackKnight1;
            board.Grid[0, 2].WhoIsOnIt = newBlackBishop1;
            board.Grid[0, 3].WhoIsOnIt = newBlackQueen;
            board.Grid[0, 4].WhoIsOnIt = newBlackKing;
            board.Grid[0, 5].WhoIsOnIt = newBlackBishop2;
            board.Grid[0, 6].WhoIsOnIt = newBlackKnight2;
            board.Grid[0, 7].WhoIsOnIt = newBlackRook2;

            board.Grid[1, 0].WhoIsOnIt = newBlackPawn1;
            board.Grid[1, 1].WhoIsOnIt = newBlackPawn2;
            board.Grid[1, 2].WhoIsOnIt = newBlackPawn3;
            board.Grid[1, 3].WhoIsOnIt = newBlackPawn4;
            board.Grid[1, 4].WhoIsOnIt = newBlackPawn5;
            board.Grid[1, 5].WhoIsOnIt = newBlackPawn6;
            board.Grid[1, 6].WhoIsOnIt = newBlackPawn7;
            board.Grid[1, 7].WhoIsOnIt = newBlackPawn8;

            board.Grid[7, 0].WhoIsOnIt = newWhiteRook1;
            board.Grid[7, 1].WhoIsOnIt = newWhiteKnight1;
            board.Grid[7, 2].WhoIsOnIt = newWhiteBishop1;
            board.Grid[7, 3].WhoIsOnIt = newWhiteQueen;
            board.Grid[7, 4].WhoIsOnIt = newWhiteKing;
            board.Grid[7, 5].WhoIsOnIt = newWhiteBishop2;
            board.Grid[7, 6].WhoIsOnIt = newWhiteKnight2;
            board.Grid[7, 7].WhoIsOnIt = newWhiteRook2;

            board.Grid[6, 0].WhoIsOnIt = newWhitePawn1;
            board.Grid[6, 1].WhoIsOnIt = newWhitePawn2;
            board.Grid[6, 2].WhoIsOnIt = newWhitePawn3;
            board.Grid[6, 3].WhoIsOnIt = newWhitePawn4;
            board.Grid[6, 4].WhoIsOnIt = newWhitePawn5;
            board.Grid[6, 5].WhoIsOnIt = newWhitePawn6;
            board.Grid[6, 6].WhoIsOnIt = newWhitePawn7;
            board.Grid[6, 7].WhoIsOnIt = newWhitePawn8;
        }
    }
}
