using NUnitTestProject1.Core;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject1.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(WebDriverManager.Driver, this);
        }
    }
}
