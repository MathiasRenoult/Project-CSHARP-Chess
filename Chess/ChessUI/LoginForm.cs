using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Chess
{
    public partial class LoginForm : Form
    {
        private string mail;
        private string password;
        private Timer timer1;
        string path = @"./NewText.json";

        public LoginForm()
        {
            InitializeComponent();
            InitTimer();
            password = txtPassword.Text;
            txtPassword.Tag = password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool acceptedRequest = true;
            mail = txtMail.Text;
            password = txtPassword.Tag.ToString();

            txtPassword.BackColor = Color.White;
            txtMail.BackColor = Color.White;

            if (password == "")
            {
                lblError.Text = "You must enter a password";
                txtPassword.BackColor = Color.Red;
                acceptedRequest = false;
            }
            if (!IsValidEmail(mail))
            {
                lblError.Text = "Your mail address is not valid";
                txtMail.BackColor = Color.Red;
                acceptedRequest = false;
            }
            if (mail == "")
            {
                lblError.Text = "You must enter a mail address";
                txtMail.BackColor = Color.Red;
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cryptatePassword(true);

            string output = JsonConvert.SerializeObject(this.Location);
            File.WriteAllText(path, output);
        }

        public void cryptatePassword(bool timesUp)
        {
            string tempString = "";
            string realPassword = txtPassword.Tag.ToString() ;
           
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
            txtPassword.Focus();
            txtPassword.SelectionStart = txtPassword.Text.Length;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
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
}
