using ProblemSolvingPractice;
using System;
using System.Collections;
internal class Program
{
    static ArrayList v = new ArrayList();
   

    private static void Main(string[] args)
    {
        int range = 10;
        FactorialDigitSum m = new FactorialDigitSum();
        long result = m.CalculateResults(range);
        Console.WriteLine("The result is : " + result);
        int n = 10;
        Console.WriteLine(m.FindSumOfDigits(n));
        Console.ReadLine();

        //int range = 13;
        //ICalulateNameResults m = new LargestNameScore();
        //long result = m.CalculateResults();
        //Console.WriteLine("The result is : " + result);
        //Console.ReadLine();
    }
}