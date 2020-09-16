using NUnitTestProject1.Core.AAACore;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace NUnitTestProject1.Pages
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "main-logo")]
        public IWebElement Logo { get; private set; }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchField { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='header-enter popup-open']")]
        public IWebElement SignIn { get; private set; }

        [FindsBy(How = How.ClassName, Using = "copyright")]
        public AButton Copyright { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='catalog-block']/span")]
        public IList<IWebElement> CatalogItems { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='catalog-block']/span[text()='Транспорт, дроны']")]
        public IWebElement TransportMenuItem { get; private set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Квадрокоптеры и дроиды']/preceding-sibling::div/img[@class='lazyload bound']")]
        public IWebElement QuadrocoptersMenuItem { get; private set; }
        
    }
}
