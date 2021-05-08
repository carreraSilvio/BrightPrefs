using UnityEngine;

namespace BrightPrefs.Runtime
{
    public class PlayerPrefEntry<T> 
    {
        public T Value 
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                var valueJson = JsonUtility.ToJson(value);
                PlayerPrefs.SetString(_key, valueJson);
            }
        }

        private T _value;
        private readonly string _key;

        public PlayerPrefEntry(string key)
        {
            _key = key;
        }

        public void Save()
        {
            PlayerPrefs.Save();
        }
    }
}