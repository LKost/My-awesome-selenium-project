using FluentAssertions;
using NUnitTestProject1.Const;
using NUnitTestProject1.Steps;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class LoginFeatureDefinition
    {

        private readonly BaseSteps _baseSteps;
        private readonly MainSteps _mainSteps;
        private readonly LoginSteps _loginSteps;

        public LoginFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
            _mainSteps = new MainSteps();
            _loginSteps = new LoginSteps();
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
            _loginSteps.IsLoginFieldDisplayed().Should().BeTrue();
            _loginSteps.TypeEmail(login);
            _loginSteps.TypePass(pass);
            _loginSteps.clickOnSubmitButton();

        }

        [Then(@"I can see popup message with warning text '(.*)'")]
        public void ThenICanSeePopupMessageWithWarningText(string expectedText)
        {
            _loginSteps.IsErrorMessageDisplayed().Should().BeTrue();
            _loginSteps.GetLoginErrorMessage().Should().Be(expectedText);
        }
    }
}
