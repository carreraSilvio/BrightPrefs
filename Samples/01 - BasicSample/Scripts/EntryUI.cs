using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BrightPrefs.Samples
{
    public class EntryUI : UIBehaviour
    {
        public Text Label;
        public InputField Value;

        public void Set(string label, object value, Action<string> onEndEditCallback)
        {
            Label.text = label;
            Value.text = value.ToString();
            Value.onEndEdit.AddListener((str) => onEndEditCallback(str));
        }
    }
}

