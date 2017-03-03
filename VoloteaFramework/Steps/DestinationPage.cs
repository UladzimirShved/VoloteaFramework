using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
namespace VoloteaFramework.Steps
{
    [TestFixture]
    class DestinationPage : PageFactory
    {
        public DestinationPage(string browser) : base(browser)
        {

        }
       
        public void GoToDestinationsPage()
        {
            Driver.Navigate().GoToUrl(@"http://www.volotea.com/en/inspiration/destinations/");
        }
        public void GoToDestinationsPage(string tag)
        {
            Driver.Navigate().GoToUrl($"http://www.volotea.com/en/inspiration/destinations/tags/{tag}");
        }
        public void GoToCityPage(string name)
        {
            Driver.Navigate().GoToUrl($"http://www.volotea.com/en/inspiration/{name}");
        }
        public IReadOnlyCollection<IWebElement> GetAllDestinations() {
            var list = Driver.FindElements(By.ClassName("destination"));
            return list;
        }
        public IReadOnlyCollection<IWebElement> GetAllTags()
        {
            var list = Driver.FindElements(By.XPath("//a[@data-type = 'tag']"));
            return list;
        }
        public int FindCityOnPage(string city)
        {
            var list = Driver.FindElements(By.ClassName("destination"));
            int k = list.Where(i => i.Text == city).Count();
            return k;

        }
       
    }
}
