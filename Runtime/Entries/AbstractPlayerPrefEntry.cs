using UnityEngine;

namespace BrightPrefs.Runtime
{
    /// <summary>
    /// Maintains key and value of a PlayerPref
    /// </summary>
    public abstract class AbstractPlayerPrefEntry : BrightPlayerPrefs 
    {
        protected readonly string _key;

        public AbstractPlayerPrefEntry(string key)
        {
            _key = key;
        }

        public abstract void Load();
        public new virtual void Save()
        {
            PlayerPrefs.Save();
        }
    }
}