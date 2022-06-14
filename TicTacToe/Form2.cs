using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetButtons();
            
        }
        static Board boardPlaySpace = new Board(3);
        public Button[,] btnGrid = new Button[boardPlaySpace.boardSize, boardPlaySpace.boardSize];

        public void SetButtons()
        {
         int buttonSize = panelTicTacToe.Height / boardPlaySpace.boardSize;

            for(int i = 0; i < boardPlaySpace.boardSize; i++)
            {
                for(int j = 0; j < boardPlaySpace.boardSize; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    panelTicTacToe.Controls.Add(btnGrid[i, j]);

                    btnGrid[i, j].Location = new Point(i *buttonSize, j *buttonSize);   


                }


            }

        }

    }
}
