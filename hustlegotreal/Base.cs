using hustlegotreal.Core.Browsers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace hustlegotreal
{
    public class Base
    {

        public static void Main(string[] args)
        {
            Lazy<BrowserFactory> _factory = new Lazy<BrowserFactory>();
            IBrowser Driver;
            var dirName = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
            Driver = _factory.Value.GetBrowser(Config.Browser);

            var page = new Authentication(Driver);
            page.Authenticate();

            var homePage = new Home(Driver);
            homePage.GetProducts();

            Driver.Page.Quit();
        }
    }
}
