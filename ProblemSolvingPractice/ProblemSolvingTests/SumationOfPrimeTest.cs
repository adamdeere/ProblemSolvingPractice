using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class SumationOfPrimeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Is_Number_A_Prime_Test()
        {
            bool result = Utils.IsPrime(19);

            Assert.That(result, Is.True);
        }
    }
}