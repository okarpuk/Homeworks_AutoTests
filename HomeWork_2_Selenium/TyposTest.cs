using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class TyposTest
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
        public void Typos()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Typos")).Click();
            Thread.Sleep(1000);

            var textToCheck = ChromeDriver.FindElement(By.TagName("p")).Text;

            var requestedText = "Sometimes you'll see a typo, other times you won't.";
            Assert.That(textToCheck, Is.EqualTo(requestedText));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("TYPOS TEST COMPLETED");
        }
    }
}
