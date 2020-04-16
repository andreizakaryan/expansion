using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models.Algorithms
{
    public interface IStrategy
    {
        int BestMove(Game game);
    }
}
