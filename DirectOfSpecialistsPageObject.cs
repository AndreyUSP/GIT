using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace CianTest
{
    public class DirectOfSpecialistsPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _sortByListButton = By.CssSelector(".catalog__sorting .s-button_arrow");
        private readonly By _allTheSorts = By.CssSelector(".s-popup__menu__item--sort.catalog__select__item");
    public DirectOfSpecialistsPageObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;

    }
        public DirectOfSpecialistsPageObject SearchSortBy(string nameSort)
        {
            WaitUntil.WaitElement(_webDriver, _sortByListButton);
            _webDriver.FindElement(_sortByListButton).Click();
            var sortBy = _webDriver.FindElements(_allTheSorts).First(x=> x.Text == nameSort);
            sortBy.Click();
            return this;
        }
    }
}