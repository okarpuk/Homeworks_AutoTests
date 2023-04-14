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
        Calculator calculation;

        [OneTimeSetUp]
        public void DivideSetup()
        {
            calculation = new Calculator();
        }

        [Test]
        [Description("Divide values")]
        [Category("Values")]
        [Retry(3)]
        public void DivideValues(
            [Values(2, 16, 111)] int values1,
            [Values(-5, -11)] int values2)
        {
            //Action
            var actual = calculation.Divide(values1, values2);
            var expected = values1 / values2;
            Console.WriteLine($"First number: {values1};\nSecond number: {values2};\nActual divide result: {actual};\nExpected divide result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Divide range")]
        [Category("Range")]
        [Retry(3)]
        public void DivideRange(
            [Values(6, 12)] int range1,
            [Range(11, 13, 1)] int range2)
        {
            //Action
            var actual = calculation.Divide(range1, range2);
            var expected = range1 / range2;
            Console.WriteLine($"First number: {range1};\nSecond number: {range2};\nActual divide result: {actual};\nExpected divide result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Divide random")]
        [Category("Random")]
        [Retry(3)]
        public void DivideRandom(
            [Values(6, 12, 3)] int random1,
            [Random(1, 20, 2)] int random2)
        {
            //Action
            var actual = calculation.Divide(random1, random2);
            var expected = random1 / random2;
            Console.WriteLine($"First number: {random1};\nSecond number: {random2};\nActual add result: {actual};\nExpected add result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Divide test cases")]
        [Category("TestCases")]
        [Retry(3)]
        [TestCase(9, 3)]
        [TestCase(-100, -5)]
        public void DivideTestCases(int testCase1, int testCase2)
        {
            //Action
            var actual = calculation.Divide(testCase1, testCase2);
            var expected = testCase1 / testCase2;
            Console.WriteLine($"First number: {testCase1};\nSecond number: {testCase2};\nActual divide result: {actual};\nExpected divide result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Divide test completed successfully");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("All divide tests completed successfully");
        }
    }
}
