using FluentAssert;
using seleniumStudy17122024_17122024.Pages;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class NegativeUsernameTest : BaseTest
    {
        private LoginPage loginPage;

        public override void SetUpPageObjects()
        {
            loginPage = new LoginPage(driver);
        }

        // Test case 2: Negative username test
        [TestMethod]
        public void Verify_Negative_Username()
        {
            // Step 1: Open page
            string url = "https://practicetestautomation.com/practice-test-login/";
            loginPage.GoToLogin(url);

            // Step 2: Type username incorrectUser into Username field with correct password
            string username = "incorrectUser";
            string password = "Password123";
            loginPage.EnterUsernameAndPassword(username, password);

            // Step 3: Push Submit button
            loginPage.ClickSubmitButton();

            // Step 4: Verify error message is displayed
            bool isErrorMessageDisplay = loginPage.VerifyErrorMessageExist();
            isErrorMessageDisplay.ShouldBeTrue();

            // Step 5: Verify error message text is Your username is invalid!
            bool isCorrectErrorMessage = loginPage.VerifyCorrectErrorMessage("Your username is invalid!");
            isCorrectErrorMessage.ShouldBeTrue();
        }
    }
}

