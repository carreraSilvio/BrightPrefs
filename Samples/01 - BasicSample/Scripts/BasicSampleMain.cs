using BrightPrefs.Runtime;
using UnityEngine;

namespace BrightPrefs.Samples
{
    public class BasicSampleMain : MonoBehaviour
    {
        public EntryUI intEntry;
        public EntryUI floatEntry;
        public EntryUI stringEntry;


        private PlayerPrefEntry<int> _intPlayerPrefEntry;

        void Awake()
        {
            _intPlayerPrefEntry = new PlayerPrefEntry<int>("intPlayerPrefEntry");
        }

        // Start is called before the first frame update
        void Start()
        {
            intEntry.Value.text = _intPlayerPrefEntry.Value.ToString();
            intEntry.Value.onEndEdit.AddListener(test);
        }

        private void test(string value)
        {
            _intPlayerPrefEntry.Value = 22;
            PlayerPrefs.Save();
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

