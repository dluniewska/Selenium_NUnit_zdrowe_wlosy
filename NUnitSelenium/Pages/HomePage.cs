using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        public IWebElement SearchInput => WebDriver.FindElement(By.Name("search"));
        public IWebElement SearchButton => WebDriver.FindElement(By.XPath("//button[contains(., 'Szukaj')]"));

        public void Search(string searchPhrase)
        {
            SearchInput.SendKeys(searchPhrase);
            SearchButton.Click();
        }

        public bool IsCardWithTitleDisplayed(string title)
        {
            if (WebDriver.FindElements(By.XPath($"//h5[contains(.,'{title}')]")).Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AwaitedCardWithTitleDisplayed(string title)
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            var GarnierCard = wait.Until(x => x.FindElement(By.XPath($"//h5[contains(.,'{title}')]")));
            return GarnierCard.Displayed;
        }


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
