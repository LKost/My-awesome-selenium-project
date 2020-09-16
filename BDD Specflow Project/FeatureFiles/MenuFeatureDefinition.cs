using FluentAssertions;
using NUnitTestProject1.Const;
using NUnitTestProject1.Steps;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace BDD_Specflow_Project
{
    [Binding]
    class MenuFeatureDefinition
    {

        private readonly BaseSteps _baseSteps;
        private readonly MainSteps _mainSteps;
        private int _numOfMenuItems;
        private List<string> _menuItemsTexts;

        public MenuFeatureDefinition()
        {
            _baseSteps = new BaseSteps();
            _mainSteps = new MainSteps();
        }

        [Given(@"We are on Main page")]
        public void GivenWeAreOnMainPage()
        {
            _baseSteps.NavigateToUrl(Urls.Base);
        }

        [When(@"we count number menu items")]
        public void WhenWeCountNumberMenuItems()
        {
            _numOfMenuItems = _mainSteps.GetCatalogItems();
        }

        [Then(@"we should get '(.*)' items")]
        public void ThenWeShouldGetItems(int expectedNumOfItem)
        {
            _numOfMenuItems.Should().Be(expectedNumOfItem);
        }

        [When(@"we get menu items text from each item")]
        public void WhenWeGetMenuItemsTextFromEachItem()
        {
            _menuItemsTexts = _mainSteps.GetCatalogItemsTitles();
        }

        [Then(@"Items text should be equals with expected")]
        public void ThenItemsTextShouldBeEqualsWithExpected()
        {
            var expectedMenuItems = new List<string>()
             {
                  "Смартфоны, аксессуары", "Планшеты, Ноутбуки, Десктопы", "Батареи и аккумуляторы", "Часы, Фитнес-браслеты", "Хороший вкус", "Аудио", "ТВ, камеры, проекторы", "Smart devices", "Транспорт, дроны", "Еще больше"
             };
            _menuItemsTexts.Should().Equal(expectedMenuItems);

        }
    }
}
