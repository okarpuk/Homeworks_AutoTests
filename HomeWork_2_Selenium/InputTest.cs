﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;
using System.Xml;
using System.Xml.Linq;
using System;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class InputTest
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [Test]
        public void ArrowUpInput()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
            Thread.Sleep(1000);

            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);
            Thread.Sleep(1000);

            Assert.That("3", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void ArrowDownInput()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
            Thread.Sleep(1000);

            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowDown);
            input.SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);

            Assert.That("-2", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void ArrowUpDownInput()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
            Thread.Sleep(1000);

            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);

            Assert.That("0", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void KeyboardInput()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
            Thread.Sleep(1000);

            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys("12345");
            Thread.Sleep(1000);

            Assert.That("12345", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void TextInput()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
            Thread.Sleep(1000);

            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys("abc");
            Thread.Sleep(1000);

            Assert.IsEmpty(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value"));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("INPUTS TEST COMPLETED");
        }
    }
}
