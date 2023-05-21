using ProblemSolvingPractice;
using System;
using System.Collections;
internal class Program
{
    static ArrayList v = new ArrayList();
    static void Multiply(int x)
    {
        int carry = 0;
        int size = v.Count;
        for (int i = 0; i < size; i++)
        {
            // Calculate res + prev carry
            int res = carry + (int)v[i] * x;

            // updation at ith position
            v[i] = res % 10;
            carry = res / 10;
        }
        while (carry != 0)
        {
            v.Add(carry % 10);
            carry /= 10;
        }
    }

    // Returns sum of digits in n!
    static int FindSumOfDigits(int n)
    {
        v.Add(1); // adds 1 to the end

        // One by one multiply i to current vector
        // and update the vector.
        for (int i = 1; i <= n; i++)
            Multiply(i);

        // Find sum of digits in vector v[]
        int sum = 0;
        int size = v.Count;
        for (int i = 0; i < size; i++)
            sum += (int)v[i];
        return sum;
    }

    private static void Main(string[] args)
    {
        int range = 10;
        ICalculateFactorial m = new FactorialDigitSum();
        long result = m.CalculateResults(range);
        Console.WriteLine("The result is : " + result);
        int n = 10;
        Console.WriteLine(FindSumOfDigits(n));
        Console.ReadLine();

        //int range = 13;
        //ICalulateNameResults m = new LargestNameScore();
        //long result = m.CalculateResults();
        //Console.WriteLine("The result is : " + result);
        //Console.ReadLine();
    }
}