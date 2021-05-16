namespace BrightPrefs.Runtime
{
    public sealed class BoolPlayerPrefEntry : AbstractPlayerPrefEntry
    {
        public bool Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                SetBool(_key, value);
            }
        }
        private bool _value;

        public BoolPlayerPrefEntry(string key) : base(key)
        {
            _value = GetBool(_key);
        }
    }
}