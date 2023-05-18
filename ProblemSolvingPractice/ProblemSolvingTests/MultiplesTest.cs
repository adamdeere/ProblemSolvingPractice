namespace ProblemSolvingTests
{
    public class CalculateMultiplesTests
    {
        Multiples test;
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

            int total = test.CalculateMultiples(range);

            Assert.That(total, Is.EqualTo(expected));
        }
    }
}