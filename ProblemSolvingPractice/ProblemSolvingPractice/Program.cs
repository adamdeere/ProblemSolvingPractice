using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        int range = 10;
        ICalculateFactorial m = new FactorialDigitSum();
        long result = m.CalculateResults(range);
        Console.WriteLine("The result is : " + result);
        Console.ReadLine();
    }
}