using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_nUnit
{
    [TestFixture]
    public class Add
    {
        [TestCase(7, 8, 15)]
        [TestCase(2.8, 8.7, 11.5)]
        [TestCase(-100, -5, -105)]
        [TestCase(-20, 80, 60)]

        public void AddTest(double a, double b, double expected)
        {
            // Arrange
            var calculation = new Calculator();

            // Act
            var actual = calculation.Add(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
