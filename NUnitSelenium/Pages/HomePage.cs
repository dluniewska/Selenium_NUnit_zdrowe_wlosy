using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.Pages
{
    internal class HomePage
    {
        private IWebDriver WebDriver { get; }

        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement LoginElement  => WebDriver.FindElement(By.XPath("//a[contains(., 'Zaloguj się')]"));

        public IWebElement HelloDescription => WebDriver.FindElement(By.XPath("//div[contains(., 'Zdrowe Włosy jest to baza danych zawierająca kosmetyki do pielęgnacji włosów. W opisie umieszczamy tylko składniki. Jeśli jesteś tu nowa ściągnij PDF z instrukcją jak dbać o włosy.')]"));
        public IWebElement DownloadButton => WebDriver.FindElement(By.XPath("//button[contains(., 'Ściągnij PDF')]"));

        public void ClickLogin()
        {
            LoginElement.Click();
        }

        public void ClickDownload()
        {
            DownloadButton.Click();
        }

        public bool IfHelloDesriptionDisplayed() => HelloDescription.Displayed;
    }
}
