using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    public class Board
    {
        private int size;
        private int turn;
        private double computerDifficulty;
        private Case[,] grid;

        public Board(double computerDifficulty=0)
        {
            int i,j;
            this.size = 8;
            this.turn = 0;
            this.computerDifficulty = computerDifficulty;
            Case[,] grid = new Case[size, size];
            for (i=0;i<size;i++)
            {
                for(j=0;j<size;j++)
                {
                    Piece standardVoid = new VoidCase("",i,j,false);
                    grid[i,j] = new Case(standardVoid,0);
                }
            }
            this.grid = grid;
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public double ComputerDifficulty
        {
            get { return computerDifficulty; }
            set { computerDifficulty = value; }
        }
            
        public Case[,] Grid
        {
            get { return grid; }
            set { grid = value; }
        }

    }
}
