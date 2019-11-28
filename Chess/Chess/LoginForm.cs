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
            bool acceptedRequest = true;
            mail = txtMail.Text;
            password = txtPassword.Text;

            if (password == "")
            {
                lblError.Text = "You must enter a password";
                acceptedRequest = false;
            }
            if (!IsValidEmail(mail))
            {
                lblError.Text = "Your mail address is not valid";
                acceptedRequest = false;
            }
            if (mail == "")
            {
                lblError.Text = "You must enter a mail address";
                acceptedRequest = false;
            }

            if(acceptedRequest)
            {
                if (Login.LoginUser(mail,password))
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
            else
            {
                lblError.Visible = true;
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

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
