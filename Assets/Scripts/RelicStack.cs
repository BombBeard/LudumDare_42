using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RelicStack {

    public List<Relic> memberRelics;
    public int stackHeight;
    public float stackMultiplier;
    public Color heatIndexColor;


    public RelicStack(List<Relic> relics)
    {
        memberRelics = relics;
        stackHeight = GetStackHeight();
        stackMultiplier = CalculateStackMultiplier();
        heatIndexColor = Color.gray;
    }

    public void AddRelic(Relic relic)
    {
        memberRelics.Add(relic);
        Update();
    }
    public void RemoveRelic(Relic relic)
    {
        memberRelics.Remove(relic);
        Update();
    }

    private int GetStackHeight()
    {
        return memberRelics.Count;
    }

    private float CalculateStackMultiplier()
    {

        return 1f;//TODO calc stack multiplier
    }

    private Color GenerateHeatIndexColor()
    {

        return Color.gray;//TODO algorithm for choosing color
    }

    private void Update()
    {
        stackHeight = GetStackHeight();
        stackMultiplier = CalculateStackMultiplier();
        GenerateHeatIndexColor();
    }
}
