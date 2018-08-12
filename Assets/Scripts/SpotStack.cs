using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(BoxCollider))]
public class SpotStack{

    [HideInInspector]
    public static int stackCounter = 0;
    public GameObject gameObject;
    public BoxCollider stackCollider;

    public enum RELIC_SIZE
    {
        SMALL,
        MEDIUM,
        LARGE
    };


    public List<Spot[]> spots;// Layer -> [4] Spots
    public int stackHeight;// highest layer containing a relic

    public SpotStack()
    {
        stackCounter++;
        gameObject = new GameObject("SpotStack" + stackCounter.ToString());
        stackCollider =  gameObject.AddComponent<BoxCollider>();
        stackCollider.center = new Vector3(0f, .5f, 0f);
        stackCollider.isTrigger = true;
    }

    void Start()
    { 
        spots[0] = GenerateSpots();
	}



    //Assumes chosen spot is valid
    public void PlaceRelic(Relic relic, Spot[] spot)//TODO implement
    {
        /* Parent relic to stack
         * set relic to average of spots given in local space
         * Stretch: play place animation
         */ 
        //Parent relic to spotStack
        //DesiredLayerPosition is spot[0].layerposition
        //DesiredGridPosition is the position of the average of spot[] positions
        //SetRelicPosition (DesiredGridPosition.x, DesiredLayerPosition , DesiredGrid.z


    }

    //public Spot[] GetPlaceableSpots(Relic relic)
    //{
        //Spot[] placeableSpots;

        /* if(IsLayerFull( stackHeight, relic) && (stackHeight < MAX_STACK_HEIGHT)
         *      AddLayer();
         *      return all spots in new layer
         * if(!(IsLayerFull( stackHeight, relic))
         * 
         * 
         */

    //    return placeableSpots;
    //}

    private bool IsLayerFull(int layer)
    {


        return false;
    }
    private bool IsLayerFull(int layer, Relic relic)
    {

        return false;
    }

    
    //Evaluates if a given spot is a valid surface for relics to stack on
    public bool IsValidSpot(Spot spot)
    {
        return false;//TODO Implement
    }

    private bool IsLayerEmpty(int layerNum)
    {
        if(spots == null)
            return true;
        foreach (Spot spot in spots[layerNum])
        {
            if (!spot.isOpen)
                return false;
        }
        return true;

    }
    private List<Spot[]> GetContiguousSpots(RELIC_SIZE size)
    {
        List<Spot[]> viableSpots = new List<Spot[]>(); 
        switch (size)
        {
            case RELIC_SIZE.SMALL:
                //check for open spots
                //return all open spots not covered
                break;
            case RELIC_SIZE.MEDIUM:
                //check for two adjacent spots not covered
                //return all combinations of such
                break;
            case RELIC_SIZE.LARGE:
                //Available layer empty == true
                //return all four spots
                break;
            default:
                return null;
                break;
        }


        Spot[] s = new Spot[1] { new Spot() };
        viableSpots.Add(s);
        return viableSpots;//TODO update return
    }

    private Spot[] AddLayer(int layerNumber)
    {
        if (!(stackHeight <= MAX_STACK_HEIGHT))
            return null;
        else
            return GenerateSpots(layerNumber);
    }

    //layerNumber 
    private Spot[] GenerateSpots(int layerNumber = 0)//TODO Test this method
    {
        if (!IsLayerEmpty(layerNumber))//If layer has Spots assigned
            return null;
        Spot[] spots = new Spot[STACK_RESOLUTION];
        int cnt = 0;// is a hack to get correct incrementing of array
        //Iterate over grid and set new Spot to center of each grid
        for (int i = 0; i < STACK_RESOLUTION/2; i++)
        {
            for (int j = 0; j < STACK_RESOLUTION/2; j++)
            {
                spots[cnt] = new Spot();
                spots[cnt].gameObject.transform.SetParent( gameObject.transform );
                spots[cnt++].gameObject.transform.localPosition = new Vector3(0, layerNumber, 0);
            }
        }

        return spots;
    }
}
