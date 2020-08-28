using NLog;
using NUnit.Framework;
using static NUnitTestProject1.Core.WebDriverManager;

namespace NUnitTestProject1.Tests
{

    [Parallelizable(ParallelScope.Fixtures)]
    public class BaseTest
    {
        protected static Logger Logger => LogManager.GetCurrentClassLogger();

        [SetUp]
        public void TestInitialize()
        {
            //Todo some action 
        }

        [TearDown]
        public void TestFinalize()
        {
            CloseDriver();
        }
    }
}
