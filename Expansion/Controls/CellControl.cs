using Expansion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expansion.Controls
{
    class CellControl : PictureBox
    {
        public Cell Cell;

        public CellControl(Cell cell)
        {
            Dock = DockStyle.Fill;
            Cell = cell;
        }
    }
}
