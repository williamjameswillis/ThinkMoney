﻿using OpenQA.Selenium;
using Framework.Helpers;

namespace Framework.POMs
{
    public class LoginPage
    {
        private readonly IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

            WaitFor.VerySmall();
        }

        public string PageHeaderText => webDriver.FindElement(By.XPath("/html/body/form/div[3]/div[2]/div[2]/div/div[2]/div[2]/div[2]/div[2]/div[1]/div")).Text;

        public IWebElement Username => webDriver.FindElement(By.Id("ThinkMoney_Theme_wt28_block_wtMainContent_OnlineBanking_CW_wt55_block_wtMainContent_OnlineBanking_CW_wt86_block_wtInputWidget_ThinkMoney_Patterns_wt52_block_wtInput_Label_wtUserNameInput"));


        public IWebElement Password => webDriver.FindElement(By.Id("ThinkMoney_Theme_wt28_block_wtMainContent_OnlineBanking_CW_wt55_block_wtMainContent_OnlineBanking_CW_wt68_block_wtInputWidget_ThinkMoney_Patterns_wt88_block_wtInput_Label_wtPasswordInput"));


        public static void Continue(IWebDriver webDriver)
        {
            webDriver.FindElement(By.Id("ThinkMoney_Theme_wt28_block_wtMainContent_OnlineBanking_CW_wt55_block_wtButtons_wtLoginButton")).Click();
        }
    }
}
