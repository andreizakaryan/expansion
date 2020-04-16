using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models
{
    public class Cell
    {
        /// <summary>
        /// Color index of the cell 
        /// </summary>
        public int Color;

        /// <summary>
        /// Is the cell owned by one of the players
        /// </summary>
        public bool Owned;
        
        /// <param name="color">color of the cell</param>
        /// <param name="owned">is the cell owned</param>
        public Cell(int color, bool owned = false)
        {
            Color = color;
            Owned = owned;
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="cell"></param>
        public Cell(Cell cell)
        {
            Color = cell.Color;
            Owned = cell.Owned;
        }
    }
}
