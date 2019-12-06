using Chess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessUI
{
    public partial class ChangeDBConfigForm : Form
    {
        string path = @"./configDB.json";
        string server;
        string db;
        string uid;
        string password;
        public ChangeDBConfigForm()
        {
             InitializeComponent();
        }

        private void ChangeDBConfigForm_Load(object sender, EventArgs e)
        {
            using (System.IO.StreamReader file = File.OpenText(@"./NewText.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Point newPoint = (Point)serializer.Deserialize(file, typeof(Point));
                this.SetDesktopLocation(newPoint.X, newPoint.Y);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if(txtDatabase.Text.Length > 0 && txtPassword.Text.Length > 0 && txtServer.Text.Length > 0 && txtUID.Text.Length > 0)
            {
                server = txtServer.Text;
                db = txtDatabase.Text;
                uid = txtUID.Text;
                password = txtPassword.Text;
                DatabaseConfig newConfig = new DatabaseConfig(server, db, uid, password);
                string output = JsonConvert.SerializeObject(newConfig, Formatting.Indented);
                File.WriteAllText(path, output);
                this.Hide();
                LoginForm newLoginForm = new LoginForm();
                newLoginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have to fill every field");
            }
        }
    }
}
