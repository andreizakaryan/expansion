using Expansion.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models
{
    public class Board
    {
        /// <summary>
        /// The board
        /// </summary>
        private Cell[,] gameBoard;
        /// <summary>
        /// The size of the board
        /// </summary>
        public int Size;
        /// <summary>
        /// The first cell of the board
        /// </summary>
        public Cell First
        {
            get => gameBoard[0, 0];
            set => gameBoard[0, 0] = value;
        }
        /// <summary>
        /// The last cell of the board
        /// </summary>
        public Cell Last
        {
            get => gameBoard[Size - 1, Size - 1];
            set => gameBoard[Size - 1, Size - 1] = value;
        }
        /// <summary>
        /// Checks if the board contains the given cell
        /// </summary>
        /// <param name="i">row</param>
        /// <param name="j">column</param>
        /// <returns></returns>
        public bool Contains(int i, int j) => i >= 0 && j >= 0 && i < Size && j < Size;

        /// <param name="size">the size of the board</param>
        public Board(int size)
        {
            Size = size;
            gameBoard = new Cell[Size, Size];
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="board"></param>
        public Board(Board board)
        {
            Size = board.Size;
            gameBoard = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    gameBoard[i, j] = new Cell(board[i, j]);
                }
            }
        }

        /// <summary>
        /// Fill the board with random colors
        /// </summary>
        /// <param name="maxColor">maximal color index</param>
        public void FillBoard(int maxColor)
        {
            int color;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    bool diff = false;
                    do
                    {
                        diff = true;
                        color = Rand.Next(maxColor);
                        if (i > 0) diff = color != gameBoard[i - 1, j].Color;
                        if (j > 0) diff &= (color != gameBoard[i, j - 1].Color);
                        if (i == Size - 1 && j == Size - 1) diff &= color != First.Color;
                    } while (!diff);
                    gameBoard[i, j] = new Cell(color);
                }
            }
            First.Owned = true;
            Last.Owned = true;
        }

        /// <summary>
        /// Get cell from the board
        /// </summary>
        /// <param name="i">row</param>
        /// <param name="j">column</param>
        /// <returns>Returns the cell at the (<paramref name="i"/>, <paramref name="j"/>) position</returns>
        public Cell this[int i, int j]
        {
            get => gameBoard[i, j];
            set => gameBoard[i, j] = value;
        }

        public override string ToString()
        {
            var res = "";
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    res += gameBoard[i, j].Color + " ";
                }
                res += "\r\n";
            }
            return res;
        }

    }
}
