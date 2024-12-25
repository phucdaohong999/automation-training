using Automation.WebDriver;
using OpenQA.Selenium;

namespace seleniumStudy17122024_17122024.Pages
{
    public class LoginSuccessPage : BasePage
    {
        public LoginSuccessPage(IWebDriver _driver) : base(_driver)
        {
        }

        //Elements
        private IWebElement loggedTitlePage => driver.FindElementByXpath("//h1[@class = 'post-title']");
        private IWebElement btnLogOut => driver.FindElementByXpath("//a[text() = 'Log out']");

        //Method interact
        public bool VerifyLoggedInMessage(string loggedInMessage)
        {
            return loggedTitlePage.Text == loggedInMessage;
        }

        public bool VerifyLogOutButtonExist()
        {
            return btnLogOut.Displayed;
        }
    }
}

