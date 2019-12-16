using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chess
{
    public partial class GameForm : Form
    {
        private Timer timer1;
        private Board mainBoard = new Board();
        private int i = 0,  j = 0;

        public GameForm(string user)
        {
            InitializeComponent();
            lblLogged.Text = "Logged as: " + user;
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
            foreach (PictureBox pctCase in pnlMain.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (pctCase.Image != null)
                {
                    pctCase.Image = null;
                }
                if (board.Grid[i%8,j%8].WhoIsOnIt.Color == "void")
                {
                    if(pctCase.Image != null)
                    {
                        pctCase.Image = null;
                    }
                    if (pctCase.BackgroundImage != null)
                    {
                        pctCase.BackgroundImage = null;
                    }
                }
                if(board.Grid[i%8,j%8].WhoIsOnIt.Color == "white")
                {
                    if(board.Grid[i%8,j%8].WhoIsOnIt is Knight)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/whiteKnight.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Rook)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/whiteRook.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Bishop)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/whiteBishop.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Queen)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/whiteQueen.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is King)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/whiteKing.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Pawn)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/whitePawn.png");
                    }

                }
                else
                {
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Knight)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/blackKnight.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Rook)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/blackRook.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Bishop)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/blackBishop.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Queen)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/blackQueen.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is King)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/blackKing.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Pawn)
                    {
                        pctCase.BackgroundImage = Image.FromFile("../../../Assets/blackPawn.png");
                    }
                }
                j++;
                if (j%8 == 0)
                {
                    i++;
                }
                if(j == 64)
                {
                    break;
                }
                
            }
        }
        private void GameForm_Click(object sender, EventArgs e)
        {
            pctCase00.Click += ClickOnCase;
            pctCase01.Click += ClickOnCase;
            pctCase02.Click += ClickOnCase;
            pctCase03.Click += ClickOnCase;
            pctCase04.Click += ClickOnCase;
            pctCase05.Click += ClickOnCase;
            pctCase06.Click += ClickOnCase;
            pctCase07.Click += ClickOnCase;
            pctCase10.Click += ClickOnCase;
            pctCase11.Click += ClickOnCase;
            pctCase12.Click += ClickOnCase;
            pctCase13.Click += ClickOnCase;
            pctCase14.Click += ClickOnCase;
            pctCase15.Click += ClickOnCase;
            pctCase16.Click += ClickOnCase;
            pctCase17.Click += ClickOnCase;
            pctCase20.Click += ClickOnCase;
            pctCase21.Click += ClickOnCase;
            pctCase22.Click += ClickOnCase;
            pctCase23.Click += ClickOnCase;
            pctCase24.Click += ClickOnCase;
            pctCase25.Click += ClickOnCase;
            pctCase26.Click += ClickOnCase;
            pctCase27.Click += ClickOnCase;
            pctCase30.Click += ClickOnCase;
            pctCase31.Click += ClickOnCase;
            pctCase32.Click += ClickOnCase;
            pctCase33.Click += ClickOnCase;
            pctCase34.Click += ClickOnCase;
            pctCase35.Click += ClickOnCase;
            pctCase36.Click += ClickOnCase;
            pctCase37.Click += ClickOnCase;
            pctCase40.Click += ClickOnCase;
            pctCase41.Click += ClickOnCase;
            pctCase42.Click += ClickOnCase;
            pctCase43.Click += ClickOnCase;
            pctCase44.Click += ClickOnCase;
            pctCase45.Click += ClickOnCase;
            pctCase46.Click += ClickOnCase;
            pctCase47.Click += ClickOnCase;
            pctCase50.Click += ClickOnCase;
            pctCase51.Click += ClickOnCase;
            pctCase52.Click += ClickOnCase;
            pctCase53.Click += ClickOnCase;
            pctCase54.Click += ClickOnCase;
            pctCase55.Click += ClickOnCase;
            pctCase56.Click += ClickOnCase;
            pctCase57.Click += ClickOnCase;
            pctCase60.Click += ClickOnCase;
            pctCase61.Click += ClickOnCase;
            pctCase62.Click += ClickOnCase;
            pctCase63.Click += ClickOnCase;
            pctCase64.Click += ClickOnCase;
            pctCase65.Click += ClickOnCase;
            pctCase66.Click += ClickOnCase;
            pctCase67.Click += ClickOnCase;
            pctCase70.Click += ClickOnCase;
            pctCase71.Click += ClickOnCase;
            pctCase72.Click += ClickOnCase;
            pctCase73.Click += ClickOnCase;
            pctCase74.Click += ClickOnCase;
            pctCase75.Click += ClickOnCase;
            pctCase76.Click += ClickOnCase;
            pctCase77.Click += ClickOnCase;

            btnBlackTurn.Click += UpdateGrid;
            btnWhiteTurn.Click += UpdateGrid;
            btnDot.Click += UpdateGrid;
            btnSquare.Click += UpdateGrid;
            btnFade.Click += UpdateGrid;
            btnStandardMode.Click += UpdateGrid;
            btnDebugMode.Click += UpdateGrid;
        }

       private void ClickOnCase(object sender, EventArgs e)
        {
            int oldI = i;
            int oldJ = j;
            string playerTurn;

            if(btnBlackTurn.Checked == true)
            {
                playerTurn = "black";
            }
            else
            {
                playerTurn = "white";
            }

            DrawGrid(mainBoard);
            PictureBox pctBox = sender as PictureBox;


            i = pctBox.TabIndex / 10;
            j = pctBox.TabIndex % 10;


            if (mainBoard.Grid[i, j].whoIsOnIt.Color != playerTurn && mainBoard.Grid[oldI, oldJ].whoIsOnIt.Color == playerTurn)
            {
                if (mainBoard.Grid[oldI, oldJ].WhoIsOnIt.CanMoveThere(pctBox.TabIndex / 10, pctBox.TabIndex % 10) == true)
                {
                    if(mainBoard.Grid[oldI, oldJ].whoIsOnIt is King && pctBox.TabIndex % 10 - oldJ == 2)
                    {
                        mainBoard.Grid[oldI, 5].whoIsOnIt = mainBoard.Grid[oldI, 7].whoIsOnIt;
                        mainBoard.Grid[oldI, 5].whoIsOnIt.Y = mainBoard.Grid[oldI, 7].whoIsOnIt.Y;
                        VoidCase newVoidCase = new VoidCase("void", oldI, 7, mainBoard);
                        mainBoard.Grid[oldI, 7].whoIsOnIt = newVoidCase;
                        mainBoard.Grid[oldI, 7].whoIsOnIt.Color = "void";
                        mainBoard.Grid[oldI, 7].whoIsOnIt.Y = 5;
                        mainBoard.Grid[oldI, 7].whoIsOnIt.NbrOfMoves++;
                    }
                    if (mainBoard.Grid[oldI, oldJ].whoIsOnIt is King && pctBox.TabIndex % 10 - oldJ == -2)
                    {
                        mainBoard.Grid[oldI, 3].whoIsOnIt = mainBoard.Grid[oldI, 0].whoIsOnIt;
                        mainBoard.Grid[oldI, 3].whoIsOnIt.Y = mainBoard.Grid[oldI, 0].whoIsOnIt.Y;
                        VoidCase newVoidCase = new VoidCase("void", oldI, 0, mainBoard);
                        mainBoard.Grid[oldI, 0].whoIsOnIt = newVoidCase;
                        mainBoard.Grid[oldI, 0].whoIsOnIt.Color = "void";
                        mainBoard.Grid[oldI, 0].whoIsOnIt.Y = 3;
                        mainBoard.Grid[oldI, 0].whoIsOnIt.NbrOfMoves++;
                    }
                    mainBoard.Grid[pctBox.TabIndex / 10, pctBox.TabIndex % 10].whoIsOnIt = mainBoard.Grid[oldI, oldJ].whoIsOnIt;
                    mainBoard.Grid[pctBox.TabIndex / 10, pctBox.TabIndex % 10].whoIsOnIt.X = pctBox.TabIndex / 10;
                    mainBoard.Grid[pctBox.TabIndex / 10, pctBox.TabIndex % 10].whoIsOnIt.Y = pctBox.TabIndex % 10;
                    VoidCase voidCase = new VoidCase("void", oldI, oldJ, mainBoard);
                    mainBoard.Grid[oldI, oldJ].whoIsOnIt = voidCase;
                    mainBoard.Grid[oldI, oldJ].whoIsOnIt.Color = "void";
                    mainBoard.Grid[oldI, oldJ].whoIsOnIt.X = i;
                    mainBoard.Grid[oldI, oldJ].whoIsOnIt.Y = j;
                    mainBoard.Grid[oldI, oldJ].whoIsOnIt.NbrOfMoves++;
                    DrawGrid(mainBoard);
                    if(btnWhiteTurn.Checked == true)
                    {
                        btnBlackTurn.Checked = btnWhiteTurn.Checked;
                    }
                    else
                    {
                        btnWhiteTurn.Checked = btnBlackTurn.Checked;
                    }
                    
                }
            }
            else
            {
                if(mainBoard.Grid[i, j].whoIsOnIt.Color == playerTurn)
                {
                    pctBox.Image = Image.FromFile("../../../Assets/selection.png");
                    lbl1.Text = pctBox.Name;
                    lbl1.Text = mainBoard.Grid[i, j].whoIsOnIt.Color + mainBoard.Grid[i, j].whoIsOnIt.GetType().ToString().Substring(6, mainBoard.Grid[i, j].whoIsOnIt.GetType().ToString().Length - 6);
                    ColorValidMoves(mainBoard.Grid[i, j].whoIsOnIt);
                }
                
            }
        }

        private void UpdateGrid(Object sender, EventArgs e)
        {
            ColorValidMoves(mainBoard.Grid[i, j].whoIsOnIt);
        }

        private void ColorValidMoves(Piece piece)
        {
            bool res;
            if(btnStandardMode.Checked == true)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        res = piece.CanMoveThere(i, j);
                        if (res == true)
                        {
                            Control[] control = pnlMain.Controls.Find("pctCase" + i.ToString() + j.ToString(), true);
                            PictureBox pctBox = control[0] as PictureBox;

                            if (btnDot.Checked == true)
                            {
                                pctBox.Image = Image.FromFile("../../../Assets/dotBlue.png");
                            }
                            if (btnSquare.Checked == true)
                            {
                                pctBox.Image = Image.FromFile("../../../Assets/selectionBlue.png");
                            }
                            if (btnFade.Checked == true)
                            {
                                if(mainBoard.Grid[i, j].whoIsOnIt.Color != piece.Color && mainBoard.Grid[i, j].whoIsOnIt.Color != "void")
                                {
                                    pctBox.Image = Image.FromFile("../../../Assets/fadeRed.png");
                                    pctBox.Tag = "fadeRed";
                                }
                                else
                                {
                                    pctBox.Image = Image.FromFile("../../../Assets/fadeBlue.png"); pctBox.Tag = "fadeBlue";
                                    pctBox.Tag = "fadeBlue";
                                }
                                
                            }
                        }
                    }
                }
            }
            else
            {
                if(btnDebugMode.Checked == true)
                {
                    for(int i=0; i<8;i++)
                    {
                        for(int j=0;j<8;j++)
                        {
                            for(int ii=0;ii<8;ii++)
                            {
                                for(int jj=0;jj<8;jj++)
                                {
                                    if(mainBoard.Grid[i, j].whoIsOnIt.CanMoveThere(ii, jj))
                                    {
                                        Control[] control = pnlMain.Controls.Find("pctCase" + ii.ToString() + jj.ToString(), true);
                                        PictureBox pctBox = control[0] as PictureBox;
                                        if(mainBoard.Grid[i, j].whoIsOnIt.Color == "white")
                                        { 
                                            if(pctBox.Image == null)
                                            {
                                                pctBox.Image = Image.FromFile("../../../Assets/fadeBlue.png");
                                                pctBox.Tag = "fadeBlue";
                                            }
                                            else
                                            {
                                                if (pctBox.Tag.ToString() == "fadeRed")
                                                {
                                                    pctBox.Image = Image.FromFile("../../../Assets/fadePurple.png");
                                                    pctBox.Tag = "fadePurple";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (pctBox.Image == null)
                                            {
                                                pctBox.Image = Image.FromFile("../../../Assets/fadeRed.png");
                                                pctBox.Tag = "fadeRed";
                                            }
                                            else
                                            {
                                                if (pctBox.Tag.ToString() == "fadeBlue")
                                                {
                                                    pctBox.Image = Image.FromFile("../../../Assets/fadePurple.png");
                                                    pctBox.Tag = "fadePurple";
                                                }
                                            }
                                        }    
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
