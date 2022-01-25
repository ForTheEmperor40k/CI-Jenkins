using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System.Reflection;

namespace MsTestProject.Models
{
    public class TestDataModel
    {
        private ISettingsFile settingsFile = new JsonSettingsFile(@"Resources\TestData.json", Assembly.GetCallingAssembly());

        public string Password => settingsFile.GetValue<string>("Password");
        public string Login => settingsFile.GetValue<string>("Login");
    }
}
