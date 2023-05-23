using System.Collections;

namespace ProblemSolvingPractice
{
    public class Utils
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)System.Math.Floor(System.Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static void Multiply(int x, ArrayList v)
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
    }
}