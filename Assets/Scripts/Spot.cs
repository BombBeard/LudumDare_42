using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spot : MonoBehaviour {

    public bool isOpen = true;
    public int layerPosition;
    public Vector3 localPosition = new Vector3();

    //public Relic_Attributes relicContained = null;


	// Use this for initialization
	void Start () {

    }


    //Determine layer
    int SetStackLayer()
    {
        return 0;
    }
}
