using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class GameForm : Form
    {
        private Timer timer1;
        public GameForm(string user)
        {
            InitializeComponent();
            lblLogged.Text = "Logged as: " + user;
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
    }
}
