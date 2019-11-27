using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Piece
    {
        private string color; //Black or White
        private double x; //X coordinates [0-7]
        private double y; //Y coordinates [0-7]
        private bool isChecking; //Check if the piece is checking the opponent's King

        public Piece(string color,double x,double y,bool isChecking)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.isChecking = isChecking;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public bool IsChecking
        {
            get { return isChecking; }
            set { isChecking = value; }
        }

        public abstract bool CanMoveThere(int x0, int y0, int x1, int y1);
    }
}
