using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        int range = 4;
        ICalculateProduct m = new LargestNumberInSeries();
        long result = m.CalculateResults(range);
        Console.WriteLine("The result is : " + result);
        Console.ReadLine();
    }
}