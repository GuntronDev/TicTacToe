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
        public Cell [,] Cellsgrid { get; set; }
               
       public Board (int BoardSize)
        {
            boardSize = BoardSize;

            //create cell board
            Cellsgrid = new Cell[boardSize, boardSize];

            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    Cellsgrid[j,i] = new Cell (j,i);
                    

                }
            }
        }

        public void CheckOffSet(Cell OccupiedCell)
        {
            OccupiedCell.isOccupied = true;

            //check north          
           for (int i = OccupiedCell.row; i >= 0; i--)
           {
             
           }

            //check south
           for (int i = OccupiedCell.row ; i < boardSize; i++)
           {
              
           } 

           // check west            
           for (int i = OccupiedCell.column; i >= 0; i--)
           {
               
           }

           // check east
           for (int i = OccupiedCell.column; i < boardSize; i++)
           {
               
           }

           //check north-east
           for (int i = OccupiedCell.column, j = OccupiedCell.row ; i < boardSize && j >= 0; i++, j--)
           {
                                  
           }
           
            //check north-west
            for (int i = OccupiedCell.column, j = OccupiedCell.row; i >= 0 && j >= 0; i--, j--)
            {
              
            }
            
            //check south-east
            for (int i = OccupiedCell.column, j = OccupiedCell.row; i < boardSize && j < boardSize; i++, j++)
            {
              
            }
            
            //check south-west
            for (int i = OccupiedCell.column, j = OccupiedCell.row; i >= 0 && j < boardSize; i--, j++)
            {
               
            }
        }
    }
}
