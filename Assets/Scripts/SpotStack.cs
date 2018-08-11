using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotStack : MonoBehaviour {

    public enum RELIC_SIZE
    {
        SMALL,
        MEDIUM,
        LARGE
    };
    public const int STACK_RESOLUTION = 4;// num of Spots in a layer assumed even
    private const int MAX_STACK_HEIGHT = 4;


    public List<Spot[]> spots;// Layer -> [4] Spots
    public int stackHeight;// highest layer containing a relic


	// Use this for initialization
	void Start () {
        spots[0] = GenerateSpots();
	}


    //Evaluates if a given spot is a valid surface for relics to stack on
    public bool IsValidSpot()
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
        int cnt = 0;// hack to get correct incrementing of array
        //Iterate over grid and set new Spot to center of each grid
        for (int i = 0; i < STACK_RESOLUTION/2; i++)
        {
            for (int j = 0; j < STACK_RESOLUTION/2; j++)
            {
                spots[cnt] = new Spot();
                spots[cnt].transform.SetParent(transform);
                spots[cnt++].transform.localPosition = new Vector3(0, layerNumber, 0);
            }
        }

        return spots;
    }
}
