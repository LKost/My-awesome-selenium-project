using System;

namespace NUnitTestProject1.Core.AAACore.attribute
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class)]
    public class ElementTitleAttribute : Attribute
    {
        public ElementTitleAttribute(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
