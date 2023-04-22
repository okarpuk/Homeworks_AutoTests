using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class CheckboxesTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            ChromeDriver.FindElement(By.LinkText("Checkboxes")).Click();
        }

        [Test]
        public void Checkbox1()
        {
            List<IWebElement> checkboxes = ChromeDriver.FindElements(By.CssSelector("[type = checkbox]")).ToList();
            Assert.IsNull(checkboxes[0].GetAttribute("checked"));
            checkboxes[0].Click();
            Assert.IsNotNull(checkboxes[0].GetAttribute("checked"));
        }

        [Test]
        public void Checkbox2()
        {
            List<IWebElement> checkboxes = ChromeDriver.FindElements(By.CssSelector("[type = checkbox]")).ToList();
            Assert.IsNotNull(checkboxes[1].GetAttribute("checked"));
            checkboxes[1].Click();
            Assert.IsNull(checkboxes[1].GetAttribute("checked"));
        }
    }
}
