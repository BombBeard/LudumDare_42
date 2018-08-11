using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Relic_Attributes))]
public class Relic_Object : MonoBehaviour {

    /*
    public static readonly float MIN_GROWTH = .001f;
    public static readonly float MAX_GROWTH = 2f;


    public new string name = "";
    public string description = "";
    public Mesh mesh = null;
    public Vector2 spotDimensions = SMALL;
    public int multiplier = 1;
    public int value = 1;
    public float baseGrowth = 1.0f;
*/

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
