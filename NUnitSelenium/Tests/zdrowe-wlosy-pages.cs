using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitSelenium.Tests
{
    public class Tests
    {
        //string url = "https://zdrowe-wlosy.netlify.app/";

        [SetUp]
        public void Setup()
        {
            ////Open browser
            //IWebDriver webDriver = new ChromeDriver();

            ////Navigate to site
            //webDriver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Login()
        {
            //IWebDriver webDriver = new ChromeDriver();
            //webDriver.Navigate().GoToUrl(url);
            //IWebElement Description = webDriver.FindElement(By.XPath("//div[contains(., 'Zdrowe W³osy jest to baza danych zawieraj¹ca kosmetyki do pielêgnacji w³osów. W opisie umieszczamy tylko sk³adniki. Jeœli jesteœ tu nowa œci¹gnij PDF z instrukcj¹ jak dbaæ o w³osy.')]"));
            //Assert.That(Description.Displayed, Is.True);

            ////Open browser
            //IWebDriver webDriver = new ChromeDriver();
            ////Navigate to site
            //webDriver.Navigate().GoToUrl(url);
            ////Identify login
            ////IWebElement login = webDriver.FindElement(By.XPath("//div[@id='root']/div/header/div[2]/a/span"));
            //IWebElement login = webDriver.FindElement(By.XPath("//a[contains(., 'Zaloguj siê')]"));
            //login.Click();
            //var txtEmail = webDriver.FindElement(By.Name("email"));
            //var txtPassword = webDriver.FindElement(By.Name("password"));
            ////Assertion
            //Assert.That(txtEmail.Displayed, Is.True);
            //Assert.That(txtPassword.Displayed, Is.True);

            //txtEmail.SendKeys("admin@admin");
            //txtPassword.SendKeys("admin");
            //IWebElement signinbtn = webDriver.FindElement(By.XPath("//button[contains(., 'Sign In')]"));
            //signinbtn.Submit();
            ////webDriver.FindElement(By.XPath("//h6[contains(., 'Dodaj Kosmetyk')]"));

        }
    }
}