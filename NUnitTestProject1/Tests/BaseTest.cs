using NLog;
using NUnit.Framework;
using System;
using static NUnitTestProject1.Core.WebDriverManager;

namespace NUnitTestProject1.Tests
{

    //[Parallelizable(ParallelScope.Fixtures)]
    public class BaseTest : IDisposable
    {
        protected static Logger Logger => LogManager.GetCurrentClassLogger();

        [SetUp]
        public void TestInitialize()
        {
            
        }

        [TearDown]
        public void Dispose()
        {
            CloseDriver();
        }
    }
}
