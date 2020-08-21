using OpenQA.Selenium.Support.UI;
using System;
using static NUnitTestProject1.Core.WebDriverManager;

namespace NUnitTestProject1.Steps
{
    public class BaseSteps
    {
        protected WebDriverWait Wait;

        public BaseSteps()
        {
            Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 20));
        }

        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}

