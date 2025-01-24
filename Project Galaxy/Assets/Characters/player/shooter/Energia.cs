using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Energia : MonoBehaviour
{
    public float energiaActual = 10;
    public float energiaTotal = 10;
    public float velocidadDeRecarga = 2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (energiaActual< energiaTotal)
        {
            energiaActual+= Time.deltaTime / velocidadDeRecarga ;

        }

      
        
    }
}
