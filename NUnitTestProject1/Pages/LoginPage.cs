
using NUnitTestProject1.Core.Elemens;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject1.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='auth-login']/form/input[@name='email']")]
        public Element AuthEmail { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='auth-login']/form/input[@name='password']")]
        public Element AuthPass { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='auth-login']/form/*[@class='btn' and @type='submit']")]
        public Element SubmitButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "swal-title")]
        public Element LoginError { get; private set; }
    }
}
