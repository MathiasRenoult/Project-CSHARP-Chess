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
        private int selectedTurn;
        private double computerDifficulty;
        private Case[,,] grid;

        public Board(double computerDifficulty=0.0)
        {
            this.size = 8;
            this.selectedTurn = 0;
            this.computerDifficulty = computerDifficulty;
            Case[,,] grid = new Case[size, size,100];
            this.grid = grid;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public int SelectedTurn
        {
            get { return selectedTurn; }
            set { selectedTurn = value; }
        }
        public double ComputerDifficulty
        {
            get { return computerDifficulty; }
            set { computerDifficulty = value; }
        }
            
        public Case[,,] Grid
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
                    Piece standardVoid = new VoidCase("void", i, j);
                    grid[i, j,0] = new Case(standardVoid, 0);
                }
            }
        }

        public void NewTurn(Board board)
        {
            for(int i=0; i<8;i++)
            {
                for(int j=0; j<8;j++)
                {
                    board.grid[i, j, selectedTurn + 1] = board.grid[i, j, selectedTurn].DeepCopy();
                }
            }
            selectedTurn++;
        }

        /// <summary>
        /// Clear the board and place each piece on the board
        /// </summary>
        /// <param name="board"></param>
        public void placePieces(Board board)
        {
            board.clearBoard(board);
            //Instancing each piece
            Rook newBlackRook1 = new Rook("black", 0, 0);
            Knight newBlackKnight1 = new Knight("black", 0, 1);
            Bishop newBlackBishop1 = new Bishop("black", 0, 2);
            Queen newBlackQueen = new Queen("black", 0, 3);
            King newBlackKing = new King("black", 0, 4);
            Bishop newBlackBishop2 = new Bishop("black", 0, 5);
            Knight newBlackKnight2 = new Knight("black", 0, 6);
            Rook newBlackRook2 = new Rook("black", 0, 7);

            Pawn newBlackPawn1 = new Pawn("black", 1, 0);
            Pawn newBlackPawn2 = new Pawn("black", 1, 1);
            Pawn newBlackPawn3 = new Pawn("black", 1, 2);
            Pawn newBlackPawn4 = new Pawn("black", 1, 3);
            Pawn newBlackPawn5 = new Pawn("black", 1, 4);
            Pawn newBlackPawn6 = new Pawn("black", 1, 5);
            Pawn newBlackPawn7 = new Pawn("black", 1, 6);
            Pawn newBlackPawn8 = new Pawn("black", 1, 7);


            Rook newWhiteRook1 = new Rook("white", 7, 0);
            Knight newWhiteKnight1 = new Knight("white", 7, 1);
            Bishop newWhiteBishop1 = new Bishop("white", 7, 2);
            Queen newWhiteQueen = new Queen("white", 7, 3);
            King newWhiteKing = new King("white", 7, 4);
            Bishop newWhiteBishop2 = new Bishop("white", 7, 5);
            Knight newWhiteKnight2 = new Knight("white", 7, 6);
            Rook newWhiteRook2 = new Rook("white", 7, 7);

            Pawn newWhitePawn1 = new Pawn("white", 6, 0);
            Pawn newWhitePawn2 = new Pawn("white", 6, 1);
            Pawn newWhitePawn3 = new Pawn("white", 6, 2);
            Pawn newWhitePawn4 = new Pawn("white", 6, 3);
            Pawn newWhitePawn5 = new Pawn("white", 6, 4);
            Pawn newWhitePawn6 = new Pawn("white", 6, 5);
            Pawn newWhitePawn7 = new Pawn("white", 6, 6);
            Pawn newWhitePawn8 = new Pawn("white", 6, 7);

            //Placing each piece on the board
            board.Grid[0, 0, 0].WhoIsOnIt = newBlackRook1;
            board.Grid[0, 1, 0].WhoIsOnIt = newBlackKnight1;
            board.Grid[0, 2, 0].WhoIsOnIt = newBlackBishop1;
            board.Grid[0, 3, 0].WhoIsOnIt = newBlackQueen;
            board.Grid[0, 4, 0].WhoIsOnIt = newBlackKing;
            board.Grid[0, 5, 0].WhoIsOnIt = newBlackBishop2;
            board.Grid[0, 6, 0].WhoIsOnIt = newBlackKnight2;
            board.Grid[0, 7, 0].WhoIsOnIt = newBlackRook2;

            board.Grid[1, 0, 0].WhoIsOnIt = newBlackPawn1;
            board.Grid[1, 1, 0].WhoIsOnIt = newBlackPawn2;
            board.Grid[1, 2, 0].WhoIsOnIt = newBlackPawn3;
            board.Grid[1, 3, 0].WhoIsOnIt = newBlackPawn4;
            board.Grid[1, 4, 0].WhoIsOnIt = newBlackPawn5;
            board.Grid[1, 5, 0].WhoIsOnIt = newBlackPawn6;
            board.Grid[1, 6, 0].WhoIsOnIt = newBlackPawn7;
            board.Grid[1, 7, 0].WhoIsOnIt = newBlackPawn8;

            board.Grid[7, 0, 0].WhoIsOnIt = newWhiteRook1;
            board.Grid[7, 1, 0].WhoIsOnIt = newWhiteKnight1;
            board.Grid[7, 2, 0].WhoIsOnIt = newWhiteBishop1;
            board.Grid[7, 3, 0].WhoIsOnIt = newWhiteQueen;
            board.Grid[7, 4, 0].WhoIsOnIt = newWhiteKing;
            board.Grid[7, 5, 0].WhoIsOnIt = newWhiteBishop2;
            board.Grid[7, 6, 0].WhoIsOnIt = newWhiteKnight2;
            board.Grid[7, 7, 0].WhoIsOnIt = newWhiteRook2;

            board.Grid[6, 0, 0].WhoIsOnIt = newWhitePawn1;
            board.Grid[6, 1, 0].WhoIsOnIt = newWhitePawn2;
            board.Grid[6, 2, 0].WhoIsOnIt = newWhitePawn3;
            board.Grid[6, 3, 0].WhoIsOnIt = newWhitePawn4;
            board.Grid[6, 4, 0].WhoIsOnIt = newWhitePawn5;
            board.Grid[6, 5, 0].WhoIsOnIt = newWhitePawn6;
            board.Grid[6, 6, 0].WhoIsOnIt = newWhitePawn7;
            board.Grid[6, 7, 0].WhoIsOnIt = newWhitePawn8;
        }
    }
}
