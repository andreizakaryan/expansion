using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models.Algorithms
{
    public class Mover : IMover
    {
        /// <summary>
        /// Make a move
        /// </summary>
        /// <param name="board">board</param>
        /// <param name="player">0 - first player, 1 - second player</param>
        /// <param name="new_color">new color</param>
        /// <returns>Returns the number of cells occupied</returns>
        public int Move(Board board, int player, int new_color)
        {
            int i = 0, j = 0;
            int old_color = board.First.Color;
            if (player == 1)
            {
                i = j = board.Size - 1;
                old_color = board.Last.Color;
            }
            FindOccupied(board, i, j, old_color, new_color);
            return Count(board, i, j, new_color);
        }

        /// <summary>
        /// Find all occupied cells after the move
        /// </summary>
        /// <param name="board"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="old_color"></param>
        /// <param name="new_color"></param>
        private void FindOccupied(Board board, int i, int j, int old_color, int new_color)
        {
            if (!board.Contains(i, j)) return;
            var cell = board[i, j];
            if (cell.Color == new_color || cell.Color == old_color && cell.Owned)
            {
                cell.Color = -1;
                FindOccupied(board, i - 1, j, old_color, new_color);
                FindOccupied(board, i + 1, j, old_color, new_color);
                FindOccupied(board, i, j - 1, old_color, new_color);
                FindOccupied(board, i, j + 1, old_color, new_color);
            }            
        }

        /// <summary>
        /// Paint all cells with new color and count them
        /// </summary>
        /// <param name="board"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="new_color"></param>
        /// <returns></returns>
        private int Count(Board board, int i, int j, int new_color)
        {
            if (!board.Contains(i, j)) return 0 ;
            var cell = board[i, j];
            if (cell.Color != -1) return 0;
            cell.Color = new_color;
            cell.Owned = true;
            int res = 1;
            res += Count(board, i - 1, j,  new_color);
            res += Count(board, i + 1, j, new_color);
            res += Count(board, i, j - 1, new_color);
            res += Count(board, i, j + 1, new_color);
            return res;
        }
    }
}
