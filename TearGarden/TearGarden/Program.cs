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
    class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        public string CoreIP = "10.35.178.196";
        static string CoreUsername = "administrator";
        static string CorePassword = "123asdQ";

        static void Main(string[] args)
        {
            //OpenBrowser(CoreIP, CoreUsername, CorePassword);
            
        }

        public static void OpenBrowser(string coreIP, string coreUsername, string corePassword)
        {
            string CoreURL = String.Format("https://{0}:{1}@{2}:8006/apprecovery/admin/", coreUsername, corePassword, coreIP);
            driver.Navigate().GoToUrl(CoreURL);
            driver.Manage().Window.Maximize();
        }

        public static void OpenBrowser(IWebDriver webdriver, string coreIP, string coreUsername, string corePassword)
        {
            string CoreURL = String.Format("https://{0}:{1}@{2}:8006/apprecovery/admin/", coreUsername, corePassword, coreIP);
            webdriver.Navigate().GoToUrl(CoreURL);
            webdriver.Manage().Window.Maximize();
        }

        public static void CloseBrowser()
        {
            driver.Close();
        }
    }
}
