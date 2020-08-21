using FluentAssertions;
using NUnitTestProject1.Steps;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class LoginFeatureDefinition
    {
        private static string Url => "https://www.citrus.ua/";

        private readonly BaseSteps _baseSteps;
        private readonly LoginSteps _loginSteps;

        public LoginFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
            _loginSteps = new LoginSteps();
        }

        [Given(@"I'm on login page")]
        public void GivenIMOnLoginPage()
        {
            _baseSteps.NavigateToUrl(Url);
        }

        [When(@"I try to login with wrong credentials")]
        public void WhenITryToLoginWithWrongCredentials()
        {
            _loginSteps.TypeEmail("");
        }


        [Then(@"I can see popup message with warning text '(.*)'")]
        public void ThenICanSeePopupMessageWithWarningText(string expectedText)
        {
            _loginSteps.IsErrorMessageDisplayed().Should().BeTrue();

            // check expectedText
        }
    }
}
