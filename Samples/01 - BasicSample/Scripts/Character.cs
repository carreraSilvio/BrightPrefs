namespace BrightPrefs.Samples
{
    [System.Serializable]
    public class Character
    {
        public string name = "Sample";
        public int strength = 10;
        public float damage = 30f;
        public bool magicUser = true;

        public int[] itemBag = new[]{ 10, 2, 3 };
        public Role role = new Role();
    }
}

