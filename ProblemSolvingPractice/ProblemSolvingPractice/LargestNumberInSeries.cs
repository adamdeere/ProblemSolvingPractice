namespace ProblemSolvingPractice
{
    public class LargestNumberInSeries : ICalculateProduct
    {
        public long CalculateResults(int step)
        {
            char[] numbers = ReadInFile("Files/numberSeries.txt");
            return 0;
           
        }

        public char[] ReadInFile(string fileName)
        {
            string error = "Error: The file could not be read:";
            try
            {
                // Open the text file using a stream reader.
                using var sr = new StreamReader("Files/numberSeries.txt");
                List<char> numberSeries = sr.ReadToEnd().ToList();

                for (int i = 0; i < numberSeries.Count; i++)
                {
                    if (i == 50)
                    {
                        int y = 0;
                        y++;
                    }
                    char f = numberSeries[i];
                    if (numberSeries[i] == '\r' || numberSeries[i] == '\n')
                    {
                        numberSeries.RemoveAt(i);
                        i--;
                    }
                }
                return numberSeries.ToArray();
               
            }
            catch (IOException e)
            {
                Console.WriteLine(error);
                Console.WriteLine(e.Message);
                return error.ToCharArray();
            }
        }
    }
}
