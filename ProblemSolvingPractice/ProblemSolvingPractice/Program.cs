using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        int range = 2000000;
        ICalculateResults m = new SumationOfPrimes();
        int result = m.CalculateResults(range);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}