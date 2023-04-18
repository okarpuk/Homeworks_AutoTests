using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NuGet.Frameworks;
using OpenQA.Selenium.Support.UI;
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


            var check = ChromeDriver.FindElement(By.TagName("p"));
           
            
            
            //inputDigit.SendKeys(Keys.ArrowUp);
            //Thread.Sleep(1000);




            //inputDigit.Clear();
            //Thread.Sleep(1000);
            //inputDigit.SendKeys(Keys.ArrowDown);


            //inputDigit.Clear();

            //inputDigit.SendKeys("abc");
            //Thread.Sleep(1000);







        }
        //[TearDown]
        //public void TearDown()
        //{
        //    ChromeDriver.Quit();
        //    Console.WriteLine("INPUTS TEST COMPLETED");
        //}
    }
}
