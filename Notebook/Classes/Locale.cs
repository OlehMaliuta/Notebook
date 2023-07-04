using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Notebook.Classes
{
    internal static class Locale
    {
        private const string defaultLang = "en";
        private static string currentLang = null;

        public static string CurrentLang
        {
            get
            {
                if (currentLang == null)
                {
                    JObject progStorage = JObject
                                    .Parse(File.ReadAllText($"Settings.json"));

                    string lang = progStorage
                        .SelectToken("appLanguage")
                        ?.Value<string>();

                    currentLang = lang ?? defaultLang;
                }

                return currentLang;
            }
            set
            {
                if (File.Exists($"Localization/{value}.json"))
                {
                    JObject obj = JObject.Parse(File.ReadAllText($"Settings.json"));
                    obj["appLanguage"] = value;
                    currentLang = value;

                    File.WriteAllText("Settings.json", obj.ToString());

                    return;
                }

                throw new Exception("This language does not exist!");
            }
        }

        public static string Get(string key)
        {
            if (currentLang == null)
            {
                JObject progStorage = JObject
                                .Parse(File.ReadAllText($"Settings.json"));

                string lang = progStorage
                    .SelectToken("appLanguage")
                    ?.Value<string>();

                currentLang = lang ?? defaultLang;
            }

            JObject data = JObject
                .Parse(File.ReadAllText($"Localization/{currentLang}.json"));

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