using UnityEngine;

namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Extends UnityEngine.PlayerPrefs with bool and object support.
    /// </summary>
    public class BrightPlayerPrefs : PlayerPrefs
    {
        public static void SetBool(string key, bool value)
        {
            SetString(key, value ? "true" : "false");
        }

        public static bool GetBool(string key, bool defaultValue = false)
        {
            var stringValue = GetString(key, string.Empty);
            return string.IsNullOrEmpty(stringValue) ? 
                defaultValue : 
                stringValue == "true";
        }

        public static void SetObject(string key, object value)
        {
            switch (value)
            {
                case int intValue:
                    SetInt(key, intValue);
                    break;
                case float floatValue:
                    SetFloat(key, floatValue);
                    break;
                case string stringValue:
                    SetString(key, stringValue);
                    break;
                case bool boolValue:
                    SetBool(key, boolValue);
                    break;
                default:
                    string jsonValue = JsonUtility.ToJson(value);
                    SetString(key, jsonValue);
                    break;
            }
        }

        public static T GetObject<T>(string key) where T : new()
        {

            var stringValue = GetString(key, string.Empty);
            return string.IsNullOrEmpty(stringValue) ?
                new T() :
                JsonUtility.FromJson<T>(stringValue);
        }
    }
}