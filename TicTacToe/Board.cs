using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public int boardSize { get; set; }
        public Cell [,] grid { get; set; }
       
       public Board (int BoardSize)
        {
            boardSize = BoardSize;

            grid = new Cell[boardSize, boardSize];

            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    grid[i,j] = new Cell (i,j);
                }


            }



        }
    }
}
