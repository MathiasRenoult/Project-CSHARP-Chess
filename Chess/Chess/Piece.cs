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
        private int nbrOfMoves; //Count the number of times the piece was moved

        public Piece(string color,int x,int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.isChecking = false;
            this.nbrOfMoves = 0;
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
        public int NbrOfMoves
        {
            get { return nbrOfMoves; }
            set { nbrOfMoves = value; }
        }

        public Piece DeepCopy()
        {
            Piece copy = (Piece)MemberwiseClone();
            return copy;
        }

        /// <summary>
        /// where the piece can move
        /// </summary>
        /// <param name="x">the position in X</param>
        /// <param name="y">the position in Y</param>
        /// <param name="board">Board name</param>
        /// <returns></returns>
        public virtual int CanMoveThere(int x, int y, Board board) // 0 = invalid move, 1 = valid move, 2 = pawn bigger move
        {
            return 0;
        }

        /// <summary>
        /// Îf it's checked return false
        /// </summary>
        /// <param name="board">board name</param>
        /// <returns></returns>
        public virtual bool IsChecked(Board board)
        {
            return false;
        }

        /// <summary>
        /// If it's check mated return false
        /// </summary>
        /// <param name="x">position of the king in X</param>
        /// <param name="y">position of the king in Y</param>
        /// <param name="board">the game under way</param>
        /// <returns></returns>
        public virtual bool IsCheckMated(int x, int y, Board board)
        {
            return false;
        }

        /// <summary>
        /// give the direction where you can move
        /// </summary>
        /// <param name="a">Return X</param>
        /// <param name="b">Return Y</param>
        /// <returns></returns>
        public int giveDirection(int a, int b)//Return x or y value for the direction
        {
            if (a - b > 0)
            {
                return -1;
            }
            else if (a - b < 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
