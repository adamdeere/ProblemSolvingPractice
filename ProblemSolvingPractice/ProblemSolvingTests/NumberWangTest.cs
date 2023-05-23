using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTests
{
    public class NumberWangTest
    {
        ThousandFibNumber test;
        [SetUp]
        public void Setup()
        {
            test = new ThousandFibNumber();
        }

        [Test]
        public void Calculate_Total_Index_Test()
        {
            long expected = 19;

            int total = NumberWang.CalculateNumberLetterCount("Files/numberWangTest.txt");

            Assert.That(total, Is.EqualTo(expected));
        }
    }
}
