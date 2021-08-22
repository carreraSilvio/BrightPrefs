using UnityEngine;

namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Extends UnityEngine.PlayerPrefs with bool and object support.
    /// </summary>
    public static class BrightPlayerPrefs
    {
        public static void SetBool(string key, bool value)
        {
            PlayerPrefs.SetString(key, value ? "true" : "false");
        }

        public static bool GetBool(string key, bool defaultValue = false)
        {
            var stringValue = PlayerPrefs.GetString(key, string.Empty);
            return string.IsNullOrEmpty(stringValue) ? 
                defaultValue : 
                stringValue == "true";
        }

        public static void SetObject(string key, object value)
        {
            string jsonValue = JsonUtility.ToJson(value);
            PlayerPrefs.SetString(key, jsonValue);
        }

        public static T GetObject<T>(string key) where T : new()
        {
            var stringValue = PlayerPrefs.GetString(key, string.Empty);
            return string.IsNullOrEmpty(stringValue) ?
                new T() :
                JsonUtility.FromJson<T>(stringValue);
        }
    }
}