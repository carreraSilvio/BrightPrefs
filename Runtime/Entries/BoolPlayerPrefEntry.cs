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
            }
        }
        private bool _value;

        public BoolPlayerPrefEntry(string key) : base(key)
        {
            Load();
        }

        public override void Load()
        {
            _value = BrightPlayerPrefs.GetBool(_key);
        }

        public override void Save()
        {
            BrightPlayerPrefs.SetBool(_key, _value);
            base.Save();
        }
    }
}