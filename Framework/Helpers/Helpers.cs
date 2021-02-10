using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Helpers
{
    public static class Helpers
    {
        private static IWebDriver webDriver;
        private static readonly int waitSeconds = 10;
        private static readonly string startUrl = "www.thinkmoney.co.uk";

        public static IWebDriver StartTest()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitSeconds);
            webDriver.Navigate().GoToUrl(startUrl);
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            return webDriver;
        }

        public static void SwitchToNewTab(IWebDriver webDriver)
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
        }

        public static void TearDown()
        {
            webDriver.Quit();
        }

    }
    public static class WaitFor
    {
        public static void Large()
        {
            Thread.Sleep(5000);
        }
    }
}
