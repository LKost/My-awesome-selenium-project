using FluentAssertions;
using NUnitTestProject1.Context;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class LoginFeatureDefinition
    {

        //public LoginFeatureDefinition()
        //{

        //}

        private static string URL => "https://www.citrus.ua/";

        private BaseSteps _baseSteps;
        private LoginStesps _loginStesps;

        public LoginFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
            _loginStesps = new LoginStesps();
        }

        [Given(@"I'm on login page")]
        public void GivenIMOnLoginPage()
        {
            _baseSteps.NavigateToUrl(URL);
        }

        [When(@"I try to login with wrong credentials")]
        public void WhenITryToLoginWithWrongCredentials()
        {
            _loginStesps.TypeEmail("");
        }


        [Then(@"I can see popup message with warning text '(.*)'")]
        public void ThenICanSeePopupMessageWithWarningText(string expectedText)
        {
            _loginStesps.IsErrorMessageDisplayed().Should().BeTrue();

            // check expectedText
        }



    }
}
