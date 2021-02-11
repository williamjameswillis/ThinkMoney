using System;
using Framework.Helpers;
using OpenQA.Selenium;
using Xunit;

namespace AcceptanceTests
{
    public class TestFixture : IDisposable
    {
        public static IWebDriver WebDriver { get; set; }

        public TestFixture()
        {
            WebDriver = Helpers.StartTest();
        }

        public void Dispose()
        {
            Helpers.TearDown(WebDriver);
        }
    }

    [CollectionDefinition("AcceptanceTests")]
    public class MyFixture : ICollectionFixture<TestFixture>
    {
    }
}
