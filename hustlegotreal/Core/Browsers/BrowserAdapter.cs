using OpenQA.Selenium;
using hustlegotreal.Core.enumeration;

namespace hustlegotreal.Core.Browsers
{
    public sealed class BrowserAdapter<T> : IBrowser<T> where T : IWebDriver
    {
        private readonly PageAdapter<T> _page;

        public BrowserAdapter(T driver, BrowserType type)
        {
            Type = type;
            Driver = driver;
            _page = new PageAdapter<T>(this);
        }

        public BrowserType Type { get; }
        public T Driver { get; }
        public IPage Page => _page;
    }
}
