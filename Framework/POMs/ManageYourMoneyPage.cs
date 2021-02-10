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

        public string PageHeaderText => webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div[1]/div/h1")).Text;

        public static void ContinueToLogin(IWebDriver webDriver)
        {
            try
            {
                webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div[1]/div/a/button")).Click();
            }
            catch (StaleElementReferenceException)
            {
                webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div[1]/div/a/button")).Click();
            }
        }
    }
}
