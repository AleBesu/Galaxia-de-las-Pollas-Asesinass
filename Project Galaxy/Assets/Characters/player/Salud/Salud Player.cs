using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludPlayer : Salud
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per fram

    private void OnTriggerEnter(Collider other) {
        
      if (other.tag == "enemy")
      {

        saludActual --;
        Destroy(other.gameObject);
        Debug.Log(saludActual);
      }

    }



}
