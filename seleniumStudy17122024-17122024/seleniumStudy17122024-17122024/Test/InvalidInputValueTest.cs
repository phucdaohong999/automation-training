using Automation.Core.Helpers;
using Newtonsoft.Json;
using OpenQA.Selenium.BiDi.Modules.Log;
using seleniumStudy17122024_17122024.Pages;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class InvalidInputValueTest : BaseTest
    {
        private LoginPage loginPage;
        private AddEntitlementsPage addEntitlementPage;

        public override void SetUpPageObjects()
        {
            loginPage = new LoginPage(driver);
            addEntitlementPage = new AddEntitlementsPage(driver);
        }

        [TestMethod]
        public void VerifyErrorMessage()
        {
            //Go to login page
            string url = ConfigurationHelper.GetValue<string>("url");
            loginPage.GoToLogin(url);

            //Type username and password
            string username = ConfigurationHelper.GetValue<string>("username");
            string password = ConfigurationHelper.GetValue<string>("password");
            loginPage.EnterUsernameAndPassword(username, password);

            //Push Submit button
            loginPage.ClickLoginButton();


            //Navigate to Add Entitlements page
            addEntitlementPage.ClickBtnLeave();
            addEntitlementPage.ClickBtnEntitlements();
            addEntitlementPage.ClickBtnAddEntitlements();


            //Enter Employee name
            addEntitlementPage.EnterEmployeeName("bard");

            //Open Leave type Dropdown
            string leaveTypeLabel = "Leave Type";
            addEntitlementPage.SelectDropdown(leaveTypeLabel);

            //Select CAS Option Of Leave type Dropdown
            string dropdownOption = "US - Matternity";
            addEntitlementPage.SelectNonBlankOptionOfDropdown(dropdownOption, leaveTypeLabel);

            //Open Leave type Dropdown
            addEntitlementPage.SelectDropdown(leaveTypeLabel);
            //Select Blank Option Of Leave type Dropdown
            addEntitlementPage.SelectBlankOptionOfDropdown(leaveTypeLabel);


            //Open Leave Period Dropdown
            string leavePeriodLabel = "Leave Period";
            addEntitlementPage.SelectDropdown(leavePeriodLabel);

            //Select Blank Option Of Leave Period Dropdown
            addEntitlementPage.SelectBlankOptionOfDropdown(leavePeriodLabel);


            //Enter Entitlement
            addEntitlementPage.EnterEntitlement("aa");

            //Verify error messages are showing
            string employeeNameLabel = "Employee Name";
            string entitlementLabel = "Entitlement";
            string invalidErrorMessage = "Invalid";
            string requiredErrorMessage = "Required";
            string entitlementErrorMessage = "Should be a number with upto 2 decimal places";


            string employeeNameError = addEntitlementPage.GetErrorText(employeeNameLabel);
            string leaveTypeError = addEntitlementPage.GetErrorText(leaveTypeLabel);
            string leavePeriodError = addEntitlementPage.GetErrorText(leavePeriodLabel);
            string entitlementError = addEntitlementPage.GetErrorText(entitlementLabel);

            Assert.AreEqual(employeeNameError, invalidErrorMessage);
            Assert.AreEqual(leaveTypeError, requiredErrorMessage);
            Assert.AreEqual(leavePeriodError, requiredErrorMessage);
            Assert.AreEqual(entitlementError, entitlementErrorMessage);
        }
    }
}
