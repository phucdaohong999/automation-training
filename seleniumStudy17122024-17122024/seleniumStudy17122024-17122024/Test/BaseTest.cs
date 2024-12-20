using System;
using FluentAssert;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using seleniumStudy17122024_17122024.Pages;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class BaseTest
    {
        protected static IWebDriver driver;

        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void SetupAndOpenBrowser(TestContext testContext)
        {
            //Init driver for google chrome
            driver = new ChromeDriver();

            //Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
        }

        [ClassCleanup]
        public static void BrowserCleanup()
        {
            driver.Quit();
        }
    }
}

