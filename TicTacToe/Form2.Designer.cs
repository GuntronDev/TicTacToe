namespace TicTacToe
{
    partial class Form2
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
            this.panelTicTacToe = new System.Windows.Forms.Panel();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.textBoxVictoryBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelTicTacToe
            // 
            this.panelTicTacToe.Location = new System.Drawing.Point(12, 184);
            this.panelTicTacToe.Name = "panelTicTacToe";
            this.panelTicTacToe.Size = new System.Drawing.Size(450, 450);
            this.panelTicTacToe.TabIndex = 0;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(12, 100);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(450, 64);
            this.buttonPlayAgain.TabIndex = 5;
            this.buttonPlayAgain.Text = "Play Again!!!";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // textBoxVictoryBox
            // 
            this.textBoxVictoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVictoryBox.Location = new System.Drawing.Point(12, 12);
            this.textBoxVictoryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVictoryBox.Name = "textBoxVictoryBox";
            this.textBoxVictoryBox.ReadOnly = true;
            this.textBoxVictoryBox.Size = new System.Drawing.Size(451, 50);
            this.textBoxVictoryBox.TabIndex = 6;
            this.textBoxVictoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 641);
            this.Controls.Add(this.textBoxVictoryBox);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.panelTicTacToe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTicTacToe;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.TextBox textBoxVictoryBox;
    }
}