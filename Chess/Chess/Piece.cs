using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {
        private string color; //Black or White
        private int x; //X coordinates [0-7]
        private int y; //Y coordinates [0-7]
        private bool isChecking; //Check if the piece is checking the opponent's King
        private Board board; //Set the board wich the piece is on

        public Piece(string color,int x,int y, Board board)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.isChecking = false;
            this.board = board;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public bool IsChecking
        {
            get { return isChecking; }
            set { isChecking = value; }
        }
        public Board Board
        {
            get { return board; }
            set { board = value; }
        }

        public virtual bool CanMoveThere(int x, int y, Board board)
        {
            return false;
        }
    }
}
