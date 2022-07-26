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
        public static bool Xplaying = true;
        List<Move>moves = new List<Move>();
        public static bool AiPlaying = false;
       
        public void SetButtons()
        {            
            int buttonSize = panelTicTacToe.Height / boardPlaySpace.boardSize;

            //create button board

            for (int i = 0; i < boardPlaySpace.boardSize; i++)
            {
                for (int j = 0; j < boardPlaySpace.boardSize; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    panelTicTacToe.Controls.Add(btnGrid[i, j]);

                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].Click += buttonCell_Click;

                    btnGrid[i, j].Tag = new Point(i, j);

                    btnGrid[i, j].Font = new Font(btnGrid[i, j].Font.FontFamily, 40);
                }
            }
        }
        public void buttonCell_Click(object sender, EventArgs e)
        {
            Button CommonButton = (Button)sender;

            //set the same button reference to cell reference
            Point Location = (Point)CommonButton.Tag;         

            int x = Location.X;
            int y = Location.Y;

            Cell CurrentCell = boardPlaySpace.Cellsgrid[x, y];

            if (AiPlaying == true)
            {
                Cell AiCell = PlaceAiMoves();
                PlaceMove(AiCell);
                btnGrid[AiCell.column, AiCell.row].Enabled = false;

            }
            if(AiPlaying == false)
            {
                PlaceMove(CurrentCell);
                CommonButton.Enabled = false;
                
            }
            CheckForWinning();

            Xplaying = !Xplaying;
            AiPlaying = !AiPlaying;
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < boardPlaySpace.boardSize; i++)
            {
                for(int j = 0; j < boardPlaySpace.boardSize; j++)
                {
                    btnGrid[i,j].Enabled = true;
                    btnGrid[i, j].Text = null;
                    boardPlaySpace.VictoryX = false;
                    boardPlaySpace.VictoryO = false;
                    boardPlaySpace.Cellsgrid[i,j].isOccupied = false;
                    boardPlaySpace.Cellsgrid[i, j].occupiedByX = false;
                    boardPlaySpace.Cellsgrid[i, j].occupiedByO = false;
                    Xplaying = true;
                    textBoxVictoryBox.Text = "No Victory";
                }
            }

        }
        public List<Move> FindMoves()
        {
            moves = new List<Move>();
            for(int i = 0; i < boardPlaySpace.boardSize; i++)
            {
                for(int j = 0; j < boardPlaySpace.boardSize; j++)
                {
                    if (btnGrid[i,j].Enabled == true)
                    {
                       moves.Add(new Move(boardPlaySpace.Cellsgrid[i,j]));                        
                    }
                }
            }
            return moves;
        }

        public Cell PlaceAiMoves()
        { 
            moves = FindMoves();
            Random rand = new Random();
            Cell CommonCell = moves[rand.Next(0, moves.Count)].cellLocation;
            return CommonCell;
        }
        private void CheckForWinning()
        {

            for (int i = 0; i < boardPlaySpace.boardSize; i++)
            {
                for (int j = 0; j < boardPlaySpace.boardSize; j++)
                {
                    boardPlaySpace.CheckOffSet(boardPlaySpace.Cellsgrid[i, j]);
                }
            }

            //Victory display
            if (boardPlaySpace.VictoryX == true)
            {
                textBoxVictoryBox.Text = "X won";
                return;
            }
            if (boardPlaySpace.VictoryO == true)
            {
                textBoxVictoryBox.Text = "O won";
                return;
            }
            else { textBoxVictoryBox.Text = "no Victory"; }

        }
        private void PlaceMove(Cell CurrentCell)
        {
            if (Xplaying == true)
            {
                btnGrid[CurrentCell.column,CurrentCell.row].Text = "X";

                CurrentCell.occupiedByX = true;
            }
            if (Xplaying == false)
            {
                btnGrid[CurrentCell.column, CurrentCell.row].Text = "O";

                CurrentCell.occupiedByO = true;
            }

        }
    }
}
