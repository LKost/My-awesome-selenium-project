﻿using NUnit.Framework;
using NUnitTestProject1.Const;
using NUnitTestProject1.Core;
using NUnitTestProject1.Steps;
using System.Collections.Generic;
using System.Threading;

namespace NUnitTestProject1.Tests
{
    [TestFixture]
    class TestClass : BaseTest
    {
        private readonly MainSteps _mainSteps;

        public TestClass()
        {
            _mainSteps = new MainSteps();
        }

        [Test]
        public void ScrollTest()
        {
            var expectedCopyright = "2020";
            WebDriverManager.OpenUrl(Urls.Base);
            Logger.Info("Scroll to element Copyright");
            _mainSteps.ScrollToCopyright();
            var copyrightText = _mainSteps.GetCopyrightText();
            Assert.True(copyrightText.Contains(expectedCopyright), "copyrightText [" + copyrightText + "] doesn't contain [" + expectedCopyright + "]");
        }

        [Test]
        public void DimensionTest()
        {
            int width = 600;
            int height = 600;
            var oldDimension = WebDriverManager.GetWindowSize();

            WebDriverManager.OpenUrl(Urls.Base);
            Logger.Info("Wingows Size width: {0}, height: {1}", oldDimension[0], oldDimension[1]);
            Logger.Info("Change Wingows Size width: {0}, height: {1}", width, height);
            WebDriverManager.ChangeWindowSize(600, 600);
            var newDimension = WebDriverManager.GetWindowSize();
            Assert.AreNotEqual(oldDimension, newDimension, "WindowSize doesn't changed");
        }

        [Test]
        public void LoginTest()
        {
            var mainSteps = new MainSteps();
            var loginSteps = new LoginSteps();
            var login = "asdf@gmail.com";
            var pass = "1234567";

            WebDriverManager.OpenUrl(Urls.Base);
            mainSteps.ClickOnSignIn();
            Assert.True(loginSteps.IsLoginFieldDisplayed(), "Login field doesn't displayed");
            loginSteps.TypeEmail(login);
            loginSteps.TypePass(pass);
            loginSteps.clickOnSubmitButton();
            Assert.True(loginSteps.IsErrorMessageDisplayed(), "ErrorMessage doesn't displayed");
        }

        [Test]
        public void MenuItemsTest()
        {
            var mainSteps = new MainSteps();
            int expectedItems = 10;
            List<string> expectedMenuItems = new List<string>()
             {
                  "Смартфоны, аксессуары", "Планшеты, Ноутбуки, Десктопы", "Батареи и аккумуляторы", "Часы, Фитнес-браслеты", "Хороший вкус", "Аудио", "ТВ, камеры, проекторы", "Smart devices", "Транспорт, дроны", "Еще больше"
             };

            WebDriverManager.OpenUrl(Urls.Base);
            Logger.Info("Verify number of categories");
            Assert.AreEqual(mainSteps.GetCatalogItems(), expectedItems, "There are differ number of item");
            Logger.Info("Verify titles");
            Assert.AreEqual(expectedMenuItems, mainSteps.GetCatalogItemsTitles());
        }

        [Test]
        public void HoverAndUrlTest()
        {
            var mainSteps = new MainSteps();
            var expectedUrl = "quadrocopters-and-droids";

            WebDriverManager.OpenUrl(Urls.Base);
            mainSteps.HoverOnTransportMenuItem();
            mainSteps.ClickOnQuadrocopterMenuItem();
            Assert.True(WebDriverManager.GetUrl().Contains(expectedUrl), "Current URL doesn't contain expected text:" + expectedUrl);
            mainSteps.ClickOnLogo();
            Assert.AreEqual(Urls.Base, WebDriverManager.GetUrl());
        }

        [Test]
        public void SortDropdownTest()
        {
            var quadrocopters = new QuadrocoptersSteps();
            List<string> expectedMenuItems = new List<string>()
            {
                "По новизне" ,"Акции" ,"От дешевых к дорогим" ,"От дорогих к дешевым"
            };
            WebDriverManager.OpenUrl(Urls.Quadrocopters);
            Assert.AreEqual(expectedMenuItems, quadrocopters.GetSortSelectOptions());
            quadrocopters.SortBy("От дешевых к дорогим");
            Assert.AreEqual("От дешевых к дорогим", quadrocopters.GetActiveOption());
            quadrocopters.SortBy("Акции");
            Assert.AreEqual("Акции", quadrocopters.GetActiveOption());
        }

        [Test]
        public void CheckboxFilterTest()
        {
            var quadrocopters = new QuadrocoptersSteps();
            List<string> expectedQuadrocopters = new List<string>()
            {
            "Квадрокоптер Xiaomi Mi Drone White 4K", "Квадрокоптер Xiaomi Mi Drone White", "Трикоптер Xiaomi YI Erida"
            };

            WebDriverManager.OpenUrl(Urls.Quadrocopters);
            quadrocopters.ClickOnBrandFilter(); 
            quadrocopters.ClickOnCheckboxMi();
            //Todo
            Thread.Sleep(3000);
            Assert.AreEqual(expectedQuadrocopters, quadrocopters.GetMiProductsTitle());
        }

    }
}