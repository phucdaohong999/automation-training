using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace seleniumStudy17122024_17122024.SeleniumLearning1812202418122024
{
    [TestClass]

    public class FunctionalTest
    {

        IWebDriver driver;

        [TestInitialize]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
            //string url = "https://demoqa.com/droppable";
            string url = "https://rahulshettyacademy.com/AutomationPractice/";

            //driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            //driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";
            driver.Url = url;
        }

        [TestMethod]
        [Timeout(2)]
        public void TestFail()
        {
            Thread.Sleep(3_000);
        }

        //[TestMethod]
        //[Obsolete]
        //public void VerifyAutoComplete()
        //{
        //    driver.FindElement(By.XPath("//input[@id='autocomplete']")).SendKeys("ind");

        //    IList autoCompleteList = driver.FindElements(By.XPath("//li[@class='ui-menu-item']"));
        //    Thread.Sleep(1000);

        //    IList autoString = new ArrayList();

        //    foreach (IWebElement element in autoCompleteList)
        //    {
        //        autoString.Add(element.FindElement(By.XPath("//div")).Text);
        //    }

        //    Console.Write("debugger");

        //    foreach (IWebElement option in autoCompleteList)
        //    {
        //        string input = option.FindElement(By.XPath("//div")).Text;

        //        if (input.Equals("India"))
        //        {
        //            option.Click();
        //        }
        //    }

        //    string result = driver.FindElement(By.XPath("//input[@id='autocomplete']")).GetAttribute("Value");
        //    Console.WriteLine(result);
        //}

        //[TestMethod]

        //public void Frame()
        //{
        //    IWebElement frameScroll = driver.FindElement(By.XPath("//iframe[@id = 'courses-iframe']"));
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    js.ExecuteScript("arguments[0].scrollIntoView(true);", frameScroll);

        //    driver.SwitchTo().Frame("courses-iframe");
        //    driver.FindElement(By.XPath("//a[text()='All Access plan']")).Click();

        //    driver.SwitchTo().DefaultContent();
        //}

        //[TestMethod]
        //public void UseAction()
        //{
        //    Actions a = new Actions(driver);
        //    a.MoveToElement(driver.FindElement(By.CssSelector("a.dropdown-toggle"))).Perform();
        //    //driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li[1]/a")).Click();
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='dropdown-menu']/li[1]/a")));
        //    a.MoveToElement(driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li[1]/a"))).Click().Perform();

        //    a.DragAndDrop(driver.FindElement(By.XPath("//div[@id='draggable']")), driver.FindElement(By.XPath("//div[@id='droppable']"))).Perform();
        //}



        //[TestMethod]
        //public void testAlert()
        //{
        //    string name = "a-name";
        //    driver.FindElement(By.CssSelector("input[id = 'name']")).SendKeys(name);
        //    driver.FindElement(By.CssSelector("input[id='alertbtn']")).Click();

        //    driver.SwitchTo().Alert();
        //    string alertMessage = driver.SwitchTo().Alert().Text;

        //    StringAssert.Contains(alertMessage, name);
        //}

        //[TestMethod]
        //public void SortTable()
        //{
        //    IWebElement dropdown = driver.FindElement(By.CssSelector("select[id='page-menu']"));
        //    dropdown.Click();
        //    SelectElement s = new SelectElement(dropdown);
        //    s.SelectByValue("20");

        //    ArrayList a = new ArrayList();
        //    ArrayList b = new ArrayList();
        //    // step 1 - get all veggie names into arrayList A
        //    IList<IWebElement> veggies = driver.FindElements(By.XPath("//tr/td[1]"));

        //    foreach (IWebElement veggie in veggies)
        //    {
        //        a.Add(veggie.Text);
        //    }


        //    foreach (string veggie in a)
        //    {
        //        Console.WriteLine(veggie);
        //    }

        //    // step 2 - sort this arrayList A
        //    a.Sort();

        //    // step 3 - go and click column
        //    driver.FindElement(By.XPath("//tr//th//span[text() = 'Veg/fruit name']")).Click();

        //    // step 4 - get all veggie names into arrayList B
        //    IList<IWebElement> sortedVeggies = driver.FindElements(By.XPath("//tr/td[1]"));

        //    foreach (IWebElement veggie in sortedVeggies)
        //    {
        //        b.Add(veggie.Text);
        //    }

        //    //Console.WriteLine("to check");

        //    // arrayList A to B = equal
        //    CollectionAssert.AreEqual(a, b);
        //}

        //[TestMethod]
        //public void ProductList()
        //{
        //    var expectedProducts = new string[] { "iphone X", "Blackberry" };

        //    //string[] expectedProducts = { "iphone X", "Blackberry" };
        //    driver.FindElement(By.CssSelector("input[id='username']")).SendKeys("rahulshettyacademy");
        //    driver.FindElement(By.CssSelector("input[id='password']")).SendKeys("learning");
        //    driver.FindElement(By.CssSelector("input[id='signInBtn']")).Click();

        //    IList<IWebElement> products = driver.FindElements(By.TagName("app-card"));

        //    foreach (IWebElement product in products)
        //    {
        //        string productName = product.FindElement(By.CssSelector(".card-title a")).Text;

        //        if (!products.Any())
        //        {
        //            Console.WriteLine("No products found.");
        //            return;
        //        }

        //        if (expectedProducts.Contains(productName))
        //        {
        //            product.FindElement(By.CssSelector(".card-footer button")).Click();
        //        }

        //        Console.WriteLine(productName);
        //    }

        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));

        //    driver.FindElement(By.PartialLinkText("Checkout")).Click();
        //}

        ////[TestMethod]
        ////[Obsolete]
        ////public void RadioButton()
        ////{
        ////    IList<IWebElement> rdos = driver.FindElements(By.CssSelector("input[type='radio']"));

        ////    foreach (IWebElement radioButton in rdos)
        ////    {
        ////        if (radioButton.GetAttribute("value").Equals("user"))
        ////        {
        ////            radioButton.Click();
        ////        }
        ////    }

        ////    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        ////    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("okayBtn")));

        ////    driver.FindElement(By.Id("okayBtn")).Click();
        ////    Boolean result = driver.FindElement(By.CssSelector("input[value='user']")).Selected;
        ////    Assert.That(result, Is.True);
        ////}

        //[TestMethod]
        //public void dropdown()
        //{
        //    IWebElement dropdown = driver.FindElement(By.CssSelector("select.form-control"));

        //    SelectElement s = new SelectElement(dropdown);

        //    s.SelectByIndex(2);
        //    s.SelectByText("Student");
        //    s.SelectByValue("teach");
        //}

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}

