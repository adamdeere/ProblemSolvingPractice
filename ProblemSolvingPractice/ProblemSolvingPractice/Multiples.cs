using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class Multiples
    {
        public int CalculateMultiples(int range)
        {
            int total = 0;
            for (int i = 1; i < range; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
