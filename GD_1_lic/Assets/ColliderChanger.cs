using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChanger : MonoBehaviour
{
    public SphereCollider sphere;
    public Vector3 size;
    public float aaaa;


    // Start is called before the first frame update
    void Start()
    {
        size.y = 2;
        sphere.radius = aaaa;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
