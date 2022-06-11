using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.Pages
{
    internal class RegisterPage
    {
        private IWebDriver WebDriver { get; }

        public IWebElement FirstNameInput => WebDriver.FindElement(By.Name("firstName"));
        public IWebElement PasswordInput => WebDriver.FindElement(By.Name("lastName"));
        public IWebElement LastNameInput => WebDriver.FindElement(By.Name("email"));
        public IWebElement EmailInput => WebDriver.FindElement(By.Name("password"));
        public IWebElement ConfirmPasswordInput => WebDriver.FindElement(By.Name("confirmPassword"));
        public IWebElement LoginButton => WebDriver.FindElement(By.XPath("//button[contains(., 'Masz już konto? Zaloguj się!')]"));


        public RegisterPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
