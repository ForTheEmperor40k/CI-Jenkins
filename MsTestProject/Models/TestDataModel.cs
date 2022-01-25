using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System.Reflection;

namespace MsTestProject.Models
{
    public class TestDataModel
    {
        private const string PathToConfigFile = @"Resources.TestData.json";

        private ISettingsFile settingsFile = new JsonSettingsFile(PathToConfigFile, Assembly.GetCallingAssembly());

        public string Login => settingsFile.GetValue<string>(".login");

        public string Password => settingsFile.GetValue<string>(".password");
    }
}
