using System;
using System.Collections;

namespace ProblemSolvingPractice
{
    
    public class FactorialDigitSum : ICalculateFactorial
    {
        private ArrayList v = new ArrayList();

        private void Multiply(int x)
        {
            int carry = 0;
            int size = v.Count;
            for (int i = 0; i < size; i++)
            {
                // Calculate res + prev carry
                int res = carry + (int)v[i] * x;

                // updation at ith position
                v[i] = res % 10;
                carry = res / 10;
            }
            while (carry != 0)
            {
                v.Add(carry % 10);
                carry /= 10;
            }
        }

        // Returns sum of digits in n!
        public int FindSumOfDigits(int n)
        {
            v.Add(1); // adds 1 to the end

            // One by one multiply i to current vector
            // and update the vector.
            for (int i = 1; i <= n; i++)
                Multiply(i);

            // Find sum of digits in vector v[]
            int sum = 0;
            int size = v.Count;
            for (int i = 0; i < size; i++)
                sum += (int)v[i];
            return sum;
        }

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