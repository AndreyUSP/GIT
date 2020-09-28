using OpenQA.Selenium;

namespace CianTest
{
    public class PersonalAccountPageObject
    {
        private IWebDriver _webDriver;

        public PersonalAccountPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}