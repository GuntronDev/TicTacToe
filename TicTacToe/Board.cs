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
        public bool VictoryX { get; set; } = false;
        public bool VictoryO { get; set; } = false;

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
        //checking all offsets to see if anyone won
        public void CheckOffSet(Cell OccupiedCell)
        {
            
            //check north          
            for (int i = OccupiedCell.row, OccupiedInRow = 0; i >= 0; i--)
            {              
                    if (Cellsgrid[OccupiedCell.column,i].isOccupied == true)
                    {
                    Console.WriteLine("Working");
                    if (Cellsgrid[OccupiedCell.column, i].occupiedByX == true)
                        {
                            OccupiedInRow += 1;
                        }
                        else if (Cellsgrid[OccupiedCell.column, i].occupiedByO == true)
                        {
                            OccupiedInRow += 10;
                        }
                    }

                    if (OccupiedInRow == 3)
                    {
                        VictoryX = true;
                        return; 
                    }
                    if (OccupiedInRow == 30)
                    {
                        VictoryO = true;
                        return;
                    }
            }
            
            //check south
            for (int i = OccupiedCell.row, OccupiedInRow = 0; i < boardSize; i++)
           {
                if (OccupiedCell.isOccupied == true)
                {
                    if (Cellsgrid[OccupiedCell.column, i].occupiedByX == true)
                    {
                        OccupiedInRow += 1;
                    }
                    if (Cellsgrid[OccupiedCell.column, i].occupiedByO == true)
                    {
                        OccupiedInRow += 10;
                    }
                }

                if (OccupiedInRow == 3)
                {
                    VictoryX = true;
                    return ;
                }
                if (OccupiedInRow == 30)
                {
                    VictoryO = true;
                    return;
                }
            }
             
            // check west            
            for (int i = OccupiedCell.column, OccupiedInRow = 0; i >= 0; i--)
            {
                 if (OccupiedCell.isOccupied == true)
                 {
                     if (Cellsgrid[i, OccupiedCell.row].occupiedByX == true)
                     {
                         OccupiedInRow += 1;
                     }
                     if (Cellsgrid[i, OccupiedCell.row].occupiedByO == true)
                     {
                         OccupiedInRow += 10;
                     }
                 }

                 if (OccupiedInRow == 3)
                 {
                     VictoryX = true;
                     return;
                 }
                 if (OccupiedInRow == 30)
                 {
                     VictoryO = true;
                     return;
                 }
             }
            
            // check east
            for (int i = OccupiedCell.column, OccupiedInRow = 0; i < boardSize; i++)
            {
                 if (OccupiedCell.isOccupied == true)
                 {
                     if (Cellsgrid[i, OccupiedCell.row].occupiedByX == true)
                     {
                         OccupiedInRow += 1;
                     }
                     if (Cellsgrid[i, OccupiedCell.row].occupiedByO == true)
                     {
                         OccupiedInRow += 10;
                     }
                 }

                 if (OccupiedInRow == 3)
                 {
                     VictoryX = true;
                     return;
                 }
                 if (OccupiedInRow == 30)
                 {
                     VictoryO = true;
                     return;
                 }
             }
            
            //check north-east
            for (int i = OccupiedCell.column, j = OccupiedCell.row, OccupiedInRow = 0; i < boardSize && j >= 0; i++, j--)
            {
                 if (OccupiedCell.isOccupied == true)
                 {
                    if (Cellsgrid[i,j].occupiedByX == true)
                     {
                         OccupiedInRow += 1;
                     }
                     if (Cellsgrid[i, j].occupiedByO == true)
                     {
                         OccupiedInRow += 10;
                     }
                 }

                 if (OccupiedInRow == 3)
                 { 
                     VictoryX = true;
                 return;
                 }
                 if (OccupiedInRow == 30)
                 {
                     VictoryO = true;
                     return;
                 }
             }
            
             //check north-west
             for (int i = OccupiedCell.column, j = OccupiedCell.row, OccupiedInRow = 0; i >= 0 && j >= 0; i--, j--)
             {
                 if (OccupiedCell.isOccupied == true)
                 {
                     if (Cellsgrid[i, j].occupiedByX == true)
                     {
                         OccupiedInRow += 1;
                     }
                     if (Cellsgrid[i, j].occupiedByO == true)
                     {
                         OccupiedInRow += 10;
                     }
                 }

                 if (OccupiedInRow == 3)
                 {
                     VictoryX = true;
                     return;
                 }
                 if (OccupiedInRow == 30)
                 {
                     VictoryO = true;
                     return;
                 }
             }
            
            //check south-east
            for (int i = OccupiedCell.column, j = OccupiedCell.row, OccupiedInRow = 0; i < boardSize && j < boardSize; i++, j++)
             {
                 if (OccupiedCell.isOccupied == true)
                 {
                     if (Cellsgrid[j, i].occupiedByX == true)
                     {
                         OccupiedInRow += 1;
                     }
                     if (Cellsgrid[j, i].occupiedByO == true)
                     {
                         OccupiedInRow += 10;
                     }
                 }

                 if (OccupiedInRow == 3)
                 {
                     VictoryX = true;
                     return;
                 }
                 if (OccupiedInRow == 30)
                 {
                     VictoryO = true;
                     return;
                 }
             }


            //check south-west
            for (int i = OccupiedCell.column, j = OccupiedCell.row, OccupiedInRow = 0; i >= 0 && j < boardSize; i--, j++)
            {
                if (OccupiedCell.isOccupied == true)
                {
                    if (Cellsgrid[j, i].occupiedByX == true)
                    {
                        OccupiedInRow += 1;
                    }
                    if (Cellsgrid[j, i].occupiedByO == true)
                    {
                        OccupiedInRow += 10;
                    }
                }

                if (OccupiedInRow == 3)
                {
                    VictoryX = true;
                    return;
                }
                if (OccupiedInRow == 30)
                {
                    VictoryO = true;
                    return;
                }
            }  
        }
    }
}
