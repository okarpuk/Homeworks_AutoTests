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
        [TestCase(2, 5, 10)]
        [TestCase(5, 3, 15)]
        [TestCase(12, 10, 120)]
        [TestCase(10, 3, 30)]
        public void MultiplyTest(double a, double b, double expected)
        {
            var calculation = new Calculator();

            var actual = calculation.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }





    }
}
