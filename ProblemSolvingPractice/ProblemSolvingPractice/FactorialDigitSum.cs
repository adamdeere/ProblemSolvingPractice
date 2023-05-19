using System;

namespace ProblemSolvingPractice
{
    public class FactorialDigitSum : ICalculateFactorial
    {
        public long CalculateProduct(int range)
        {
              var factorialExpression = string.Join("*", Enumerable.Range(1, range));
            factorialExpression.Reverse();
            long total = range * (range - 1);
            range -= 2;
          
            while (range != 1)
            {
                total *= range;
                range--;
            }
            
            return total;
        }

        public long CalculateResults(int range)
        {
            long product = CalculateProduct(range);

            char[] charArray = product.ToString().ToCharArray();

            long total = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                long y = long.Parse(charArray[i].ToString());
                total += y;
            }
            return total;
        }
    }
}