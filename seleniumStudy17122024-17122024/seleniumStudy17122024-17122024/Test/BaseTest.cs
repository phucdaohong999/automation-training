using System.Threading;
using Automation.Core.Helpers;
using Automation.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

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

            Console.Write("have driver");

            //Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ConfigurationHelper.GetValue<double>("timeout"));
            driver.Manage().Window.Maximize();

            SetUpPageObjects();
        }

        [TestCleanup]
        public void BrowserCleanup()
        {
            driver.Quit();
        }
    }

    //[TestClass]
    //public class BaseTest
    //{
    //    protected static IWebDriver driver;

    //    public virtual void SetUpPageObjects()
    //    {
    //        //Empty
    //    }

    //    [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
    //    public static void SetupAndOpenBrowser(TestContext testContext)
    //    {
    //        //Init driver for google chrome
    //        driver = new ChromeDriver();

    //        Console.Write("have driver");

    //        //Set implicit wait
    //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    //        driver.Manage().Window.Maximize();

    //        SetUpPageObjects();
    //    }

    //    [ClassCleanup(InheritanceBehavior.BeforeEachDerivedClass)]
    //    public static void BrowserCleanup()
    //    {
    //        driver.Quit();
    //    }
    //}
}

