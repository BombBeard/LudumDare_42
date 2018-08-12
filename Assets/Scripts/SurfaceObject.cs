using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SurfaceObject {

    public float interestEarned;
    public int level;
    //<level, growthRequiredToLevel>
    public Dictionary<int, int> levelProgression;
    public Dictionary<int, Mesh> meshProgression;
    public float durability;
    public PhysicMaterial physic;

    public SurfaceAttributes attributes;


}
