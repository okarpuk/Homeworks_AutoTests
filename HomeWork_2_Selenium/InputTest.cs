using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;
using System.Xml;

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
        public void Inputs()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
            Thread.Sleep(1000);









        }
    }
}
