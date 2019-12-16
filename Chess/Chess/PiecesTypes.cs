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
        public override bool CanMoveThere(int x, int y)
        {
            return false;
        }
    }
    public class Pawn : Piece 
    {
        public Pawn(string color,int x,int y, Board board) : base(color,x,y, board)
        {
            
        }

        public override bool CanMoveThere(int x, int y)
        {
            int biggerMove = 0;
            if (this.Board.Grid[x, y].WhoIsOnIt.Color == this.Color || (x - this.X < 0 && this.Color == "black") || (x - this.X > 0 && this.Color == "white"))
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
                if (Math.Abs(this.Y - y) == 1 && this.Board.Grid[x, y].WhoIsOnIt.Color != this.Color && this.Board.Grid[x, y].WhoIsOnIt.Color != "void" && Math.Abs(x - this.X) == 1)
                {
                    return true;
                }
                else
                {
                    if (this.Board.Grid[x, y].WhoIsOnIt.Color == "void" && Math.Abs(this.Y - y) == 0 && Math.Abs(x - this.X) <= 1 + biggerMove)
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
        public override bool CanMoveThere(int x, int y)
        {
            if (Math.Abs(this.X - x) + Math.Abs(this.Y - y) != 3 || Math.Abs(this.X - x) > 2 || Math.Abs(this.Y - y) > 2)
            {
                return false; //Invalid move, Knights can only move in "L" shape
            }

            if (this.Board.Grid[x, y].whoIsOnIt.Color == this.Color)
            {
                return false;
            }
            else
            {
                if (this.Board.Grid[x, y].whoIsOnIt.Color != this.Color)
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
        public override bool CanMoveThere(int x, int y)
        {
            double length = Math.Abs(this.X - x) + Math.Abs(this.Y - y);

            if (x == this.X && y == this.Y) return false;
            if (x - this.X != 0 && y - this.Y != 0) return false;

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color != this.Color && this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color != "void")
                {
                    if (i == Math.Abs(this.X - x))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color == this.Color)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    public class Bishop : Piece
    {
        public Bishop(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }
        public override bool CanMoveThere(int x, int y)
        {
            double length = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(x - this.X), 2) + Math.Pow(Math.Abs(y - this.Y), 2)) / 1.414);

            if (x == this.X && y == this.Y) return false;
            if (x - this.X == 0 || y - this.Y == 0 || (Math.Abs(x - this.X) != Math.Abs(y - this.Y))) return false;

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color != this.Color && this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color != "void")
                {
                    if (i == Math.Abs(this.X - x))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color == this.Color)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    public class Queen : Piece
    {
        public Queen(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }

        public override bool CanMoveThere(int x, int y)
        {
            double length;

            if (x == this.X && y == this.Y) return false;
            if (x - this.X != 0 && y - this.Y != 0 && Math.Abs(y - this.Y) != Math.Abs(x - this.X)) return false;

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
                if (this.Board.Grid[this.X + (xDir*i), this.Y + (yDir*i)].whoIsOnIt.Color != this.Color && this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color != "void")
                {
                    if (i == Math.Abs(this.X - x))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].whoIsOnIt.Color == this.Color)
                    {
                        return false;
                    }
                }
            }
            return true;
        }  
    }
    public class King : Piece
    {
        private bool isChecked;
        public King(string color, int x, int y, Board board) : base(color, x, y, board)
        {
        }
        public override bool CanMoveThere(int x, int y)
        {
            if (Math.Abs(x - this.X) > 1 || Math.Abs(y - this.Y) > 1)
            {
                return false;
            }
            else
            {
                if (this.Board.Grid[x, y].whoIsOnIt.Color != this.Color)
                {
                    return true;
                }
                if (this.Board.Grid[x, y].whoIsOnIt.Color == this.Color)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
