using NUnitTestProject1.Core.Elemens;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace NUnitTestProject1.Pages
{
    public class MainPage
    {
        [FindsBy(How = How.ClassName, Using = "main-logo")]
        public Element Logo { get; private set; }

        [FindsBy(How = How.Name, Using = "q")]
        public Element SearchField { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='header-enter popup-open']")]
        public Element SignIn { get; private set; }

        [FindsBy(How = How.ClassName, Using = "copyright")]
        public Element Copyright { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='catalog-block']/span")]
        public IList<Element> CatalogItems { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='catalog-block']/span[text()='Транспорт, дроны']")]
        public Element TransportMenuItem { get; private set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Квадрокоптеры и дроиды']/preceding-sibling::div/img[@class='lazyload bound']")]
        public Element QuadrocoptersMenuItem { get; private set; }
        
    }
}
