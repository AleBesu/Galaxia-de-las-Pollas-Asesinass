using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class Energia : MonoBehaviour
{
    
    [HideInInspector]
    public float energiaActual;
    public float energiaTotal = 10;
    float ultimaEnergiaRegistrada;
   public Slider energyBar;
    public float velocidadDeRecarga = 2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        energiaActual = energiaTotal;
    }

    // Update is called once per frame
    void Update()
    {

 
            energiaActual+= Time.deltaTime / velocidadDeRecarga ;
          
          if (ultimaEnergiaRegistrada != energiaActual)
          {
            EnergyBarGetPercentValue();
          }

      
        
    }


     void EnergyBarGetPercentValue (){
  
    if (energyBar != null)
    {
        energyBar.maxValue = energiaTotal;
        energyBar.value = energiaActual;
    }


     }



}
