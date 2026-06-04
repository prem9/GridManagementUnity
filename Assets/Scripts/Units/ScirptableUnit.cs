using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "scriptable unit")]

public class ScirptableUnit : ScriptableObject
{
    public Faction Faction;
}

public enum Faction
{
    Hero = 0,
    Enemy = 1
}