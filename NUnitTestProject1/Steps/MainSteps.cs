using NUnitTestProject1.Core;
using NUnitTestProject1.Pages;
using NUnitTestProject1.Utils;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1.Steps
{
    public class MainSteps
    {
        public MainPage MainPage => new MainPage();

        public void ScrollToCopyright()
        {
            MainPage.Copyright.ScrollToElement();
        }

        public string GetCopyrightText()
        {
            return MainPage.Copyright.Text;
        }

        public void TypeIntoSearch(string value)
        {
            MainPage.SearchField.SendKeys(value);
            MainPage.SearchField.SendKeys(Keys.Enter);
        }

        public void ClickOnSignIn()
        {
            MainPage.SignIn.Click();
        }

        public string GetSignInText()
        {
            return MainPage.SignIn.Text;
        }

        public int GetCatalogItems()
        { 
            return MainPage.CatalogItems.Where(x => x.Displayed).ToList().Count;
        }

        public List<string> GetCatalogItemsTitles()
        {
            return MainPage.CatalogItems.Where(x => x.Displayed).Select(x => x.Text).ToList();
        }

        public void HoverOnTransportMenuItem()
        {
            WebDriverManager.HoverOver(MainPage.TransportMenuItem);
        }

        public void ClickOnQuadrocopterMenuItem()
        {
            MainPage.QuadrocoptersMenuItem.Click();
        }

        public void ClickOnLogo()
        {
            MainPage.Logo.Click();
        }
    }
}
