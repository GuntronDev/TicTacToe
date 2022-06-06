namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCredits = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxMainScreenTicTacToe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainScreenTicTacToe)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCredits
            // 
            this.textBoxCredits.Location = new System.Drawing.Point(12, 418);
            this.textBoxCredits.Name = "textBoxCredits";
            this.textBoxCredits.ReadOnly = true;
            this.textBoxCredits.Size = new System.Drawing.Size(178, 20);
            this.textBoxCredits.TabIndex = 0;
            this.textBoxCredits.Text = "Made by: Filip Jozíf";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(407, 84);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " Tic-Tac-Toe";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.Location = new System.Drawing.Point(98, 102);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(220, 115);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMainScreenTicTacToe
            // 
            this.pictureBoxMainScreenTicTacToe.Image = global::TicTacToe.Properties.Resources.TicTacToe_export;
            this.pictureBoxMainScreenTicTacToe.Location = new System.Drawing.Point(112, 223);
            this.pictureBoxMainScreenTicTacToe.Name = "pictureBoxMainScreenTicTacToe";
            this.pictureBoxMainScreenTicTacToe.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxMainScreenTicTacToe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainScreenTicTacToe.TabIndex = 3;
            this.pictureBoxMainScreenTicTacToe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.pictureBoxMainScreenTicTacToe);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCredits);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainScreenTicTacToe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCredits;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox pictureBoxMainScreenTicTacToe;
    }
}

