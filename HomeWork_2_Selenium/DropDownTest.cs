using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class DropDownTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            ChromeDriver.FindElement(By.LinkText("Dropdown")).Click();
        }

        [Test]
        public void CheckElements()
        {
            ChromeDriver.FindElement(By.Id("dropdown")).Click();
            Assert.IsNotNull(ChromeDriver.FindElement(By.XPath($"//option[2]")));
            Assert.IsNotNull(ChromeDriver.FindElement(By.XPath($"//option[3]")));
        }

        [Test]
        public void SelectOption1()
        {
            SelectElement option1 = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            option1.SelectByText("Option 1");
            Assert.IsTrue(ChromeDriver.FindElement(By.XPath($"//option[2]")).Selected);
        }

        [Test]
        public void SelectOption2()
        {
            SelectElement option2 = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));
            option2.SelectByText("Option 2");
            Assert.IsTrue(ChromeDriver.FindElement(By.XPath($"//option[3]")).Selected);
        }
    }
}
