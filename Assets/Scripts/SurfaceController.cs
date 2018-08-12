using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RelicStackController))]
[RequireComponent(typeof(SurfaceObject))]
public class SurfaceController : MonoBehaviour
{
    public readonly float GRID_RESOLUTION = 4f;

    public RelicStackController relicStackController;
    public SurfaceObject surfaceObject;
    public List<Relic> relics;

    public Vector3 surfaceDimensions;

    // Use this for initialization
    void Start()
    {
        surfaceDimensions = GetComponent<BoxCollider>().size;

        relics = new List<Relic>();
    }


}
