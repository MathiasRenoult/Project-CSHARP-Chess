using System;
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
        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
    public class Pawn : Piece 
    {
        public Pawn(string color,double x,double y,bool isChecking) : base(color,x,y, isChecking)
        {
            
        }

        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
    public class Knight : Piece
    {
        public Knight(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
    public class Rook : Piece
    {
        public Rook(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
    public class Bishop : Piece
    {
        public Bishop(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
    public class Queen : Piece
    {
        public Queen(string color, double x, double y, bool isChecking) : base(color, x, y, isChecking)
        {

        }
        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
    public class King : Piece
    {
        private bool isChecked;
        public King(string color, double x, double y, bool isChecked = false) : base(color, x, y,isChecked)
        {
            this.isChecked = isChecked;
        }
        public override int CanMoveThere(int x0, int y0, int x1, int y1)
        {
            return 0;
        }
    }
}
