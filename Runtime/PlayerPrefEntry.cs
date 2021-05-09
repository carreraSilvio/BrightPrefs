namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Maintains key and value of a PlayerPref
    /// </summary>
    public sealed class PlayerPrefEntry<T> : BrightPlayerPrefs where T : new()
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
                SetObject(_key, value);
            }
        }

        private T _value;
        private readonly string _key;

        public PlayerPrefEntry(string key)
        {
            _key = key;
            _value = (T)GetObject<T>(key);
        }
    }
}