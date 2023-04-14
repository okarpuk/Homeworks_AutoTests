﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace HomeWork_1_nUnit
{
    [TestFixture]
    public class Add
    {
        Calculator calculation;

        [OneTimeSetUp]
        public void AddSetup()
        {
            calculation = new Calculator();
        }

        [Test]
        [Description("Add values")]
        [Category("Values")]
        [Retry(3)]
        public void AddValues([Values(2, 16, 111)] int values1, [Values(-5, -11, -132)] int values2)
        {
            //Action
            var actual = calculation.Add(values1, values2);
            var expected = values1 + values2;
            Console.WriteLine($"First number: {values1};\nSecond number: {values2};\nActual add result: {actual};\nExpected add result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Add range")]
        [Category("Range")]
        [Retry(3)]
        public void AddRange([Values(6, 12, 100)] int range1, [Range(11, 13, 1)] int range2)
        {
            //Action
            var actual = calculation.Add(range1, range2);
            var expected = range1 + range2;
            Console.WriteLine($"First number: {range1};\nSecond number: {range2};\nActual add result: {actual};\nExpected add result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Add random")]
        [Category("Random")]
        [Retry(3)]
        public void AddRandom([Values(6, 12, 3)] int random1, [Random(1, 20, 3)] int random2)
        {
            //Action
            var actual = calculation.Add(random1, random2);
            var expected = random1 + random2;
            Console.WriteLine($"First number: {random1};\nSecond number: {random2};\nActual add result: {actual};\nExpected add result: {expected};");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Description("Add test cases")]
        [Category("TestCases")]
        [Retry(3)]
        [TestCase(7, 8)]
        [TestCase(-100, -5)]
        public void AddTestCases(int testCase1, int testCase2)
        {
            //Action
            var actual = calculation.Add(testCase1, testCase2);
            var expected = testCase1 + testCase2;
            Console.WriteLine($"First number: {testCase1};\nSecond number: {testCase2};\nActual add result: {actual};\nExpected add result: {expected};");
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