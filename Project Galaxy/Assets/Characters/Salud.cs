using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Salud : MonoBehaviour
{
    public float saludActual = 10;
    public float saludTotal = 10;
    float ultimaSaludRegistrada;
    public Slider barraDeSalud ;

  
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
     


    // Update is called once per frame
    void Update()
    {
    

       if (ultimaSaludRegistrada != saludActual)
       {
         healthBarGetPercentValue();
       }
           if (saludActual < 0)
        {
            Destroy(gameObject);
        }
    }



   

    void healthBarGetPercentValue (){


     if (barraDeSalud != null)
     {
       barraDeSalud.minValue = -1;
      barraDeSalud.maxValue = saludTotal;
      barraDeSalud.value = saludActual; 
     }
     

    }

  
    


}
