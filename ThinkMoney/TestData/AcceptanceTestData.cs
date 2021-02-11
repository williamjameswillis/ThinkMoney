using System.Collections.Generic;

namespace AcceptanceTests
{
    public static class AcceptanceTestData
    {
        private static readonly Dictionary<string, string> testData = new Dictionary<string, string>
        {
            {"homePageText", "Digital banking for everyone"},
            {"manageYourMoneyURL", "https://www.thinkmoney.co.uk/current-account/online-banking/" },
            {"manageYourMoneyText", "Manage your money with online banking" },
            {"partialLoginURL", "https://my.thinkmoney.co.uk/onlinebanking/" },
            {"logInText", "Log In" },
            {"logInTitle", "Login" },
        };

        public static string Get(string option)
        {
            string result = testData[option];

            return result;
        }
    }
}
