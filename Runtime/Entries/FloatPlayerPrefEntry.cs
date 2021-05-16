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
            }
        }
        private float _value;

        public FloatPlayerPrefEntry(string key) : base(key)
        {
            Load();
        }

        public override void Load()
        {
            _value = GetFloat(_key);
        }

        public override void Save()
        {
            SetFloat(_key, _value);
            base.Save();
        }
    }
}