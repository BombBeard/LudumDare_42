using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Surface))]
public class Spot : MonoBehaviour {

    private Surface surface;
    //neighbor Spots {x+, x-, y+, y-, z+, z-}
    //Local to Surface
    public Spot X_Positive_Neighbor = null;
    public Spot X_Negative_Neighbor = null;
    public Spot Y_Positive_Neighbor = null;
    public Spot Y_Negative_Neighbor = null;
    public Spot Z_Positive_Neighbor = null;
    public Spot Z_Negative_Neighbor = null;

    public int layerPosition;
    public Vector3 localPosition = new Vector3();

    //public Relic_Attributes relicContained = null;


	// Use this for initialization
	void Start () {
        surface = GetComponent<Surface>();
        //map out neighboring Spots
        //Determine layer position
        layerPosition = GetStackLayer();
        //set RelicContained

    }


	
    //Queries neighboring colliders using... raycasts?
    private Spot FindSpot()
    {

        return new Spot(); //TODO meaningful return
    }

    //Evaluates if a given spot is a valid surface for relics to stack on
    public bool IsValidSpot()
    {
        return false;//TODO Implement
    }

    //Determine layer
    int GetStackLayer()
    {
        if( Y_Negative_Neighbor == null)
            return 0;
        else
            return Y_Negative_Neighbor.layerPosition + 1;
    }
}
