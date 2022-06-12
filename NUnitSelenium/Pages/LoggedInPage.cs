using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.Pages
{
    internal class LoggedInPage
    {
        private IWebDriver WebDriver { get; }

        public IWebElement TitleInput => WebDriver.FindElement(By.Name("title"));
        public IWebElement INCIInput => WebDriver.FindElement(By.Name("message"));
        public IWebElement TagsInput => WebDriver.FindElement(By.Name("tags"));
        public IWebElement SaveButton => WebDriver.FindElement(By.XPath("//button[contains(., 'ZAPISZ')]"));


        public LoggedInPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public void CreateNewPost(string name, string inci, string tags)
        {
            TitleInput.SendKeys(name);
            INCIInput.SendKeys(inci);
            TagsInput.SendKeys(tags);
            SaveButton.Submit();
        }
    }
}
