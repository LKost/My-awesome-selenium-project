using FluentAssertions;
using NUnitTestProject1.Const;
using NUnitTestProject1.Context;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class ScrollFeatureDefinition
    {
        private BaseSteps _baseSteps;
        private MainSteps _mainSteps;

        public ScrollFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
            _mainSteps = new MainSteps();
        }

        [Given(@"I'm on main page")]
        public void GivenIMOnMainPage()
        {
            _baseSteps.NavigateToUrl(Urls.Base);
        }

        [When(@"I scroll to footer section")]
        public void WhenIScrollToFooterSection()
        {
            _mainSteps.ScrollToCopyright();
        }

        [Then(@"The footer text display correct '(.*)' text")]
        public void ThenTheFooterTextDiplayCorrectText(int expectedCopyright)
        {
            _mainSteps.GetCopyrightText().Should().Contain(expectedCopyright.ToString());
        }
    }
}
