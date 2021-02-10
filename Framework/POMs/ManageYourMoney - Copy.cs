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

        public IWebElement SearchProduct => webDriver.FindElement(By.Id("siteSearch-input"));

        public static void OpenAccount(IWebDriver webDriver)
        {
            webDriver.FindElement(By.CssSelector("#gatsby-focus-wrapper > main > div.HeaderWithImage__DesktopHeader-z0urnu-0.bZcbVv.gbi-1208345109-9nxaEisrF1uzXgHGD4CzVm.gatsby-image-wrapper > div > a > button")).Click();
        }
    }
}
