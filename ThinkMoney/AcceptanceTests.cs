using Framework;
using Framework.Helpers;
using Framework.POMs;
using OpenQA.Selenium;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace AcceptanceTests
{
    [Collection("AcceptanceTests")]
    public class AcceptanceTests
    {
        private static IWebDriver webDriver;

        public AcceptanceTests()
        {
            webDriver = TestFixture.WebDriver;
            Helpers.CloseNewTabAndSwitchBack(webDriver);
            Helpers.NavigateHome(webDriver);
        }

        //As a Customer
        //When I visit the thinkmoney website www.thinkmoney.co.uk
        //Then I see the thinkmoney homepage
        [Fact]
        public void TestHomePage()
        {
            //Given i am using a web browser

            //When i navigate to the thinkmoney website  

            //Then i see the thinkmoney homepage
            HomePage homePage = new HomePage(webDriver);
            Assert.True(webDriver.Url == Configuration.Get("HomePageUrl"));
            Assert.True(homePage.PageHeaderText == AcceptanceTestData.Get("homePageText"));
        }

        //As a Customer
        //When I click the login button
        //Then I see the “Manage your money” page
        [Fact]
        public void TestManageYourMoneyPage()
        {
            //Given i am on the thinkmoney homepage

            //When i click the login button
            HomePage.Login(webDriver);

            //Then i see the Manage Your Money Page
            ManageYourMoneyPage manageYourMoneyPage = new ManageYourMoneyPage(webDriver);
            Assert.True(webDriver.Url == AcceptanceTestData.Get("manageYourMoneyURL"));
            Assert.True(manageYourMoneyPage.PageHeaderText == AcceptanceTestData.Get("manageYourMoneyText"));
        }

        //As a Customer
        //When I click the Continue To Login button
        //Then I see the Login page
        [Fact]
        public void TestLoginPage()
        {
            //Given i am on the Manage your money homepage
            HomePage.Login(webDriver);

            //When i click the Continue To Login button
            ManageYourMoneyPage.ContinueToLogin(webDriver);
            Helpers.SwitchToTab(webDriver, "Last");

            //Then i see the Login Page
            Assert.Contains(AcceptanceTestData.Get("partialLoginURL"), webDriver.Url);
            LoginPage loginPage = new LoginPage(webDriver);
            Assert.True(loginPage.PageHeaderText == AcceptanceTestData.Get("logInText"));
            Assert.True(webDriver.Title == AcceptanceTestData.Get("logInTitle"));
            Assert.True(loginPage.Password.Displayed);
            Assert.True(loginPage.Password.Enabled);
            Assert.True(loginPage.Username.Displayed);
            Assert.True(loginPage.Username.Enabled);
        }
    }
}
