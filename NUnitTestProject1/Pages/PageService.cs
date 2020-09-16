using NUnitTestProject1.Core;
using NUnitTestProject1.Core.AAACore;
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
            var test = new AFieldDecorator();
            PageFactory.InitElements(driver, page, test);
            //PageFactory.InitElements(driver, page);
            return page;
        }
    }
}
