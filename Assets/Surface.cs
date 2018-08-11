using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour {

    public List<Spot> spots;
    private BoxCollider boxCollider;

    private Vector3 surfaceDimensions;

    public Relic_Object relicToPlace;

	// Use this for initialization
	void Start () {
        boxCollider = GetComponent<BoxCollider>();
        //relicToPlace = GetComponent<Relic_Object>();

        surfaceDimensions = boxCollider.size;
        Vector3 topLeft = new Vector3(0,1,0);
        Vector3 distFromOrigin = topLeft - transform.localPosition;
        Debug.Log("Surface Dimensions" + surfaceDimensions.ToString());
        Debug.Log("Local Surface Dimensions:" + distFromOrigin.ToString());
        //PlaceRelic();
	}
	

    public bool SetRelic(Spot spot)
    {
        return false;
    }

    private List<Vector3> DefineSpots()
    {
        List<Vector3> viablePositions = new List<Vector3>();
        viablePositions.Add(new Vector3(0, 0, 0));

        /* divide surface (x,z) into unit square
         * iterate through grid (vars: x & z
         *  create spot = GameObject("parentName_spot_coord")
         *  add BoxCollider
         *      set collider y=.5 size = (1,1,1)
         *  add Spot component to spot
         *  spot.transform.parent(transform)
         *  spot.transform.position = (0,0,0)
         *  
         */


        return viablePositions;
    }
    void PlaceRelic(Vector3 desiredPosition)
    {
        //get spot
        //get relic
        //check for collision between the two and OnClick
        //check for existing relic; true:
        //set relic position to center of collider x,z y=1
        //false
        //get layer and set relic to collider x,z y=existingRelic+1

        desiredPosition = ( transform.localPosition );
        relicToPlace.transform.position = transform.TransformPoint( desiredPosition );
   }
}
