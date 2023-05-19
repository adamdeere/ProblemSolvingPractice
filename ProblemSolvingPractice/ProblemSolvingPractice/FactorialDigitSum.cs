using System;

namespace ProblemSolvingPractice
{
    public class FactorialDigitSum : ICalculateFactorial
    {
        public long CalculateProduct(int range)
        {
            long total = range * (range - 1);
            range = range - 2;
            int inital = range;
            while (range != 1)
            {
                total = total * range;
                range--;
            }
            
            return total;
        }

        public long CalculateResults(int range)
        {
            return CalculateProduct(range);
        }
    }
}