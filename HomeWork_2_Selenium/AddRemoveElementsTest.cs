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
        }

        [Test]
        public void AddRemoveElement()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000); //добавил для удобства просмотра действий автотеста
            var addRemoveElement = ChromeDriver.FindElement(By.LinkText("Add/Remove Elements"));
            addRemoveElement.Click();
            Thread.Sleep(1000);

            var addElement = ChromeDriver.FindElement(By.XPath("//button[text()='Add Element']"));
            addElement.Click();
            Thread.Sleep(1000);
            addElement.Click();
            Thread.Sleep(1000);

            var deleteElement = ChromeDriver.FindElement(By.XPath("//button[text()='Delete']"));
            deleteElement.Click();
            Thread.Sleep(1000);

            List<IWebElement> elements = ChromeDriver.FindElements(By.XPath("//button[text()='Delete']")).ToList();
            int count = elements.Count;
            Assert.AreEqual(1, count);
            Console.WriteLine($"ELEMENTS COUNT IS - {count} ");
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("ADD / REMOVE ELEMENTS TEST COMPLETED");
        }
    }
}