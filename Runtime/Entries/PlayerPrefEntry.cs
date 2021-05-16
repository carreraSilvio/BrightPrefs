namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Maintains key and value of a PlayerPref
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
            _value = GetObject<T>(_key);
        }

        public override void Save()
        {
            SetObject(_key, _value);
            base.Save();
        }
    }
}