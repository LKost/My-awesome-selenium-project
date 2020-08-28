using NUnit.Framework;
using NUnitTestProject1.Steps;

namespace NUnitTestProject1.Tests
{
    [TestFixture]
    class TestClass2 : BaseTest
    {
        private readonly MainSteps _mainSteps;
        private readonly LoginSteps _loginSteps;
        private readonly QuadrocoptersSteps _quadrocoptersSteps;

        public TestClass2()
        {
            _mainSteps = new MainSteps();
            _loginSteps = new LoginSteps();
            _quadrocoptersSteps = new QuadrocoptersSteps();
        }
    }
}