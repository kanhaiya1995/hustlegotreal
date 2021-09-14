using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using hustlegotreal.Core.enumeration;
using System;
using System.Collections.Generic;
using System.Text;

namespace hustlegotreal.Core.Browsers
{
    public abstract class AbstractFactory : IBrowserFactory
    {
        private readonly Dictionary<BrowserType, Func<IBrowser>> _browsers = 
            new Dictionary<BrowserType, Func<IBrowser>>();

        public AbstractFactory()
        {
            _browsers.Add(BrowserType.Chrome, Chrome);
        }

        public IBrowser Create<T>() where T : IWebDriver
        {
            var factoryMothod = this as IBrowserWebDriver<T>;
            return factoryMothod?.Create();
        }

        private IBrowser Chrome()
        {
            return Create<ChromeDriver>();
        }

        public IBrowser GetBrowser(BrowserType type)
        {
            return _browsers[type].Invoke();
        }
    }
}
