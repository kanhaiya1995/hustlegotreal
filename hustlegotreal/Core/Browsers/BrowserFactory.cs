using OpenQA.Selenium.Chrome;
using hustlegotreal.Core.enumeration;
using System;
using System.IO;

namespace hustlegotreal.Core.Browsers
{
    public sealed class BrowserFactory : AbstractFactory, IBrowserWebDriver<ChromeDriver>
    {
        IBrowser<ChromeDriver> IBrowserWebDriver<ChromeDriver>.Create()
        {
            var dirName = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
            var fileInfo = new FileInfo(dirName);
            var parentDirName = fileInfo?.FullName;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            return new BrowserAdapter<ChromeDriver>(new ChromeDriver(parentDirName + @"libs", chromeOptions), BrowserType.Chrome);
        }
    }
}
