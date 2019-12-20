﻿using System;
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
        public override int CanMoveThere(int x, int y)
        {
            return 0;
        }
    }
    public class Pawn : Piece 
    {
        public Pawn(string color,int x,int y, Board board) : base(color,x,y, board)
        {
            
        }

        public override int CanMoveThere(int x, int y)
        {
            int biggerMove = 0;
            if (this.Board.Grid[x, y].WhoIsOnIt.Color == this.Color || (x - this.X < 0 && this.Color == "black") || (x - this.X > 0 && this.Color == "white"))
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
                if (Math.Abs(this.Y - y) == 1 && this.Board.Grid[x, y].WhoIsOnIt.Color != this.Color && this.Board.Grid[x, y].WhoIsOnIt.Color != "void" && Math.Abs(x - this.X) == 1)
                {
                    return 1;
                }
                else
                {
                    if (this.Board.Grid[x, y].WhoIsOnIt.Color == "void" && Math.Abs(this.Y - y) == 0 && Math.Abs(x - this.X) == 1 + biggerMove)
                    {
                        return 2;      
                    }
                    if(this.Board.Grid[x, y].WhoIsOnIt.Color == "void" && Math.Abs(this.Y - y) == 0 && Math.Abs(x - this.X) == 1)
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
        public Knight(string color, int x, int y, Board board) : base(color, x, y, board)
        {
            
        }
        public override int CanMoveThere(int x, int y)
        {
            if (Math.Abs(this.X - x) + Math.Abs(this.Y - y) != 3 || Math.Abs(this.X - x) > 2 || Math.Abs(this.Y - y) > 2)
            {
                return 0; //Invalid move, Knights can only move in "L" shape
            }

            if (this.Board.Grid[x, y].WhoIsOnIt.Color == this.Color)
            {
                return 0;
            }
            else
            {
                if (this.Board.Grid[x, y].WhoIsOnIt.Color != this.Color)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
    public class Rook : Piece
    {
        public Rook(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }
        public override int CanMoveThere(int x, int y)
        {
            double length = Math.Abs(this.X - x) + Math.Abs(this.Y - y);

            if (x == this.X && y == this.Y) return 0;
            if (x - this.X != 0 && y - this.Y != 0) return 0;

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color != this.Color && this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color != "void")
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
                    if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color == this.Color)
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
        public Bishop(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }
        public override int CanMoveThere(int x, int y)
        {
            double length = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(x - this.X), 2) + Math.Pow(Math.Abs(y - this.Y), 2)) / 1.414);

            if (x == this.X && y == this.Y) return 0;
            if (x - this.X == 0 || y - this.Y == 0 || (Math.Abs(x - this.X) != Math.Abs(y - this.Y))) return 0;

            int xDir = giveDirection(this.X, x);
            int yDir = giveDirection(this.Y, y);

            for (int i = 1; i <= length; i++)
            {
                if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color != this.Color && this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color != "void")
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
                    if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color == this.Color)
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
        public Queen(string color, int x, int y, Board board) : base(color, x, y, board)
        {

        }

        public override int CanMoveThere(int x, int y)
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
                if (this.Board.Grid[this.X + (xDir*i), this.Y + (yDir*i)].WhoIsOnIt.Color != this.Color && this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color != "void")
                {
                    if (i == Math.Abs(this.X - x))
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
                    if (this.Board.Grid[this.X + (xDir * i), this.Y + (yDir * i)].WhoIsOnIt.Color == this.Color)
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
        public King(string color, int x, int y, Board board) : base(color, x, y, board)
        {
        }
        public override int CanMoveThere(int x, int y)
        {
            if(NbrOfMoves == 0 && Board.Grid[this.X, 7].WhoIsOnIt.NbrOfMoves == 0 && x == this.X && y - this.Y == 2 && 
                Board.Grid[this.X, 6].WhoIsOnIt is VoidCase && Board.Grid[this.X, 5].WhoIsOnIt is VoidCase)//Small castling
            {
                return 1;
            }
            if (NbrOfMoves == 0 && Board.Grid[this.X, 0].WhoIsOnIt.NbrOfMoves == 0 && x == this.X && this.Y - y == 2 &&
                Board.Grid[this.X, 3].WhoIsOnIt is VoidCase && Board.Grid[this.X, 3].WhoIsOnIt is VoidCase && Board.Grid[this.X, 1].WhoIsOnIt is VoidCase)//Big castling
            {
                return 1;
            }
            if (Math.Abs(x - this.X) > 1 || Math.Abs(y - this.Y) > 1)
            {
                return 0;
            }
            else
            {
                if (this.Board.Grid[x, y].WhoIsOnIt.Color != this.Color)
                {
                    return 1;
                }
                if (this.Board.Grid[x, y].WhoIsOnIt.Color == this.Color)
                {
                    return 0;
                }
                return 1;
            }
        }

        public override bool IsChecked()
        {
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                   if( Board.Grid[i, j].WhoIsOnIt.CanMoveThere(this.X, this.Y) == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override bool IsCheckMated(int x, int y)
        {
            Board newBoard = new Board();
            newBoard.Grid = (Case[,]) this.Board.Grid.Clone();

            if(this.Board.Grid[x, y].WhoIsOnIt.IsChecked()==true)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        for (int ii = 0; ii < 8; ii++)
                        {
                            for (int jj = 0; jj < 8; jj++)
                            {
                                if (newBoard.Grid[i, j].WhoIsOnIt.CanMoveThere(ii, jj) == 1)
                                {
                                    newBoard.Grid[ii, jj].WhoIsOnIt = newBoard.Grid[i, j].WhoIsOnIt;
                                    VoidCase newVoidCase = new VoidCase("void", i, j, newBoard);
                                    newBoard.Grid[i, j].WhoIsOnIt = newVoidCase;

                                    if(i == x && j == y)
                                    {
                                        if(newBoard.Grid[ii, jj].WhoIsOnIt.IsChecked()==false)
                                        {
                                            return false;
                                        } 
                                    }
                                    else
                                    {
                                        if(newBoard.Grid[x, y].WhoIsOnIt.IsChecked()==false)
                                        {
                                            return false;
                                        }
                                        else
                                        {
                                            newBoard.Grid = (Case[,])this.Board.Grid.Clone();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
