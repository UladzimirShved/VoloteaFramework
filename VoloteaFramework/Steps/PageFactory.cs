using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoloteaFramework.Steps
{
    public class PageFactory
    {
        protected IWebDriver Driver { get; set; }

        public PageFactory(string browser)
        {
            Driver = WebDriver.GetBrowser(browser);
        }

        public void GoTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            Driver.Quit();
        }
    }
}
