using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionChange : MonoBehaviour
{
    public SphereCollider sphere;

    void Start()
    {
        if (sphere.radius == 1)
        {
            sphere.radius = 2;
            sphere.center = Vector3.one;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
