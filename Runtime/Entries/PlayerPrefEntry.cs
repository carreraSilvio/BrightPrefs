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
                SetObject(_key, value);
            }
        }
        protected T _value;

        public PlayerPrefEntry(string key) : base(key)
        {
            _value = GetObject<T>(_key);
        }
    }
}