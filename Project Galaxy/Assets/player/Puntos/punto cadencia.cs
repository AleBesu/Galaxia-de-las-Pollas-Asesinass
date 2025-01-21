using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntocadencia : MonoBehaviour
{
    
    float potencia = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" )
        {
            other.GetComponent<Shooter>().cadence += potencia;
         Destroy(gameObject);
        }
    }
}
