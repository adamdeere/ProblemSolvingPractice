﻿using NUnit.Framework.Internal;

namespace ProblemSolvingTests
{
    public class SumationOfPrimeTest
    {
        private ICalulateLargeResults CalculateResults;

        [SetUp]
        public void Setup()
        {
            CalculateResults = new SumationOfPrimes();
        }

        [Test]
        public void Is_Number_A_Prime_Test()
        {
            int range = 19;
            bool result = Utils.IsPrime(range);

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
        public void Calculate_Prime_Numbers_Test_Low()
        {
            int expected = 17;
            int range = 10;

            long result = CalculateResults.CalculateResults(range);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Prime_Numbers_Test_Medium()
        {
            int expected = 41;
            int range = 17;

            long result = CalculateResults.CalculateResults(range);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Prime_Numbers_Test_Middle()
        {
            int expected = 277050;
            int range = 2001;

            long result = CalculateResults.CalculateResults(range);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Prime_Numbers_Test_High()
        {
            int expected = 873608362;
            int range = 140759;

            long result = CalculateResults.CalculateResults(range);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_Prime_Numbers_Test_Last()
        {
            long expected = 142913828922;
            int range = 2000000;

            long result = CalculateResults.CalculateResults(range);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}