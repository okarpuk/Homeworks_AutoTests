using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class AddRemoveElementsTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
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
    }
}