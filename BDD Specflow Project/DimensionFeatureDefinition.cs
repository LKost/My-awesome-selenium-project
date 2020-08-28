using FluentAssertions;
using NUnitTestProject1.Const;
using NUnitTestProject1.Core;
using NUnitTestProject1.Steps;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class DimensionFeatureDefinition
    {

        private readonly BaseSteps _baseSteps;
        private (int, int) oldDimension;

        public DimensionFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
        }

        [Given(@"open browser window")]
        public void GivenOpenBrowserWindow()
        {
            _baseSteps.NavigateToUrl(Urls.Base);
        }

        [Given(@"get dimension size of full screen")]
        public void GivenGetDimensionSizeOfFullScreen()
        {
            oldDimension = WebDriverManager.GetWindowSize();
        }

        [When(@"I change dimention resolutun to custom")]
        public void WhenIChangeDimentionResolutunToCustom()
        {
            WebDriverManager.ChangeWindowSize(600, 600);
        }

        [Then(@"resolution should be differe from initial")]
        public void ThenResolutionShouldBeDiffereFromInitial()
        {
            var newDimension = WebDriverManager.GetWindowSize();
            oldDimension.Should().NotBeSameAs(newDimension);
        }
    }
}
