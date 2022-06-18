using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereChanger : MonoBehaviour
{
    public SphereCollider sphere;
    public float rozmiar;
    // Start is called before the first frame update
    void Start()
    {
        sphere.radius = rozmiar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
