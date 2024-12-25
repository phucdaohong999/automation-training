using seleniumStudy17122024_17122024.Pages;
using FluentAssert;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class LoginTest : BaseTest
    {
        private LoginPage loginPage;
        private LoginSuccessPage loginSuccessPage;

        public override void SetUpPageObjects()
        {
            loginPage = new LoginPage(driver);
            loginSuccessPage = new LoginSuccessPage(driver);
        }

        [TestMethod]
        public void Verify_Positive_LoginTest()
        {
            // Test case 1: Positive LogIn test

            //Open page
            string url = "https://practicetestautomation.com/practice-test-login/";
            loginPage.GoToLogin(url);

            //Enter username and password
            string username = "student";
            string password = "Password123";
            loginPage.EnterUsernameAndPassword(username, password);

            //Push Submit button
            loginPage.ClickSubmitButton();

            //Verify new page URL contains practicetestautomation.com / logged -in-successfully /
            driver.Url.ShouldContain("practicetestautomation.com/logged-in-successfully/");

            //Verify new page contains expected text('Congratulations' or 'successfully logged in')
            bool loginSuccessMessage = loginSuccessPage.VerifyLoggedInMessage("Logged In Successfully");
            loginSuccessMessage.ShouldBeTrue();

            //Verify button Log out is displayed on the new page
            bool isLogoutButtonDisplay = loginSuccessPage.VerifyLogOutButtonExist();
            isLogoutButtonDisplay.ShouldBeTrue();
        }
    }
}

