using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using static NUnitTestProject1.Core.WebDriverManager;

namespace NUnitTestProject1.Core
{
    public class WaitManager 
    {
        public static void SetImplicitWait(IWebDriver driver, int seconds) => driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);

        public static bool IsDisplayedByXpathWithFluent(string xpath)
        {
            return IsDisplayedByXpathWithFluent(xpath, 8, 100);
        }

        public static bool IsDisplayedByXpathWithFluent(string xpath, int seconds, int poolingMs)
        {
            var fluentWait = new DefaultWait<IWebDriver>(Driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds), 
                PollingInterval = TimeSpan.FromMilliseconds(poolingMs),
                Message = "Element to be searched not found"
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(x => x.FindElement(By.XPath(xpath)).Displayed);
        }

        public static void WaitPageReady()
        {
            Thread.Sleep(1000);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            var result = wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
