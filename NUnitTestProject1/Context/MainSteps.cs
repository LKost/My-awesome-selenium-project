using NUnitTestProject1.Pages;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1.Context

{
    public class MainSteps
    {
        public MainPage mainPage;
        public MainSteps()
        {
            mainPage = new MainPage();
        }
        public void ScrollToCopyright()
        {
            WebDriverManager.WebDriverManager.ScrollToElement(mainPage.Copyright);
        }
        public string GetCopyrightText()
        {
            return mainPage.Copyright.Text;
        }
        public void TypeIntoSearch(string value)
        {
            IWebElement searchField = mainPage.SearchField;
            searchField.SendKeys(value);
            searchField.SendKeys(Keys.Enter);
        }
        public void ClickOnSignIn()
        {
            mainPage.SignIn.Click();
        }

        public string GetSignInText()
        {
            return mainPage.SignIn.Text;
        }

        public int GetCatalogItems()
        { 
            return mainPage.CatalogItems.Where(x => x.Displayed).ToList().Count;
        }

        public List<string> GetCatalogItemsTitles()
        {
            return mainPage.CatalogItems.Where(x => x.Displayed).Select(x => x.Text).ToList();
        }

        public void HoverOnTransportMenuItem()
        {
            WebDriverManager.WebDriverManager.HoverOver(mainPage.TransportMenuItem);
        }

        public void ClickOnQuadrocopterMenuItem()
        {
            mainPage.QuadrocoptersMenuItem.Click();
        }

        public void ClickOnLogo()
        {
            mainPage.Logo.Click();
        }
    }
}
