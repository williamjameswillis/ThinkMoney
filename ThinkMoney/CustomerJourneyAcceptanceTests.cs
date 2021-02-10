using Framework.Helpers;
using Framework.POMs;
using OpenQA.Selenium;
using Xunit;

namespace ThinkMoney
{
    public class CustomerJourneyAcceptanceTests
    {
        private static IWebDriver webDriver;
        private const string homePageURL = "https://www.thinkmoney.co.uk/";
        private const string homePageText = "Digital banking for everyone";
        private const string manageYourMoneyURL = "https://www.thinkmoney.co.uk/current-account/online-banking/";
        private const string manageYourMoneyText = "Manage your money with online banking";

        public CustomerJourneyAcceptanceTests()
        {
            webDriver = Helpers.StartTest(); //Usually would handle Startup in a constructor of a xUnit Collection Fixture - https://xunit.net/docs/shared-context#constructor 
        }

        //As a Customer
        //When I visit the thinkmoney website www.thinkmoney.co.uk
        //Then I see the thinkmoney homepage
        [Fact]
        public void ThinkMoneyHomePage()
        {
            //Given i am using a web browser

            //When i navigate to the thinkmoney website  

            //Then i see the thinkmoney homepage
            HomePage homePage = new HomePage(webDriver);
            Assert.True(webDriver.Url == homePageURL);
            Assert.True(homePage.PageHeaderText == homePageText);
        }

        //As a Customer
        //When I click the login button
        //Then I see the “Manage your money” page
        [Fact]
        public void ClickLoginSeeManageYourMoneyPage()
        {
            //Given i am on the thinkmoney homepage

            //When i click the login button
            HomePage.Login(webDriver);

            //Then i see the Manage Your Money Page
            ManageYourMoneyPage manageYourMoneyPage = new ManageYourMoneyPage(webDriver);
            Assert.True(webDriver.Url == manageYourMoneyURL);
            Assert.True(manageYourMoneyPage.PageHeaderText == manageYourMoneyText);
        }

        //As a Customer
        //When I click the Continue To Login button
        //Then I see the Login page
        [Fact]
        public void ClickContinueToLoginSeeLoginPage()
        {
            //Given i am on the Manage your money homepage

            //When i click the Continue To Login button
            ManageYourMoneyPage.ContinueToLogin(webDriver);

            //Then i see the Manage Your Money Page
            ManageYourMoneyPage manageYourMoneyPage = new ManageYourMoneyPage(webDriver);
            Assert.True(webDriver.Url == manageYourMoneyURL);
            Assert.True(manageYourMoneyPage.PageHeaderText == manageYourMoneyText);
        }
    }
}
