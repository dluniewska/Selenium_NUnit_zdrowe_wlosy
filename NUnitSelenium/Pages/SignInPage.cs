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

        public IWebElement SigninButton => WebDriver.FindElement(By.XPath("//button[contains(., 'Sign In')]"));
        public IWebElement EmailInput => WebDriver.FindElement(By.Name("email"));
        public IWebElement PasswordInput => WebDriver.FindElement(By.Name("password"));
        public IWebElement GoogleSignInButton => WebDriver.FindElement(By.XPath("//button[contains(., 'Google Sign In')]"));
        public IWebElement RegisterButton => WebDriver.FindElement(By.XPath("//button[contains(., 'Nie posiadasz konta? Załóż je!')]"));

        public void ClickRegister()
        {
            RegisterButton.Click();
        }

        public void SignIn(string username, string password)
        {
            EmailInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            SigninButton.Submit();
        }

        public bool IsLoggedSuccesfully() 
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            var AddCosmeticsForm = wait.Until(x => x.FindElement(By.XPath("//span[contains(.,'ZAPISZ')]")));
            return AddCosmeticsForm.Displayed;
        }

        public bool IsWindowOpened(int expectedNumberOfWindows)
        {
            int numberOfWindows;
            bool boolIsExpectedWindowsOpened;

            numberOfWindows = WebDriver.WindowHandles.Count;
            boolIsExpectedWindowsOpened = (numberOfWindows == expectedNumberOfWindows ? true : false);

            return boolIsExpectedWindowsOpened;
        }
    }
}
