using FluentAssertions;
using NUnitTestProject1.Const;
using NUnitTestProject1.Context;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class LoginFeatureDefinition
    {

        private BaseSteps _baseSteps;
        private MainSteps _mainSteps;
        private LoginStesps _loginStesps;

        public LoginFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
            _mainSteps = new MainSteps();
            _loginStesps = new LoginStesps();
        }

        [Given(@"I'm on Main page")]
        public void GivenIMOnLoginPage()
        {
            _baseSteps.NavigateToUrl(Urls.Base);
        }

        [When(@"I try to login with wrong credentials")]
        public void WhenITryToLoginWithWrongCredentials()
        {
            var login = "asdf@gmail.com";
            var pass = "1234567";

            _mainSteps.ClickOnSignIn();
            _loginStesps.IsLoginFieldDisplayed().Should().BeTrue();
            _loginStesps.TypeEmail(login);
            _loginStesps.TypePass(pass);
            _loginStesps.clickOnSubmitButton();
        }


        [Then(@"I can see popup message with warning text '(.*)'")]
        public void ThenICanSeePopupMessageWithWarningText(string expectedText)
        {
            _loginStesps.IsErrorMessageDisplayed().Should().BeTrue();
            _loginStesps.GetLoginErrorMessage().Should().Be(expectedText);
        }
    }
}
