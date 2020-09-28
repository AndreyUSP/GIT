using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CianTest
{
    [TestFixture]
    public class AuthorizationCianPageTests : BaseTest
    {        
        [Test]
        public void LoginAsUser_StandartBehavior_Logined()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
            .SignIn()
            .Login(UserNameForTests.StartLogin, UserNameForTests.StartLoginPassword)
          //  .GoToPersonalAccount()
            .NavigateToDirectoryOfSpecialists()
            .SearchSortBy(NameSorts.ByAlphabetSort);

            // Thread.sleep(1000); //Use wait expected result
            //  string actualLogin = mainMenu.GetUserLogin();

            // Assert.AreEqual(UserNameForTests.UserLogin, actualLogin, "Login is wrong or Enter wasn't completer");
        }
        
    }
}