using OpenQA.Selenium;

namespace CianTest
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _loginInButton = By.XPath("//input[@name='username']");
        private readonly By _continueButton = By.XPath("//span[@class='authentication_widget-content-1b5pRyDjx']");
        private readonly By _passwordInputButton = By.XPath("//input[@name='password']");
        private readonly By _enterButton = By.XPath("//button[@data-mark='ContinueAuthBtn']");

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_loginInButton).SendKeys(login);
            _webDriver.FindElement(_continueButton).Click();
            WaitUntil.WaitElement(_webDriver, _passwordInputButton);

            _webDriver.FindElement(_passwordInputButton).SendKeys(password);
            _webDriver.FindElement(_enterButton).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}