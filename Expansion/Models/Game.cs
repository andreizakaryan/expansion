using Expansion.Models.Algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Expansion.Models
{
    public class Game
    {
        public Board Board;
        public Player Player1;
        public Player Player2;
        public int MaxColor;
        public IMover Mover;
        /// <summary>
        /// 0 - first player, 1 - second palyer;
        /// </summary>
        public int CurrentPlayer;
        /// <summary>
        /// Get current player
        /// </summary>
        public Player CurPlayer
        {
            get => CurrentPlayer == 0 ? Player1 : Player2;
        }

        /// <summary>
        /// Fires when the board is updated
        /// </summary>
        public event EventHandler Update;
        /// <summary>
        /// Fires when the game is over 
        /// </summary>
        public event EventHandler End;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="player1">first player</param>
        /// <param name="player2">second player</param>
        /// <param name="size">size of the board</param>
        /// <param name="maxColor">maximal color index</param>
        public Game(Player player1, Player player2, int size, int maxColor)
        {
            Mover = new Mover();
            Board = new Board(size);
            MaxColor = maxColor;
            Board.FillBoard(MaxColor);
            Player1 = player1;
            Player2 = player2;
            CurrentPlayer = 0;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="game"></param>
        public Game(Game game)
        {
            Board = new Board(game.Board);
            Player1 = new Player(game.Player1);
            Player2 = new Player(game.Player2);
            CurrentPlayer = game.CurrentPlayer;
            MaxColor = game.MaxColor;
            Mover = game.Mover;
        }

        /// <summary>
        /// Get next state of the game
        /// </summary>
        /// <param name="color">color index</param>
        /// <returns>Returns the state of the game after the move</returns>
        public Game GetNextState(int color)
        {
            var game = new Game(this);
            game.Move(color);
            return game;
        }

        /// <summary>
        /// Get all possible moves
        /// </summary>
        /// <returns>Returns a list of all possible moves</returns>
        public List<int> GetMoves()
        {
            var moves = new List<int>();
            for (int i = 0; i < MaxColor; i++)
            {
                if (IsValidColor(i))
                {
                    moves.Add(i);
                }
            }
            return moves;
        }

        /// <summary>
        /// Make move as a human or a bot
        /// </summary>
        /// <param name="color">color index</param>
        public void MakeMove(int color)
        {
            Move(color);
            NextMove();
        }

        /// <summary>
        /// Make a move if the current player is a bot
        /// </summary>
        public void NextMove()
        {
            if (CurPlayer.Bot && !IsOver())
            {
                MakeMove(CurPlayer.Strategy.BestMove(this));
            }
        }

        /// <summary>
        /// Check if the game is over
        /// </summary>
        /// <returns>Returns true if the game is over</returns>
        public bool IsOver()
        {
            var half = Math.Ceiling((double)(Board.Size * Board.Size) / 2);
            return Player1.Score >= half || Player2.Score >= half;
        }

        /// <summary>
        /// Make a move and switch the player
        /// </summary>
        /// <param name="color">color index</param>
        private void Move(int color)
        {
            if (!IsValidColor(color))
            {
                return;
            }
            CurPlayer.Score = Mover.Move(Board, CurrentPlayer, color);
            SwitchPlayer();
            Update?.Invoke(this, new EventArgs());
            if (IsOver())
            {
                End?.Invoke(this, new EventArgs());
                return;
            }
        }

        /// <summary>
        /// Swith the player
        /// </summary>
        private void SwitchPlayer()
        {
            CurrentPlayer = 1 - CurrentPlayer;
        }

        /// <summary>
        /// Check if the color is valid for making move
        /// </summary>
        /// <param name="color">color index</param>
        /// <returns></returns>
        private bool IsValidColor(int color)
        {
            return color != Board.First.Color && color != Board.Last.Color;
        }
    }
}
