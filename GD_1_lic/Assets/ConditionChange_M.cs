using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionChange_M : MonoBehaviour {

	public SphereCollider sphere;

	void Start() {
		if(sphere == null) {
			Debug.Log("Nieprzypisana zmienna");
			return;
		}

		if(sphere.radius == 1) {
			sphere.radius = 2;
			sphere.center = Vector3.one;
		} else {
			sphere.radius = 0.5f;
		}
	}

	void Update() {

	}
}
