using OpenQA.Selenium;
using seleniumStudy17122024_17122024.Pages;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class InvalidInputValueTest : BaseTest
    {
        private LoginPage loginPage;
        private AddEntitlementsPage addEntitlementPage;

        public InvalidInputValueTest()
        {
            loginPage = new LoginPage(driver);
            addEntitlementPage = new AddEntitlementsPage(driver);
        }

        [TestMethod]
        public void VerifyErrorMessage()
        {
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


            ////Open Leave type Dropdown
            addEntitlementPage.SelectDropdown("Leave Type");

            //Select CAS Option Of Leave type Dropdown
            addEntitlementPage.SelectNonBlankOptionOfDropdown("CAS", "Leave Type");

            ////Open Leave type Dropdown
            addEntitlementPage.SelectDropdown("Leave Type");
            //Select Blank Option Of Leave type Dropdown
            addEntitlementPage.SelectBlankOptionOfDropdown("Leave Type");



            ////Open Leave Period Dropdown
            addEntitlementPage.SelectDropdown("Leave Period");

            //Select Blank Option Of Leave Period Dropdown
            addEntitlementPage.SelectBlankOptionOfDropdown("Leave Period");


            //Enter Entitlement
            addEntitlementPage.EnterEntitlement("aa");

            //Verify error messages are showing
            string employeeNameError = addEntitlementPage.GetErrorText("Employee Name");
            string leaveTypeError = addEntitlementPage.GetErrorText("Leave Type");
            string leavePeriodError = addEntitlementPage.GetErrorText("Leave Period");
            string entitlementError = addEntitlementPage.GetErrorText("Entitlement");

            Assert.AreEqual(employeeNameError, "Invalid");
            Assert.AreEqual(leaveTypeError, "Required");
            Assert.AreEqual(leavePeriodError, "Required");
            Assert.AreEqual(entitlementError, "Should be a number with upto 2 decimal places");
        }
    }
}
