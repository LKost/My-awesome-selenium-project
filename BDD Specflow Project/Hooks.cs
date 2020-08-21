using NUnitTestProject1.Core;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void Setup()
        {
            //just for example
            //WebDriverManager.Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterMethod()
        {
            WebDriverManager.CloseDriver();
        }
    }
}