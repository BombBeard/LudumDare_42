using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(Relic_Metrics))]
public class Relic: MonoBehaviour {

    private string baseRelicAttributePath = "Assets/Relics/RelicAttributes/Relic_Base.asset";

    public Relic_Attributes attributes;
    [HideInInspector]
    public Relic_Metrics metrics;

    public new string name = "";
    public string description = "";
    public float durability;

    public BoxCollider relicCollider;


    private void Start()
    {
        if (attributes == null)
            attributes = (Relic_Attributes)AssetDatabase.LoadAssetAtPath(baseRelicAttributePath, typeof(Relic_Attributes));

        name = attributes.name;
        description = attributes.description;
 
        metrics.value = attributes.value;
        metrics.growth = attributes.growth;

        GetComponent<MeshFilter>().mesh = attributes.mesh;
        
    }
    private void OnEnable()
    {
        if(!(GetComponent<Relic_Metrics>() == null))
            metrics = GetComponent<Relic_Metrics>();
    }

    
}
