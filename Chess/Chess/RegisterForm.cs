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
    public partial class RegisterForm : Form
    {
        private string mail;
        private string pseudo;
        private string password;
        private string passwordComfirm;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            mail = txtMail.Text;
            pseudo = txtPseudo.Text;
            password = txtPassword.Text;
            passwordComfirm = txtComfirmPassword.Text;

            if(password == passwordComfirm)
            {
                this.Hide();
                Register.CreateUser(mail, pseudo, password);
                GameForm newGameForm = new GameForm();
                newGameForm.ShowDialog();
                
            }
            else
            {
                Console.WriteLine("Passwords does not match !");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.ShowDialog();
        }
    }
}
