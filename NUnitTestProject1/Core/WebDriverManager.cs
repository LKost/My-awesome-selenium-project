using NUnitTestProject1.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace NUnitTestProject1.WebDriverManager
{
    public class WebDriverManager
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver => _driver ??= SetWebDriver();

        private static IWebDriver SetWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            var driver = new ChromeDriver(options);
            WaitManager.SetImplicitWait(driver, 20);
            return driver;
        }

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);
        }

        public static void HoverOver(IWebElement element)
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(element)
                .Build()
                .Perform();
            //action.MoveByOffset(500, 500).ContextClick().Perform();
        }

        public static void ChangeWindowSize(int width, int height)
        {
            Driver.Manage().Window.Size = new Size(width, height);
        }

        public static int[] GetWindowSize()
        {
            int[] dimention = new int[2];
            dimention[0] = Driver.Manage().Window.Size.Width;
            dimention[1] = Driver.Manage().Window.Size.Height;
            return dimention;
        }

        public void MoveAndClick(IWebElement element)
        {
            new Actions(Driver)
                .MoveToElement(element)
                .Click()
                .Build()
                .Perform();
        }

        public static void OpenUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static string GetUrl()
        {
            return Driver.Url;
        }

        public static void CloseDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
    }
}
