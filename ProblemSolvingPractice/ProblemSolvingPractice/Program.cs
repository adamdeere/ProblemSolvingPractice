using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        int range = 2000000;
        ICalulateLargeResults m = new SumationOfPrimes();
        long result = m.CalculateResults(range);
        Console.WriteLine("The result is : " + result);
        Console.ReadLine();
    }
}