using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class LargestNumberInSeriesTest
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Calculate_Multiples_Test()
        {
            int range = 4;
            int expected = 5832;

            int total = 0;

            Assert.That(total, Is.EqualTo(expected));
        }
    }
}
