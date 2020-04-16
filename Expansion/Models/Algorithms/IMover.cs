using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Models.Algorithms
{
    public interface IMover
    {
        int Move(Board board, int player, int new_color);
    }
}
