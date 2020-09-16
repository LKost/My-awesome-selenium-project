using NUnitTestProject1.Core.AAACore.attribute;
using NUnitTestProject1.Pages;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace NUnitTestProject1.Core.AAACore
{
    public class PageContext
    {
        private Dictionary<object, string> _elements;
        private Dictionary<string, Dictionary<object, string>> _elementsInBlocks;
        public Dictionary<object, string> Elements => _elements ?? (_elements = new Dictionary<object, string>());

        public Dictionary<string, Dictionary<object, string>> ElementsInBlocks =>
            _elementsInBlocks ?? (_elementsInBlocks = new Dictionary<string, Dictionary<object, string>>());

        public BasePage CurrentPage { get; private set; }

        public string PageTitle => ((PageTitleAttribute)CurrentPage.GetType().GetCustomAttribute(typeof(PageTitleAttribute))).Title;

        public BasePage OpenPage(string title)
        {
            foreach (var page in PageManager.AllPages)
            {
                if (!(page.GetCustomAttribute(typeof(PageTitleAttribute)) is PageTitleAttribute attr) ||
                    attr.Title != title) continue;
                var newPage = (BasePage)Activator.CreateInstance(page);
                CurrentPage = newPage;
                return CurrentPage;
            }
            throw new NullReferenceException($"Не найдена страница с названием '{title}'. Убедитесь в наличии атрибута [PageTitle] у классов страниц.");
        }

    }
}
