using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace seleniumStudy17122024_17122024.Pages
{
    public class AddEntitlementsPage : BasePage
    {
        public AddEntitlementsPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
        // cac element cua page nay
        private IWebElement btnLeave => driver.FindElement(By.XPath("//a[@class='oxd-main-menu-item']//span[text() = 'Leave']"));
        private IWebElement btnEntitlements => driver.FindElement(By.XPath("//li//span[contains(text(),'Entitlements')]"));
        private IWebElement btnAddEntitlements => driver.FindElement(By.XPath("//a[text()='Add Entitlements']"));

        private IWebElement employeeNameInput => driver.FindElement(By.XPath("//label[text()='Employee Name']//parent::div//following-sibling::div//input"));
        //private IWebElement leavePeriodDropdown => driver.FindElement(By.XPath("//label[text()='Leave Period']//parent::div//following-sibling::div"));
        
        //private IWebElement blankOptionOfLeavePeriodDropdown => driver.FindElement(By.XPath("//div[@role ='listbox']//div[text() ='-- Select --']"));

        //private IWebElement blankOptionOfLeavePeriodDropdown => driver.FindElement(By.XPath("//label[text()='Leave Period']//parent::div//following-sibling::div//div[text() = '-- Select --']"));
        private IWebElement entitlementInput => driver.FindElement(By.XPath("//label[text()='Entitlement']/../following-sibling::div//input"));

        private IWebElement error(string name) => driver.FindElement(By.XPath($"//label[text() ='{name}']//..//following-sibling::div//following-sibling::span"));

        // method tuong tac voi element 
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

        //public void SelectLeavePeriodDropdown()
        //{
        //    leavePeriodDropdown.Click();
        //}

        //public void SelectBlankOptionOfLeavePeriodDropdown()
        //{
        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        //    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Leave Period']//parent::div//following-sibling::div//div[text() = '-- Select --']")));
        //    blankOptionOfLeavePeriodDropdown.Click();
        //}


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

