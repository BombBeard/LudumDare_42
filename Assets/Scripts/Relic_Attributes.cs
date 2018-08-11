using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Relic_Attributes", menuName = "Relic_Attributes")]
public class Relic_Attributes : ScriptableObject{

    public static readonly float MIN_GROWTH = .001f;
    public static readonly float MAX_GROWTH = 2f;


    public new string name = "";
    public string description = "";
    public Mesh mesh = null;
    public Vector2 spotDimensions = SMALL;
    public int multiplier = 1;
    public int value = 1;
    public float baseGrowth = 1.0f;


}