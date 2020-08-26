using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace NUnitTestProject1.Core
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

        public static void HoverOver(IWebElement element)
        {
            var action = new Actions(Driver);
            action
                .MoveToElement(element)
                .Build()
                .Perform();
        }

        public static void ChangeWindowSize(int width, int height)
        {
            Driver.Manage().Window.Size = new Size(width, height);
        }

        public static int[] GetWindowSize()
        {
            var dimension = new int[2];
            dimension[0] = Driver.Manage().Window.Size.Width;
            dimension[1] = Driver.Manage().Window.Size.Height;
            return dimension;
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
