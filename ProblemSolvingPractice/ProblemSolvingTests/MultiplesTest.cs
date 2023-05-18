namespace ProblemSolvingTests
{
    public class CalculateMultiplesTests
    {
        private ICalculateResults test;

        [SetUp]
        public void Setup()
        {
            test = new Multiples();
        }

        [Test]
        public void Calculate_Multiples_Test()
        {
            int range = 10;
            int expected = 23;

            int total = test.CalculateResults(range);

            Assert.That(total, Is.EqualTo(expected));
        }
    }
}