using NUnitTestProject1.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject1.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage() : base() { }
        [FindsBy(How = How.XPath, Using = "//*[@id='auth-login']/form/input[@name='email']")]
        public IWebElement AuthEmail { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='auth-login']/form/input[@name='password']")]
        public IWebElement AuthPass { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='auth-login']/form/*[@class='btn' and @type='submit']")]
        public IWebElement SubmitButton { get; private set; }


        [FindsBy(How = How.ClassName, Using = "swal-title")]
        public IWebElement LoginError { get; private set; }
    }
}
