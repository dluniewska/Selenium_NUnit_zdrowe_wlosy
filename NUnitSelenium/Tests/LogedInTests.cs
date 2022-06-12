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
    internal class LogedInTests
    {
        string url = "https://zdrowe-wlosy.netlify.app/";

        //Browser driver
        IWebDriver webDriver = new ChromeDriver();
        HomePage homepage;
        SignInPage signInPage;
        LoggedInPage loggedInPage;

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl(url);
            homepage = new HomePage(webDriver);
            signInPage = new SignInPage(webDriver);
            loggedInPage = new LoggedInPage(webDriver);
            homepage.ClickLogin();
            signInPage.SignIn("admin@admin", "admin");
        }

        [Test]
        public void CreateNewItem()
        {
            signInPage.IsLoggedSuccesfully();
            loggedInPage.CreateNewPost("SeleniumTestPost", "SeleniumTestPostINCI", "SeleniumTestPostTag");
            homepage.AwaitedCardWithTitleDisplayed("SeleniumTestPost");
            Assert.That(homepage.IsCardWithTitleDisplayed("SeleniumTestPost"), Is.True);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
