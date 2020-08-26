using NUnitTestProject1.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject1.Utils
{
    public static class ElementExtensions
    {
        public static void ScrollToElement(this IWebElement element)
        {
            ((IJavaScriptExecutor)WebDriverManager.Driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);
        }

        public static void HoverOver(this IWebElement element)
        {
            WebDriverManager.HoverOver(element);
        }

       


    }
}
