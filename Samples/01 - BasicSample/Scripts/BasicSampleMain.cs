using BrightPrefs.Runtime;
using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace BrightPrefs.Samples
{
    public class BasicSampleMain : MonoBehaviour
    {
        [Header("Basic Types")]
        public EntryUI intEntry;
        public EntryUI floatEntry;
        public EntryUI boolEntry;
        public EntryUI stringEntry;

        private IntPlayerPrefEntry _intPlayerPrefEntry;
        private FloatPlayerPrefEntry _floatPlayerPrefEntry;
        private BoolPlayerPrefEntry _boolPlayerPrefEntry;
        private StringPlayerPrefEntry _stringPlayerPrefEntry;

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
            intEntry.SaveBtn.onClick.AddListener(() => { _intPlayerPrefEntry.Save(); });
            intEntry.LoadBtn.onClick.AddListener(() => 
            {
                _intPlayerPrefEntry.Load();
                intEntry.Value.text = _intPlayerPrefEntry.Value.ToString(); 
            });

            floatEntry.Set("float", _floatPlayerPrefEntry.Value, (strValue) => HandleFloatEntryChange(strValue));
            floatEntry.SaveBtn.onClick.AddListener(() => { _floatPlayerPrefEntry.Save(); });
            floatEntry.LoadBtn.onClick.AddListener(() => 
            {
                _floatPlayerPrefEntry.Load();
                floatEntry.Value.text = _floatPlayerPrefEntry.Value.ToString(); 
            });

            boolEntry.Set("bool", _boolPlayerPrefEntry.Value, (strValue) => HandleBoolEntryChange(strValue));
            boolEntry.SaveBtn.onClick.AddListener(() => { _boolPlayerPrefEntry.Save(); });
            boolEntry.LoadBtn.onClick.AddListener(() => 
            {
                _boolPlayerPrefEntry.Load();
                boolEntry.Value.text = _boolPlayerPrefEntry.Value.ToString(); 
            });

            stringEntry.Set("string", _stringPlayerPrefEntry.Value, (strValue) => HandleStringEntryChange(strValue));
            stringEntry.SaveBtn.onClick.AddListener(() => { _stringPlayerPrefEntry.Save(); });
            stringEntry.LoadBtn.onClick.AddListener(() => 
            {
                _stringPlayerPrefEntry.Load();
                stringEntry.Value.text = _stringPlayerPrefEntry.Value.ToString(); 
            });
        }

        private void HandleIntEntryChange(string value)
        {
            if(int.TryParse(value, out int result))
            {
                _intPlayerPrefEntry.Value = result;
                Debug.Log($"Result is {_intPlayerPrefEntry.Value }");
            }
        }

        private void HandleFloatEntryChange(string value)
        {
            var result = float.Parse(value, CultureInfo.InvariantCulture);
            _floatPlayerPrefEntry.Value = result;
            Debug.Log($"Result is {_floatPlayerPrefEntry.Value }");
        }

        private void HandleBoolEntryChange(string value)
        {
            if (bool.TryParse(value, out bool result))
            {
                _boolPlayerPrefEntry.Value = result;
                Debug.Log($"Result is {_boolPlayerPrefEntry.Value }");
            }
        }

        private void HandleStringEntryChange(string value)
        {
            _stringPlayerPrefEntry.Value = value;
            Debug.Log($"Result is {_stringPlayerPrefEntry.Value }");
        }
    }
}

