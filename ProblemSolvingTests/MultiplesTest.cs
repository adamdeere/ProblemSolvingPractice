using ProblemSolvingPractice;

namespace ProblemSolvingTests
{
    public class Tests
    {
        private Multiples test;
        [SetUp]
        public void Setup()
        {
            test = new Multiples();
        }

        [Test]
        public void Test1()
        {
            int expected = 0;
            int range = 10;
            int result = test.CalculateMultiples(range);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}