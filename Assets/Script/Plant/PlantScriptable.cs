using UnityEngine;

[CreateAssetMenu(fileName = "PlantScriptable", menuName = "Scriptable Objects/PlantScriptable")]
public class PlantScriptable : ScriptableObject
{
    enum Environment{

        None,
        Day,
        Night,
        Water,
        Smog,
        Toit

    }

    enum Role
    {
        None,
        Wallers,
        Direct_Damage,
        Boom,
        Sun_Producers,
        Zone_Damage,
        Control,
    }

    enum Effects
    {
        None,
        Gel,
        InstaKills,
        Projectils,
        Protects,
        Specials,
    }
}
