using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        Multiples m = new Multiples();
        int result = m.CalculateMultiples(1000);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}