using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public int liczbaCalkowita = 10;
    public int LiczbaB = 6;
    public float liczbaZmiennoprzecinkowa = 5.5f;
    public bool trueFalse = true;
    public string tekst = "Co ja pacze?";
    private int prywatnaLiczba = 100;
    public GameObject diffrentObjesct;
    public Light sceneLight;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(tekst);
        Debug.Log("cokolwiek");
        Debug.Log(Podziel(liczbaCalkowita, LiczbaB, prywatnaLiczba));
        Debug.Log(Mnozenie(liczbaCalkowita, LiczbaB, prywatnaLiczba));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Podziel(int a, int b, int c)
    {
        return a / b / c;
    }

    int Mnozenie(int a, int b, int c)
    {
        return a * b * c;
    }
}
