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
            this.textBoxPlayersName = new System.Windows.Forms.TextBox();
            this.textBoxPlayersScore = new System.Windows.Forms.TextBox();
            this.textBoxAiName = new System.Windows.Forms.TextBox();
            this.textBoxAiScore = new System.Windows.Forms.TextBox();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.textBoxVictoryBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelTicTacToe
            // 
            this.panelTicTacToe.Location = new System.Drawing.Point(16, 226);
            this.panelTicTacToe.Margin = new System.Windows.Forms.Padding(4);
            this.panelTicTacToe.Name = "panelTicTacToe";
            this.panelTicTacToe.Size = new System.Drawing.Size(600, 554);
            this.panelTicTacToe.TabIndex = 0;
            // 
            // textBoxPlayersName
            // 
            this.textBoxPlayersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayersName.Location = new System.Drawing.Point(16, 16);
            this.textBoxPlayersName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayersName.Name = "textBoxPlayersName";
            this.textBoxPlayersName.ReadOnly = true;
            this.textBoxPlayersName.Size = new System.Drawing.Size(50, 60);
            this.textBoxPlayersName.TabIndex = 1;
            this.textBoxPlayersName.Text = "X";
            // 
            // textBoxPlayersScore
            // 
            this.textBoxPlayersScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayersScore.Location = new System.Drawing.Point(72, 13);
            this.textBoxPlayersScore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayersScore.Name = "textBoxPlayersScore";
            this.textBoxPlayersScore.ReadOnly = true;
            this.textBoxPlayersScore.Size = new System.Drawing.Size(52, 60);
            this.textBoxPlayersScore.TabIndex = 2;
            this.textBoxPlayersScore.Text = "0";
            // 
            // textBoxAiName
            // 
            this.textBoxAiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAiName.Location = new System.Drawing.Point(551, 16);
            this.textBoxAiName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAiName.Name = "textBoxAiName";
            this.textBoxAiName.ReadOnly = true;
            this.textBoxAiName.Size = new System.Drawing.Size(50, 60);
            this.textBoxAiName.TabIndex = 3;
            this.textBoxAiName.Text = "O";
            // 
            // textBoxAiScore
            // 
            this.textBoxAiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAiScore.Location = new System.Drawing.Point(499, 16);
            this.textBoxAiScore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAiScore.Name = "textBoxAiScore";
            this.textBoxAiScore.ReadOnly = true;
            this.textBoxAiScore.Size = new System.Drawing.Size(44, 60);
            this.textBoxAiScore.TabIndex = 4;
            this.textBoxAiScore.Text = "0";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(16, 123);
            this.buttonPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(600, 79);
            this.buttonPlayAgain.TabIndex = 5;
            this.buttonPlayAgain.Text = "Play Again!!!";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // textBoxVictoryBox
            // 
            this.textBoxVictoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVictoryBox.Location = new System.Drawing.Point(131, 15);
            this.textBoxVictoryBox.Name = "textBoxVictoryBox";
            this.textBoxVictoryBox.ReadOnly = true;
            this.textBoxVictoryBox.Size = new System.Drawing.Size(361, 61);
            this.textBoxVictoryBox.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 789);
            this.Controls.Add(this.textBoxVictoryBox);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.textBoxAiScore);
            this.Controls.Add(this.textBoxAiName);
            this.Controls.Add(this.textBoxPlayersScore);
            this.Controls.Add(this.textBoxPlayersName);
            this.Controls.Add(this.panelTicTacToe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTicTacToe;
        private System.Windows.Forms.TextBox textBoxPlayersName;
        private System.Windows.Forms.TextBox textBoxPlayersScore;
        private System.Windows.Forms.TextBox textBoxAiName;
        private System.Windows.Forms.TextBox textBoxAiScore;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.TextBox textBoxVictoryBox;
    }
}