using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTests
{
    public class ThousandFibNumberTests
    {
        ThousandFibNumber test;
        [SetUp]
        public void Setup()
        {
            test = new ThousandFibNumber();
        }

        [Test]
        public void Calculate_Total_Index_Test()
        {
            int range = 3;
            long expected = 12;

            int total = ThousandFibNumber.SumUpEvenFib(range);

            Assert.That(total, Is.EqualTo(expected));
        }
    }
}
