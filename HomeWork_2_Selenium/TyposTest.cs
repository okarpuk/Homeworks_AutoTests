using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    public class TyposTest
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            ChromeDriver.FindElement(By.LinkText("Typos")).Click();
            Thread.Sleep(1000);
        }

        [Test]
        public void Typos()
        {
            var textToCheck = ChromeDriver.FindElement(By.XPath($"//p[2]")).Text;
            var verificationText = "Sometimes you'll see a typo, other times you won't.";
            Assert.That(textToCheck, Is.EqualTo(verificationText));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("TYPOS TEST COMPLETED");
        }
    }
}
