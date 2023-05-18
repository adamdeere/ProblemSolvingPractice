namespace ProblemSolvingPractice
{
    public class LargestNameScore : ICalulateNameResults
    {
        public long CalculateResults()
        {
            long result = 0;
            List<string> results = ReadInFile("Files/names.txt");
            for (int i = 0; i < results.Count; i++)
            {
                long nameScore = CalculateNameScore(results[i]);
                int index = i + 1;
                if (i >= results.Count)
                {
                    index--;
                }
                result += nameScore * index;
            }
            return result;
        }

        public List<string> ReadInFile(string fileName)
        {
            // Open the text file using a stream reader.
            using var sr = new StreamReader(fileName);
            string line = sr.ReadToEnd();
            List<string> results = line.Split(new char[] { ',', '\"', '"' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            results.Sort();
            return results;
        }

        public long CalculateNameScore(string name)
        {
            long score = 0;
            for (int i = 0; i < name.Length; i++)
            {
                int index = name[i] % 32;
                score += index;
            }
            return score;
        }
    }
}