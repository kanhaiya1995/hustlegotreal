using OpenQA.Selenium;
using hustlegotreal.Core.enumeration;

namespace hustlegotreal.Core.Browsers
{
    public interface IBrowser
    {
        IPage Page { get; }
    }

    public interface IBrowser<out T>: IBrowser where T: IWebDriver
    {
        BrowserType Type { get; }
        T Driver { get; }
    }
}
