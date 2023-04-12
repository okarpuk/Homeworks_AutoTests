using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_nUnit
{
    [TestFixture]
    public class Multiply
    {
        [TestCase(4, 6, 24)]
        [TestCase(-3, 7, -21)]
        [TestCase(1.2, 3.5, 4.2)]
        [TestCase(-3.5, 7.2, -25.2)]

        [Test]
        public void MultiplyTest(double a, double b, double expected)
        {
            var calculation = new Calculator();
            var actual = calculation.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
