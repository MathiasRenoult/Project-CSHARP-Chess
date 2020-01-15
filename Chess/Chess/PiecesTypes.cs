using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class VoidCase : Piece
    {
        public VoidCase(string color, int x, int y) : base("void",x,y)
        {

        }
        public override int CanMoveThere(int x, int y, Board board)
        {
            return 0;
        }
    }
    public class Pawn : Piece
    {
        public Pawn(string color,int x,int y) : base(color,x,y)
        {

        }
        /// <summary>
        /// the pawn deplacement
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override int CanMoveThere(int x, int y, Board board)
        {
            int biggerMove = 0;
            if (board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color == this.Color || (x - this.X < 0 && this.Color == "black") || (x - this.X > 0 && this.Color == "white"))
            {
                return 0;
            }
            else
            {
                if ((this.Color == "white" && this.X == 6) ||
                     (this.Color == "black" && this.X == 1))
                {
                    biggerMove = 1;
                }
                if (Math.Abs(this.Y - y) == 1 && board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color != this.Color && board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color != "void" && Math.Abs(x - this.X) == 1)
                {
                    return 1;
                }
                else
                {
                    if (board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color == "void" && Math.Abs(this.Y - y) == 0 && Math.Abs(x - this.X) == 1 + biggerMove)
                    {
                        return 2;
                    }
                    if(board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color == "void" && Math.Abs(this.Y - y) == 0 && Math.Abs(x - this.X) == 1)
                    {
                        return 1;
                    }
                    return 0;
                }
            }
        }
    }
    public class Knight : Piece
    {
        public Knight(string color, int x, int y) : base(color, x, y)
        {

        }
        /// <summary>
        /// the knight deplacement 
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override int CanMoveThere(int x, int y, Board board)
        {
            if (Math.Abs(this.X - x) + Math.Abs(this.Y - y) != 3 || Math.Abs(this.X - x) > 2 || Math.Abs(this.Y - y) > 2)
            {
                return 0; //Invalid move, Knights can only move in "L" shape
            }

            if (board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color == this.Color)
            {
                return 0;
            }
            else
            {
                if (board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color != this.Color)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
    public class Rook : Piece
    {
        public Rook(string color, int x, int y) : base(color, x, y)
        {

        }
        /// <summary>
        /// the rook deplacement 
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override int CanMoveThere(int x, int y, Board board)
        {
            double length = Math.Abs(this.X - x) + Math.Abs(this.Y - y);

            if (x == this.X && y == this.Y) return 0;
            if (x - this.X != 0 && y - this.Y != 0) return 0;

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color != this.Color && board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color != "void")
                {
                    if (i == length)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color == this.Color)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
    public class Bishop : Piece
    {
        public Bishop(string color, int x, int y) : base(color, x, y)
        {

        }
        /// <summary>
        /// the bishop deplacement
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override int CanMoveThere(int x, int y, Board board)
        {
            double length = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(x - this.X), 2) + Math.Pow(Math.Abs(y - this.Y), 2)) / 1.414);

            if (x == this.X && y == this.Y) return 0;
            if (x - this.X == 0 || y - this.Y == 0 || (Math.Abs(x - this.X) != Math.Abs(y - this.Y))) return 0;

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color != this.Color && board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color != "void")
                {
                    if (i == length)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color == this.Color)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
    public class Queen : Piece
    {
        public Queen(string color, int x, int y) : base(color, x, y)
        {

        }
        /// <summary>
        /// the queen deplacement
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override int CanMoveThere(int x, int y, Board board)
        {
            double length;

            if (x == this.X && y == this.Y) return 0;
            if (x - this.X != 0 && y - this.Y != 0 && Math.Abs(y - this.Y) != Math.Abs(x - this.X)) return 0;

            if(Math.Abs(this.X - x) == Math.Abs(this.Y -y))
            {
                length = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(x - this.X), 2) + Math.Pow(Math.Abs(y - this.Y), 2)) / 1.414);
            }
            else
            {
                length = Math.Abs(this.X - x) + Math.Abs(this.Y - y);
            }

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (board.Grid[this.X + (xDir*i), this.Y + (yDir*i), board.SelectedTurn].WhoIsOnIt.Color != this.Color && board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color != "void")
                {
                    if (i == length)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (board.Grid[this.X + (xDir * i), this.Y + (yDir * i), board.SelectedTurn].WhoIsOnIt.Color == this.Color)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
    public class King : Piece
    {
        public King(string color, int x, int y) : base(color, x, y)
        {
        }
        /// <summary>
        /// the king deplacement 
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="board">int the game</param>
        /// <returns></returns>
        public override int CanMoveThere(int x, int y, Board board)
        {
            if(NbrOfMoves == 0 && board.Grid[this.X, 7, board.SelectedTurn].WhoIsOnIt.NbrOfMoves == 0 && x == this.X && y - this.Y == 2 &&
                board.Grid[this.X, 6, board.SelectedTurn].WhoIsOnIt is VoidCase && board.Grid[this.X, 5, board.SelectedTurn].WhoIsOnIt is VoidCase)//Small castling
            {
                return 1;
            }
            if (NbrOfMoves == 0 && board.Grid[this.X, 0, board.SelectedTurn].WhoIsOnIt.NbrOfMoves == 0 && x == this.X && this.Y - y == 2 &&
                board.Grid[this.X, 3, board.SelectedTurn].WhoIsOnIt is VoidCase && board.Grid[this.X, 3, board.SelectedTurn].WhoIsOnIt is VoidCase && board.Grid[this.X, 1, board.SelectedTurn].WhoIsOnIt is VoidCase)//Big castling
            {
                return 1;
            }
            if (Math.Abs(x - this.X) > 1 || Math.Abs(y - this.Y) > 1)
            {
                return 0;
            }
            else
            {
                if (board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color != this.Color)
                {
                    return 1;
                }
                if (board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.Color == this.Color)
                {
                    return 0;
                }
                return 1;
            }
        }
        /// <summary>
        /// Check if the king is checked
        /// </summary>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override bool IsChecked(Board board)
        {
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                   if( board.Grid[i, j,  board.SelectedTurn].WhoIsOnIt.CanMoveThere(this.X, this.Y, board) == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// check if the king is check mated
        /// </summary>
        /// <param name="x">king position</param>
        /// <param name="y">king position</param>
        /// <param name="board">in the game</param>
        /// <returns></returns>
        public override bool IsCheckMated(int x, int y, Board board)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int ii = 0; ii < 8; ii++)
                    {
                        for (int jj = 0; jj < 8; jj++)
                        {
                            if(board.Grid[i, j, board.SelectedTurn].WhoIsOnIt.CanMoveThere(ii, jj, board) > 0)
                            {
                                board.NewTurn(board);
                                if (!board.Grid[x, y, board.SelectedTurn].WhoIsOnIt.IsChecked(board)) return false;
                                board.SelectedTurn--;
                            }
                        }
                    }
                }
            }
        return true;
        }
    }
}
