using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        long test = 14455555555555555;

        int length = test.ToString().Length;
        int range = 13;
        ICalulateNameResults m = new LargestNameScore();
        long result = m.CalculateResults();
        Console.WriteLine("The result is : " + result);
        Console.ReadLine();
    }
}