namespace ProblemSolvingPractice
{
    public class LargestNameScore : ICalulateNameResults
    {
        public long CalculateResults()
        {
            List<string> results = ReadInFile("Files/names.txt");
            results.Sort();

            for (int i = 0; i < results.Count; i++)
            {
                long nameScore = CalculateNameScore("COLIN");
            }
            return 0;
        }

        private List<string> ReadInFile(string fileName)
        {
            // Open the text file using a stream reader.
            using var sr = new StreamReader(fileName);
            string line = sr.ReadToEnd();

            return line.Split(new char[] { ',', '\"', '"' }, StringSplitOptions.RemoveEmptyEntries).ToList();
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