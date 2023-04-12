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
        [TestCase(6, 2, 3)]
        [TestCase(133, 1, 133)]
        [TestCase(35, 5, 7)]
        [TestCase(220, 2, 110)]

        public void DivideTest(double a, double b, double expected)
        {
            var calculation = new Calculator();
            double actual = calculation.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }





    }

}
