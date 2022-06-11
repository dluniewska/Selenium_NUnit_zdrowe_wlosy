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
    internal class RegisterPageTests
    {
        string url = "https://zdrowe-wlosy.netlify.app/";

        //Browser driver
        IWebDriver webDriver = new ChromeDriver();
        HomePage homepage;
        SignInPage signInPage;

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl(url);
            homepage = new HomePage(webDriver);
            signInPage = new SignInPage(webDriver);
            homepage.ClickLogin();
            signInPage.ClickRegister();
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
