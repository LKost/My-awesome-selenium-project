using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Internal;
using System.Collections.Generic;
using System.Drawing;

namespace NUnitTestProject1.Core.Elemens
{
    interface IElement : IWebElement, IWrapsElement, ICoordinates
    {
        string GetInfo();

        void Clear();

        void Click();

        void SendKeys(string text);

        string GetText();

        IWebElement GetWebElement();

        string GetTagName();

        string GetAttribute(string attribute);

        bool IsSelected();

        bool IsEnabled();

        void Submit();

        IList<IWebElement> FindElements(By by);

        IWebElement FindElement(By by);

        bool IsDisplayed();

        Point GetLocation();

        //Dimension getSize();

        Rectangle GetRect();

        string GetCssValue(string cssValue);

       //<X> X getScreenshotAs(OutputType<X> outputType);

        ICoordinates GetCoordinates();

        IWebElement GetWrappedElement();


    }
}
