using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework; 

namespace VoloteaFramework.Tests
{
    [Ignore("There are few free minutes on BrowserStack. Please, don`t use :3")]
    [TestFixture]
    public class LocationTest
    {
        private Steps.SearchFlightsPage pageLocal;
        private Steps.SearchFlightsPage pageBrowserStack;
        private string url = "http://www.volotea.com/en/search-flights/";

        [SetUp]
        public void SetUp()
        {
            pageLocal = new Steps.SearchFlightsPage("chrome");
            pageBrowserStack = new Steps.SearchFlightsPage("browserstack");
        }

        [Test]
        public void TestLocation()
        {
            pageLocal.GoTo(url);
            pageBrowserStack.GoTo(url);
            string localCity = pageLocal.GetCity();
            string browserStackCity = pageBrowserStack.GetCity();

            Assert.True(localCity.Contains("Chisinau"));
            Assert.True(browserStackCity.Contains("Lille"));
        }

        [TearDown]
        public void TearDown()
        {
            pageLocal.Quit();
        }
    }
}
