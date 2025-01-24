using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DetectorDeAliados : MonoBehaviour
{

   HashSet<GameObject> aliadosEnZonaDeDisparo =  new HashSet<GameObject>();
   
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }



 

    private void OnTriggerStay(Collider other) {


        if (other.tag == "enemy")
        {  
            aliadosEnZonaDeDisparo.Add(other.gameObject);
      
        }

        if (aliadosEnZonaDeDisparo.Count() >= 1)
        {
            transform.parent.GetComponent<Enemy>().zonaDedisparoDespejada = false;
        }else
        { transform.parent.GetComponent<Enemy>().zonaDedisparoDespejada = true;
        }




    }
}
