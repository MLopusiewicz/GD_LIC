using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent_M : MonoBehaviour {

	//zmienna <-> pole			//domyœlna wartoœæ
	public int liczbaCalkowita = 10;
	public int liczbaB = 0;
	public float liczbaZmmiennoprzecinkowa = 5.5f;
	public bool TrueFalse = true;
	public string tekst = "casdfa sdfas df";
	private int prywatnaLiczba = 10;
	public GameObject diffrentObject;
	public Light sceneLight;

	// Start is called before the first frame update
	void Start() {              // od góry do do³u \/ 
		Debug.Log(Dodaj(liczbaCalkowita, liczbaB));
	}

	// Update is called once per frame
	void Update() { 
	}

	// funkcja <-> metoda
	int Dodaj(int a, int b) { 
		return a + b;
	}
	//funkcja mo¿e byæ u¿ywana jako zmienna
	int Dziel(int a, int b) {
		return a / b;
	}
}
