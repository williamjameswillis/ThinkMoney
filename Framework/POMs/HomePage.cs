using OpenQA.Selenium;
using Framework.Helpers;

namespace Framework.POMs
{
    public class HomePage
    {
        private readonly IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

            WaitFor.VerySmall();
        }

        public string PageHeaderText => webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div[1]/div/h1")).Text;

        public static void Login(IWebDriver webDriver)
        {
            webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/div/div/div/nav/a/button")).Click();
        }
    }
}
