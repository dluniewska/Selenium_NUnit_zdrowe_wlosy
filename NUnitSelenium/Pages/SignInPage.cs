using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.Pages
{
    internal class SignInPage
    {
        private IWebDriver WebDriver { get; }

        public SignInPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement Signinbtn => WebDriver.FindElement(By.XPath("//button[contains(., 'Sign In')]"));
        //public IWebElement AddCosmeticsForm => WebDriver.FindElement(By.XPath("//span[contains(.,'ZAPISZ')]"));
        public IWebElement TxtEmail => WebDriver.FindElement(By.Name("email"));
        public IWebElement TxtPassword => WebDriver.FindElement(By.Name("password"));

        public void SignIn(string username, string password)
        {
            TxtEmail.SendKeys(username);
            TxtPassword.SendKeys(password);
            Signinbtn.Submit();
        }

        public bool IsLoggedSuccesfully() 
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            var AddCosmeticsForm = wait.Until(x => x.FindElement(By.XPath("//span[contains(.,'ZAPISZ')]")));
            return AddCosmeticsForm.Displayed;
        } 
    }
}
