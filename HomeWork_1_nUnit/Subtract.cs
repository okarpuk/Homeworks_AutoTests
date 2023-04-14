﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_nUnit
{
    [TestFixture]
    public class Subtract
    {
        int random1;
        int random2;
        Calculator calculation;

        [OneTimeSetUp]
        public void SubtractSetup()
        {
            calculation = new Calculator();
            random1 = new Random().Next(-10, -5);
            random2 = new Random().Next(12, 34);
        }

        [Test]
        [Description("SubtractRandom")]
        [Category("Random")]
        [Retry(3)]
        public void SubtractRandom()
        {
            //Action
            var actual = calculation.Subtract(random1, random2);
            var expected = random1 - random2;
            Console.WriteLine($"First number: {random1};\nSecond number: {random2};\nActual subtract result: {actual};\nExpected subtract result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Subtract values")]
        [Category("Values")]
        [Retry(3)]
        public void SubtractValues([Values(2, 16, 111)] int values1, [Values(-5, -11, -132)] int values2)
        {
            //Action
            var actual = calculation.Subtract(values1, values2);
            var expected = values1 - values2;
            Console.WriteLine($"First number: {values1};\nSecond number: {values2};\nActual subtract result: {actual};\nExpected subtract result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Subtract range")]
        [Category("Range")]
        [Retry(3)]
        public void SubtractRange([Values(6, 12, 100)] int range1, [Range(1, 3, 5)] int range2)
        {
            //Action
            var actual = calculation.Subtract(range1, range2);
            var expected = range1 - range2;
            Console.WriteLine($"First number: {range1};\nSecond number: {range2};\nActual subtract result: {actual};\nExpected subtract result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Subtract test cases")]
        [Category("TestCases")]
        [Retry(3)]
        [TestCase(7, 8)]
        [TestCase(-100, -5)]
        public void SubtractTestCases(int testCase1, int testCase2)
        {
            //Action
            var actual = calculation.Subtract(testCase1, testCase2);
            var expected = testCase1 - testCase2;
            Console.WriteLine($"First number: {testCase1};\nSecond number: {testCase2};\nActual subtract result: {actual};\nExpected subtract result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Add test completed successfully");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("All add tests completed successfully");
        }
    }
}
