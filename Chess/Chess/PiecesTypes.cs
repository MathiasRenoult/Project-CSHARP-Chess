using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class VoidCase : Piece
    {
        public VoidCase(string color, int x, int y, Board board) : base("void",x,y, board)
        {

        }
        public override bool CanMoveThere(int x, int y, Board board)
        {
            return false;
        }
    }
    public class Pawn : Piece 
    {
        public Pawn(string color,int x,int y, Board board) : base(color,x,y, board)
        {
            
        }

        public override bool CanMoveThere(int x, int y, Board board)
        {
            int biggerMove = 0;

            if (board.Grid[x, y].WhoIsOnIt.Color == this.Color || (x - this.X < 0 && this.Color == "black") || (x - this.X > 0 && this.Color == "white"))
            {
                return false;
            }
            else
            {
                if ((this.Color == "white" && this.X == 6) ||
                     (this.Color == "black" && this.X == 1))
                {
                    biggerMove = 1;
                }
                if (Math.Abs(this.Y - y) == 1 && board.Grid[x, y].WhoIsOnIt.Color != this.Color && board.Grid[x, y].WhoIsOnIt.Color != "void" && Math.Abs(x - this.X) == 1)
                {
                    return true;
                }
                else
                {
                    if (board.Grid[x, y].WhoIsOnIt.Color == "void" && Math.Abs(this.Y - y) == 0 && Math.Abs(x - this.X) <= 1 + biggerMove)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
    public class Knight : Piece
    {
        public Knight(string color, int x, int y, Board board) : base(color, x, y, board)
        {
            
        }
        public override bool CanMoveThere(int x, int y, Board board)
        {
            if (Math.Abs(this.X - x) + Math.Abs(this.Y - y) != 3 || Math.Abs(this.X - x) > 2 || Math.Abs(this.Y - y) > 2)
            {
                return false; //Invalid move, Knights can only move in "L" shape
            }

            if (board.Grid[x, y].whoIsOnIt.Color == this.Color)
            {
                return false;
            }
            else
            {
                if (board.Grid[x, y].whoIsOnIt.Color != this.Color)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class Rook : Piece
    {
        public Rook(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }
        public override bool CanMoveThere(int x, int y, Board board)
        {
            return false;
        }
    }
    public class Bishop : Piece
    {
        public Bishop(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }
        public override bool CanMoveThere(int x, int y, Board board)
        {
            return false;
        }
    }
    public class Queen : Piece
    {
        public Queen(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }
        public override bool CanMoveThere(int x, int y, Board board)
        {
            return false;
        }
    }
    public class King : Piece
    {
        private bool isChecked;
        public King(string color, int x, int y, Board board) : base(color, x, y, board)
        {
        }
        public override bool CanMoveThere(int x, int y, Board board)
        {
            return false;
        }
    }
}
