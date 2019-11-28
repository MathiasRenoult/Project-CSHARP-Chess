﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class VoidCase : Piece
    {
        public VoidCase(string color, double x, double y, bool isChecking) : base("void",x,y,false)
        {

        }
        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return false;
        }
    }
    public class Pawn : Piece 
    {
        public Pawn(string color,double x,double y,bool isChecking) : base(color,x,y, isChecking)
        {
            
        }

        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return false;
        }
    }
    public class Knight : Piece
    {
        public Knight(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            if (Math.Abs(x1 - x0) + Math.Abs(y1 - y0) != 3 || Math.Abs(x1 - x0) > 2 || Math.Abs(y1 - y0) > 2)
            {
                return false; //Invalid move, Knights can only move in "L" shape
            }

            if (Board.Grid[x1,y1].WhoIsOnIt == VoidCase)
            {
                return 3;
            }
            else
            {
                if (caseState == 2)
                {
                    return 5;
                }
                return 0;
            }

        }
    }
    public class Rook : Piece
    {
        public Rook(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return false;
        }
    }
    public class Bishop : Piece
    {
        public Bishop(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return false;
        }
    }
    public class Queen : Piece
    {
        public Queen(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return false;
        }
    }
    public class King : Piece
    {
        private bool isChecked;
        public King(string color, double x, double y, bool isChecked = false) : base(color, x, y,isChecked)
        {
            this.isChecked = isChecked;
        }
        public override bool CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return false;
        }
    }
}
