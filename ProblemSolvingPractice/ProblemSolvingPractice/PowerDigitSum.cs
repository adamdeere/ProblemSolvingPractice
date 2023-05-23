

using System.Numerics;

namespace ProblemSolvingPractice
{
    public class PowerDigitSum
    {
        public static BigInteger TotalPower(int power)
        {
            BigInteger result = BigInteger.One + 1;
            BigInteger result2 = BigInteger.One + 1;

            for (int i = 1; i < power; i++)
            {
                result *= result2;
            }

            return result;
        }
    }
}
