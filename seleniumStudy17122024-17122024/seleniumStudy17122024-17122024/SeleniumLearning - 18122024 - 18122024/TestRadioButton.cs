using OpenQA.Selenium;
using seleniumStudy17122024_17122024.Pages;
using seleniumStudy17122024_17122024.Test;

namespace seleniumStudy17122024_17122024.SeleniumLearning1812202418122024
{
    [TestClass]
	public class TestRadioButton : BaseTest
	{
        private LoginPage loginPage;

        public override void SetUpPageObjects()
        {
            loginPage = new LoginPage(driver);
        }

		[TestMethod]
        [Obsolete]
        public void TestClickRadioButton()
		{
			//Go to page
			string url = "https://rahulshettyacademy.com/loginpagePractise/"
            loginPage.GoToLogin(url);

			//Get list of radio button
			IList<IWebElement> radioButtonList = loginPage.GetRadioButtonList();

			//Loop in list of radio button, if value = user, click this button
			foreach (IWebElement radioButton in radioButtonList)
			{
				string radioButtonValue = loginPage.GetRadioButton();

                if (radioButtonValue.Equals("user"))
				{
					radioButton.Click();
				}
			}
		}
	}
}

