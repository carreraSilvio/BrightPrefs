using UnityEngine;

namespace BrightPrefs.Runtime
{
    public sealed class IntPlayerPrefEntry : AbstractPlayerPrefEntry
    {
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        private int _value;

        public IntPlayerPrefEntry(string key):base(key)
        {
            Load();
        }

        public override void Load()
        {
            _value = PlayerPrefs.GetInt(_key);
        }

        public override void Save()
        {
            PlayerPrefs.SetInt(_key, _value);
            base.Save();
        }
    }
}