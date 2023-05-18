using ProblemSolvingPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        char[] lol;
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader("Files/numberSeries.txt"))
            {
                lol = sr.ReadToEnd().ToCharArray();
                // Read the stream as a string, and write the string to the console.
                Console.WriteLine(sr.ReadToEnd());
                
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        int i = 0;
        i++;
       // int range = 2000000;
       // ICalulateLargeResults m = new SumationOfPrimes();
       // long result = m.CalculateResults(range);
       // Console.WriteLine("The result is : " + result);
       // Console.ReadLine();
    }
}