using NUnitTestProject1.Core.AAACore;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace NUnitTestProject1.Utils
{
    public static class WaitExtension
    {
        private static readonly ThreadLocal<TimeSpan> Timespan = new ThreadLocal<TimeSpan>();

        public static TimeSpan Timing
        {
            get => Timespan.Value;
            set => Timespan.Value = value;
        }

        public static IWaitUntil<T> Wait<T>(this T obj, TimeSpan timespan = default(TimeSpan))
        {
            if (timespan == default(TimeSpan))
            {
                if (obj is IWebDriver) timespan = TimeSpan.FromSeconds(10);
                else if (obj.GetType().BaseType == typeof(AProxyElement))
                {
                    var aProxyElement = obj as AProxyElement;
                    timespan = TimeSpan.FromSeconds(aProxyElement.TimeOut);
                }
                else timespan = TimeSpan.FromSeconds(4);
            }
            Timing = timespan;
            return new BaseWaitTypeChooser<T>(obj, timespan);
        }
    }
}
