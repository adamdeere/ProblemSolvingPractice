﻿using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class SumationOfPrimeTest
    {
        private ICalculateResults CalculateResults;
        [SetUp]
        public void Setup()
        {
            CalculateResults = new SumationOfPrimes();
        }

        [Test]
        public void Is_Number_A_Prime_Test()
        {
            bool result = Utils.IsPrime(19);

            Assert.That(result, Is.True);
        }
        [Test]
        public void Is_Number_A_Prime_Test_Edge_Case()
        {
            int range = 4;
            bool result = Utils.IsPrime(range);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Calculate_Prime_Numbers_Test()
        {
            int expected = 17;
            int range = 10;

            int result = CalculateResults.CalculateResults(range);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}