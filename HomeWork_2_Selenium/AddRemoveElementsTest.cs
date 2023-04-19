using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class AddRemoveElementsTest
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            ChromeDriver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Thread.Sleep(1000); //добавил для удобства просмотра действий автотеста
        }

        [Test]
        public void AddRemoveElement()
        {
            ChromeDriver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            ChromeDriver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.XPath("//button[text()='Delete']")).Click();
            Thread.Sleep(1000);
            List<IWebElement> elements = ChromeDriver.FindElements(By.XPath("//button[text()='Delete']")).ToList();
            Assert.AreEqual(1, elements.Count);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("ADD / REMOVE ELEMENTS TEST COMPLETED");
        }
    }
}