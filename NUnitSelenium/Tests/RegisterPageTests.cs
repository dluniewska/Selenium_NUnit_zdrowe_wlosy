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
        RegisterPage registerPage;

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl(url);
            homepage = new HomePage(webDriver);
            signInPage = new SignInPage(webDriver);
            registerPage = new RegisterPage(webDriver);
            homepage.ClickLogin();
            signInPage.ClickRegister();
        }

        [Test]
        public void IsFirstNameFieldDisplayed()
        {
            Assert.That(registerPage.FirstNameInput.Displayed, Is.True);
        }

        [Test]
        public void IsLastNameFieldDisplayed()
        {
            Assert.That(registerPage.LastNameInput.Displayed, Is.True);
        }

        [Test]
        public void IsEmailNameFieldDisplayed()
        {
            Assert.That(registerPage.EmailInput.Displayed, Is.True);
        }

        [Test]
        public void IsPasswordFieldDisplayed()
        {
            Assert.That(registerPage.PasswordInput.Displayed, Is.True);
        }

        [Test]
        public void IsConfirmPasswordFieldDisplayed()
        {
            Assert.That(registerPage.ConfirmPasswordInput.Displayed, Is.True);
        }

        [Test]
        public void IsLoginButtonDisplayed()
        {
            Assert.That(registerPage.LoginButton.Displayed, Is.True);
        }

        //[TearDown]
        //public void TearDown() => webDriver.Quit();
    }
}
