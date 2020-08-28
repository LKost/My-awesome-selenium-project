using NUnitTestProject1.Core;
using NUnitTestProject1.Pages;

namespace NUnitTestProject1.Steps
{
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps()
        {
            _loginPage = new LoginPage();
        }

        public bool IsLoginFieldDisplayed()
        {
            WaitManager.WaitPageReady();
            return _loginPage.AuthEmail.Displayed;
        }

        public void TypeEmail(string email)
        {
            _loginPage.AuthEmail.SendKeys(email);
        }

        public void TypePass(string pass)
        {
            _loginPage.AuthPass.SendKeys(pass);
        }

        public void clickOnSubmitButton()
        {
            _loginPage.SubmitButton.Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return WaitManager.IsDisplayedByXpathWithFluent("//*[@class='swal-title']");
        }

        public string GetLoginErrorMessage()
        {
            return _loginPage.LoginError.Text;
        }
    }
}
