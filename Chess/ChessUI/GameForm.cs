﻿using System;
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
        }

       private void ClickOnCase(object sender, EventArgs e)
        {
           PictureBox pctBox = sender as PictureBox;
           pctSelection.Location = pctBox.Location;
        }
    }
}
