using OpenQA.Selenium;

namespace Framework.POMs
{
    public class HomePage
    {
        private readonly IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement PageText => webDriver.FindElement(By.ClassName("Typography__H1-q8nsdf-0 dVUGBu"));

        public static void OpenAccount(IWebDriver webDriver)
        {
            webDriver.FindElement(By.CssSelector("#gatsby-focus-wrapper > main > div.HeaderWithImage__DesktopHeader-z0urnu-0.bZcbVv.gbi-1208345109-9nxaEisrF1uzXgHGD4CzVm.gatsby-image-wrapper > div > a > button")).Click();
        }

        public static void Login(IWebDriver webDriver)
        {
            webDriver.FindElement(By.CssSelector("#gatsby-focus-wrapper > header > div.DesktopHeader__Wrapper-sc-1ppbjw5-0.bNQyJS > div > div > div > nav > a > button")).Click();
        }
    }
}
