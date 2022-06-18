using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionChange : MonoBehaviour
{
    public SphereCollider sphere;

    // Start is called before the first frame update
    void Start()
    {
        if(sphere == null)
        {
            Debug.Log("Nieprzypisana zmienna");
            return;
        }
        if (sphere.radius == 1)
        {
            sphere.radius = 2;
            sphere.center = Vector3.one;

        }
        else
        {
            sphere.radius = 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
