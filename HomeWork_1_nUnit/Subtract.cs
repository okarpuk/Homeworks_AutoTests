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

        public void SubtractTest(int a, int b, int expected)
        {
            var calculation = new Calculator();
            var actual = calculation.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
