﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CianTest
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        [OneTimeSetUp]

        protected void DoBeforeAllTheTests()
        {
            _webDriver = new ChromeDriver();

        }
        /*[OneTimeTearDown]

        protected void DoAfterAllTheTests()
        {

        }*/

        [TearDown]
        protected void DoAfterEach()
        {
            _webDriver.Quit();
        }
        [SetUp]
        protected void DoBeforeEach()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestSettings.LocationCian);
            _webDriver.Manage().Window.Maximize();
            WaitUntil.ShouldLocate(_webDriver, TestSettings.LocationCian);
        }
    }

}
