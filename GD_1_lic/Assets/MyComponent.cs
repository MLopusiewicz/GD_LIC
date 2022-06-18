using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public int liczbaCalkowita = 10;
    public int liczbaB = 0;
    public float liczbaZmiennoprzecinkowa = 5.5f;
    public bool TrueFalse = true;
    public string tekst = "blablabla";
    private int prywatnaLiczba = 10;
    public GameObject differentObject;
    public Light sceneLight;

    // Start is called before the first frame update
    void Start()
    { 
        int zmienna = Dodaj(5, 10);
        Debug.Log(tekst);
        Debug.Log("cokolwiek");
        Debug.Log(Dodaj(Dziel(10, 2), Dziel(3, 1)));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Dodaj(int a , int b)
    {
        return a + b;

    }
    int Dziel(int a, int b) 
    {
        return a / b;

    }
}
