using System;

namespace NUnitTestProject1.Utils
{
    public interface IWaitUntil<T>
    {
        TResult Until<TResult>(Func<TResult> action);
        TResult Until<TResult>(Func<T, TResult> action);
    }
}