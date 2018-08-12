using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to give easier access to the relics to be randomly presented
public class RelicPool : MonoBehaviour{

    private List<string> relicReferences;


    public void OnEnable()
    {
        relicReferences = PoolRelics();
    }

    //Get references to all relics in asset folder
    public List<string> PoolRelics()
    {

        return new List<string>();
    }

    //TODO randomly return a relic from given relics given
    //the criteria
    public Relic GenerateRelic(float minValue, float maxValue)
    {

        return new Relic();
    }
}
