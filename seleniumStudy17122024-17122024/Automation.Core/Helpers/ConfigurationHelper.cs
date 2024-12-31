using System.Configuration;
using Newtonsoft.Json;

namespace Automation.Core.Helpers
{
    public static class ConfigurationHelper
    {
        public static T GetValue<T>(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (value is null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static T GetJsonValue<T>(string key)
        {
            string filePath = "/Users/daohongphuc270521/projects/seleniumStudy17122024-17122024/seleniumStudy17122024-17122024/testdata.json";
            string fileContent = File.ReadAllText(filePath);

            var jsonData = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileContent);

            // Get value by key
            if (jsonData.TryGetValue(key, out string value))
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            else
            {
                return default(T);
            }
        }
    }
}

