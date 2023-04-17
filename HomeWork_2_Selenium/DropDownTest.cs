using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;

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
        public void Checkboxes()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(1000);
            ChromeDriver.FindElement(By.LinkText("Dropdown")).Click();
            Thread.Sleep(1000);




            IWebElement dropDown = ChromeDriver.FindElement(By.Id("dropdown"));
            SelectElement select = new SelectElement(dropDown);
            select.SelectByText("Option 1");
            Assert.IsNotNull(select);


            //var dropDown = ChromeDriver.FindElement(By.Id("dropdown"));
            //dropDown.Click();
            //Thread.Sleep(1000);

            //List<IWebElement> dropDownElements = ChromeDriver.FindElements(By.CssSelector("[type = value]")).ToList();

            //dropDownElements[0].Click();
            //Assert.IsNotNull(dropDownElements[0].GetAttribute("selected"));
            //Thread.Sleep(1000);

            //Assert.IsNotNull(checkboxes[1].GetAttribute("checked"));
            //checkboxes[1].Click();
            //Thread.Sleep(1000);
            //Assert.IsNull(checkboxes[1].GetAttribute("checked"));
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    ChromeDriver.Quit();
        //    Console.WriteLine("CHECKBOXES TEST COMPLETED");
        //}
    }
}
