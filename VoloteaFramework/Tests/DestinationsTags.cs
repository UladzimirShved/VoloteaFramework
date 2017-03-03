using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VoloteaFramework.Steps;

namespace VoloteaFramework.Tests
{
    [TestFixture]
    class DestinationsTags
    {
        public DestinationPage page;
        [OneTimeSetUp]
        public void SetUpAttribute()
        {
            page = new DestinationPage("chrome");
        }
        [Test]
        public void Main()
        {
            page.GoToDestinationsPage();
            var list = page.GetAllDestinations();
            string city = list.ElementAt(0).Text;
            page.GoToCityPage(city);
            var tags = page.GetAllTags();
            page.GoToDestinationsPage(tags.ElementAt(0).Text);
            Assert.AreNotEqual(page.FindCityOnPage(city), 1);
        }
        [OneTimeTearDown]
        public void Clean()
        {
            page.Quit();
        }
    }
}
