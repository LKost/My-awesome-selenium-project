using FluentAssertions;
using NUnit.Framework;
using System;

namespace NUnitTestProject1.Tests
{
    [TestFixture]
    class TestClass2
    {
     

        [Test]
        public void SimpleTestForSettings()
        {
            int number = 2;

            Console.WriteLine("Square of " + number);
            (number * number).Should().Be(4, "simple mathematics logic is broken");

        }

    }
}