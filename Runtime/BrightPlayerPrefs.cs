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
            SetString(key, JsonUtility.ToJson(value));
        }

        public static object GetObject<T>(string key, object defaultValue = default)
        {
            var stringValue = GetString(key, string.Empty);
            return string.IsNullOrEmpty(stringValue) ?
                defaultValue :
                JsonUtility.FromJson<T>(stringValue);
        }
    }
}