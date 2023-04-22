using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class InputTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            ChromeDriver.FindElement(By.LinkText("Inputs")).Click();
        }

        [Test]
        public void ArrowUpInput()
        {
            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowUp + Keys.ArrowUp + Keys.ArrowUp);
            Assert.That("3", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void ArrowDownInput()
        {
            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowDown + Keys.ArrowDown);
            Assert.That("-2", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void ArrowUpDownInput()
        {
            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowUp + Keys.ArrowDown);
            Assert.That("0", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void KeyboardInput()
        {
            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys("12345");
            Assert.That("12345", Is.EqualTo(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value")));
        }

        [Test]
        public void TextInput()
        {
            var input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys("abc");
            Assert.IsEmpty(ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value"));
        }
    }
}
