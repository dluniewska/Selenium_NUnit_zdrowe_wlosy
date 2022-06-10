using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.Pages
{
    internal class LoginPage
    {
        private IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement signinbtn => WebDriver.FindElement(By.XPath("//button[contains(., 'Sign In')]"));
        public IWebElement txtEmail => WebDriver.FindElement(By.Name("email"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("password"));

        public void SignIn(string username, string password)
        {
            txtEmail.SendKeys(username);
            txtPassword.SendKeys(password);
            signinbtn.Submit();
        }
    }
}
