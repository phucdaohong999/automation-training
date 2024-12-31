using FluentAssert;
using seleniumStudy17122024_17122024.Pages;

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

        [TestMethod("Test description goes in here")]
        public void Verify_Positive_LoginTest()
        {
            // Test case 1: Log In test with correct username and password

            // Step 1: Open page
            string url = "https://practicetestautomation.com/practice-test-login/";
            loginPage.GoToLogin(url);

            // Step 2: Enter username and password
            string username = "student";
            string password = "Password123";
            loginPage.EnterUsernameAndPassword(username, password);

            // Step 3: Push Submit button
            loginPage.ClickSubmitButton();

            // Step 4: Verify new page URL contains practicetestautomation.com / logged -in-successfully /
            driver.Url.ShouldContain("practicetestautomation.com/logged-in-successfully/");

            // Step 5: Verify new page contains expected text('Congratulations' or 'successfully logged in')
            bool loginSuccessMessage = loginSuccessPage.VerifyLoggedInMessage("Logged In Successfully");
            loginSuccessMessage.ShouldBeTrue();

            // Step 6: Verify button Log out is displayed on the new page
            bool isLogoutButtonDisplay = loginSuccessPage.VerifyLogOutButtonExist();
            isLogoutButtonDisplay.ShouldBeTrue();
        }
    }
}

