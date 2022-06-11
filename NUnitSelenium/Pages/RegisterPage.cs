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

        public RegisterPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
