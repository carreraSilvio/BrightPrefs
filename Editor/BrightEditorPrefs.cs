using UnityEditor;
using UnityEngine;

namespace BrightPrefs.Editortime
{
    /// <summary>
    /// Wrapper for UnityEditor.EditorPrefs with object support.
    /// </summary>
    public class BrightEditorPrefs
    {
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

        #region Wrapper Methods
        public static void DeleteAll() => EditorPrefs.DeleteAll();
        public static void DeleteKey(string key) => EditorPrefs.DeleteKey(key);

        public static bool GetBool(string key, bool defaultValue = false)
            => EditorPrefs.GetBool(key, defaultValue);
        public static float GetFloat(string key, float defaultValue = 0f)
            => EditorPrefs.GetFloat(key, defaultValue);
        public static int GetInt(string key, int defaultValue = 0)
            => EditorPrefs.GetInt(key, defaultValue);
        public static string GetString(string key, string defaultValue = "")
            => EditorPrefs.GetString(key, defaultValue);

        public static bool HasKey(string key)
            => EditorPrefs.HasKey(key);


        public static void SetBool(string key, bool value)
            => EditorPrefs.SetBool(key, value);
        public static void SetFloat(string key, float value)
            => EditorPrefs.SetFloat(key, value);
        public static void SetInt(string key, int value)
            => EditorPrefs.SetInt(key, value);
        public static void SetString(string key, string value)
            => EditorPrefs.SetString(key, value); 
        #endregion
    }
}