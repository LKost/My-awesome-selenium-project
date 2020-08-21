using NUnitTestProject1.Pages;
using NUnitTestProject1.Utils;

namespace NUnitTestProject1.Context
{
    public class LoginStesps
    {
        private LoginPage loginPage;

        public LoginStesps()
        {
            loginPage = new LoginPage();
        }

        public bool IsLoginFieldDisplayed()
        {
            return loginPage.AuthEmail.Displayed;
        }

        public void TypeEmail(string email)
        {
            loginPage.AuthEmail.SendKeys(email);
        }

        public void TypePass(string pass)
        {
            loginPage.AuthPass.SendKeys(pass);
        }

        public void clickOnSubmitButton()
        {
            loginPage.SubmitButton.Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return WaitManager.IsDisplayedByXpathWithFluent("//*[@class='swal-title']");
        }

        public string GetLoginErrorMessage()
        {
            return loginPage.LoginError.Text;
        }
    }
}
