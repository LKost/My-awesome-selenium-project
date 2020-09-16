using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace NUnitTestProject1.Core.Elemens
{
    public class Element : IElement
    {
        private IWebElement _webElement;

        public Element(IWebElement element)
        {
            _webElement = element;
        }

        public IWebElement WebElement => _webElement;

        public string TagName => _webElement.TagName;

        public string Text => _webElement.Text;

        public bool Enabled => _webElement.Enabled;

        public bool Selected => _webElement.Selected;

        public Point Location => _webElement.Location;

        public Size Size => _webElement.Size;

        public bool Displayed => _webElement.Displayed;

        public IWebElement WrappedElement => _webElement;

        public Point LocationOnScreen => throw new NotImplementedException();

        public Point LocationInViewport => throw new NotImplementedException();

        public Point LocationInDom => throw new NotImplementedException();

        public object AuxiliaryLocator => throw new NotImplementedException();

        public void Clear()
        {
            _webElement.Clear();
        }

        public void Click()
        {
            _webElement.Click();
        }

        public IWebElement FindElement(By by)
        {
            return _webElement.FindElement(by);
        }

        public IList<IWebElement> FindElements(By by)
        {
            return _webElement.FindElements(by);
        }

        public string GetAttribute(string attribute)
        {
            return _webElement.GetAttribute(attribute);
        }

        public string GetCssValue(string propertyName)
        {
            return _webElement.GetCssValue(propertyName);
        }

        public string GetInfo()
        {
            return _webElement.ToString();
        }

        public string GetProperty(string propertyName)
        {
            return _webElement.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }

        public void Submit()
        {
            _webElement.Submit();
        }

        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {
            return _webElement.FindElements(by);
        }
    }
}
