using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BrightPrefs.ComplexSample
{
    public class EntryUI : UIBehaviour
    {
        public Text Label;
        public InputField Value;

        public void Set(string label, object value)
        {
            Label.text = label;
            Value.text = value.ToString();
        }
    }
}

