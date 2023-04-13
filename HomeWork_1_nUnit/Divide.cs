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
        [TestCase(-10, 5, -2)]

        public void DivideTest(int a, int b, int expected)
        {
            var calculation = new Calculator();
            var actual = calculation.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
