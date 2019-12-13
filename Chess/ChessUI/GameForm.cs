using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Chess
{
    public partial class GameForm : Form
    {
        private Timer timer1;
        
        public GameForm(string user)
        {
            InitializeComponent();
            lblLogged.Text = "Logged as: " + user;
            Board mainBoard = new Board();
            mainBoard.placePieces(mainBoard);
            DrawGrid(mainBoard);
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ConnectToDB connDB = new ConnectToDB();
                connDB.OpenConnection();

                //close connection
                connDB.CloseConnection();
            }
            catch
            {
                //we display the error message.
                MessageBox.Show("Connection with database lost");
                lblLogged.Text = "Logged as: no connection";
            }
        }

        public void DrawGrid(Board board)
        {
            int i=0,j=0;
            foreach (PictureBox pctCase in groupBox1.Controls)
            {

                if (board.Grid[i%8,j%8].WhoIsOnIt.Color == "void")
                {
                    if(pctCase.Image != null)
                    {
                        pctCase.Image = null;
                        pctCase.Image.Dispose();
                    }   
                }
                if(board.Grid[i%8,j%8].WhoIsOnIt.Color == "white")
                {
                    if(board.Grid[i%8,j%8].WhoIsOnIt is Knight)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/whiteKnight.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Rook)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/whiteRook.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Bishop)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/whiteBishop.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Queen)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/whiteQueen.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is King)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/whiteKing.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Pawn)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/whitePawn.png");
                    }

                }
                else
                {
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Knight)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/blackKnight.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Rook)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/blackRook.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Bishop)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/blackBishop.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Queen)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/blackQueen.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is King)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/blackKing.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Pawn)
                    {
                        pctCase.Image = Image.FromFile("../../../Assets/blackPawn.png");
                    }
                }
                j++;
                if (j%8 == 0)
                {
                    i++;
                }
                
            }
        }

        private void pctCase67_Click(object sender, EventArgs e)
        {
            lbl1.Text = pctCase67.Name;
            pctCase67.BackColor = Color.DarkOliveGreen;
        }

        private void pctCase10_Click(object sender, EventArgs e)
        {

        }

        private void pctCase01_Click(object sender, EventArgs e)
        {

        }

        private void pctCase11_Click(object sender, EventArgs e)
        {

        }

        private void pctCase12_Click(object sender, EventArgs e)
        {

        }

        private void pctCase02_Click(object sender, EventArgs e)
        {

        }

        private void pctCase13_Click(object sender, EventArgs e)
        {

        }

        private void pctCase03_Click(object sender, EventArgs e)
        {

        }

        private void pctCase14_Click(object sender, EventArgs e)
        {

        }

        private void pctCase04_Click(object sender, EventArgs e)
        {

        }

        private void pctCase05_Click(object sender, EventArgs e)
        {

        }

        private void pctCase15_Click(object sender, EventArgs e)
        {

        }

        private void pctCase16_Click(object sender, EventArgs e)
        {

        }

        private void pctCase06_Click(object sender, EventArgs e)
        {

        }

        private void pctCase07_Click(object sender, EventArgs e)
        {

        }

        private void pctCase17_Click(object sender, EventArgs e)
        {

        }

        private void pctCase27_Click(object sender, EventArgs e)
        {

        }

        private void pctCase26_Click(object sender, EventArgs e)
        {

        }

        private void pctCase25_Click(object sender, EventArgs e)
        {

        }

        private void pctCase24_Click(object sender, EventArgs e)
        {

        }

        private void pctCase23_Click(object sender, EventArgs e)
        {

        }

        private void pctCase22_Click(object sender, EventArgs e)
        {

        }

        private void pctCase21_Click(object sender, EventArgs e)
        {

        }

        private void pctCase20_Click(object sender, EventArgs e)
        {

        }

        private void pctCase30_Click(object sender, EventArgs e)
        {

        }

        private void pctCase31_Click(object sender, EventArgs e)
        {

        }

        private void pctCase32_Click(object sender, EventArgs e)
        {

        }

        private void pctCase33_Click(object sender, EventArgs e)
        {

        }

        private void pctCase34_Click(object sender, EventArgs e)
        {

        }

        private void pctCase35_Click(object sender, EventArgs e)
        {

        }

        private void pctCase36_Click(object sender, EventArgs e)
        {

        }

        private void pctCase37_Click(object sender, EventArgs e)
        {

        }

        private void pctCase47_Click(object sender, EventArgs e)
        {

        }

        private void pctCase46_Click(object sender, EventArgs e)
        {

        }

        private void pctCase45_Click(object sender, EventArgs e)
        {

        }

        private void pctCase44_Click(object sender, EventArgs e)
        {

        }

        private void pctCase43_Click(object sender, EventArgs e)
        {

        }

        private void pctCase42_Click(object sender, EventArgs e)
        {

        }

        private void pctCase41_Click(object sender, EventArgs e)
        {

        }

        private void pctCase40_Click(object sender, EventArgs e)
        {

        }

        private void pctCase51_Click(object sender, EventArgs e)
        {

        }

        private void pctCase50_Click(object sender, EventArgs e)
        {

        }

        private void pctCase60_Click(object sender, EventArgs e)
        {

        }

        private void pctCase61_Click(object sender, EventArgs e)
        {

        }

        private void pctCase52_Click(object sender, EventArgs e)
        {

        }

        private void pctCase62_Click(object sender, EventArgs e)
        {

        }

        private void pctCase53_Click(object sender, EventArgs e)
        {

        }

        private void pctCase63_Click(object sender, EventArgs e)
        {

        }

        private void pctCase54_Click(object sender, EventArgs e)
        {

        }

        private void pctCase64_Click(object sender, EventArgs e)
        {

        }

        private void pctCase65_Click(object sender, EventArgs e)
        {

        }

        private void pctCase55_Click(object sender, EventArgs e)
        {

        }

        private void pctCase66_Click(object sender, EventArgs e)
        {

        }

        private void pctCase00_Click(object sender, EventArgs e)
        {

        }

        private void pctCase57_Click(object sender, EventArgs e)
        {

        }

        private void pctCase77_Click(object sender, EventArgs e)
        {

        }

        private void pctCase76_Click(object sender, EventArgs e)
        {

        }

        private void pctCase56_Click(object sender, EventArgs e)
        {

        }

        private void pctCase75_Click(object sender, EventArgs e)
        {

        }

        private void pctCase74_Click(object sender, EventArgs e)
        {

        }

        private void pctCase73_Click(object sender, EventArgs e)
        {

        }

        private void pctCase72_Click(object sender, EventArgs e)
        {

        }

        private void pctCase71_Click(object sender, EventArgs e)
        {

        }

        private void pctCase70_Click(object sender, EventArgs e)
        {

        }
    }
}
