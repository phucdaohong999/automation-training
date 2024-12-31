using FluentAssert;
using seleniumStudy17122024_17122024.Pages;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class NegativePasswordTest : BaseTest
    {
        private LoginPage loginPage;

        public override void SetUpPageObjects()
        {
            loginPage = new LoginPage(driver);
        }

        // Test case 3: Test login with wrong password
        [TestMethod]
        public void Verify_Negative_Password()
        {
            // Step 1: Open page
            string url = "https://practicetestautomation.com/practice-test-login/";
            loginPage.GoToLogin(url);

            // Step 2: Enter correct username and incorrect password
            string username = "student";
            string password = "Password" + new Random().Next(1000, 9999 + 1);
            loginPage.EnterUsernameAndPassword(username, password);

            // Step 3: Push Submit button
            loginPage.ClickSubmitButton();

            // Step 4: Verify error message is displayed
            bool isErrorMessageDisplay = loginPage.VerifyErrorMessageExist();
            isErrorMessageDisplay.ShouldBeTrue();

            // Step 5: Verify error message text is Your password is invalid!
            bool isCorrectErrorMessage = loginPage.VerifyCorrectErrorMessage("Your password is invalid!");
            isCorrectErrorMessage.ShouldBeTrue();
        }
    }
}

