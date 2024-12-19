using System;
using OpenQA.Selenium;

namespace seleniumStudy17122024_17122024.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }
    }
}

