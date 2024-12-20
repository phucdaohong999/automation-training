using OpenQA.Selenium;
using seleniumStudy17122024_17122024.Pages;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class InvalidInputValueTest : BaseTest
    {
        private LoginPage loginPage;
        private AddEntitlementsPage addEntitlementPage;
        //
        //public InvalidInputValueTest(IWebDriver driver) : base(driver)
        //{
        //}

        //public InvalidInputValueTest(IWebDriver _driver) : base(_driver)
        //{
        //    //this.driver = _driver;

        //    loginPage = new LoginPage(_driver);
        //    addEntitlementPage = new AddEntitlementsPage(_driver);
        //}

        public InvalidInputValueTest()
        {
            //this.driver = _driver;

            loginPage = new LoginPage(driver);
            addEntitlementPage = new AddEntitlementsPage(driver);
        }

        [TestMethod]
        public void VerifyErrorMessage()
        {
            //loginPage = new LoginPage(driver);
            //addEntitlementPage = new AddEntitlementsPage(driver);

            //Go to login page
            loginPage.GoToLogin();

            //Type username and password
            loginPage.EnterUsernameAndPassword("Admin", "admin123");

            //Push Submit button
            loginPage.ClickSubmitButton();

            //Navigate to Add Entitlements page
            addEntitlementPage.ClickBtnLeave();
            addEntitlementPage.ClickBtnEntitlements();
            addEntitlementPage.ClickBtnAddEntitlements();

            //Enter Employee name
            addEntitlementPage.EnterEmployeeName("bard");

            ////Open Leave Period Dropdown
            //addEntitlementPage.SelectLeavePeriodDropdown();

            //Select Blank Option Of Leave Period Dropdown
            //addEntitlementPage.SelectBlankOptionOfLeavePeriodDropdown();

            //Enter Entitlement
            addEntitlementPage.EnterEntitlementInput("aa");

            //Verify error messages are showing
            string employeeNameError = addEntitlementPage.GetErrorText("Employee Name");
            //string leavePeriodError = addEntitlementPage.GetErrorText("Leave Period");
            string entitlementError = addEntitlementPage.GetErrorText("Entitlement");

            Assert.AreEqual(employeeNameError, "Invalid");
            //Assert.AreEqual(leavePeriodError, "Required");
            Assert.AreEqual(entitlementError, "Should be a number with upto 2 decimal places");
        }
    }
}
