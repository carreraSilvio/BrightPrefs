namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Generic version o PlayerPrefEntry
    /// </summary>
    public class PlayerPrefEntry<T> : AbstractPlayerPrefEntry where T : new()
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
            }
        }
        protected T _value;

        public PlayerPrefEntry(string key) : base(key)
        {
            Load();
        }

        public override void Load()
        {
            _value = BrightPlayerPrefs.GetObject<T>(_key);
        }

        public override void Save()
        {
            BrightPlayerPrefs.SetObject(_key, _value);
            base.Save();
        }
    }
}