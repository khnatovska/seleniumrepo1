using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TearGarden
{
    class Repository
    {
        private IWebDriver Driver;
        private WebDriverWait Wait;
        private string CoreIP = "10.35.178.196";
        private string CoreUsername = "administrator";
        private string CorePassword = "123asdQ";

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Program.OpenBrowser(Driver, CoreIP, CoreUsername, CorePassword);
        }

        [Test]
        public void OpenRepositoriesPage()
        {
            //start: any page. find Repositories in More Navigation menu, open Repositories page, verify URL
            IWebElement more = Driver.FindElement(By.CssSelector("#coreNavigationMore span.ui-navigation-core-menu-icon"));
            more.Click();
            IWebElement repoInMore = Driver.FindElement(By.CssSelector("#coreNavigationMoreMenu > li:nth-child(5) > a"));
            repoInMore.Click();
            Wait.Until(ExpectedConditions.UrlContains("Repository"));
            Assert.IsTrue(Driver.Url.Contains("Repository"));
        }
    }
}
