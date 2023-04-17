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
        }

        [Test]
        public void DropDown()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Dropdown")).Click();
            Thread.Sleep(1000);

            SelectElement dropDown1 = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            dropDown1.SelectByText("Option 1");
            Thread.Sleep(1000);
            var isFind1 = ChromeDriver.FindElement(By.XPath("//*[@id=\"dropdown\"]/option[2]"));
            var isSelected1 = isFind1.Selected;
            Assert.IsTrue(isSelected1);

            ChromeDriver.Navigate().Refresh();
            Thread.Sleep(1000);

            SelectElement dropDown2 = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            dropDown2.SelectByText("Option 2");
            Thread.Sleep(1000);
            var isFind2 = ChromeDriver.FindElement(By.XPath("//*[@id=\"dropdown\"]/option[3]"));
            var isSelected2 = isFind2.Selected;
            Assert.IsTrue(isSelected2);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("DROPDOWN TEST COMPLETED");
        }
    }
}
