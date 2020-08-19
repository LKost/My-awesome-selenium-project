using NUnitTestProject1.WebDriverManager;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void Setup()
        {
        }

        [AfterScenario]
        public void Test1()
        {
            WebDriverManager.CloseDriver();
        }
    }
}