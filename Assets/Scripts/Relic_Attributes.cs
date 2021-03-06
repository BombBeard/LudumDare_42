﻿/* Supplies information about various relics as
 * static data. Only used during Init or Reset
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RelicAttribute",menuName = "Relic", order = 1)]
[RequireComponent(typeof(MeshRenderer))]
public class Relic_Attributes : ScriptableObject {

    public enum RELIC_SIZE { XSMALL, SMALL, MEDIUM, LARGE, XLARGE };

    [Range(.001f, 2f)]
    public float growth = 1f;
    [Range(.001f, 2f)]
    public float modifier = 1f;
    [Range(1f, 1000f)]
    public float value = 1;

    public string description = "";

    public Relic_Attributes.RELIC_SIZE relicSize = Relic_Attributes.RELIC_SIZE.SMALL;

    public Mesh mesh;
    public MeshRenderer renderer;

    private void OnEnable()
    {
    }

}
