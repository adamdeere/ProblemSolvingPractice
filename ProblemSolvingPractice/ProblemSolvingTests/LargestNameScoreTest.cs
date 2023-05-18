using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class LargestNameScoreTest
    {
        private ICalulateNameResults test;

        [SetUp]
        public void Setup()
        {
            test = new LargestNameScore();
        }

        [Test]
        public void Calculate_Name_Score_Test()
        {
            string name = "COLIN";
            long expected = 53;

            long total = test.CalculateNameScore(name);

            Assert.That(total, Is.EqualTo(expected));
        }

        [Test]
        public void Is_List_Sorted_Test()
        {
            List<string> list = test.ReadInFile("Files/names.txt");
            string name = list[937];
            string expected = "COLIN";

            long total = test.CalculateNameScore(name);

            Assert.That(name, Is.EqualTo(expected));
        }
    }
}