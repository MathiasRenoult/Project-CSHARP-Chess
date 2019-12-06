namespace Chess
{
    partial class GameForm
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
            this.lblChessGame = new System.Windows.Forms.Label();
            this.lblLogged = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChessGame
            // 
            this.lblChessGame.AutoSize = true;
            this.lblChessGame.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChessGame.Location = new System.Drawing.Point(90, 147);
            this.lblChessGame.Name = "lblChessGame";
            this.lblChessGame.Size = new System.Drawing.Size(625, 135);
            this.lblChessGame.TabIndex = 0;
            this.lblChessGame.Text = "ChEsS GaMe";
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Location = new System.Drawing.Point(626, 9);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(60, 13);
            this.lblLogged.TabIndex = 1;
            this.lblLogged.Text = "Logged as:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblLogged);
            this.Controls.Add(this.lblChessGame);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChessGame;
        private System.Windows.Forms.Label lblLogged;
    }
}