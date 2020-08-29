using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Threading;

namespace NUnitTestProject1.Core
{
    public class WebDriverManager
    {
        private static ThreadLocal<IWebDriver> pool = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver => pool.Value ??= CreateAndGetDriver();

        private static IWebDriver CreateAndGetDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--no-sandbox");
            chromeOptions.AddArguments("--disable-dev-shm-usage");
            chromeOptions.AddArguments("--headless");
            ChromeDriver driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Size = new Size(1936, 1056);
            return driver;
        }

        public static void ChangeWindowSize(int width, int height)
        {
            Driver.Manage().Window.Size = new Size(width, height);
        }

        public static (int, int) GetWindowSize()
        {
            return (Driver.Manage().Window.Size.Width, Driver.Manage().Window.Size.Height);
        }

        public static string GetUrl()
        {
            return Driver.Url;
        }

        public static void CloseDriver()
        {
            if (pool.Value != null)
            {
               pool.Value.Quit();
               pool.Value.Dispose();
               pool.Value = null;
            }
        }
    }
}
