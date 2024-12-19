using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver driver;
        [TestInitialize]
        public void SetupAndOpenDriver()
        {
            //Init driver for google chrome
            driver = new ChromeDriver();

            //Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        [TestCleanup]
        public void BrowserCleanup()
        {
            driver.Quit();
        }
    }
}

