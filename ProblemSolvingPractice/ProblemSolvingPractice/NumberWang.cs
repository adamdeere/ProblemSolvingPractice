using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class NumberWang
    {
        public static int CalculateNumberLetterCount(string fileName)
        {
            int count = 0;
            // Open the text file using a stream reader.
            using var sr = new StreamReader(fileName);
            string line = sr.ReadToEnd();

            List<string> fileResults = line.Split(new char[] { '\n', '\r', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < fileResults.Count; i++)
            {
                if (fileResults[i] != string.Empty)
                {
                    List<string> stringResults = fileResults[i].Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    for (int j = 0; j <  stringResults.Count; j++)
                    {
                        if (stringResults[j] != string.Empty)
                        {
                            count += stringResults[j].Length;
                        }
                        
                    }
                    
                    
                }
            }

            return count;
        }
    }
}
