using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Notebook.Classes
{
    internal static class LanguageManager
    {
        private const string defaultLang = "en";
        private static JObject data = null;

        public static string CurrentLang
        {
            get
            {
                string lang = JObject
                    .Parse(File.ReadAllText($"Settings.json"))
                    .SelectToken("appLanguage")
                    ?.Value<string>();

                if (data == null)
                {
                    data = JObject
                        .Parse(File.ReadAllText($"Strings/{lang ?? defaultLang}.json"));
                }

                return lang ?? defaultLang;
            }
            set
            {
                if (File.Exists($"Strings/{value}.json"))
                {
                    JObject obj = JObject.Parse(File.ReadAllText($"Settings.json"));
                    obj["appLanguage"] = value;

                    data = JObject
                        .Parse(File.ReadAllText($"Strings/{value}.json"));

                    File.WriteAllText("Settings.json", obj.ToString());

                    return;
                }

                throw new Exception("This language does not exist!");
            }
        }

        public static string Get(string key)
        {
            if (data == null)
            {
                string lang = JObject
                    .Parse(File.ReadAllText($"Settings.json"))
                    .SelectToken("appLanguage")
                    ?.Value<string>();

                data = JObject
                        .Parse(File.ReadAllText($"Strings/{lang ?? defaultLang}.json"));
            }

            string value;

            try
            {
                value = data
                    .SelectToken(key)
                    ?.Value<string>();
            }
            catch (InvalidCastException)
            {
                return key;
            }

            return value ?? key;
        }
    }
}