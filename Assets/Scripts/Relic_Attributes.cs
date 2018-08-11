using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Relic_Attributes", menuName = "Relic_Attributes")]
public class Relic_Attributes : ScriptableObject{

    public static readonly Vector2 SMALL = new Vector2(1 , 1); // units in Spots -- (.5, 1, .5)
    public static readonly Vector2 MEDIUM = new Vector2(1 , 2); // Rectangle -- (1, 1, .5)
    public static readonly Vector2 LARGE = new Vector2(2, 2); // Larger Square -- (1, 1, 1)
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