using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class ThousandFibNumber
    {
        public static int SumUpEvenFib(int maxValue)
        {
            BigInteger next = 1;
            BigInteger prev = 0;
            int index = 1;
            if (maxValue > 0)
            {
                while (next.ToString().Length < maxValue)
                {
                    // sum up the next fib term
                    BigInteger temp = next;

                    next += prev;
                    prev = temp;
                    index += 1;
                }
            }
           

            return index;
        }
    }
}
