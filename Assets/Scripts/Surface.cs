using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour {
    public readonly float GRID_RESOLUTION = 4f;

    [SerializeField]
    public List<SpotStack> spotStacks;

    public Vector3 surfaceDimensions;
    
	// Use this for initialization
	void Start ()
    {
        surfaceDimensions = GetComponent<BoxCollider>().size;

        spotStacks = new List<SpotStack>();
        spotStacks = SetSpotStacks(GenerateSpotPositions());
	}
	

    public bool SetRelic(Spot spot)
    {
        return false;
    }

    private List<SpotStack> SetSpotStacks(List<Vector3> stackTransforms)
    {
        #region pseudo
        /* 
         * foreach stack in stackTransforms
         *      create SpotStack("Parent_SpotStack_coord")
         *      add to List
         *      parent to Transform
         *      set relativePosition to stackTransforms
         *      Deenqueue at some point
         *      When empty: return List
         */
        #endregion
        List<SpotStack> result = new List<SpotStack>();
        SpotStack tmp;
       foreach (Vector3 spotPosition in stackTransforms)
        {
            tmp = new SpotStack();
            tmp.gameObject.transform.SetParent(transform);
            tmp.gameObject.transform.localPosition = spotPosition;
            result.Add(tmp);
        }

        return result;
    }

    private List<Vector3> GenerateSpotPositions()//TODO Test Method
    {
        List<Vector3> viablePositions = new List<Vector3>();

        float xPivotOffset = surfaceDimensions.x / 2f;
        float zPivotOffset = surfaceDimensions.z / 2f;

        float targetX = 0f;
        float targetY = 0f;
        float targetZ = 0f;

        //Determine SpotStack positions on surface
        //Used for placing SpotStacks elsewhere
        for (int x = 1; x <= surfaceDimensions.x; x++)
        {
            //Iterate through whole numbers, stepping back half a step
            targetX = ((float)x) - (2f / SpotStack.STACK_RESOLUTION);//STACK_RESOLUTION allows for variation in subdivision of grid
            targetX -= xPivotOffset;
            for (int z = 1; z <= surfaceDimensions.z; z++)
            {
                targetZ = (float)z - (2f / SpotStack.STACK_RESOLUTION);
                targetZ -= zPivotOffset;
                viablePositions.Add(new Vector3(targetX, targetY, targetZ));
            }
        }
        return viablePositions;
    }

    /*    void PlaceRelic(Vector3 desiredPosition)
    {
        //get spot
        //get relic
        //check for collision between the two and OnClick
        //check for existing relic; true:
        //set relic position to center of collider x,z y=1
        //false
        //get layer and set relic to collider x,z y=existingRelic+1

        desiredPosition = ( transform.localPosition );
   }
   */
}
