using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SurfaceAttributes", menuName = "Surface", order = 2)]
[RequireComponent(typeof(MeshRenderer))]
public class SurfaceAttributes : ScriptableObject
{
    public int growthEarned;
    public int level;
    //<level, growthRequiredToLevel>
    public Dictionary<int, int> levelProgression;
    public Dictionary<int, Mesh> meshProgression;
    public float durability;
    public PhysicMaterial physic;

    public SurfaceAttributes attributes;


}
