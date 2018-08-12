using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Spot {

    public GameObject gameObject;
    private static int numOfSpots = 0;
    public bool isOpen = true;
    public int layerPosition;
    public Vector3 localPosition = new Vector3();

    //public Relic_Attributes relicContained = null;
    public Spot( string name = "Spot_")
    {
        numOfSpots = ++numOfSpots % SpotStack.STACK_RESOLUTION;
        name += numOfSpots.ToString();
        gameObject = new GameObject(name);

    }


    //Determine layer
    int SetStackLayer()
    {
        return 0;
    }
}
