using NUnitSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.Tests
{
    internal class HomePageTests
    {
        string url = "https://zdrowe-wlosy.netlify.app/";

        //Browser driver
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl(url);
        }

        [Test]
        public void DisplayHomePage()
        {
            HomePage homePage = new HomePage(webDriver);
            Assert.That(homePage.IfHelloDesriptionDisplayed, Is.True);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
