using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using static NUnitTestProject1.Core.WebDriverManager;

namespace NUnitTestProject1.Utils
{
    public static class ElementExtensions
    {
        public static void ScrollToElement(this IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);
        }

        public static void HoverOver(this IWebElement element)
        {
            var action = new Actions(Driver);
            action
                .MoveToElement(element)
                .Build()
                .Perform();
        }
    }
}
