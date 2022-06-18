using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChanger_M : MonoBehaviour {
	public BoxCollider box;
	public Vector3 size;

	// KROPKA operator wejœcia do wewn¹rz obiektu 

	// Start is called before the first frame update
	void Start() {
		size.y = 2;
		box.size = size;
	}

	// Update is called once per frame
	void Update() {

	}
}
