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
    }
}