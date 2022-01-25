using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System.Reflection;

namespace MsTestProject.Models
{
    public static class TestDataModel
    {
        private static ISettingsFile settingsFile = new JsonSettingsFile(@"Resources\TestData.json", Assembly.GetCallingAssembly());

        public static string Password => settingsFile.GetValue<string>("Password");
        public static string Login => settingsFile.GetValue<string>("Login");
    }
}
