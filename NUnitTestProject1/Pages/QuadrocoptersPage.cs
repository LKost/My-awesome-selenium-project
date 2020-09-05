using NUnitTestProject1.Core;
using NUnitTestProject1.Core.Elemens;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace NUnitTestProject1.Pages
{
    public class QuadrocoptersPage
    {
        public SelectElement SortSelect => new SelectElement(WebDriverManager.Driver.FindElement(By.XPath("//*[@class='sort-select icon']")));

        [FindsBy(How = How.XPath, Using = "//*[@class='filter-block' and @data-f-group='producers']")]
        public Element BrandFilter { get; private set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='label' and text()='Mi']/preceding-sibling::span[@class='checkbox-custom']")]
        public Element CheckBoxMi { get; private set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'product-buy')]/preceding-sibling::a[@class='product-title']/span")]
        public IList<Element> MiQuadrocopters { get; private set; }
    }
}
