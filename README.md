# Bright Pres
Wrapper for Unity's Player Prefs and Editor Prefs with quality of life improvements.

# Features
* Maintains the Pref Key for you
* Supports bool type
* Supports class type

## Usage - Regular Types

```csharp

//Original Unity Way
var intValue = PlayerPrefs.GetInt("myAwesomeInt", 0);
intValue = 10;
PlayerPrefs.SetInt("myAwesomeInt", intValue);
PlayerPrefs.Save();

//Bright Prefs Way
var intPrefEntry = new IntPlayerPrefEntry("myAwesomeInt", 0);
intPrefEntry.Value = 10;
intPrefEntry.Save();

//Same for Float, String and you also get Bool type
var boolPrefEntry = new BoolPlayerPrefEntry("myAwesomeBool", true);
boolPrefEntry.Value = false;
boolPrefEntry.Save();

```

## Usage - Complex Types

```csharp

[System.Serializable]
public class Character
{
    public string name = "Character";
    public int strength = 10;
    public float damage = 30f;
    public bool magicUser = true;

    public int[] itemBag = new[] { 10, 2, 3 };
    public Role role = new Role();
}
[System.Serializable]
public class Role
{
    public string name = "Warrior";
    public int bonus = 30;
}

//Bright Prefs Way
var characterPrefEntry = new PlayerPrefEntry<Character>("brightCharacter");
characterPrefEntry.Value.strength = 5;
characterPrefEntry.Value.damage = 10;
characterPrefEntry.Value.magicUser = true;
characterPrefEntry.Value.role.name = "Wizard";
characterPrefEntry.Save();

```