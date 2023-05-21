using ProblemSolvingPractice;
using System;
using System.Collections;
internal class Program
{
    static ArrayList v = new ArrayList();
   

    private static void Main(string[] args)
    {
       
        FactorialDigitSum m = new FactorialDigitSum();
        int n = 100;
        Console.WriteLine(m.FindSumOfDigits(n));
        Console.ReadLine();
    }
}