using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameCheck_M : MonoBehaviour {
	public GameObject go;
	public GameObject go2;
	
	void Start() {
		if(go == go2)
			Debug.Log("To jest ten sam obiekt");

		if(CheckSize(go, go2))
			Debug.Log("GO jest wiêkszy");

		if(go.name == "Nazwa") {
			Debug.Log("Znalaz³em nasz obiekt");
		} else {
			Debug.Log("Z³y obiekt. Jego nazwa: " + gameObject.name);
		}
	} 

	bool CheckSize(GameObject g1, GameObject g2) {
		return g1.transform.childCount > g2.transform.childCount;
	}
}
