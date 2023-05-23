

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

        public static int TotalSum(int power) 
        {
            BigInteger result = TotalPower(power);

            char[] resultArray = result.ToString().ToCharArray();
            int finalResult = 0;
            for (int i = 0; i < resultArray.Length; i++)
            {
                finalResult += int.Parse(resultArray[i].ToString());
            }
            return finalResult;
        }
    }
}
