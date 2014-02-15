using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RussianPeasantsMultiplication;

namespace RussianPeasantsTests
{
    [TestFixture]
    public class MultiplierTestShould
    {
        private readonly Multiplier multiplier = new Multiplier();
        
        [TestCase(1,1, Result = 1)]
        [TestCase(2, 2, Result = 4)]
        [TestCase(1, 2, Result = 2)]
        [TestCase(55, 43, Result = 2365)]
        public int correctly_multiply_specified_integers(int first, int second)
        {
            return multiplier.Multiply(first, second);
        }

        [Test]
        public void correctly_multiply_any_integers([Random(1, 1000, 10)]int first, [Random(1, 1000, 10)]int second)
        {
            var expected = first*second;
            Assert.AreEqual(expected, multiplier.Multiply(first, second), "Multiplier returned incorrect answer");
        }

    }
}
