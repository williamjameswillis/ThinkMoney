using System.Collections.Generic;

namespace Framework
{
    public static class Configuration
    {
        private static readonly Dictionary<string, string> appSettings = new Dictionary<string, string>
        {
            {"HomePageUrl", "https://www.thinkmoney.co.uk/"},
            {"WaitSeconds", "10" }
        };

        public static string Get(string option)
        {
            string result = appSettings[option];

            return result;
        }

    }
}
