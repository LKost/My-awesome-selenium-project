using NUnitTestProject1.Core;
using NUnitTestProject1.Pages;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1.Steps
{
    public class QuadrocoptersSteps : BaseSteps
    {

        QuadrocoptersPage _quadrocoptersPage => PageService.Quadrocopters;

        public IWebDriver Driver { get; private set; }

        public void SortBy(string option)
        {
            _quadrocoptersPage.SortSelect.SelectByText(option);
        }
        public List<string> GetSortSelectOptions()
        {
            return _quadrocoptersPage.SortSelect.Options.Select(x => x.Text).ToList();
        }

        public string GetActiveOption()
        {
            return _quadrocoptersPage.SortSelect.AllSelectedOptions.Select(x => x.Text).FirstOrDefault();
        }

        public void ClickOnBrandFilter()
        {
            _quadrocoptersPage.BrandFilter.Click();
        }

        public void ClickOnCheckboxMi()
        {
            _quadrocoptersPage.CheckBoxMi.Click();
        }

        public List<string> GetMiProductsTitle()
        {
            WaitManager.WaitPageReady();
            return _quadrocoptersPage.MiQuadrocopters.Select(x => x.Text).ToList();
        }

    }
}
