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
        IWebDriver webDriver;
        String DownloadFolder = @"C://SeleniumFiles/";
        ChromeOptions Options = new();


        [SetUp]
        public void Setup()
        {
            //Directory.CreateDirectory(DownloadFolder);
            //Options.AddUserProfilePreference("intl.accept_languages", "nl");
            //Options.AddUserProfilePreference("disable-popup-blocking", "true");
            //Options.AddUserProfilePreference("download.default_directory", DownloadFolder);
            webDriver = new ChromeDriver();
            //Navigate to site
            webDriver.Navigate().GoToUrl(url);
        }

        [Test]
        public void DisplayHomePage()
        {
            HomePage homePage = new HomePage(webDriver);
            Assert.That(homePage.IfHelloDesriptionDisplayed, Is.True);
        }

        [Test]
        public void FileDownload()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickDownload();
            Thread.Sleep(10000);
            Assert.IsTrue(File.Exists(@"C:\Users\lunie\Downloads\zdrowewlosy.pdf"));
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
