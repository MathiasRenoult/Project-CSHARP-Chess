using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ChessUI;

namespace Chess
{
    public partial class RegisterForm : Form
    {
        private string mail;
        private string pseudo;
        private string password;
        private string passwordComfirm;
        private Timer timer1;

        public RegisterForm()
        {
            InitializeComponent();
            InitTimer();

            password = txtPassword.Text;
            txtPassword.Tag = password;

            passwordComfirm= txtComfirmPassword.Text;
            txtComfirmPassword.Tag = passwordComfirm;
        }
        #region accesseur 
        public string Mail
        {
            get { return mail; }
            set { value = mail; }
        }
        public string Pseudo
        {
            get { return pseudo; }
            set { value = pseudo; }
        }
        public string Password
        {
            get { return password; }
            set { value = password; }
        }
        public string PasswordConfirm
        {
            get { return passwordComfirm; }
            set { value = passwordComfirm; }
        }
        #endregion accesseur
        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool acceptedRequest = true;
            mail = txtMail.Text;
            pseudo = txtPseudo.Text;
            password = txtPassword.Text;
            passwordComfirm = txtComfirmPassword.Text;

            if (password.Length < 6 || !password.Any(char.IsDigit))
            {
                lblError.Text = "You password is too weak";
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
                if (Register.CreateUser(mail, pseudo, password))
                {
                    this.Hide();
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

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            cryptatePassword(false);
            txtPassword.Focus();
            txtPassword.SelectionStart = txtPassword.Text.Length;
        }
   
        private void txtComfirmPassword_TextChanged(object sender, EventArgs e)
        {
            cryptateComfirmPassword(false);
            txtComfirmPassword.Focus();
            txtComfirmPassword.SelectionStart = txtComfirmPassword.Text.Length;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cryptatePassword(true);
            cryptateComfirmPassword(true);
        }

        public void cryptatePassword(bool timesUp)
        {
            string tempString = "";
            string realPassword = txtPassword.Tag.ToString();


            if (realPassword.Length < txtPassword.Text.Length)
            {
                realPassword += txtPassword.Text.Substring(txtPassword.Text.Length - 1, 1);
                Console.WriteLine(realPassword);
            }
            if (realPassword.Length > txtPassword.Text.Length)
            {
                realPassword = realPassword.Substring(0, realPassword.Length - 1);
                Console.WriteLine(realPassword);
            }
            if (realPassword.Length == txtPassword.Text.Length && timesUp == true)
            {
                for (int i = 0; i < txtPassword.Text.Length; i++)
                {
                    tempString += "*";
                }
                txtPassword.Text = tempString;
            }
            txtPassword.Tag = realPassword;
        }

        public void cryptateComfirmPassword(bool timesUp)
        {
            string tempString = "";
            string realComfirmPassword = txtComfirmPassword.Tag.ToString();

            if (realComfirmPassword.Length < txtComfirmPassword.Text.Length)
            {
                realComfirmPassword += txtComfirmPassword.Text.Substring(txtComfirmPassword.Text.Length - 1, 1);
                Console.WriteLine(realComfirmPassword);
            }
            if (realComfirmPassword.Length > txtComfirmPassword.Text.Length)
            {
                realComfirmPassword = realComfirmPassword.Substring(0, realComfirmPassword.Length - 1);
                Console.WriteLine(realComfirmPassword);
            }
            if (realComfirmPassword.Length == txtComfirmPassword.Text.Length && timesUp == true)
            {
                for (int i = 0; i < txtComfirmPassword.Text.Length; i++)
                {
                    tempString += "*";
                }
                txtComfirmPassword.Text = tempString;
            }
            txtComfirmPassword.Tag = realComfirmPassword;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText(@"./NewText.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Point newPoint = (Point)serializer.Deserialize(file, typeof(Point));
                this.SetDesktopLocation(newPoint.X, newPoint.Y);
            }
        }
    }
}
