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
            BigInteger next = 0;
            BigInteger prev = 0;
            int index = 1;
            
            while (next.ToString().Length < maxValue)
            {
             
                if (next == 0)
                {
                    next = 1;
                }
                else
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
