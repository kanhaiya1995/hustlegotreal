using OpenQA.Selenium;

namespace hustlegotreal.Core.Browsers
{
    public interface IBrowserFactory
    {
        IBrowser Create<T>() where T : IWebDriver;
    }

}
