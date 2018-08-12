using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Relic))]
public class Relic_Metrics : MonoBehaviour {
    public static readonly float MIN_GROWTH = .001f;
    public static readonly float MAX_GROWTH = 2f;


    public readonly Relic relic;

    //Displayed in the UI
    public float value;
    public float growth;

    //Used in calculations only
    private float modifier;
    private float stackModifier;

    private void Start()
    {

    }

    //Called from parent RelicStack when stack is updated
    public void SetStackModifier(float stackMod) { stackModifier = stackMod; }

    //Intended to be called every turn transition
    public float CalculateGrowth()
    {
        float result;
        result = value * modifier;
        result *= stackModifier;
        result -= value;

        return 0f;//TODO update return value
    }

    public Color GetGrowthColor()
    {

        return new Color(.5f, .5f, .5f);//TODO Update return value
    }

}
