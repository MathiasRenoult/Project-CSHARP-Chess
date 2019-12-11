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
            bool res = false;
            if (this.Color == "black")
            {
                if (board.Grid[x,y].WhoIsOnIt is VoidCase)
                {
                    if (this.X == 1)
                    {
                        if (x - this.X <= 2 && x - this.X > 0 && this.Y == y && board.Grid[this.X + 1,this.Y].WhoIsOnIt is VoidCase)
                        {
                            res = true;
                        }
                        else
                        {
                            res = false;
                        }
                    }
                    else
                    {
                        if (x - this.X == 1 && this.Y == y)
                        {
                            res = true;
                        }
                        else
                        {
                            res = false;
                        }
                    }
                }
                else
                {
                    if (y - this.Y == 1 || y - this.Y == -1)
                    {
                        res = true;
                    }
                }
            }
            else
            {
                if (board.Grid[x,y].WhoIsOnIt is VoidCase)
                {
                    if (this.X == 6)
                    {
                        if (this.X - x <= 2 && this.X - x > 0  && this.Y == y && board.Grid[this.X -1,this.Y].WhoIsOnIt is VoidCase)
                        {
                            res = true;
                        }
                        else
                        {
                            res = false;
                        }
                    }
                    else
                    {
                        if (this.X - x == 1 && this.Y == y)
                        {
                            res = true;
                        }
                        else
                        {
                            res = false;
                        }
                    }
                }
                else
                {
                    if (y - this.Y == 1 || y - this.Y == -1)
                    {
                        res = true;
                    }
                }
            }
            return res;
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
