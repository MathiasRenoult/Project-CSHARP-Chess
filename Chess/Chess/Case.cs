using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Case
    {
        public Piece whoIsOnIt;//Check which piece is on the case
        public string color;//Background color of the case. black=nothing, green=selected piece, blue=valid move, red=valid attack
        public double isAttacked; //Check who can move to this case next turn. 0=not attacked, 1=attacked by white(s), 2 attacked by black(s), 3 attacked by both teams

        public Case(Piece whoIsOnIt, double isAttacked, string color="black")
        {
            this.whoIsOnIt = whoIsOnIt;
            this.isAttacked = isAttacked;
            this.color = color;
        }

        public Case()
        {
            this.isAttacked = 0;
            this.color = "black";
        }

        public Piece WhoIsOnIt
        {
            get { return whoIsOnIt; }
            set { whoIsOnIt = value; }
        }
        public double IsAttacked
        {
            get { return isAttacked; }
            set { isAttacked = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
