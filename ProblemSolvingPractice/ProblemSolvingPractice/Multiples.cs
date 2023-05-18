namespace ProblemSolvingPractice
{
    public class Multiples : ICalculateResults
    {
        public int CalculateResults(int range)
        {


            int total = 0;
            if (range > 0)
            {
                for (int i = 1; i < range; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        total += i;
                    }
                }
            }
            return total;
        }
    }
}