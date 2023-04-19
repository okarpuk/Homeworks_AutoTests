using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeWork_2_Selenium
{
    [TestFixture]
    internal class TyposTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
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
    }
}
