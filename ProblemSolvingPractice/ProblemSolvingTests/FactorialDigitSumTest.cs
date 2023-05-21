using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class FactorialDigitSumTest
    {
        private ICalculateFactorial test;

        [SetUp]
        public void Setup()
        {
            test = new FactorialDigitSum();
        }

        [Test]
        public void Calculate_Total_Score_Test()
        {
            int range = 10;
            long expected = 27;

            long total = test.CalculateResults(range);

            Assert.That(total, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Inital_Product()
        {
            int range = 10;
            long expected = 3628800;

            long total = test.CalculateProduct(range);

            Assert.That(total, Is.EqualTo(expected));
        }
    }
}