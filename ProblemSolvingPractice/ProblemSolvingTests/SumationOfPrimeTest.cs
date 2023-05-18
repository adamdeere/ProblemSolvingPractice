using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
