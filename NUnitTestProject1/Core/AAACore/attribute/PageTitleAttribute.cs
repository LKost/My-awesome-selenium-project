using System;

namespace NUnitTestProject1.Core.AAACore.attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PageTitleAttribute : Attribute
    {
        public PageTitleAttribute(string title)
        {
            Title = title;
        }
        public string Title { get; }
    }
}
