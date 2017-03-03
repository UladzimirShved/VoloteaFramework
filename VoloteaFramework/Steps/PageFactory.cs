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

        public void Quit()
        {
            Driver.Quit();
        }
    }
}
