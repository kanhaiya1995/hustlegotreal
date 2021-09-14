using hustlegotreal.Core.Browsers;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace hustlegotreal
{
    class Home
    {
        private readonly IBrowser _browser;
        const string LIST_AND_MONITORED = "//a[@href='/SearchProduct/ActiveListings']/p[@class='value']";
        const string SUB_ALLOWANCE = "//div[@class='module_products']/div[1]/p[@class='value']";

        public Home(IBrowser browser)
        {
            _browser = browser;
        }

        public void GetProducts()
        {
            string _listAndMonitoredValue = "";
            string _subAllowanceValue = "";
            Console.WriteLine("loading home page...");
            Thread.Sleep(10000);
            var ele = _browser.Page.FindElement(By.XPath(LIST_AND_MONITORED));
            //get List and Monitored
            if (ele == null)
                throw new Exception("List and monitored element not found");
            _listAndMonitoredValue = ele.Text;

            //get subscription allowance
            ele = _browser.Page.FindElement(By.XPath(SUB_ALLOWANCE));
            if (ele == null)
                throw new Exception("Subscription Allowance element not found");
            _subAllowanceValue = ele.Text;

            //print expected result
            Console.WriteLine("Result:");
            Console.WriteLine($"List and Monitored = {_listAndMonitoredValue}");
            Console.WriteLine($"Subscription Allowance = {_subAllowanceValue}");
            Console.WriteLine("\n \n");
            Thread.Sleep(10000);
        }
    }
}
