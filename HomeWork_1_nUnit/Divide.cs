using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_nUnit
{
    [TestFixture]
    public class Divide
    {
        [TestCase(9, 3, 3)]
        [TestCase(10, 4, 2.5)]
        [TestCase(-35, 5, -7)]
        [TestCase(22, 10, 2.2)]

        public void DivideTest(double a, double b, double expected)
        {
            var calculation = new Calculator();
            var actual = calculation.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
