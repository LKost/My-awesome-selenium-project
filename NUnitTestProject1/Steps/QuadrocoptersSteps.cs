using NUnitTestProject1.Pages;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1.Steps
{
    public class QuadrocoptersSteps
    {
        QuadrocoptersPage QuadrocoptersPage => new QuadrocoptersPage();


        public void SortBy(string option)
        {
            QuadrocoptersPage.SortSelect.SelectByText(option);
        }
        public List<string> GetSortSelectOptions()
        {
            return QuadrocoptersPage.SortSelect.Options.Select(x => x.Text).ToList();
        }

        public string GetActiveOption()
        {
            return QuadrocoptersPage.SortSelect.AllSelectedOptions.Select(x => x.Text).FirstOrDefault();
        }

        public void ClickOnBrandFilter()
        {
            QuadrocoptersPage.BrandFilter.Click();
        }

        public void ClickOnCheckboxMi()
        {
            QuadrocoptersPage.CheckBoxMi.Click();
        }

        public List<string> GetMiProductsTitle()
        {
            return QuadrocoptersPage.MiQuadrocopters.Select(x => x.Text).ToList(); ;
        }

    }
}
