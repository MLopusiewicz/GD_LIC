using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereChanger_M : MonoBehaviour
{
    public SphereCollider sphere;
	public float r;

	private void Start() {
		sphere.radius = r;
	}
}
