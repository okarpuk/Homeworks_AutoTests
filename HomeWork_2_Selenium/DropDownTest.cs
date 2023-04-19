using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;
using System.Xml;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class DropDownTest
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            ChromeDriver.FindElement(By.LinkText("Dropdown")).Click();
            Thread.Sleep(1000);
        }

        [Test]
        public void CheckElements()
        {
            ChromeDriver.FindElement(By.Id("dropdown")).Click();
            Thread.Sleep(1000);
            Assert.IsNotNull(ChromeDriver.FindElement(By.XPath($"//option[2]")));
            Assert.IsNotNull(ChromeDriver.FindElement(By.XPath($"//option[3]")));
        }

        [Test]
        public void SelectOption1()
        {
            SelectElement option1 = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            option1.SelectByText("Option 1");
            Thread.Sleep(1000);
            Assert.IsTrue(ChromeDriver.FindElement(By.XPath($"//option[2]")).Selected);
        }

        [Test]
        public void SelectOption2()
        {
            SelectElement option2 = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            option2.SelectByText("Option 2");
            Thread.Sleep(1000);
            Assert.IsTrue(ChromeDriver.FindElement(By.XPath($"//option[3]")).Selected);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("DROPDOWN TEST COMPLETED");
        }
    }
}
