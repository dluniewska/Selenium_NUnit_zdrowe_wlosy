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
    internal class LoginTests
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
        public void Login()
        {
            HomePage homepage = new HomePage(webDriver);
            homepage.ClickLogin();

            SignInPage signInPage = new SignInPage(webDriver);
            signInPage.SignIn("admin@admin", "admin");

            Assert.That(signInPage.IsLoggedSuccesfully, Is.True);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
