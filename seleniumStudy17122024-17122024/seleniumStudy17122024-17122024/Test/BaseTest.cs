using Automation.Core.Helpers;
using Automation.WebDriver;
using OpenQA.Selenium;
[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver driver;

        public virtual void SetUpPageObjects()
        {
            //Empty
        }

        [TestInitialize]
        public void SetupAndOpenBrowser()
        {
            //Init driver for google chrome
            string browserType = ConfigurationHelper.GetValue<string>("browser");
            int timeout = ConfigurationHelper.GetValue<int>("timeout");
            driver = DriverFactory.InitDriver(browserType, timeout);

            //Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            driver.Manage().Window.Maximize();

            SetUpPageObjects();
        }

        [TestCleanup]
        public void BrowserCleanup()
        {
            driver.Quit();
        }
    }
}

