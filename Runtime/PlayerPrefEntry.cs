namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Class that's maintains access to key and value of a PlayerPref
    /// </summary>
    public sealed class PlayerPrefEntry<T> : BrightPlayerPrefs
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
        }
    }
}