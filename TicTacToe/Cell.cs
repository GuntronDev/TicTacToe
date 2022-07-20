using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Cell
    {
        public int column { get; set; }
        public int row { get; set; }
        public bool isOccupied { get; set; } = false;
        public bool occupiedByX { get; set; } = false;
        public bool occupiedByO { get; set; } = false;

     

        public Cell(int column, int row)
        {
            this.column = column;
            this.row = row;
        }
    }
}
