using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Case
    {
        public double whoIsOnIt;//Check which team is on the case. 0=void, 1=white, 2=black
        public string color;//Background color of the case. black=nothing, green=selected piece, blue=valid move, red=valid attack
        public double isAttacked; //Check who can move to this case next turn. 0=not attacked, 1=attacked by white(s), 2 attacked by black(s), 3 attacked by both teams

        public Case(double whoIsOnIt, double isAttacked, string color="black")
        {
            this.whoIsOnIt = whoIsOnIt;
            this.isAttacked = isAttacked;
            this.color = color;
        }

        public double WhoIsOnIt
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
