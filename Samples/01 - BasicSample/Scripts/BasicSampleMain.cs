using BrightPrefs.Runtime;
using UnityEngine;

namespace BrightPrefs.Samples
{
    public class BasicSampleMain : MonoBehaviour
    {
        [Header("Basic Types")]
        public EntryUI intEntry;
        public EntryUI floatEntry;
        public EntryUI stringEntry;

        private PlayerPrefEntry<int> _intPlayerPrefEntry;
        private PlayerPrefEntry<float> _floatPlayerPrefEntry;

        void Awake()
        {
            _intPlayerPrefEntry = new PlayerPrefEntry<int>("intPlayerPrefEntry");
            _floatPlayerPrefEntry = new PlayerPrefEntry<float>("floatPlayerPrefEntry");
        }

        // Start is called before the first frame update
        void Start()
        {
            string jsonValue = JsonUtility.ToJson(22);
            Debug.Log(jsonValue);
            //SetString(key, jsonValue);

            //intEntry.Set("int", _intPlayerPrefEntry.Value, (strValue) => test(strValue));
            //floatEntry.Set("float", _floatPlayerPrefEntry.Value, (strValue) => test(strValue));
        }

        private void test(string value)
        {
            _intPlayerPrefEntry.Value = 22;
            PlayerPrefs.Save();
        }
    }
}

