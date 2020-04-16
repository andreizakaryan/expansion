using Expansion.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expansion.Controls
{
    class ColorPicker : TableLayoutPanel
    {
        private Color[] colors;
        private int maxColor { get => colors.Count(); }

        /// <summary>
        /// Fires when one of the cells is clicked
        /// </summary>
        public event EventHandler CellClick;

        public ColorPicker(Color[] colors, List<int> available)
        {
            this.colors = colors;
            Dock = DockStyle.Fill;
            RowCount = maxColor - 2;
            ColumnCount = 1;
            RowStyles.Clear();
            ColumnStyles.Clear();
            for (int i = 0; i < maxColor - 2; i++)
            {
                RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            }
            int cur = 0;
            for (int i = 0; i < maxColor; i++)
            {
                if (available.Contains(i))
                {
                    var pbox = new CellControl(new Cell(i));
                    pbox.BackColor = colors[pbox.Cell.Color];
                    pbox.Click += (_, __) => { CellClick(_, __); };
                    Controls.Add(pbox, 0, cur);
                    cur++;
                }
            }
        }

        public void UpdateColorPicker(List<int> available)
        {
            int cur = 0;
            for (int i = 0; i < maxColor; i++)
            {
                if (available.Contains(i))
                {
                    this[cur].Cell.Color = i;
                    this[cur].BackColor = colors[i];
                    cur++;
                }
            }
        }

        /// <summary>
        /// Get cell control from the color picker
        /// </summary>
        /// <param name="i">row</param>
        /// <returns>Returns the cell control at the <paramref name="i"/>-th position</returns>
        public CellControl this[int i]
        {
            get => ((CellControl)GetControlFromPosition(0, i));
        }
    }
}
