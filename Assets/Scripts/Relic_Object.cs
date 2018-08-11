using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Relic_Attributes))]
public class Relic_Object : MonoBehaviour {

    public Relic_Attributes relic_Attributes;

	// Use this for initialization
	void Start () {
        if(relic_Attributes != null)
            relic_Attributes = GetComponent<Relic_Attributes>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
