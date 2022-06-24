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
            this.SuspendLayout();
            // 
            // panelTicTacToe
            // 
            this.panelTicTacToe.Location = new System.Drawing.Point(12, 184);
            this.panelTicTacToe.Name = "panelTicTacToe";
            this.panelTicTacToe.Size = new System.Drawing.Size(450, 450);
            this.panelTicTacToe.TabIndex = 0;
            // 
            // textBoxPlayersName
            // 
            this.textBoxPlayersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayersName.Location = new System.Drawing.Point(12, 12);
            this.textBoxPlayersName.Name = "textBoxPlayersName";
            this.textBoxPlayersName.ReadOnly = true;
            this.textBoxPlayersName.Size = new System.Drawing.Size(116, 49);
            this.textBoxPlayersName.TabIndex = 1;
            this.textBoxPlayersName.Text = "Player";
            // 
            // textBoxPlayersScore
            // 
            this.textBoxPlayersScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayersScore.Location = new System.Drawing.Point(134, 12);
            this.textBoxPlayersScore.Name = "textBoxPlayersScore";
            this.textBoxPlayersScore.ReadOnly = true;
            this.textBoxPlayersScore.Size = new System.Drawing.Size(40, 49);
            this.textBoxPlayersScore.TabIndex = 2;
            this.textBoxPlayersScore.Text = "0";
            // 
            // textBoxAiName
            // 
            this.textBoxAiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAiName.Location = new System.Drawing.Point(374, 12);
            this.textBoxAiName.Name = "textBoxAiName";
            this.textBoxAiName.ReadOnly = true;
            this.textBoxAiName.Size = new System.Drawing.Size(48, 49);
            this.textBoxAiName.TabIndex = 3;
            this.textBoxAiName.Text = "AI\r\n\r\n";
            // 
            // textBoxAiScore
            // 
            this.textBoxAiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAiScore.Location = new System.Drawing.Point(428, 12);
            this.textBoxAiScore.Name = "textBoxAiScore";
            this.textBoxAiScore.ReadOnly = true;
            this.textBoxAiScore.Size = new System.Drawing.Size(34, 49);
            this.textBoxAiScore.TabIndex = 4;
            this.textBoxAiScore.Text = "0";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(12, 100);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(450, 64);
            this.buttonPlayAgain.TabIndex = 5;
            this.buttonPlayAgain.Text = "Player Again!!!";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 641);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.textBoxAiScore);
            this.Controls.Add(this.textBoxAiName);
            this.Controls.Add(this.textBoxPlayersScore);
            this.Controls.Add(this.textBoxPlayersName);
            this.Controls.Add(this.panelTicTacToe);
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
    }
}