using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class Utils
    {
        public static bool IsPrime(int number)
        {
            int count = 0;
            for (int i = 1; i < number; i++)
            {
                if (i % number == 0)
                {
                    count++;
                    if (count > 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
