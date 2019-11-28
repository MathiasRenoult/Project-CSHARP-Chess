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
    public partial class LoginForm : Form
    {
        private string mail;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            mail = txtMail.Text;
            password = txtPassword.Text;
            if(Login.LoginUser(mail,password))
            {
                GameForm newGameForm = new GameForm();
                newGameForm.ShowDialog();
            } 
            else
            {
                this.Hide();
                LoginForm newLoginForm = new LoginForm();
                newLoginForm.ShowDialog();
            }
        }

        public string Mail
        {
            get { return mail; }
        }

        public string Password
        {
            get { return password; }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm newRegisterForm = new RegisterForm();
            newRegisterForm.ShowDialog();   
        }
    }
}
