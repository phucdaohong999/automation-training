﻿using System;
using Automation.Core.Helpers;
using OpenQA.Selenium;

namespace Automation.WebDriver
{
    public static class BrowserExtension
    {
        public static void Go(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElementByXpath(this IWebDriver driver,string xpath)
        {
            return driver.FindElement(By.XPath(xpath));
        }
    }
}

