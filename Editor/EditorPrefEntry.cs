namespace BrightPrefs.Editortime
{
    /// <summary>
    /// Maintains key and value of an EditorPref
    /// </summary>
    public sealed class EditorPrefEntry<T>
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
                BrightEditorPrefs.SetObject(_key, value);
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