using NUnitTestProject1.Core;
using NUnitTestProject1.Pages;
using NUnitTestProject1.Utils;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1.Steps
{
    public class MainSteps : BaseSteps
    {
        public MainPage _mainPage => PageService.Main;

        public void ScrollToCopyright()
        {
            _mainPage.Copyright.ScrollToElement();
        }

        public string GetCopyrightText()
        {
            return _mainPage.Copyright.Text;
        }

        public void TypeIntoSearch(string value)
        {
            _mainPage.SearchField.SendKeys(value);
            _mainPage.SearchField.SendKeys(Keys.Enter);
        }

        public void ClickOnSignIn()
        {
            _mainPage.SignIn.Click();
        }

        public string GetSignInText()
        {
            return _mainPage.SignIn.Text;
        }

        public int GetCatalogItems() 
        {
            return _mainPage.CatalogItems.Count(x => x.Displayed);
        }

        public List<string> GetCatalogItemsTitles()
        {
            return _mainPage.CatalogItems.Where(x => x.Displayed).Select(x => x.Text).ToList();
        }

        public void HoverOnTransportMenuAndClickItem()
        {
            _mainPage.TransportMenuItem.HoverOver();
            Wait.Until(driver => _mainPage.QuadrocoptersMenuItem.Displayed);
        }

        public void ClickOnQuadrocopterMenuItem()
        {
            _mainPage.QuadrocoptersMenuItem.ActionClick();
            WaitManager.WaitPageReady();
        }

        public void ClickOnLogo()
        {
            _mainPage.Logo.Click();
        }
    }
}
