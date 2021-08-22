using UnityEngine;

namespace BrightPrefs.Runtime
{
    public sealed class StringPlayerPrefEntry : AbstractPlayerPrefEntry
    {
        public string Value
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
        private string _value;

        public StringPlayerPrefEntry(string key) : base(key)
        {
            Load();
        }

        public override void Load()
        {
            _value = PlayerPrefs.GetString(_key);
        }

        public override void Save()
        {
            PlayerPrefs.SetString(_key, _value);
            base.Save();
        }
    }
}