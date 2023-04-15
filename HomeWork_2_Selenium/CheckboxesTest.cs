using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class CheckboxesTest
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
        public void Checkboxes()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            var addRemoveElement = ChromeDriver.FindElement(By.LinkText("Checkboxes"));
            addRemoveElement.Click();
            Thread.Sleep(1000);

            List<IWebElement> checkboxes = ChromeDriver.FindElements(By.CssSelector("[type = checkbox]")).ToList();

            Assert.IsNull(checkboxes[0].GetAttribute("checked"));
            checkboxes[0].Click();
            Thread.Sleep(1000);
            Assert.IsNotNull(checkboxes[0].GetAttribute("checked"));

            Assert.IsNotNull(checkboxes[1].GetAttribute("checked"));
            checkboxes[1].Click();
            Thread.Sleep(1000);
            Assert.IsNull(checkboxes[1].GetAttribute("checked"));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
            Console.WriteLine("CHECKBOXES TEST COMPLETED");
        }
    }
}
