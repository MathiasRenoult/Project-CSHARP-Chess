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
            bool acceptedRequest = true;
            mail = txtMail.Text;
            pseudo = txtPseudo.Text;
            password = txtPassword.Text;
            passwordComfirm = txtComfirmPassword.Text;

            if (password.Length < 6 || !password.Any(char.IsDigit))
            {
                lblError.Text= "You password is too weak";
                acceptedRequest = false;
            }
            if (password != passwordComfirm)
            {
                lblError.Text = "You passwords does not match";
                acceptedRequest = false;
            }
            if (password == "")
            {
                lblError.Text = "You must enter a password";
                acceptedRequest = false;
            }
            if (passwordComfirm == "")
            {
                lblError.Text = "You must a password AND a comfirm password";
                acceptedRequest = false;
            }
            if (pseudo == "")
            {
                lblError.Text = "You must enter a pseudo";
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

            if (acceptedRequest == true)
            {
                this.Hide();
                if (Register.CreateUser(mail, pseudo, password))
                {
                    GameForm newGameForm = new GameForm();
                    newGameForm.ShowDialog();
                }
                else
                {
                    this.Hide();
                    RegisterForm newRegisterForm = new RegisterForm();
                    newRegisterForm.ShowDialog();
                 }
            }
            else
            {
                lblError.Visible = true;
            }
              
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.ShowDialog();
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
