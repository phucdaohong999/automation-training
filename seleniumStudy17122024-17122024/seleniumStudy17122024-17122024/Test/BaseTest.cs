using System.Reflection;
using Automation.Core.Helpers;
using Automation.WebDriver;
using Newtonsoft.Json;
using OpenQA.Selenium;
[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected ReportHelper reportHelper;
        public TestContext TestContext { get; set; }

        public virtual void SetUpPageObjects()
        {
            //Empty
        }

        [TestInitialize]
        public void SetupAndOpenBrowser()
        {
            // Init driver for google chrome
            string browserType = ConfigurationHelper.GetValue<string>("browser");
            int timeout = ConfigurationHelper.GetValue<int>("timeout");
            driver = DriverFactory.InitDriver(browserType, timeout);

            // Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            driver.Manage().Window.Maximize();

            SetUpPageObjects();

            // Init report helper
            reportHelper = new ReportHelper();

            var testMethod = TestContext?.TestName;
            var method = this.GetType().GetMethods().FirstOrDefault(m => m.GetCustomAttributes(typeof(TestMethodAttribute), false).Any() && m.Name == testMethod); ;

            var testMethodAttribute = method.GetCustomAttributes(typeof(TestMethodAttribute), false).Cast<TestMethodAttribute>().FirstOrDefault();
            string description = testMethodAttribute?.DisplayName ?? method.Name;

            reportHelper.InitReport();
            reportHelper.CreateTestCase(TestContext.TestName, description);
        }

        [TestCleanup]
        public void BrowserCleanup()
        {
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                string imgBase64 = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                reportHelper.LogMessage("Fail", "Test case failed", imgBase64);
            }
            else
            {
                reportHelper.LogMessage("Pass", "Test case passed");
            }

            driver.Quit();
            reportHelper.ExportReport();
        }
    }
}

