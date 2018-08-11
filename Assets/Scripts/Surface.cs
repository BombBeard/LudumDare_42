using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour {

    public List<SpotStack> spotStacks;

    private Vector3 surfaceDimensions;

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

    private List<SpotStack> SetSpotStacks(Queue<Vector3> stackTransforms)
    {
        /* TODO create SpotStack
         * foreach stack in stackTransforms
         *      create SpotStack("Parent_SpotStack_coord")
         *      add to List
         *      parent to Transform
         *      set relativePosition to stackTransforms
         *      Deenqueue at some point
         *      When empty: return List
         */
    }

    private Queue<Vector3> GenerateSpotPositions()//TODO Test Method
    {
        Queue<Vector3> viablePositions = new Queue<Vector3>();

        float targetX = 0;
        float targetY = transform.position.y;
        float targetZ = 0;

        //Determine SpotStack positions on surface
        //Used for placing SpotStacks elsewhere
        for (int x = 1; x <= surfaceDimensions.x; x++)
        {
            //Iterate through whole numbers, stepping back half a step
            targetX = ((float)x) - (2f / SpotStack.STACK_RESOLUTION);//STACK_RESOLUTION allows for variation in subdivision of grid
            for (int z = 1; z <= surfaceDimensions.z; z++)
            {
                targetZ = (float)z - (2f / SpotStack.STACK_RESOLUTION);
                viablePositions.Enqueue(new Vector3(targetX, targetY, targetZ));
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
