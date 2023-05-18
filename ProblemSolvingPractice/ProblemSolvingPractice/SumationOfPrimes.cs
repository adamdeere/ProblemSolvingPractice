namespace ProblemSolvingPractice
{
    // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //  Find the sum of all the primes below two million.
    public class SumationOfPrimes : ICalulateLargeResults
    {
        public long CalculateResults(int range)
        {
            //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            long total = 0;
            for (int i = 1; i < range; i++)
            {
                if (Utils.IsPrime(i))
                {
                    total += i;
                }
            }
            return total;
        }
    }
}