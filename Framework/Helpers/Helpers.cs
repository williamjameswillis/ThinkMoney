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

        public static IWebDriver StartTest()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(int.Parse(Configuration.Get("WaitSeconds")));
            webDriver.Navigate().GoToUrl(Configuration.Get("HomePageUrl"));
            webDriver.Manage().Window.Maximize();
            WaitFor.Small();
            webDriver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            return webDriver;
        }
        public static void NavigateHome(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(Configuration.Get("HomePageUrl"));
        }

        public static void SwitchToTab(IWebDriver webDriver, string FirstOrLast)
        {
            if (FirstOrLast == "First")
            {
                webDriver.SwitchTo().Window(webDriver.WindowHandles.First());
            }
            else 
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
        }

        public static void CloseNewTabAndSwitchBack(IWebDriver webDriver)
        {
            var tabs = webDriver.WindowHandles;
            if (tabs.Count > 1)
            {
                webDriver.SwitchTo().Window(tabs[1]);
                webDriver.Close();
                webDriver.SwitchTo().Window(tabs[0]);
            }
        }

        public static void TearDown(IWebDriver webDriver)
        {
            webDriver.Quit();
        }

    }
    public static class WaitFor
    {
        public static void Small()
        {
            Thread.Sleep(500);
        }
    }
}
