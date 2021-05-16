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
                SetString(_key, value);
            }
        }
        private string _value;

        public StringPlayerPrefEntry(string key) : base(key)
        {
            _value = GetString(_key);
        }
    }
}