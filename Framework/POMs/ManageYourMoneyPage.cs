using OpenQA.Selenium;

namespace Framework.POMs
{
    public class ManageYourMoneyPage
    {
        private readonly IWebDriver webDriver;

        public ManageYourMoneyPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public string PageHeaderText => webDriver.FindElement(By.ClassName("Typography__H1-q8nsdf-0 dVUGBu")).Text;

        public static void ContinueToLogin(IWebDriver webDriver)
        {
            webDriver.FindElement(By.CssSelector("#gatsby-focus-wrapper > main > div.HeaderWithImage__DesktopHeader-z0urnu-0.bZcbVv.gbi-1860889184-43b2Qhy2GZuk2oxv9Nm3k2.gatsby-image-wrapper > div > a > button")).Click();
        }
    }
}
