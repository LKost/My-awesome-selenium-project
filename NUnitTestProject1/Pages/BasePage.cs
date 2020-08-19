using NUnitTestProject1.WebDriverManager;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject1.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(WebDriverManager.WebDriverManager.Driver, this);
        }
    }
}
