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
                SetInt(_key, value);
            }
        }
        private int _value;

        public IntPlayerPrefEntry(string key):base(key)
        {
            _value = GetInt(_key);
        }
    }
}