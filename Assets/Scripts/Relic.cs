using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(Relic_Metrics))]
public class Relic: MonoBehaviour {

    public Relic_Attributes attributes;
    private string baseRelicAttributePath = "Assets/Relics/RelicAttributes/Relic_Base.asset";

    [HideInInspector]
    public Relic_Metrics metrics;

    public new string name = "";
    public string description = "";
    //TODO Unsure if the description for relic size ought to be held in SpotStack...
    public SpotStack.RELIC_SIZE relicSize = SpotStack.RELIC_SIZE.SMALL;

    public BoxCollider relicCollider;


    private void Start()
    {
        if (attributes == null)
            attributes = (Relic_Attributes)AssetDatabase.LoadAssetAtPath(baseRelicAttributePath, typeof(Relic_Attributes));

        name = attributes.name;
        description = attributes.description;
        relicSize = attributes.relicSize;

        metrics.value = attributes.value;
        metrics.growth = attributes.growth;

        GetComponent<MeshFilter>().mesh = attributes.mesh;
        InitializeCollider();
        
        
    }
    // Use this for initialization
    private void OnEnable()
    {
        if(!(GetComponent<Relic_Metrics>() == null))
            metrics = GetComponent<Relic_Metrics>();
    }

    public void OnTriggerStay(Collider other)
{
        //if mouse clicked
        SpotStack otherStack = (SpotStack)other.gameObject.GetComponentInChildren<SpotStack>();
        //get available spots that will allow placement
        //Spot[] placeableSpots = otherStack.GetPlaceableSpots(this);
        //choose one TODO let cycle through all permutations
        //otherStack.PlaceRelic(this, )
        Debug.Log(otherStack.ToString());
    }

    private void InitializeCollider()
        //TODO Create global constant for these hardcoded values
    {
        relicCollider = GetComponent<BoxCollider>();

        switch (relicSize)
        {
            case SpotStack.RELIC_SIZE.SMALL:
                relicCollider.size = new Vector3(.5f, 1f, .5f);
                break;
            case SpotStack.RELIC_SIZE.MEDIUM:
                if(attributes.mesh.bounds.size.x > attributes.mesh.bounds.size.z)
                    relicCollider.size = new Vector3(1f, 1f, .5f);
                else
                    relicCollider.size = new Vector3(.5f, 1f, 1f);
               break;
            case SpotStack.RELIC_SIZE.LARGE:
                relicCollider.size = new Vector3(1f, 1f, 1f);
                break;
            default:
                break;
        }
        //Vector3 offset = 
        relicCollider.center = new Vector3(0f, .5f, 0f);
        relicCollider.isTrigger = true;
    }
    
}
