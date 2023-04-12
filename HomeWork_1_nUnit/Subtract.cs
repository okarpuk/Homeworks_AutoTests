using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_nUnit
{
    [TestFixture]
    public class Subtract
    {
        [TestCase(22, 10, 12)]
        [TestCase(10, 32, -22)]
        [TestCase(3.2, 2.1, 1.1)]
        [TestCase(-5.5, 2.1, -7.6)]

        public void SubtractTest(double a, double b, double expected)
        {
            var calculation = new Calculator();

            double actual = calculation.Subtract(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
