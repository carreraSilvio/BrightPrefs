using BrightPrefs.Runtime;
using System;
using System.Globalization;
using UnityEngine;

namespace BrightPrefs.Samples
{
    public class BasicSampleMain : MonoBehaviour
    {
        [Header("Basic Types")]
        public EntryUI intEntry;
        public EntryUI floatEntry;
        public EntryUI boolEntry;
        public EntryUI stringEntry;

        [Header("Class")]
        //public EntryUI intEntry;
        //public EntryUI floatEntry;
        //public EntryUI boolEntry;
        //public EntryUI stringEntry;

        private IntPlayerPrefEntry _intPlayerPrefEntry;
        private FloatPlayerPrefEntry _floatPlayerPrefEntry;
        private BoolPlayerPrefEntry _boolPlayerPrefEntry;
        private StringPlayerPrefEntry _stringPlayerPrefEntry;
        private PlayerPrefEntry<Character> _characterPrefEntry;

        void Awake()
        {
            _intPlayerPrefEntry = new IntPlayerPrefEntry("intPlayerPrefEntry");
            _floatPlayerPrefEntry = new FloatPlayerPrefEntry("floatPlayerPrefEntry");
            _boolPlayerPrefEntry = new BoolPlayerPrefEntry("boolPlayerPrefEntry");
            _stringPlayerPrefEntry = new StringPlayerPrefEntry("stringPlayerPrefEntry");

            intEntry.Value.text = _intPlayerPrefEntry.Value.ToString();
            floatEntry.Value.text = _floatPlayerPrefEntry.Value.ToString();
            boolEntry.Value.text = _boolPlayerPrefEntry.Value.ToString();
            stringEntry.Value.text = _stringPlayerPrefEntry.Value.ToString();
        }

        void Start()
        {
            intEntry.Set("int", _intPlayerPrefEntry.Value, (strValue) => HandleIntEntryChange(strValue));
            floatEntry.Set("float", _floatPlayerPrefEntry.Value, (strValue) => HandleFloatEntryChange(strValue));
            boolEntry.Set("bool", _boolPlayerPrefEntry.Value, (strValue) => HandleBoolEntryChange(strValue));
            stringEntry.Set("string", _stringPlayerPrefEntry.Value, (strValue) => HandleStringEntryChange(strValue));
        }

        private void HandleIntEntryChange(string value)
        {
            if(int.TryParse(value, out int result))
            {
                _intPlayerPrefEntry.Value = result;
                Debug.Log($"Result is {_intPlayerPrefEntry.Value }");
                PlayerPrefs.Save();
            }
        }

        private void HandleFloatEntryChange(string value)
        {
            var result = float.Parse(value, CultureInfo.InvariantCulture);
            _floatPlayerPrefEntry.Value = result;
            Debug.Log($"Result is {_floatPlayerPrefEntry.Value }");
            PlayerPrefs.Save();
        }

        private void HandleBoolEntryChange(string value)
        {
            if (bool.TryParse(value, out bool result))
            {
                _boolPlayerPrefEntry.Value = result;
                Debug.Log($"Result is {_boolPlayerPrefEntry.Value }");
                PlayerPrefs.Save();
            }
        }

        private void HandleStringEntryChange(string value)
        {
            _stringPlayerPrefEntry.Value = value;
            Debug.Log($"Result is {_stringPlayerPrefEntry.Value }");
            PlayerPrefs.Save();
        }
    }
}

