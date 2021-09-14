using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace hustlegotreal.Core.Browsers
{
    public interface IBrowserWebDriver<out T> where T: IWebDriver
    {
        IBrowser<T> Create();
    }
}
