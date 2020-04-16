using Expansion.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models.Algorithms
{
    class StrategyRandom : IStrategy
    {
        public int BestMove(Game game)
        {
            int color;
            do
            {
                color = Rand.Next(game.MaxColor);
            } while (color == game.Board.First.Color || color == game.Board.Last.Color);
            return color;
        }
    }
}
