namespace ProblemSolvingPractice
{
    public class LargestNumberInSeries : ICalculateProduct
    {
        public long CalculateResults(int step)
        {
            long result = 0;
            char[] numbers = ReadInFile("Files/numberSeries.txt");
            if (numbers[0] != 'E')
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int start = i;
                    int end = i + step - 1;
                    if (start != numbers.Length && end <= numbers.Length - 1)
                    {
                        long currentTotal = 1;
                        for (int j = start; j <= end; j++)
                        {
                            long current = long.Parse(numbers[j].ToString());
                            currentTotal *= current;
                        }

                        if (currentTotal > result)
                        {
                            result = currentTotal;
                        }
                    }
                }
            }

            return result;
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