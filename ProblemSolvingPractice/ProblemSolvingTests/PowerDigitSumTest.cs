using System.Numerics;

namespace ProblemSolvingTests
{
    public class PowerDigitSumTest
    {
        ThousandFibNumber test;
        [SetUp]
        public void Setup()
        {
            test = new ThousandFibNumber();
        }

        [Test]
        public void Calculate_Total_Power_Test()
        {
            int range = 15;
            BigInteger expected = 32768;

            BigInteger total = PowerDigitSum.TotalPower(range);

            Assert.That(total, Is.EqualTo(expected));
        }

        //[Test]
        //public void Calculate_Total_Sum_Test()
        //{
        //    int range = 15;
        //    long expected = 26;

        //    int total = ThousandFibNumber.SumUpEvenFib(range);

        //    Assert.That(total, Is.EqualTo(expected));
        //}
    }
}
