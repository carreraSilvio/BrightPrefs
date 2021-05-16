namespace BrightPrefs.Runtime
{
    public sealed class FloatPlayerPrefEntry : AbstractPlayerPrefEntry
    {
        public float Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                SetFloat(_key, value);
            }
        }
        private float _value;

        public FloatPlayerPrefEntry(string key) : base(key)
        {
            _value = GetFloat(_key);
        }
    }
}