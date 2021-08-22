namespace BrightPrefs.ComplexSample
{
    [System.Serializable]
    public class Character
    {
        public string name = "Character";
        public int strength = 10;
        public float damage = 30f;
        public bool magicUser = true;

        public int[] itemBag = new[] { 10, 2, 3 };
        public Role role = new Role();

        public string ItemBagAsString
        {
            get
            {
                var str = "";
                foreach (var item in itemBag) str += $"{item}, ";
                return str;
            }
        }
    }
}

