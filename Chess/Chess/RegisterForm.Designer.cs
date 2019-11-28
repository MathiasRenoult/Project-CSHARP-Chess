namespace Chess
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblComfirmPassword = new System.Windows.Forms.Label();
            this.txtComfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(194, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 25);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Chess";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(50, 101);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(67, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail Address";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(383, 174);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMail.Location = new System.Drawing.Point(170, 98);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 20);
            this.txtMail.TabIndex = 1;
            this.txtMail.Text = "mathias.renoult@cpnv.ch";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Pa$$w0rd";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblComfirmPassword
            // 
            this.lblComfirmPassword.AutoSize = true;
            this.lblComfirmPassword.Location = new System.Drawing.Point(50, 179);
            this.lblComfirmPassword.Name = "lblComfirmPassword";
            this.lblComfirmPassword.Size = new System.Drawing.Size(93, 13);
            this.lblComfirmPassword.TabIndex = 17;
            this.lblComfirmPassword.Text = "Comfirm Password";
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.Location = new System.Drawing.Point(170, 176);
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.Size = new System.Drawing.Size(186, 20);
            this.txtComfirmPassword.TabIndex = 3;
            this.txtComfirmPassword.Text = "Pa$$w0rd";
            this.txtComfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(50, 126);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(43, 13);
            this.lblPseudo.TabIndex = 19;
            this.lblPseudo.Text = "Pseudo";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(170, 124);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(186, 20);
            this.txtPseudo.TabIndex = 2;
            this.txtPseudo.Text = "Triximix";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(167, 206);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(59, 13);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "default text";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 232);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.lblComfirmPassword);
            this.Controls.Add(this.txtComfirmPassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblComfirmPassword;
        private System.Windows.Forms.TextBox txtComfirmPassword;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
    }
}