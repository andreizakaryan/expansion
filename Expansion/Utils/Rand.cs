using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion.Utils
{
    static class Rand
    {
        private static Random rand = new Random();
        
        public static int Next(int max)
        {
            return rand.Next(max);
        }
    }
}
