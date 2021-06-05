using BrightPrefs.Runtime;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace BrightPrefs.ComplexSample
{
    public class ComplexSampleMain : MonoBehaviour
    {
        public EntryUI nameEntry;
        public EntryUI strengthEntry;
        public EntryUI damageEntry;
        public EntryUI magicUserEntry;

        public EntryUI itemBagEntry;

        public EntryUI roleNameEntry;
        public EntryUI roleBonusEntry;

        public Button saveBtn;
        public Button loadBtn;

        private PlayerPrefEntry<Character> _characterPrefEntry;

        void Awake()
        {
            _characterPrefEntry = new PlayerPrefEntry<Character>("brightCharacter");
            _characterPrefEntry.Load();
            UpdateEntries();

            saveBtn.onClick.AddListener(HandleSaveBtnClick);
            loadBtn.onClick.AddListener(HandleLoadBtnClick);
        }

        private void HandleSaveBtnClick()
        {
            _characterPrefEntry.Value.name = nameEntry.Value.text;
            if (int.TryParse(strengthEntry.Value.text, out int strengthResult))
            {
                _characterPrefEntry.Value.strength = strengthResult;
            }
            if (float.TryParse(damageEntry.Value.text, out float damageResult))
            {
                _characterPrefEntry.Value.damage = damageResult;
            }
            if (bool.TryParse(magicUserEntry.Value.text, out bool magicUserResult))
            {
                _characterPrefEntry.Value.magicUser = magicUserResult;
            }

            _characterPrefEntry.Value.role.name = roleNameEntry.Value.text;
            if (int.TryParse(roleBonusEntry.Value.text, out int roleBonusResult))
            {
                _characterPrefEntry.Value.role.bonus = roleBonusResult;
            }

            _characterPrefEntry.Save();
        }

        private void HandleLoadBtnClick()
        {
            _characterPrefEntry.Load();
            UpdateEntries();
        }

        private void UpdateEntries()
        {
            nameEntry.Set("Name", _characterPrefEntry.Value.name);
            strengthEntry.Set("Strength", _characterPrefEntry.Value.strength);
            damageEntry.Set("Damage", _characterPrefEntry.Value.damage);
            magicUserEntry.Set("Magic User", _characterPrefEntry.Value.magicUser);

            itemBagEntry.Set("Item Bag", _characterPrefEntry.Value.ItemBagAsString);

            roleNameEntry.Set("  Name", _characterPrefEntry.Value.role.name);
            roleBonusEntry.Set("  Bonus", _characterPrefEntry.Value.role.bonus);
        }

    }
}

