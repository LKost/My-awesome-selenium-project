using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1.Utils
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
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(WebDriverManager.WebDriverManager.Driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(seconds);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(poolingMs);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            return fluentWait.Until(x => x.FindElement(By.XPath(xpath)).Displayed);
        }

        [Obsolete]
        public static IWebElement getExplisitElementBy(string xPath, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverManager.WebDriverManager.Driver, TimeSpan.FromSeconds(seconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
        }

        private void explicitWait(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverManager.WebDriverManager.Driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }
    }
}
