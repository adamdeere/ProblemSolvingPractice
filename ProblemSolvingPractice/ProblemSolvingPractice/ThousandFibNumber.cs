using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class ThousandFibNumber
    {
        public int SumUpEvenFib(int maxValue)
        {
            int next = 0;
            int prev = 0;
            int index = 1;

            while (next.ToString().Length < maxValue)
            {
                int f = next.ToString().Length;
                if (next == 0)
                {
                    next = 1;
                }
                else
                {
                    // sum up the next fib term
                    int temp = next;
                    next += prev;
                    prev = temp;
                    index += 1;
                }
             
            }

            return index;
        }
    }
}
