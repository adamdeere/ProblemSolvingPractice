using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class LargestNumberInSeriesTest
    {
        ICalculateProduct test;
        [SetUp]
        public void Setup()
        {
           test = new LargestNumberInSeries();
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
