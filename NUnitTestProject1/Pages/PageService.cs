using NUnitTestProject1.Core;
using NUnitTestProject1.Core.Elemens;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject1.Pages
{
    public class PageService
    {

        public static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = WebDriverManager.Driver;
            PageFactory.InitElements(driver, page, new CustomPageObjectDecorator(driver));
            //PageFactory.InitElements(driver, page);
            return page;
        }
    }
}
