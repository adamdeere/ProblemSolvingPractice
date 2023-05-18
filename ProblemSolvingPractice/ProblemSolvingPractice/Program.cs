using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        char c = 'C';
        //char c = 'b'; you may use lower case character.
        int index = (int)c % 32;

        int range = 13;
        ICalculateProduct m = new LargestNumberInSeries();
        long result = m.CalculateResults(range);
        Console.WriteLine("The result is : " + result);
        Console.ReadLine();
    }
}