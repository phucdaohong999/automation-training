using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace seleniumStudy17122024_17122024.Pages
{
    public class AddEntitlementsPage : BasePage
    {
        public AddEntitlementsPage(IWebDriver _driver) : base(_driver)
        {
        }

        // Page elements
        private IWebElement btnLeave => driver.FindElement(By.XPath("//a[@class='oxd-main-menu-item']//span[text() = 'Leave']"));
        private IWebElement btnEntitlements => driver.FindElement(By.XPath("//li//span[contains(text(),'Entitlements')]"));
        private IWebElement btnAddEntitlements => driver.FindElement(By.XPath("//a[text()='Add Entitlements']"));
        private IWebElement employeeNameInput => driver.FindElement(By.XPath("//label[text()='Employee Name']//parent::div//following-sibling::div//input"));

        private IWebElement dropdown(string dropDownLabel) => driver.FindElement(By.XPath($"//label[text()='{dropDownLabel}']//..//following-sibling::div"));
        private IWebElement nonBlankOptionOfLeaveTypeDropdown(string option, string dropDownLabel) => driver.FindElement(By.XPath($"//label[text()='{dropDownLabel}']//..//following-sibling::div//span[text()='{option}']"));
        private IWebElement blankOptionDropdown(string dropDownLabel) => driver.FindElement(By.XPath($"//label[text()='{dropDownLabel}']//..//following-sibling::div//div[text() = '-- Select --']"));

        private IWebElement entitlementInput => driver.FindElement(By.XPath("//label[text()='Entitlement']/../following-sibling::div//input"));
        private IWebElement error(string name) => driver.FindElement(By.XPath($"//label[text() ='{name}']//..//following-sibling::div//following-sibling::span"));


        // Methods interacting with page elements
        public void ClickBtnLeave()
        {
            btnLeave.Click();
        }

        public void ClickBtnEntitlements()
        {
            btnEntitlements.Click();
        }

        public void ClickBtnAddEntitlements()
        {
            btnAddEntitlements.Click();
        }

        public void EnterEmployeeName(string name)
        {
            employeeNameInput.SendKeys(name);
        }

        public void SelectDropdown(string dropDownLabel)
        {
            Thread.Sleep(1000);
            dropdown(dropDownLabel).Click();
        }

        public void SelectBlankOptionOfDropdown(string dropDownLabel)
        {
            blankOptionDropdown(dropDownLabel).Click();
        }

        public void SelectNonBlankOptionOfDropdown(string option, string dropDownLabel)
        {
            nonBlankOptionOfLeaveTypeDropdown(option,dropDownLabel).Click();
        }

        public void EnterEntitlementInput(string entitlement)
        {
            entitlementInput.SendKeys(entitlement);
        }

        public string GetErrorText(string name)
        {
            return error(name).Text;
        }

    }
}

