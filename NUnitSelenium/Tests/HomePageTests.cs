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
        HomePage homePage;


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
            homePage = new HomePage(webDriver);

        }

        [Test]
        public void IsLoginButtonExists()
        {
            Assert.That(homePage.LoginElement.Displayed, Is.True);
        }

        [Test]
        public void DisplayHomePage()
        {
            Assert.That(homePage.IfHelloDesriptionDisplayed, Is.True);
        }

        [Test]
        public void FileDownload()
        {
            homePage.ClickDownload();
            Thread.Sleep(10000);
            Assert.IsTrue(File.Exists(@"C:\Users\lunie\Downloads\zdrowewlosy.pdf"));
        }

        [Test]
        public void IsListOfCosmeticsDisplayed()
        {
            Assert.That(homePage.AwaitedCardWithTitleDisplayed("Garnier Maska"), Is.True);
            Assert.That(homePage.IsCardWithTitleDisplayed("Petal Fresh"), Is.True);
        }

        [Test]
        public void Search()
        {
            homePage.Search("Garnier Maska");
            Thread.Sleep(10000);

            Assert.That(homePage.IsCardWithTitleDisplayed("Garnier Maska"), Is.True);
            Assert.That(homePage.IsCardWithTitleDisplayed("Petal Fresh"), Is.False);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
