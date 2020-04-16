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
    class BoardControl : TableLayoutPanel
    {
        /// <summary>
        /// Fires when one of the cells is clicked
        /// </summary>
        public event EventHandler CellClick;
        /// <summary>
        /// Game colors
        /// </summary>
        private Color[] colors;

        /// <summary>
        /// Create a new board control
        /// </summary>
        /// <param name="board">board</param>
        /// <param name="colors">colors for each index</param>
        public BoardControl(Board board, Color[] colors)
        {
            Dock = DockStyle.Fill;
            this.colors = colors;
            RowCount = board.Size+1;
            ColumnCount = board.Size+1;
            RowStyles.Clear();
            ColumnStyles.Clear();
            for (int i = 0; i < board.Size; i++)
            {
                RowStyles.Add(new RowStyle(SizeType.Absolute, (float)500 / board.Size));
                ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, (float)500 / board.Size));
            }
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    var pbox = new CellControl(board[i,j]);
                    pbox.BackColor = colors[pbox.Cell.Color];
                    pbox.Click += (_,__) => { CellClick(_,__); };
                    Controls.Add(pbox, j, i);
                }
            }
        }

        public void UpdateBoard(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    this[i, j].Cell = board[i, j];
                    this[i, j].BackColor = colors[board[i, j].Color];
                }
            }
        }

        /// <summary>
        /// Get cell control from the board
        /// </summary>
        /// <param name="i">row</param>
        /// <param name="j">column</param>
        /// <returns>Returns the cell control at the (<paramref name="i"/>, <paramref name="j"/>) position</returns>
        public CellControl this[int i, int j]
        {
            get => ((CellControl)GetControlFromPosition(j, i));
        }
    }
}
