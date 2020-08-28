using NUnitTestProject1.Core;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject1.Pages
{
    public class PageService
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = WebDriverManager.Driver;
            PageFactory.InitElements(driver, page);
            return page;
        }

        public static MainPage Main
        {
            get { return GetPage<MainPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }


        public static QuadrocoptersPage Quadrocopters
        {
            get { return GetPage<QuadrocoptersPage>(); }
        }


    }
}
