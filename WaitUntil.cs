using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CianTest
{
    public static class WaitUntil
    {
        public static void ShouldLocate(IWebDriver webDriver, string location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(location));
            }
            catch(WebDriverException ex)
            {
                throw new NotFoundException($"Cant find out that app in specific location: {location}", ex);
            }
        }
        public static void WaitSomeInterval(int seconds = 10)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }
        public static void WaitElement(IWebDriver webDriver, By locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}