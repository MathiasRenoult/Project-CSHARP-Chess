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
            InitTimer();
            InitializeComponent();
            lblLogged.Text = "Logged as: " + user;
            mainBoard.placePieces(mainBoard);
            /*
            Queen newBlackQueen = new Queen("black", 4, 4, mainBoard);
            mainBoard.Grid[newBlackQueen.X, newBlackQueen.Y].WhoIsOnIt = newBlackQueen;
            Queen newWhiteQueen = new Queen("white", 4, 6, mainBoard);
            mainBoard.Grid[newWhiteQueen.X, newWhiteQueen.Y].WhoIsOnIt = newWhiteQueen;
            Rook newWhiteRook = new Rook("white", 4, 0, mainBoard);
            mainBoard.Grid[newWhiteRook.X, newWhiteRook.Y].WhoIsOnIt = newWhiteRook;
            */
            DrawGrid(mainBoard);
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
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
                        pctCase.BackgroundImage = Image.FromFile("Assets/whiteKnight.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Rook)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/whiteRook.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Bishop)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/whiteBishop.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Queen)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/whiteQueen.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is King)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/whiteKing.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Pawn)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/whitePawn.png");
                    }

                }
                else
                {
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Knight)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/blackKnight.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Rook)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/blackRook.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Bishop)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/blackBishop.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Queen)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/blackQueen.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is King)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/blackKing.png");
                    }
                    if (board.Grid[i%8,j%8].WhoIsOnIt is Pawn)
                    {
                        pctCase.BackgroundImage = Image.FromFile("Assets/blackPawn.png");
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

            if (btnBlackTurn.Checked == true)
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


            if (mainBoard.Grid[i, j].WhoIsOnIt.Color != playerTurn && mainBoard.Grid[oldI, oldJ].WhoIsOnIt.Color == playerTurn)
            {
                if (mainBoard.Grid[oldI, oldJ].WhoIsOnIt.CanMoveThere(pctBox.TabIndex / 10, pctBox.TabIndex % 10) > 0)
                {
                    if(mainBoard.Grid[oldI, oldJ].WhoIsOnIt is King && pctBox.TabIndex % 10 - oldJ == 2) //Castling
                    {
                        mainBoard.Grid[oldI, 5].WhoIsOnIt = mainBoard.Grid[oldI, 7].WhoIsOnIt;
                        mainBoard.Grid[oldI, 5].WhoIsOnIt.Y = mainBoard.Grid[oldI, 7].WhoIsOnIt.Y;
                        VoidCase newVoidCase = new VoidCase("void", oldI, 7, mainBoard);
                        mainBoard.Grid[oldI, 7].WhoIsOnIt = newVoidCase;
                        mainBoard.Grid[oldI, 7].WhoIsOnIt.Color = "void";
                        mainBoard.Grid[oldI, 7].WhoIsOnIt.Y = 5;
                        mainBoard.Grid[oldI, 7].WhoIsOnIt.NbrOfMoves++;
                    }
                    if (mainBoard.Grid[oldI, oldJ].WhoIsOnIt is King && pctBox.TabIndex % 10 - oldJ == -2)//Castling
                    {
                        mainBoard.Grid[oldI, 3].WhoIsOnIt = mainBoard.Grid[oldI, 0].WhoIsOnIt;
                        mainBoard.Grid[oldI, 3].WhoIsOnIt.Y = mainBoard.Grid[oldI, 0].WhoIsOnIt.Y;
                        VoidCase newVoidCase = new VoidCase("void", oldI, 0, mainBoard);
                        mainBoard.Grid[oldI, 0].WhoIsOnIt = newVoidCase;
                        mainBoard.Grid[oldI, 0].WhoIsOnIt.Color = "void";
                        mainBoard.Grid[oldI, 0].WhoIsOnIt.Y = 3;
                        mainBoard.Grid[oldI, 0].WhoIsOnIt.NbrOfMoves++;
                    }
                    mainBoard.Grid[pctBox.TabIndex / 10, pctBox.TabIndex % 10].WhoIsOnIt = mainBoard.Grid[oldI, oldJ].WhoIsOnIt;
                    mainBoard.Grid[pctBox.TabIndex / 10, pctBox.TabIndex % 10].WhoIsOnIt.X = pctBox.TabIndex / 10;
                    mainBoard.Grid[pctBox.TabIndex / 10, pctBox.TabIndex % 10].WhoIsOnIt.Y = pctBox.TabIndex % 10;
                    VoidCase voidCase = new VoidCase("void", oldI, oldJ, mainBoard);
                    mainBoard.Grid[oldI, oldJ].WhoIsOnIt = voidCase;
                    mainBoard.Grid[oldI, oldJ].WhoIsOnIt.Color = "void";
                    mainBoard.Grid[oldI, oldJ].WhoIsOnIt.X = i;
                    mainBoard.Grid[oldI, oldJ].WhoIsOnIt.Y = j;
                    mainBoard.Grid[oldI, oldJ].WhoIsOnIt.NbrOfMoves++;
                    DrawGrid(mainBoard);

                    if(btnWhiteTurn.Checked == true)
                    {
                        btnBlackTurn.Checked = btnWhiteTurn.Checked;
                    }
                    else
                    {
                        btnWhiteTurn.Checked = btnBlackTurn.Checked;
                    }

                   //TestForEndGame();
                    ColorCheckedKing();
                }
            }
            else
            {
                if(mainBoard.Grid[i, j].WhoIsOnIt.Color == playerTurn)
                {
                    pctBox.Image = Image.FromFile("Assets/selection.png");
                    lbl1.Text = mainBoard.Grid[i, j].WhoIsOnIt.Color + mainBoard.Grid[i, j].WhoIsOnIt.GetType().ToString().Substring(6, mainBoard.Grid[i, j].WhoIsOnIt.GetType().ToString().Length - 6);
                    ColorValidMoves(mainBoard.Grid[i, j].WhoIsOnIt);
                }
            }
        }

        private void UpdateGrid(Object sender, EventArgs e)
        {
            ColorValidMoves(mainBoard.Grid[i, j].WhoIsOnIt);
            ColorCheckedKing();
        }

        private void TestForEndGame()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(mainBoard.Grid[i, j].WhoIsOnIt.IsCheckMated(i, j))
                    {
                        MessageBox.Show("Echec et Mat!");
                    }
                }
            }
        }

        private void ColorCheckedKing()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mainBoard.Grid[i, j].WhoIsOnIt is King && mainBoard.Grid[i, j].WhoIsOnIt.IsChecked())
                    {
                        Control[] control = pnlMain.Controls.Find("pctCase" + i.ToString() + j.ToString(), true);
                        PictureBox pctBox = control[0] as PictureBox;
                        pctBox.Image = Image.FromFile("Assets/selectionRed.png");
                    }
                }
            }
        }

        private void ColorValidMoves(Piece piece)
        {
            int res;
            if(btnStandardMode.Checked == true)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        res = piece.CanMoveThere(i, j);
                        Control[] control = pnlMain.Controls.Find("pctCase" + i.ToString() + j.ToString(), true);
                        PictureBox pctBox = control[0] as PictureBox;
                        if (res>0)
                        {
                            if (btnDot.Checked == true)
                            {
                                pctBox.Image = Image.FromFile("Assets/dotBlue.png");
                            }
                            if (btnSquare.Checked == true)
                            {
                                pctBox.Image = Image.FromFile("Assets/selectionBlue.png");
                            }
                            if (btnFade.Checked == true)
                            {
                                if(mainBoard.Grid[i, j].WhoIsOnIt.Color != piece.Color && mainBoard.Grid[i, j].WhoIsOnIt.Color != "void")
                                {
                                    pctBox.Image = Image.FromFile("Assets/fadeRed.png");
                                    pctBox.Tag = "fadeRed";
                                }
                                else
                                {
                                    pctBox.Image = Image.FromFile("Assets/fadeBlue.png"); pctBox.Tag = "fadeBlue";
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
                                    if(mainBoard.Grid[i, j].WhoIsOnIt.CanMoveThere(ii, jj) == 1)
                                    {
                                        Control[] control = pnlMain.Controls.Find("pctCase" + ii.ToString() + jj.ToString(), true);
                                        PictureBox pctBox = control[0] as PictureBox;
                                        if(mainBoard.Grid[i, j].WhoIsOnIt.Color == "white")
                                        { 
                                            if(pctBox.Image == null)
                                            {
                                                pctBox.Image = Image.FromFile("Assets/fadeBlue.png");
                                                pctBox.Tag = "fadeBlue";
                                            }
                                            else
                                            {
                                                if (pctBox.Tag.ToString() == "fadeRed")
                                                {
                                                    pctBox.Image = Image.FromFile("Assets/fadePurple.png");
                                                    pctBox.Tag = "fadePurple";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (pctBox.Image == null)
                                            {
                                                pctBox.Image = Image.FromFile("Assets/fadeRed.png");
                                                pctBox.Tag = "fadeRed";
                                            }
                                            else
                                            {
                                                if (pctBox.Tag.ToString() == "fadeBlue")
                                                {
                                                    pctBox.Image = Image.FromFile("Assets/fadePurple.png");
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

        public void FunnyColors()
        {
            int r, g, b;
            float angle;
            double hyp;
            Random random = new Random();

            r = random.Next(0, 256);
            g = random.Next(0, 256);
            b = random.Next(0, 256);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Control[] control = pnlMain.Controls.Find("pctCase" + i.ToString() + j.ToString(), true);
                    PictureBox pctBox = control[0] as PictureBox;

                   
                    hyp = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2)) / 8 * 255;
                    if (hyp > 255)
                    {
                        hyp = 255;
                    }

                    //Red
                    angle = ((int)((Math.Atan2(i-4, j-4) * 180 / Math.PI) + 180)) % 360;
                    r = (int)GetColorValue(angle);

                    //Green
                    angle = ((int)((Math.Atan2(i-4, j-4) * 180 / Math.PI) + 300)) % 360;
                    g = (int)(GetColorValue(angle));

                    //Blue
                    angle = ((int)((Math.Atan2(i-4, j-4) * 180 / Math.PI) + 420)) % 360;
                    b = (int)(GetColorValue(angle));

                    pctBox.BackColor = Color.FromArgb(255,r,g,b);  

                }
            }
        }

        private void btnTestColors_Click(object sender, EventArgs e)
        {
            FunnyColors();
        }

        private void chkLabels_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLabels.Checked == false)
            {
                label0.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
            }
            else
            {
                label0.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label31.Visible = true;
            }
        }

        public float GetColorValue(float angle)
        {
            float temp = 0;
            if (angle >= 0 && angle < 60)
            {
                temp = angle;
                temp /= 60;
                return temp * 255;
            }
            if (angle >= 60 && angle < 180)
            {
                return 255;
            }
            if (angle >= 180 && angle < 240)
            {
                temp = 240 - angle;
                temp /= 60;
                return temp * 255;
            }
            if (angle >= 240 && angle < 360)
            {
                return 0;
            }
            return 0;
        }
    }
}
