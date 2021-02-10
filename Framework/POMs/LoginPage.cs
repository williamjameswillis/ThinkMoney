using OpenQA.Selenium;

namespace Framework.POMs
{
    public class LoginPage
    {
        private readonly IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement PageHeaderText => webDriver.FindElement(By.ClassName("Heading1"));

        public IWebElement Username => webDriver.FindElement(By.Id("ThinkMoney_Theme_wt28_block_wtMainContent_OnlineBanking_CW_wt55_block_wtMainContent_OnlineBanking_CW_wt86_block_wtInputWidget_ThinkMoney_Patterns_wt52_block_wtInput_Label_wtUserNameInput"));


        public IWebElement Password => webDriver.FindElement(By.Id("ThinkMoney_Theme_wt28_block_wtMainContent_OnlineBanking_CW_wt55_block_wtMainContent_OnlineBanking_CW_wt68_block_wtInputWidget_ThinkMoney_Patterns_wt88_block_wtInput_Label_wtPasswordInput"));


        public static void Continue(IWebDriver webDriver)
        {
            webDriver.FindElement(By.Id("ThinkMoney_Theme_wt28_block_wtMainContent_OnlineBanking_CW_wt55_block_wtButtons_wtLoginButton")).Click();
        }
    }
}
