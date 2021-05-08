namespace BrightPrefs.Editortime
{
    /// <summary>
    /// Maintains key and value of a EditorPref
    /// </summary>
    public sealed class EditorPrefEntry<T> : BrightEditorPrefs
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

        public EditorPrefEntry(string key)
        {
            _key = key;
        }
    }
}