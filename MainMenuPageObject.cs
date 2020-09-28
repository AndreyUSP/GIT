using System;
using OpenQA.Selenium;

namespace CianTest
{
    
    public class MainMenuPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _signInButton = By.CssSelector("#login-btn");
        private readonly By _userLogin = By.XPath("//span[@class='c-header__cabinet-mobile-name']']");
        private readonly By _personalAccountButton = By.CssSelector(".c-header-user-menu .user-avatar");
        private readonly By _direcoryOfSpecialists = By.XPath("//a[@href='/agents/']");
        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public DirectOfSpecialistsPageObject NavigateToDirectoryOfSpecialists()
        {
            WaitUntil.WaitElement(_webDriver, _direcoryOfSpecialists);
            _webDriver.FindElement(_direcoryOfSpecialists).Click();

            return new DirectOfSpecialistsPageObject(_webDriver);
        }
        public AuthorizationPageObject SignIn()
        {
            _webDriver.FindElement(_signInButton).Click();
            return new AuthorizationPageObject(_webDriver);
        }
        public string GetUserLogin()
        {
            string userLogin = _webDriver.FindElement(_userLogin).Text;
            return userLogin;
        }
        public PersonalAccountPageObject GoToPersonalAccount()
        {
            WaitUntil.WaitElement(_webDriver, _personalAccountButton);
            _webDriver.FindElement(_personalAccountButton).Click();

            return new PersonalAccountPageObject(_webDriver);
        }

    }
}