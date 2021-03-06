using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BrightPrefs.BasicSample
{
    public class EntryUI : UIBehaviour
    {
        public Text Label;
        public InputField Value;
        public Button SaveBtn;
        public Button LoadBtn;

        public void Set(string label, object value, Action<string> onEndEditCallback)
        {
            Label.text = label;
            Value.text = value.ToString();
            Value.onEndEdit.AddListener((str) => onEndEditCallback(str));
        }
    }
}

