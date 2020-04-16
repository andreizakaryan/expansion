using Expansion.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models.Algorithms
{
    class StrategyAlphaBeta : IStrategy
    {
        /// <summary>
        /// Maximal depth 
        /// </summary>
        public int Depth;
        /// <summary>
        /// Maximizing player
        /// </summary>
        public int Player;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="depth">maximal depth</param>
        /// <param name="player">maximizing player</param>
        public StrategyAlphaBeta(int depth, int player)
        {
            Depth = depth;
            Player = player;
        }

        /// <summary>
        /// Searches for the best move
        /// </summary>
        /// <param name="game">game</param>
        /// <returns>Returns the best move for current position</returns>
        public int BestMove(Game game)
        {
            return AlphaBetaRoot(game , Depth);
        }

        /// <summary>
        /// Start of minimax algorithm
        /// </summary>
        /// <param name="state">current state</param>
        /// <param name="depth">current depth of the algorithm</param>
        /// <returns>Returns random move from the best ones</returns>
        private int AlphaBetaRoot(Game state, int depth)
        {
            var moves = state.GetMoves();
            var evalMoves = new List<Tuple<int, int>>();
            foreach (var move in moves)
            {
                evalMoves.Add(new Tuple<int, int>(move, AlphaBeta(state.GetNextState(move), false, depth - 1, int.MinValue, int.MaxValue)));
            }
            evalMoves = evalMoves.OrderBy(o => o.Item2).ToList();
            evalMoves = (from move in evalMoves
                            where move.Item2 == evalMoves.Last().Item2
                            select move).ToList();
            return evalMoves[Rand.Next(evalMoves.Count)].Item1;
        }

        /// <summary>
        /// Minimax algorithm with alpha-beta pruning
        /// </summary>
        /// <param name="state">current state of the game</param>
        /// <param name="isMax">true if it's maximizing players turn</param>
        /// <param name="depth">current depth</param>
        /// <param name="alpha">alpha</param>
        /// <param name="beta">beta</param>
        /// <returns></returns>
        private int AlphaBeta(Game state, bool isMax, int depth, int alpha, int beta)
        {
            if (depth == 0 || state.IsOver())
            {                
                return Evaluate(state); 
            }
            if (isMax)
            {
                foreach (var color in state.GetMoves())
                {
                    alpha = Math.Max(alpha, AlphaBeta(state.GetNextState(color), !isMax, depth-1, alpha, beta)); 
                    if (beta <= alpha) break;
                }
                return alpha;
            }
            else
            {
                foreach (var color in state.GetMoves())
                {
                    beta = Math.Min(beta, AlphaBeta(state.GetNextState(color), !isMax, depth - 1, alpha, beta));
                    if (beta <= alpha) break;
                }
                return beta;
            }
        }
        
        /// <summary>
        /// Heuristic function
        /// </summary>
        /// <param name="state">Current state</param>
        /// <returns>Returns the rank of current position</returns>
        private int Evaluate(Game state)
        {
            int over = 0;
            if (state.IsOver())
            {
                if (state.Player1.Score > state.Player2.Score)
                {
                    over =  Player == 0 ? int.MaxValue : int.MinValue;
                }
                else if (state.Player1.Score < state.Player2.Score)
                {
                    over =  Player == 0 ? int.MinValue : int.MaxValue;
                }                
            }
            over = over / 2;
            return over + (Player==0 ? state.Player1.Score : state.Player2.Score);
        }
    }
}
