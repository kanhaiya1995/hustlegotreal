using Microsoft.Extensions.Configuration;
using hustlegotreal.Core.enumeration;
using System;
using System.IO;

namespace hustlegotreal.Core.Browsers
{
    public class Config
    {
        public static BrowserType Browser => (BrowserType)Enum.Parse(typeof(BrowserType), GetValue("Browser"));
        public static string BaseUrl => GetValue("baseUrl");

        private static string GetValue(string value)
        {
            var dirName = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));
            var fileInfo = new FileInfo(dirName);
            var parentDirName = fileInfo?.FullName;

            var builder = new ConfigurationBuilder().SetBasePath(parentDirName).AddJsonFile("appSettings.json");
            return builder.Build()[value];
        }
    }
}
