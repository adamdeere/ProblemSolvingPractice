using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class LargestNumberInSeriesTest
    {
        private ICalculateProduct test;

        [SetUp]
        public void Setup()
        {
            test = new LargestNumberInSeries();
        }

        [Test]
        public void Find_Largest_Product_Test()
        {
            int expected = 5832;
            int step = 4;
            long result = test.CalculateResults(step);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Read_In_File_Test()
        {
            int expected = 1000;

            char[] testArray = test.ReadInFile("Files/numberSeries.txt");

            Assert.That(testArray, Has.Length.EqualTo(expected));
        }
    }
}