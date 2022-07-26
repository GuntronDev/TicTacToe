using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Move
    {
        public Cell cellLocation { get; set; }

        public Move(Cell cellLocation)
        {
            this.cellLocation = cellLocation;  
        }
    }
}
