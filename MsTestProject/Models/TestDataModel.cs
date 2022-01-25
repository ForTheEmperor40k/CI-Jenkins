using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System.Reflection;

namespace MsTestProject.Models
{
    public static class TestDataModel
    {
        private const string PathToConfigFile = @"Resources.TestData.json";

        private static ISettingsFile settingsFile = new JsonSettingsFile(PathToConfigFile, Assembly.GetCallingAssembly());

        public static string Login => settingsFile.GetValue<string>("login");

        public static string Password => settingsFile.GetValue<string>("password");

    }
}
