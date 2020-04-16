using Expansion.Models.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models
{
    public class Player
    {
        public string Name  = "";
        public bool Bot = false;
        public int Score = 1;
        public IStrategy Strategy;

        public Player()
        {
        }

        public Player(Player player)
        {
            Name = player.Name;
            Bot = player.Bot;
            Score = player.Score;
            Strategy = player.Strategy;
        }
    }
}
