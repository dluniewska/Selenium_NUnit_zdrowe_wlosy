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
    internal class LoginPageTests
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
        }

        [Test]
        public void IsEmailInputDisplayed()
        {
            Assert.That(signInPage.EmailInput.Displayed, Is.True);
        }

        [Test]
        public void IsPasswordInputExists()
        {
            Assert.That(signInPage.PasswordInput.Displayed, Is.True);
        }

        [Test]
        public void IsNewWindowOpenedAfterGoogleSignInClick()
        {
            signInPage.GoogleSignInButton.Click();
            var isNewWindowOpened = signInPage.IsWindowOpened(2);
            Assert.That(isNewWindowOpened, Is.True);
        }

        [Test]
        public void IsGoogleLoginButtonExists()
        {
            Assert.That(signInPage.GoogleSignInButton.Displayed, Is.True);
        }

        [Test]
        public void Login()
        {
            signInPage.SignIn("admin@admin", "admin");

            Assert.That(signInPage.IsLoggedSuccesfully, Is.True);
        }

        //[TearDown]
        //public void TearDown() => webDriver.Quit();
    }
}
