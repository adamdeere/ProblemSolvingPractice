using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        int range = 13;
        ICalulateNameResults m = new LargestNameScore();
        long result = m.CalculateResults();
        Console.WriteLine("The result is : " + result);
        Console.ReadLine();
    }
}