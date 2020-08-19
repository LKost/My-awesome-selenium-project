using NUnitTestProject1.Pages;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1.Context
{
    public class QuadrocoptersSteps
    {
        QuadrocoptersPage quadrocoptersPage;
        public QuadrocoptersSteps()
        {
            quadrocoptersPage = new QuadrocoptersPage();
        }

        public void SortBy(string option)
        {
            quadrocoptersPage.SortSelect.SelectByText(option);
        }
        public List<string> GetSortSelectOptions()
        {
            return quadrocoptersPage.SortSelect.Options.Select(x => x.Text).ToList();
        }

        public string GetActiveOption()
        {
            return quadrocoptersPage.SortSelect.AllSelectedOptions.Select(x => x.Text).FirstOrDefault();
        }

        public void ClickOnBrandFilter()
        {
            quadrocoptersPage.BrandFilter.Click();
        }

        public void ClickOnCheckboxMi()
        {
            quadrocoptersPage.CheckBoxMi.Click();
        }

        public List<string> getMiProductsTitle()
        {
            return quadrocoptersPage.MiQuadrocopters.Select(x => x.Text).ToList(); ;
        }

    }
}
