using hustlegotreal.Core.Browsers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hustlegotreal
{
    class Authentication
    {
        private readonly IBrowser _browser;

        const string USER_NAME = "//input[@id='Email']";
        const string PASSWORD = "//input[@id='Password']";
        const string LOGIN_BTN = "//button[@type='submit']";

        const string EMAIL = "testing@hustlegotreal.com";
        const string PASS = "HGR2021";

        public Authentication(IBrowser browser)
        {
            _browser = browser;
        }

        //autheticate user once
        public void Authenticate()
        {
            _browser.Page.GoToUrl(Config.BaseUrl + "/Account/Login");
            _browser.Page.FindElement(By.XPath(USER_NAME)).SendKeys(EMAIL);
            _browser.Page.FindElement(By.XPath(PASSWORD)).SendKeys(PASS);
            _browser.Page.FindElement(By.XPath(LOGIN_BTN)).Click();
        }
    }
}
