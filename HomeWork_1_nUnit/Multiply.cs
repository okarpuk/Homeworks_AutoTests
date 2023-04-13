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

        [Test]
        public void MultiplyTest(int a, int b, int expected)
        {
            var calculation = new Calculator();
            var actual = calculation.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
